using Hotel_Philoxenia.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Linq;
using System.Windows.Forms;

namespace Hotel_Philoxenia.Forms
{
    public partial class BookingClass : Form
    {
        private readonly HotelContext _context;
        private bool isAddingCustomer = false;

        public BookingClass()
        {
            InitializeComponent();
            _context = new HotelContext();
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

        private void NudPersons_ValueChanged(object sender, EventArgs e)
        {
            SearchRooms();
        }
        
        private void Button4Search_Click(object sender, EventArgs e)
        {
            SearchRooms();
        }


        private void DtReservationFrom_ValueChanged(object sender, EventArgs e)
        {
            DateTime today = DateTime.Today;

            if (DtReservationFrom.Value < today)
            {
                MessageBox.Show("The reservation day cannot be earlier than today.");
                DtReservationFrom.Value = today;
            }
        }

       

        private void ToggleAddCustomerFields(bool enable)
        {
            isAddingCustomer = enable;
            comboBox1.Visible = !enable;
            button2.Visible = !enable;
            textBox2.Visible = enable;
            button3.Text = enable ? "Save New Customer" : "Add New Customer";
        }

        private void button3_Click(object sender, EventArgs e)
        {
            if (!isAddingCustomer)
            {
                textBox2.Clear();
                textBox2.Location = comboBox1.Location;
                button3.Location = button2.Location;
                ToggleAddCustomerFields(true);
                textBox2.Focus();
                return;
            }

            string fullNameInput = textBox2.Text.Trim();
            if (string.IsNullOrWhiteSpace(fullNameInput))
            {
                MessageBox.Show("Please enter a full name.");
                return;
            }

            var nameArray = fullNameInput.Split(' ');
            if (nameArray.Length != 2)
            {
                MessageBox.Show("Use format: Lastname Surname.");
                return;
            }

            string lastName = nameArray[0];
            string surName = nameArray[1];

            var newCustomer = new Customer
            {
                SurName = surName,
                LastName = lastName,
                Afm = "000000000"
            };

            _context.Customers.Add(newCustomer);
            _context.SaveChanges();

            var customers = _context.Customers.ToList();
            comboBox1.DataSource = customers;
            comboBox1.DisplayMember = "FullName";
            comboBox1.ValueMember = "Id";
            comboBox1.SelectedValue = newCustomer.Id;

            ToggleAddCustomerFields(false);
        }

        private void SearchRooms()
        {
            {
                int numberOfPersons = (int)NudPersons.Value;
                var reservationFrom = DtReservationFrom.Value.Date;
                var reservationTo = DtReservationTo.Value.Date;

                
                if (numberOfPersons <= 0)
                {
                    MessageBox.Show("Please select at least one person.");
                    return;
                }

                if (reservationTo <= reservationFrom)
                {
                    MessageBox.Show("Reservation end date must be after the start date.");
                    return;
                }

                var availableRooms = _context.Rooms
                    .Where(r => r.Capacity >= numberOfPersons &&
                                !_context.Bookings.Any(b =>
                                    b.RoomId == r.Id &&
                                    b.ReservationDateFrom < reservationTo &&
                                    b.ReservationDateTo > reservationFrom &&
                                    !b.Canceled))
                    .ToList();

                if (availableRooms.Count == 0)
                {
                    MessageBox.Show("No available rooms found for the selected dates and capacity.");
                }
                

                dataGridView1.DataSource = availableRooms;

                if (dataGridView1.Columns.Contains("Bookings"))
                    dataGridView1.Columns["Bookings"].Visible = false;

                
                comboBox2.DataSource = availableRooms;
                comboBox2.DisplayMember = "RoomNumber";
                comboBox2.ValueMember = "Id";

                var customers = _context.Customers.ToList();
                comboBox1.DataSource = customers;
                comboBox1.DisplayMember = "FullName";
                comboBox1.ValueMember = "Id";
            }
        }
        private void button4CreateReservation_Click(object sender, EventArgs e)
        {
            if (comboBox1.SelectedValue == null || comboBox2.SelectedValue == null)
            {
                MessageBox.Show("Please select a customer and a room.");
                return;
            }

            int customerId = (int)comboBox1.SelectedValue;
            int roomId = (int)comboBox2.SelectedValue;

            DateTime reservationFrom = DtReservationFrom.Value;
            DateTime reservationTo = DtReservationTo.Value;

            if (reservationTo <= reservationFrom)
            {
                MessageBox.Show("Reservation end date must be after start date.");
                return;
            }

            var room = _context.Rooms.FirstOrDefault(r => r.Id == roomId);
            if (room == null)
            {
                MessageBox.Show("Selected room not found.");
                return;
            }

            int days = (reservationTo - reservationFrom).Days;
            if (days <= 0)
            {
                MessageBox.Show("Reservation must be at least 1 day.");
                return;
            }

            decimal price = room.PricePerNight;

            var newReservation = new Booking
            {
                CustomerId = customerId,
                RoomId = roomId,
                ReservationDateFrom = reservationFrom,
                ReservationDateTo = reservationTo,
                CheckInDate = reservationFrom,
                CheckOutDate = reservationTo,
                ReservationDayPrice = (double)price,
                Canceled = false
            };

            _context.Bookings.Add(newReservation);
            try
            {
                _context.SaveChanges();
                MessageBox.Show("Reservation created successfully.");

            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error: {ex.Message}");
            }
        }
    }
}
