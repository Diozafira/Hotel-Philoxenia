﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Microsoft.EntityFrameworkCore;
using Hotel_Philoxenia.Models;

namespace Hotel_Philoxenia.Forms
{

    

    public partial class RegistrationForm : Form
    {
        public RegistrationForm()
        {
            InitializeComponent();
        }

        private void registerSignup_Click(object sender, EventArgs e)
        {
            if (registerUsername.Text == "" || registerPassword.Text == "" || registerConfirmPass.Text == "")
            {
                MessageBox.Show("Please fill in all fields", "Error Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else if (registerPassword.Text != registerConfirmPass.Text)
            {
                MessageBox.Show("Passwords do not match");
            }
            else
            {
                using (var db = new HotelContext())
                {
                    var user = new User
                    {
                        Username = registerUsername.Text.Trim(),
                        Password = PasswordHelper.HashPassword(registerPassword.Text.Trim())
                    };
                    db.Users.Add(user);
                    db.SaveChanges();
                    MessageBox.Show("User registered successfully");
                }
            }
        }  

        private void registerShowPassBtn_CheckedChanged(object sender, EventArgs e)
        {
            registerPassword.UseSystemPasswordChar = !registerShowPassBtn.Checked;
            registerConfirmPass.UseSystemPasswordChar = !registerShowPassBtn.Checked;
        }

        private void registerPassword_TextChanged(object sender, EventArgs e) { }

        private void registerHeaderTextChanged(object sender, EventArgs e) { }

        private void label5_Click(object sender, EventArgs e) { }

        private void registerLogin_Click(object sender, EventArgs e)
        {
            this.Hide(); // Hide Register form
            LoginForm logForm = new LoginForm();
            logForm.FormClosed += (s, args) => this.Show(); 
            logForm.Show();
        }

        private void Button1_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

    }
}
