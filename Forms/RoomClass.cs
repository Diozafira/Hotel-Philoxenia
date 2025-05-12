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
            LoadRooms();
            LoadHotels();

            dataGridViewRooms.SelectionChanged += DataGridView1_SelectionChanged;
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
                AddRoom();
            }
            else if (e.ClickedItem == updateToolStripMenuItem)
            {
                UpdateRoom();
            }
            else if (e.ClickedItem == deleteToolStripMenuItem)
            {
                DeleteRoom();
            }
            else if (e.ClickedItem == viewToolStripMenuItem)
            {
                LoadRooms();
            }
        }

        private void LoadRooms()
        {
            roomBindingSource.DataSource = _context.Rooms.ToList();
        }

        private void DataGridView1_SelectionChanged(object sender, EventArgs e)
        {
            if (dataGridViewRooms.CurrentRow?.DataBoundItem is Room selected)
            {
                textBox2_roomid.Text = selected.Id.ToString();
                textBox3_roomNumber.Text = selected.RoomNumber;
                textBox4_roomType.Text = selected.Type;
                textBox5_priceperNight.Text = selected.PricePerNight.ToString("F2");
            }
        }

        private void AddRoom()
        {
            if (comboBoxHotels.SelectedValue == null)
            {
                MessageBox.Show("Please select a hotel before adding a room.");
                return;
            }

            var newRoom = new Room
            {
                RoomNumber = textBox3_roomNumber.Text,
                Type = textBox4_roomType.Text,
                PricePerNight = decimal.Parse(textBox5_priceperNight.Text),
                IsAvailable = IsAvaillable.Checked,
                HotelId = (int)comboBoxHotels.SelectedValue 
            };

            _context.Rooms.Add(newRoom);
            _context.SaveChanges();
            LoadRooms();
            ClearFields();
        }

        private void UpdateRoom()
        {
            if (int.TryParse(textBox2_roomid.Text, out int id))
            {
                var room = _context.Rooms.Find(id);
                if (room != null)
                {
                    room.RoomNumber = textBox3_roomNumber.Text;
                    room.Type = textBox4_roomType.Text;
                    room.PricePerNight = decimal.Parse(textBox5_priceperNight.Text);
                    // IsAvailable = IsAvailable.Checked;
                }
                ;


                _context.SaveChanges();
                LoadRooms();
                ClearFields();
            }
        }


        private void DeleteRoom()
        {
            if (int.TryParse(textBox2_roomid.Text, out int id))
            {
                var room = _context.Rooms.Find(id);
                if (room != null)
                {
                    var confirm = MessageBox.Show("Are you sure for this deletion?", "Confirm", MessageBoxButtons.YesNo);
                    if (confirm == DialogResult.Yes)
                    {
                        _context.Rooms.Remove(room);
                        _context.SaveChanges();
                        LoadRooms();
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
        }


        private void LoadHotels()
        {
            var hotels = _context.Hotels.ToList();
            comboBoxHotels.DataSource = hotels;
            comboBoxHotels.DisplayMember = "Name";    // Adjust this if your Hotel model has a different property for the name
            comboBoxHotels.ValueMember = "Id";        // Primary key
        }


        private void textBox2_roomid_TextChanged(object sender, EventArgs e)
        {

        }

        private void dataGridViewRooms_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void label7_Click(object sender, EventArgs e)
        {

        }
    }
}
