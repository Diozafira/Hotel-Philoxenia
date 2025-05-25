using Hotel_Philoxenia.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;
using static System.Runtime.InteropServices.JavaScript.JSType;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

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
    }
}
