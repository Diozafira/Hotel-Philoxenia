using Hotel_Philoxenia.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Linq;
using System.Windows.Forms;

namespace Hotel_Philoxenia.Forms
{
    public partial class RoomClass : Form
    {
        private readonly HotelContext _context;

        public RoomClass()
        {
            InitializeComponent();
            _context = new HotelContext();
            LoadCustomers();

            dataGridView1.SelectionChanged += DataGridView1_SelectionChanged;
            this.return_image.Click += new System.EventHandler(this.ReturnToAdminForm_Click);

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


        private void menuStrip1_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {
            if (e.ClickedItem == addToolStripMenuItem)
            {
                AddCustomer();
            }
            else if (e.ClickedItem == updateToolStripMenuItem)
            {
                UpdateCustomer();
            }
            else if (e.ClickedItem == deleteToolStripMenuItem)
            {
                DeleteCustomer();
            }
            else if (e.ClickedItem == viewToolStripMenuItem)
            {
                LoadCustomers();
            }
        }

        private void LoadCustomers()
        {
            customerBindingSource.DataSource = _context.Customers.AsNoTracking().ToList();
        }

        private void DataGridView1_SelectionChanged(object sender, EventArgs e)
        {
            if (dataGridView1.CurrentRow?.DataBoundItem is Customer selected)
            {
                textBox2_roomid.Text = selected.Id.ToString();
                textBox3_roomNumber.Text = selected.SurName;
                textBox4_roomType.Text = selected.LastName;
                textBox5_priceperNight.Text = selected.Email;
                textBox6.Text = selected.Afm;
                textBox7.Text = selected.Telephone;
            }
        }

        private void AddCustomer()
        {
            var newCustomer = new Customer
            {
                SurName = textBox3_roomNumber.Text,
                LastName = textBox4_roomType.Text,
                Email = textBox5_priceperNight.Text,
                Afm = textBox6.Text,
                Telephone = textBox7.Text
            };

            _context.Customers.Add(newCustomer);
            _context.SaveChanges();
            LoadCustomers();
            ClearFields();
        }

        private void UpdateCustomer()
        {
            if (int.TryParse(textBox2_roomid.Text, out int id))
            {
                var customer = _context.Customers.Find(id);
                if (customer != null)
                {
                    customer.SurName = textBox3_roomNumber.Text;
                    customer.LastName = textBox4_roomType.Text;
                    customer.Email = textBox5_priceperNight.Text;
                    customer.Afm = textBox6.Text;
                    customer.Telephone = textBox7.Text;

                    _context.SaveChanges();
                    LoadCustomers();
                    ClearFields();
                }
            }
        }

        private void DeleteCustomer()
        {
            if (int.TryParse(textBox2_roomid.Text, out int id))
            {
                var customer = _context.Customers.Find(id);
                if (customer != null)
                {
                    var confirm = MessageBox.Show("Are you sure for this deletion?", "Confirm", MessageBoxButtons.YesNo);
                    if (confirm == DialogResult.Yes)
                    {
                        _context.Customers.Remove(customer);
                        _context.SaveChanges();
                        LoadCustomers();
                        ClearFields();
                    }
                }
            }
        }

        private void ClearFields()
        {
            textBox2_roomid.Text = "";
            textBox3_roomNumber.Text = "";
            textBox4_roomType.Text = "";
            textBox5_priceperNight.Text = "";
            textBox6.Text = "";
            textBox7.Text = "";
        }
    }
}
