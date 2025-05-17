using Hotel_Philoxenia.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace Hotel_Philoxenia.Forms
{
    public partial class RoomClass : Form
    {
        private readonly HotelContext _context;
        private int currentPage = 1;
        private int pageSize = 10;
        private int totalPages = 1;
        private List<Room> allRooms = new List<Room>();

        

        public RoomClass()
        {
            InitializeComponent();
            _context = new HotelContext();

            LoadRooms();
            LoadHotels();

            dataGridViewRooms.SelectionChanged += DataGridView1_SelectionChanged;
            return_image.Click += ReturnToAdminForm_Click;


        }



        private void LoadRooms()
        {
            allRooms = _context.Rooms
                .Include(r => r.Hotel)
                .OrderBy(r => r.Id)
                .ToList();

            totalPages = (int)Math.Ceiling(allRooms.Count / (double)pageSize);
            DisplayPage(currentPage);
        }

        private void DisplayPage(int page)
        {
            var roomsToDisplay = allRooms
                .Skip((page - 1) * pageSize)
                .Take(pageSize)
                .ToList();

            var displayRooms = roomsToDisplay.Select(r => new
            {
                r.RoomNumber,
                r.Type,
                r.PricePerNight,
                r.IsAvailable,
                Hotel = r.Hotel != null ? r.Hotel.Name : "N/A"
            }).ToList();

            dataGridViewRooms.DataSource = roomsToDisplay;

        }

        private void DataGridView1_SelectionChanged(object sender, EventArgs e)
        {
            if (dataGridViewRooms.CurrentRow?.DataBoundItem is Room selected)
            {
                textBox3_roomNumber.Text = selected.RoomNumber.ToString();
                textBox4_roomType.Text = selected.Type;
                textBox5_priceperNight.Text = selected.PricePerNight.ToString();
                
            }
        }

        private void AddRoom()
        {
            if (comboBoxHotel.SelectedValue == null)
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
                HotelId = (int)comboBoxHotel.SelectedValue
            };

            _context.Rooms.Add(newRoom);
            _context.SaveChanges();
            currentPage = 1;
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
                    room.HotelId = (int)comboBoxHotel.SelectedValue;
                    room.IsAvailable = IsAvaillable.Checked;

                    _context.SaveChanges();
                    LoadRooms();
                    ClearFields();
                }
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
                        currentPage = 1;
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
            comboBoxHotel.DataSource = hotels;
            comboBoxHotel.DisplayMember = "Name";
            comboBoxHotel.ValueMember = "Id";
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

        private void textBox2_roomid_TextChanged(object sender, EventArgs e) { }
        private void dataGridViewRooms_CellContentClick(object sender, DataGridViewCellEventArgs e) { }
        private void label7_Click(object sender, EventArgs e) { }

        private void button2_Click(object sender, EventArgs e)
        {

        }
    }
}
