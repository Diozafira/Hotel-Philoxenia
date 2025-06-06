using Hotel_Philoxenia.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Linq;
using System.Windows.Forms;

namespace Hotel_Philoxenia.Forms
{
    public partial class CustomerClass : Form
    {
        private readonly HotelContext _context;

        public CustomerClass()
        {
            InitializeComponent();
            _context = new HotelContext();
            LoadCustomers();

            dataGridView1.SelectionChanged += DataGridView1_SelectionChanged;
            this.return_image.Click += new System.EventHandler(this.ReturnToAdminForm_Click);

            addToolStripMenuItem.Click += (s, e) => AddCustomer();
            updateToolStripMenuItem.Click += (s, e) => UpdateCustomer();
            deleteToolStripMenuItem.Click += (s, e) => DeleteCustomer();
            viewToolStripMenuItem.Click += (s, e) => LoadCustomers();

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
            customerBindingSource.DataSource = _context.Customers.AsNoTracking().ToList();//tells EF not to track the entities it retrieves from the database.
        }

        private void DataGridView1_SelectionChanged(object sender, EventArgs e)
        {
            if (dataGridView1.CurrentRow?.DataBoundItem is Customer selected)
            {
                textBox2.Text = selected.Id.ToString();
                textBox3.Text = selected.SurName;
                textBox4.Text = selected.LastName;
                textBox5.Text = selected.Email;
                textBox6.Text = selected.Afm;
                textBox7.Text = selected.Telephone;
            }
        }

        private void AddCustomer()
        {
            var newCustomer = new Customer
            {
                SurName = textBox3.Text,
                LastName = textBox4.Text,
                Email = textBox5.Text,
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
            if (int.TryParse(textBox2.Text, out int id))//cast without error exceptions
            {
                var customer = _context.Customers.Find(id);
                if (customer != null)
                {
                    customer.SurName = textBox3.Text;
                    customer.LastName = textBox4.Text;
                    customer.Email = textBox5.Text;
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
            if (int.TryParse(textBox2.Text, out int id))
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
            textBox2.Text = "";
            textBox3.Text = "";
            textBox4.Text = "";
            textBox5.Text = "";
            textBox6.Text = "";
            textBox7.Text = "";
        }
    }
}
