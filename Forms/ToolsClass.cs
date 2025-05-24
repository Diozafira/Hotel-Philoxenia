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








        private void button2_Click(object sender, EventArgs e)
        {

        }
    }
}
