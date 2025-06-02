using Hotel_Philoxenia.Forms;
using Hotel_Philoxenia.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace Hotel_Philoxenia
{
    public partial class ToolsClass : Form
    {
        private readonly HotelContext _context;




        public ToolsClass()
        {
            InitializeComponent();
            _context = new HotelContext();
            LoadValidBookings();
            UpdateTotalCost();



        }

        private void button1_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void ReturnToAdminForm_Click(object sender, EventArgs e)
        {
            this.Hide();
            AdminMainForm adminMainForm = new AdminMainForm();
            adminMainForm.Show();
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
                    Display = $"#{b.Id} - {b.Customer.SurName} in Room {b.Room.RoomNumber}"
                })
                .ToList();

            comboBoxBookingId.DataSource = validBookings;
            comboBoxBookingId.DisplayMember = "Display";
            comboBoxBookingId.ValueMember = "Id";
        }







        private void UpdateTotalCost()
        {
            if (double.TryParse(textBox_CostPerDay.Text, out double costPerDay) &&
                DateTime.TryParse(dateTimePicker_arrival.Text, out DateTime fromDate) &&
                DateTime.TryParse(dateTimePicker2_depart.Text, out DateTime toDate))
            {
                int bookingDuration = (int)(toDate - fromDate).TotalDays;

                if (bookingDuration <= 0)
                {
                    textBox_TotalCost.Text = "Invalid stay duration";
                    return;
                }

                if (double.TryParse(textBox_Discount.Text, out double discountPercent))
                {
                    if (discountPercent < 0 || discountPercent > 100)
                    {
                        textBox_TotalCost.Text = "Discount must be 0–100%";
                        return;
                    }

                    double baseCost = costPerDay * bookingDuration;
                    double totalCost = ApplyDiscount(baseCost, discountPercent);
                    textBox_TotalCost.Text = totalCost.ToString("F2");
                }
                else
                {
                    textBox_TotalCost.Text = "Invalid discount";
                }
            }
            else
            {
                textBox_TotalCost.Text = "Invalid input";
            }
        }



        private void button_UpdateBooking_Click(object sender, EventArgs e)
        {
            if (comboBoxBookingId.SelectedValue is int bookingId) // ✔️ Get selected booking
            {
                var booking = _context.Bookings.FirstOrDefault(b => b.Id == bookingId); // ✔️ Fetch booking from DB
                if (booking != null)
                {
                    booking.CheckInDate = dateTimePicker_arrival.Value; // ✔️ Update check-in
                    booking.CheckOutDate = dateTimePicker2_depart.Value; // ✔️ Update check-out

                    if (double.TryParse(textBox_CostPerDay.Text, out double costPerDay))
                    {
                        booking.ReservationDayPrice = costPerDay; // ✔️ Update cost if valid
                    }

                    _context.SaveChanges(); // ✔️ Save changes to DB
                    MessageBox.Show("Booking updated successfully.");
                }
                else
                {
                    MessageBox.Show("Booking not found."); // ❌ Could happen if invalid ID
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
                    // Set reservation dates in date pickers
                    dateTimePicker_arrival.Value = booking.ReservationDateFrom;
                    dateTimePicker2_depart.Value = booking.ReservationDateTo;

                    // Set price per day
                    textBox_CostPerDay.Text = booking.ReservationDayPrice.ToString("F2");

                    // Optional: pre-fill discount if stored, or default to 0
                    if (string.IsNullOrWhiteSpace(textBox_Discount.Text))
                    {
                        textBox_Discount.Text = "0";
                    }
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

        }

        private void button3_finalConfirmation_Click(object sender, EventArgs e)

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

                    if (double.TryParse(textBox_CostPerDay.Text, out double costPerDay))
                    {
                        int duration = (int)(depart - arrival).TotalDays;
                        booking.ReservationDayPrice = costPerDay * duration;
                    }

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

        private double ApplyDiscount(double basePrice, double discountPercent)
        {
           

            return basePrice - (basePrice * (discountPercent / 100));
        }

    }
}



    
