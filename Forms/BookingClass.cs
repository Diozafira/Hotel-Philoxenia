using Hotel_Philoxenia.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;
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
    }
}
