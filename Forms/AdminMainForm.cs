using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Hotel_Philoxenia.Forms
{
    public partial class AdminMainForm : Form
    {
        public AdminMainForm()
        {
            InitializeComponent();

            AdminMainExitBtn.Click += this.AdminMainExitBtn_Click;
            AdminMainFormCustBtn.Click += this.AdminMainFormCustBtn_Click;
            AdminMainFormRoomsBtn.Click += this.AdminMainFormRoomsBtn_Click;
            AdminMainFormBookingsBtn.Click += this.AdminMainFormBookingsBtn_Click;
            AdminMainFormToolsBtn.Click += this.AdminMainFormToolsBtn_Click;

        }

        private void AdminMainExitBtn_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void AdminMainFormCustBtn_Click(object sender, EventArgs e)
        {
            
            CustomerClass customerClass = new CustomerClass();
            customerClass.Show();
            this.Hide();
        }

        private void AdminMainFormRoomsBtn_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Under Construction");
        }

        private void AdminMainFormBookingsBtn_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Under Construction");
        }

        private void AdminMainFormToolsBtn_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Under Construction");
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void AdminMainExitBtn_Click_1(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
