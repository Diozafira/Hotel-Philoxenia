using Hotel_Philoxenia.Forms;
using Hotel_Philoxenia.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Linq;
using QuestPDF.Fluent;
using QuestPDF.Helpers;
using QuestPDF.Infrastructure;
using System.IO;
using System.Windows.Forms;

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
                textBox_TotalCost.Text = "Invalid input";
                return;
            }

            int bookingDuration = (int)(toDate - fromDate).TotalDays;
            if (bookingDuration <= 0)
            {
                textBox_TotalCost.Text = "Please check the dates";
                return;
            }

            if (TryGetDiscount(out double discountPercent))
            {
                double baseCost = costPerDay * bookingDuration;
                double totalCost = ApplyDiscount(baseCost, discountPercent);
                textBox_TotalCost.Text = totalCost.ToString("F2");
            }
            else
            {
                textBox_TotalCost.Text = "Invalid discount";
            }
        }

        private bool TryGetDiscount(out double discountPercent)
        {
            if (double.TryParse(textBox_Discount.Text, out discountPercent) &&
                discountPercent >= 0 && discountPercent <= 100)
            {
                return true;
            }

            discountPercent = 0;
            return false;
        }

        private double ApplyDiscount(double basePrice, double discountPercent)
        {
            return basePrice - (basePrice * (discountPercent / 100));
        }

        private void button_UpdateBooking_Click(object sender, EventArgs e)
        {
            if (comboBoxBookingId.SelectedValue is int bookingId)
            {
                var booking = _context.Bookings.FirstOrDefault(b => b.Id == bookingId);
                if (booking != null)
                {
                    booking.CheckInDate = dateTimePicker_arrival.Value;
                    booking.CheckOutDate = dateTimePicker2_depart.Value;

                    if (double.TryParse(textBox_CostPerDay.Text, out double costPerDay))
                    {
                        booking.ReservationDayPrice = costPerDay;
                    }

                    _context.SaveChanges();
                    MessageBox.Show("Booking updated successfully.");
                }
                else
                {
                    MessageBox.Show("Booking not found.");
                }
            }
        }

        private void comboBoxBookingId_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (comboBoxBookingId.SelectedValue is int bookingId)
            {
                var booking = _context.Bookings.FirstOrDefault(b => b.Id == bookingId);
                if (booking != null)
                {
                    dateTimePicker_arrival.Value = booking.ReservationDateFrom;
                    dateTimePicker2_depart.Value = booking.ReservationDateTo;
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

        private void button_FinalizeUpdate_Click(object sender, EventArgs e)
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
                        double basePrice = costPerDay * duration;
                        booking.ReservationDayPrice = ApplyDiscount(costPerDay, discountPercent);
                    }
                    UpdateTotalCost();
                    _context.SaveChanges();
                    MessageBox.Show("Booking updated successfully.");
                    LoadValidBookings();
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
            // Retrieve values from form
            var bookingId = comboBoxBookingId.SelectedItem?.ToString() ?? "Unknown";
            var arrival = dateTimePicker_arrival.Value.ToString("dd/MM/yyyy");
            var depart = dateTimePicker2_depart.Value.ToString("dd/MM/yyyy");
            var totalCost = textBox_TotalCost.Text;
            var costPerDay = textBox_CostPerDay.Text;
            var discount = textBox_Discount.Text;

            string reservationRange = $"{arrival} - {depart}";
            string customer = "Customer Name (optional to fetch from model)";
            string room = "Room Info (optional to fetch from model)";

            string filePath = $"Booking_{bookingId}.pdf";

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
                        col.Item().Text($"Reservation: {reservationRange}");
                        col.Item().Text($"Room: {room}");
                        col.Item().Text($"Customer: {customer}");
                        col.Item().Text($"Cost per Day: {costPerDay}");
                        col.Item().Text($"Discount: {discount}%");
                        col.Item().Text($"Total Cost: {totalCost}");
                        col.Item().PaddingTop(20).Text("Thank you for choosing Hotel Philoxenia!").Italic();
                    });
                });
            }).GeneratePdf(filePath);

            MessageBox.Show($"PDF generated:\n{filePath}", "Success");
        }
    }

}
