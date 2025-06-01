using Hotel_Philoxenia.Models;

namespace Hotel_Philoxenia.Forms
{
    public partial class BookingClass : Form
    {
        private readonly HotelContext _context;

        public BookingClass()
        {
            InitializeComponent();
            _context = new HotelContext();
        }



        private void BtnSearchRoom_Click(object sender, EventArgs e)
        {
            int numberOfPersons = (int)NudPersons.Value;

            ////var availableBookings = _context.Bookings
            //    .Include(b => b.Room)
            //    .Where(r =>
            //        ((r.ReservationDateFrom >= DtReservationFrom.Value &&
            //          r.ReservationDateFrom <= DtReservationTo.Value) ||
            //         (r.ReservationDateTo >= DtReservationFrom.Value &&
            //          r.ReservationDateTo <= DtReservationTo.Value)) &&
            //          r.Room.Capacity >= NudPersons.Value
            //    )
            //    .ToList();

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

        private void BringRooms()
        {
            int selectedCapacity = (int)NudPersons.Value;

            var rooms = _context.Rooms
                .Where(r => r.Capacity >= selectedCapacity)
                .ToList();

            var customers = _context.Customers
            .Select(c => new
            {
                c.Id,
                FullName = c.LastName + " " + c.SurName
            })
         .ToList();

            dataGridView1.DataSource = rooms;

            comboBox2.DataSource = rooms;
            comboBox2.ValueMember = "Id";
            comboBox2.DisplayMember = "RoomNumber";

            comboBox1.DataSource = customers;
            comboBox1.ValueMember = "Id";
            comboBox1.DisplayMember = "Fullname";


        }

        private void NudPersons_ValueChanged(object sender, EventArgs e)
        {
            BringRooms();
        }

        private void textBox4_TextChanged(object sender, EventArgs e)
        {
            if (double.TryParse(textBox3.Text, out double costPerDay))
            {
                int bookingDuration = 3;
                // bookingDuration = (DtReservationTo.Value - DtReservationFrom.Value) + int 1;
                double totalCost = costPerDay * bookingDuration;
                textBox4.Text = totalCost.ToString("F2");
            }
        }

        private void button4CreateReservation_Click(object sender, EventArgs e)
        {
            int customerId = (int)comboBox1.SelectedValue;
            int roomId = (int)comboBox2.SelectedValue;
            

            DateTime reservationFrom = DtReservationFrom.Value;
            DateTime reservationTo = DtReservationTo.Value;

            if (!double.TryParse(textBox3.Text, out double reservationDayPrice))
            {
                MessageBox.Show("Please enter a valid numeric value for Reservation Day Price.");
                return;
            }

            Booking newReservation = new Booking
            {
                CustomerId = customerId,
                RoomId = roomId,
                ReservationDateFrom = reservationFrom,
                ReservationDateTo = reservationTo,
               //CheckInDate = reservationFrom,
               //CheckOutDate = reservationTo,
                Canceled = false,
                ReservationDayPrice = reservationDayPrice
                 
                
            };


            _context.Bookings.Add(newReservation);
            _context.SaveChanges();
            MessageBox.Show("Reservation created successfully.");
        }
    }
}

