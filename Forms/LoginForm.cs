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
    public partial class LoginForm : Form
    {
        public LoginForm()
        {
            InitializeComponent();
        }

        private void loginRegistration_Click(object sender, EventArgs e)
        {
            this.Hide(); // Hide login form
            RegistrationForm regForm = new RegistrationForm();
            regForm.FormClosed += (s, args) => this.Show(); // Re-show login after register closes
            regForm.Show();
        }
        private void label2_Click(object sender, EventArgs e) { }
        private void label1_Click(object sender, EventArgs e) { }
        private void pictureBox1_Click(object sender, EventArgs e) { }
        private void loginClose_TextChanged(object sender, EventArgs e) { }
        private void textBox2_TextChanged(object sender, EventArgs e) { }
        private void loginUsername_TextChanged(object sender, EventArgs e) { }
        private void loginPassword_TextChanged(object sender, EventArgs e) { }
        private void loginShowPassBtn_CheckedChanged(object sender, EventArgs e)
        {
            loginPassword.UseSystemPasswordChar = !loginShowPassBtn.Checked;
        }
        private void loginLogin_Click(object sender, EventArgs e) { }
        private void label5_Click(object sender, EventArgs e) { }
        private void label6_Click(object sender, EventArgs e) { }

        private void button1_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
