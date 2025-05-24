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
            _context.Bookings.Where(r =>
                ((r.ReservationDateFrom >= DtReservationFrom.Value &&
                r.ReservationDateFrom <= DtReservationTo.Value) ||
                (r.ReservationDateTo >= DtReservationFrom.Value &&
                r.ReservationDateTo <= DtReservationTo.Value)) &&
                r.Room.Capacity >= Convert.ToInt32(NudPersons.Value)
            );

            
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

        
    }
}
