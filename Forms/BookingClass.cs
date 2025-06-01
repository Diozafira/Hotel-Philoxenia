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



        private void button4CreateReservation_Click(object sender, EventArgs e)
        {
            int customerId = (int)comboBox1.SelectedValue;
            int roomId = (int)comboBox2.SelectedValue;

            DateTime reservationFrom = DtReservationFrom.Value;
            DateTime reservationTo = DtReservationTo.Value;
            //DateTime checkInDate = dateTimePicker_arrival.Value;
            //DateTime checkOutDate = dateTimePicker_depart.Value;

            Booking newReservation = new Booking
            {
                CustomerId = customerId,
                RoomId = roomId,
                ReservationDateFrom = reservationFrom,
                ReservationDateTo = reservationTo,
                //CheckInDate = checkInDate,              
                //CheckOutDate = checkOutDate,           
                ReservationDayPrice = 0,
                Canceled = false
            };

            _context.Bookings.Add(newReservation);
            _context.SaveChanges();
            MessageBox.Show("Reservation created successfully.");
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

        private void button3_Click(object sender, EventArgs e)
        { 
           ChangeFields();
           textBox2.Location = comboBox1.Location;
           button3.Location = button2.Location;
        
            if (string.IsNullOrEmpty(textBox2.Text.Trim()))
                ChangeFields();

            var nameArray = textBox2.Text.Trim().Split(' ');
            if (nameArray.Length == 2)
            {
                Models.Customer newCustomer = new Models.Customer()
                {
                    SurName = nameArray[0],
                    LastName = nameArray[1],
                    Afm = "000000000"
                };
                _context.Customers.Add(newCustomer);
                _context.SaveChanges();
                comboBox1.DataSource = _context.Customers.ToList();
                comboBox1.DisplayMember = "FullName";
                comboBox1.SelectedIndex = -1;

                comboBox1.SelectedValue = newCustomer.Id;
                ChangeFields();
            }

        }

        private void ChangeFields()
        {
            comboBox1.Visible = !comboBox1.Visible;
            button2.Visible = !button2.Visible;
            textBox2.Visible = !textBox2.Visible;
            button3.Visible = !button3.Visible;
        }
    }
    }


