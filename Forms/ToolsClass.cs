using Hotel_Philoxenia.Forms;
using Hotel_Philoxenia.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Linq;
using System.Windows.Forms;
using QuestPDF.Fluent;
using QuestPDF.Infrastructure;
using QuestPDF.Helpers;

namespace Hotel_Philoxenia
{
    public partial class ToolsClass : Form
    {
        private readonly HotelContext _context;

        public ToolsClass()
        {
            InitializeComponent();
            QuestPDF.Settings.License = LicenseType.Community;
            _context = new HotelContext();
            LoadValidBookings();
            UpdateTotalCost();
            ClearInputs();
        }

        private void button_Exit_Click(object sender, EventArgs e) => Application.Exit();

        private void ReturnToAdminForm_Click(object sender, EventArgs e)
        {
            this.Hide();
            new AdminMainForm().Show();
        }

        private void textBox_CostPerDay_TextChanged(object sender, EventArgs e) => UpdateTotalCost();
        private void textBox_Discount_TextChanged(object sender, EventArgs e) => UpdateTotalCost();
        private void dateTimePicker_arrival_ValueChanged(object sender, EventArgs e) => UpdateTotalCost();
        private void dateTimePicker2_depart_ValueChanged(object sender, EventArgs e) => UpdateTotalCost();

        private void LoadValidBookings()
        {
            var validBookings = _context.Bookings
                .Include(b => b.Customer)
                .Include(b => b.Room)
                .Where(b => !b.Canceled && b.ReservationDateTo >= DateTime.Today)
                .Select(b => new
                {
                    b.Id,
                    Display = $"#{b.Id} - {b.Customer.FullName} in Room {b.Room.RoomNumber}"
                })
                .ToList();

            comboBoxBookingId.DataSource = validBookings;
            comboBoxBookingId.DisplayMember = "Display";
            comboBoxBookingId.ValueMember = "Id";
        }

        private void UpdateTotalCost()
        {
            double costPerDay;
            DateTime fromDate = dateTimePicker_arrival.Value;
            DateTime toDate = dateTimePicker2_depart.Value;

            if (!double.TryParse(textBox_CostPerDay.Text, out costPerDay))
            {
                textBox_TotalCost.Text = "Invalid cost";
                return;
            }

            int bookingDuration = (int)(toDate - fromDate).TotalDays;
            if (bookingDuration <= 0)
            {
                textBox_TotalCost.Text = "Check dates";
                return;
            }

            if (!TryGetDiscount(out double discountPercent))
            {
                textBox_TotalCost.Text = "Invalid discount";
                return;
            }

            double baseCost = costPerDay * bookingDuration;
            double totalCost = ApplyDiscount(baseCost, discountPercent);
            textBox_TotalCost.Text = totalCost.ToString("F2");
        }

        private bool TryGetDiscount(out double discountPercent)
        {
            discountPercent = 0;
            string input = textBox_Discount.Text?.Trim();
            if (string.IsNullOrEmpty(input)) return true;

            if (double.TryParse(input, out double value))
            {
                if (value >= 0 && value <= 100)
                {
                    discountPercent = value;
                    return true;
                }
                else
                {
                    MessageBox.Show("Discount must be between 0 and 100%");
                    return false;
                }
            }

            MessageBox.Show("Enter a valid discount number.");
            return false;
        }

        private double ApplyDiscount(double basePrice, double discountPercent)
        {
            return basePrice - (basePrice * (discountPercent / 100));
        }

        private void comboBoxBookingId_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (comboBoxBookingId.SelectedValue is int bookingId)
            {
                var booking = _context.Bookings.FirstOrDefault(b => b.Id == bookingId);
                if (booking != null)
                {
                    dateTimePicker_arrival.Value = booking.CheckInDate ?? booking.ReservationDateFrom;
                    dateTimePicker2_depart.Value = booking.CheckOutDate ?? booking.ReservationDateTo;
                    textBox_CostPerDay.Text = booking.ReservationDayPrice.ToString("F2");

                    if (string.IsNullOrWhiteSpace(textBox_Discount.Text))
                        textBox_Discount.Text = "0";

                    UpdateTotalCost();
                }
            }
        }

        private void cancel_rsv_button_Click(object sender, EventArgs e)
        {
            if (comboBoxBookingId.SelectedValue == null)
            {
                MessageBox.Show("Please select a booking to cancel.");
                return;
            }

            int bookingId = (int)comboBoxBookingId.SelectedValue;
            var booking = _context.Bookings.FirstOrDefault(b => b.Id == bookingId);

            if (booking == null)
            {
                MessageBox.Show("Booking not found.");
                return;
            }

            booking.Canceled = true;
            _context.SaveChanges();
            MessageBox.Show("Reservation canceled successfully.");

            LoadValidBookings();
            ClearInputs();
        }

        private void button3_FinalConfirmation_Click(object sender, EventArgs e)
        {
            if (comboBoxBookingId.SelectedValue is int bookingId)
            {
                var booking = _context.Bookings.FirstOrDefault(b => b.Id == bookingId);
                if (booking != null)
                {
                    DateTime arrival = dateTimePicker_arrival.Value;
                    DateTime depart = dateTimePicker2_depart.Value;

                    if (depart <= arrival)
                    {
                        MessageBox.Show("Departure must be after arrival.");
                        return;
                    }

                    booking.CheckInDate = arrival;
                    booking.CheckOutDate = depart;

                    if (double.TryParse(textBox_CostPerDay.Text, out double costPerDay) &&
                        TryGetDiscount(out double discountPercent))
                    {
                        int duration = (int)(depart - arrival).TotalDays;
                        double baseCost = costPerDay * duration;
                        double discountedTotal = ApplyDiscount(baseCost, discountPercent);
                        booking.ReservationDayPrice = discountedTotal / duration; // Save discounted per-day rate
                    }

                    UpdateTotalCost();
                    _context.SaveChanges();
                    MessageBox.Show("Booking updated successfully.");
                    LoadValidBookings();
                    ClearInputs();
                }
                else
                {
                    MessageBox.Show("Booking not found.");
                }
            }
        }

        private void ClearInputs()
        {
            textBox_CostPerDay.Text = "";
            textBox_Discount.Text = "0";
            textBox_TotalCost.Text = "";
            dateTimePicker_arrival.Value = DateTime.Today;
            dateTimePicker2_depart.Value = DateTime.Today.AddDays(1);
        }


        private void button2_Click(object sender, EventArgs e)
        {
            if (comboBoxBookingId.SelectedValue is not int bookingId)
            {
                MessageBox.Show("Please select a valid booking to generate invoice.");
                return;
            }

            var booking = _context.Bookings
                .Include(b => b.Customer)
                .Include(b => b.Room)
                .FirstOrDefault(b => b.Id == bookingId);

            if (booking == null)
            {
                MessageBox.Show("Booking not found.");
                return;
            }

            string customerName = booking.Customer?.FullName ?? "Unknown Customer";
            string roomInfo = booking.Room != null
                ? $"Room {booking.Room.RoomNumber} ({booking.Room.Type})"
                : "Unknown Room";

            string arrival = dateTimePicker_arrival.Value.ToString("dd/MM/yyyy");
            string depart = dateTimePicker2_depart.Value.ToString("dd/MM/yyyy");
            string reservationRange = $"{arrival} - {depart}";

            string costPerDay = textBox_CostPerDay.Text;
            string discount = string.IsNullOrWhiteSpace(textBox_Discount.Text) ? "0" : textBox_Discount.Text;
            string totalCost = textBox_TotalCost.Text;
            
            
            string desktopPath = Environment.GetFolderPath(Environment.SpecialFolder.Desktop);
            string filePath = Path.Combine(desktopPath, $"Booking_{bookingId}.pdf");

            Document.Create(container =>
            {
                container.Page(page =>
                {
                    page.Margin(30);
                    page.Size(PageSizes.A4);

                    page.Content().Column(col =>
                    {
                        col.Spacing(10);
                        col.Item().Text("Hotel Philoxenia").FontSize(22).Bold();
                        col.Item().Text("Reservation Invoice").FontSize(16).Underline().Bold();

                        col.Item().Text($"Booking ID: {bookingId}");
                        col.Item().Text($"Reservation Dates: {reservationRange}");
                        col.Item().Text($"Room: {roomInfo}");
                        col.Item().Text($"Customer: {customerName}");

                        col.Item().Text($"Cost per Day: €{costPerDay}");
                        col.Item().Text($"Discount: {discount}%");
                        col.Item().Text($"Total Cost: €{totalCost}");

                        col.Item().PaddingTop(20).Text("Thank you for choosing Hotel Philoxenia!").Italic();
                    });
                });
            }).GeneratePdf(filePath);

            MessageBox.Show($"PDF successfully generated:\n{filePath}", "Success");
        }
    }
    }



