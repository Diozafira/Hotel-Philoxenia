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
    public partial class RegistrationForm : Form
    {
        public RegistrationForm()
        {
            InitializeComponent();
        }

        private void registerSignup_Click(object sender, EventArgs e) { }

        private void registerShowPassBtn_CheckedChanged(object sender, EventArgs e)
        {
            registerPassword.UseSystemPasswordChar = !registerShowPassBtn.Checked;
            registerConfirmPass.UseSystemPasswordChar = !registerShowPassBtn.Checked;
        }

        private void registerPassword_TextChanged(object sender, EventArgs e) { }

        private void registerUsername_TextChanged(object sender, EventArgs e) { }

        private void registerHeaderTextChanged(object sender, EventArgs e) { }
        
        private void label5_Click(object sender, EventArgs e) { }

     
    }
}
