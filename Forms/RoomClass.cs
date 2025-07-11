﻿using Hotel_Philoxenia.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Drawing.Printing;
using System.Linq;
using System.Numerics;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace Hotel_Philoxenia.Forms
{
    public partial class RoomClass : Form //A partial class in C# allows you to split the definition of a class across multiple files. When the code is compiled, all parts are combined into one class.
    {
        private readonly HotelContext _context;

        private int currentPage = 1;
        private int pageRecords = 5;
        private int totalPages = 0;


        public RoomClass()
        {
            InitializeComponent();
            _context = new HotelContext();

            LoadRooms();
            //LoadHotels();

            RoomsClass.SelectionChanged += DataGridView1_SelectionChanged;
            //this.return_image.Click += new System.EventHandler(this.ReturnToAdminForm_Click);

            addToolStripMenuItem.Click += (s, e) => AddRoom();
            updateToolStripMenuItem.Click += (s, e) => UpdateRoom();
            deleteToolStripMenuItem.Click += (s, e) => DeleteRoom();
            viewToolStripMenuItem.Click += (s, e) => LoadRooms();

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

            int totalRooms = _context.Rooms.Count();
            totalPages = totalRooms / pageRecords;
            roomBindingSource2.DataSource = _context.Rooms
                //.Include(r => r.Hotel)
                .AsNoTracking()
                .OrderBy(r => r.RoomNumber)
                .Skip((currentPage - 1) * pageRecords)
                .Take(pageRecords)
                .ToList();

            RoomsClass.DataSource = roomBindingSource2;
            roomBindingSource2.ResetBindings(false);
            if (RoomsClass.Columns.Contains("HotelId"))
                RoomsClass.Columns["HotelId"].Visible = false;

            if (RoomsClass.Columns.Contains("Hotel"))
                RoomsClass.Columns["Hotel"].Visible = false;

            labelPageNum.Text = $"Page {currentPage} of {totalPages}";

        }


        private void DataGridView1_SelectionChanged(object sender, EventArgs e)
        {
            if (RoomsClass.CurrentRow?.DataBoundItem is Room selected)
            {
                textBox2_roomid.Text = selected.Id.ToString();
                textBox3_roomNumber.Text = selected.RoomNumber;
                textBox2Capacity.Text = selected.Capacity.ToString();
                textBox4_roomType.Text = selected.Type;
                textBox5_priceperNight.Text = selected.PricePerNight.ToString("0.00");
                //IsAvaillable.Checked = selected.IsAvailable;
                //comboBoxHotel.SelectedValue = selected.HotelId;
            }
        }

        private void AddRoom()
        {
            /*if (comboBoxHotel.SelectedValue == null)
            {
                MessageBox.Show("Please select a hotel before adding a room.");
                return;
            }*/

            string roomType = textBox4_roomType.Text.Trim();
            if (roomType != "Single" && roomType != "Double" && roomType != "Suite")
            {
                MessageBox.Show("Please enter a valid room type (Single, Double or Suite).");
                return;
            }

            var newRoom = new Room
            {
                RoomNumber = textBox3_roomNumber.Text,
                Type = textBox4_roomType.Text,
                Capacity = int.Parse(textBox2Capacity.Text),
                PricePerNight = decimal.Parse(textBox5_priceperNight.Text),
               //IsAvailable = IsAvaillable.Checked,
               //HotelId = (int)comboBoxHotel.SelectedValue
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
                    room.Capacity = int.Parse(textBox2Capacity.Text);
                    room.PricePerNight = decimal.Parse(textBox5_priceperNight.Text);
                    //room.HotelId = (int)comboBoxHotel.SelectedValue;
                    //room.IsAvailable = IsAvaillable.Checked;



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
            textBox2Capacity.Text = "";
            //IsAvaillable.Checked = true;
            //comboBoxHotel.SelectedIndex = -1;
        }

        /*private void LoadHotels()
        {
            var hotels = _context.Hotels.ToList();
            comboBoxHotel.DataSource = hotels;
            comboBoxHotel.DisplayMember = "Name";
            comboBoxHotel.ValueMember = "Id";
        }*/

        private void GoToPreviousPage()
        {
            if (currentPage > 1)
            {
                currentPage--;
                LoadRooms();
            }
        }

        private void GoToNextPage()
        {
            if (currentPage < totalPages)
            {
                currentPage++;
                LoadRooms();
            }
        }

        private void btnPrevious_Click(object sender, EventArgs e)
        {
            GoToPreviousPage();
        }

        private void btnNext_Click(object sender, EventArgs e)
        {
            GoToNextPage();
        }

        
    }
}
