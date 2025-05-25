namespace Hotel_Philoxenia.Forms
{
    partial class RoomClass
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(RoomClass));
            DataGridViewCellStyle dataGridViewCellStyle2 = new DataGridViewCellStyle();
            roomBindingSource = new BindingSource(components);
            button1 = new Button();
            textBox1 = new TextBox();
            pictureBox2 = new PictureBox();
            label1 = new Label();
            pictureBox1 = new PictureBox();
            RoomsClass = new DataGridView();
            dataGridViewTextBoxColumn1 = new DataGridViewTextBoxColumn();
            dataGridViewTextBoxColumn2 = new DataGridViewTextBoxColumn();
            dataGridViewTextBoxColumn3 = new DataGridViewTextBoxColumn();
            IsAvailable = new DataGridViewCheckBoxColumn();
            Hotel = new DataGridViewTextBoxColumn();
            roomBindingSource2 = new BindingSource(components);
            roomBindingSource1 = new BindingSource(components);
            hotelBindingSource = new BindingSource(components);
            toolTip1 = new ToolTip(components);
            textBox4_roomType = new TextBox();
            menuStrip1 = new MenuStrip();
            addToolStripMenuItem = new ToolStripMenuItem();
            deleteToolStripMenuItem = new ToolStripMenuItem();
            updateToolStripMenuItem = new ToolStripMenuItem();
            viewToolStripMenuItem = new ToolStripMenuItem();
            roomid = new Label();
            RoomNumber = new Label();
            Type = new Label();
            PricePerNight = new Label();
            Availlability = new Label();
            textBox2_roomid = new TextBox();
            textBox3_roomNumber = new TextBox();
            textBox5_priceperNight = new TextBox();
            return_image = new PictureBox();
            IsAvaillable = new CheckBox();
            comboBoxHotel = new ComboBox();
            roomsBindingSource = new BindingSource(components);
            label2 = new Label();
            btnPrevious = new Button();
            btnNext = new Button();
            labelPageNum = new Label();
            label3Capacity = new Label();
            textBox2Capacity = new TextBox();
            ((System.ComponentModel.ISupportInitialize)roomBindingSource).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)RoomsClass).BeginInit();
            ((System.ComponentModel.ISupportInitialize)roomBindingSource2).BeginInit();
            ((System.ComponentModel.ISupportInitialize)roomBindingSource1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)hotelBindingSource).BeginInit();
            menuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)return_image).BeginInit();
            ((System.ComponentModel.ISupportInitialize)roomsBindingSource).BeginInit();
            SuspendLayout();
            // 
            // roomBindingSource
            // 
            roomBindingSource.DataSource = typeof(Models.Room);
            // 
            // button1
            // 
            button1.BackColor = Color.Silver;
            button1.ForeColor = Color.Black;
            button1.Image = (Image)resources.GetObject("button1.Image");
            button1.Location = new Point(60, 340);
            button1.Margin = new Padding(3, 2, 3, 2);
            button1.Name = "button1";
            button1.Size = new Size(100, 52);
            button1.TabIndex = 12;
            button1.Text = "Log Out";
            button1.TextImageRelation = TextImageRelation.TextAboveImage;
            button1.UseVisualStyleBackColor = false;
            button1.Click += button1_Click;
            // 
            // textBox1
            // 
            textBox1.BackColor = Color.Silver;
            textBox1.BorderStyle = BorderStyle.None;
            textBox1.Font = new Font("Segoe Script", 7.8F, FontStyle.Regular, GraphicsUnit.Point, 161);
            textBox1.ForeColor = Color.OrangeRed;
            textBox1.Location = new Point(0, 458);
            textBox1.Margin = new Padding(3, 2, 3, 2);
            textBox1.Multiline = true;
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(216, 62);
            textBox1.TabIndex = 11;
            textBox1.Text = " Rue Philoxenia, Athens\r\n11257\r\nemail: philoxenia@yahoo.gr\r\ntel.: 210-2233456\r\n";
            textBox1.TextAlign = HorizontalAlignment.Center;
            // 
            // pictureBox2
            // 
            pictureBox2.Image = (Image)resources.GetObject("pictureBox2.Image");
            pictureBox2.Location = new Point(0, 2);
            pictureBox2.Margin = new Padding(3, 2, 3, 2);
            pictureBox2.Name = "pictureBox2";
            pictureBox2.Size = new Size(224, 46);
            pictureBox2.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox2.TabIndex = 9;
            pictureBox2.TabStop = false;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Cambria", 16.2F, FontStyle.Bold, GraphicsUnit.Point, 161);
            label1.ForeColor = Color.OrangeRed;
            label1.Location = new Point(13, 62);
            label1.Name = "label1";
            label1.Size = new Size(182, 26);
            label1.TabIndex = 10;
            label1.Text = "Hotel Philoxenia";
            label1.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // pictureBox1
            // 
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(-3, 99);
            pictureBox1.Margin = new Padding(0);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(229, 193);
            pictureBox1.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox1.TabIndex = 8;
            pictureBox1.TabStop = false;
            // 
            // RoomsClass
            // 
            RoomsClass.AllowUserToAddRows = false;
            RoomsClass.AllowUserToDeleteRows = false;
            RoomsClass.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            RoomsClass.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            RoomsClass.Columns.AddRange(new DataGridViewColumn[] { dataGridViewTextBoxColumn1, dataGridViewTextBoxColumn2, dataGridViewTextBoxColumn3, IsAvailable, Hotel });
            RoomsClass.GridColor = Color.FromArgb(255, 128, 0);
            RoomsClass.Location = new Point(293, 290);
            RoomsClass.Margin = new Padding(3, 2, 3, 2);
            RoomsClass.Name = "RoomsClass";
            RoomsClass.ReadOnly = true;
            RoomsClass.RowHeadersWidth = 51;
            RoomsClass.Size = new Size(651, 152);
            RoomsClass.TabIndex = 13;
            // 
            // dataGridViewTextBoxColumn1
            // 
            dataGridViewTextBoxColumn1.DataPropertyName = "RoomNumber";
            dataGridViewTextBoxColumn1.HeaderText = "RoomNumber";
            dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
            dataGridViewTextBoxColumn1.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn2
            // 
            dataGridViewTextBoxColumn2.DataPropertyName = "Type";
            dataGridViewTextBoxColumn2.HeaderText = "Type";
            dataGridViewTextBoxColumn2.Name = "dataGridViewTextBoxColumn2";
            dataGridViewTextBoxColumn2.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn3
            // 
            dataGridViewTextBoxColumn3.DataPropertyName = "PricePerNight";
            dataGridViewCellStyle2.Format = "C2";
            dataGridViewCellStyle2.NullValue = "C2";
            dataGridViewTextBoxColumn3.DefaultCellStyle = dataGridViewCellStyle2;
            dataGridViewTextBoxColumn3.HeaderText = "PricePerNight";
            dataGridViewTextBoxColumn3.Name = "dataGridViewTextBoxColumn3";
            dataGridViewTextBoxColumn3.ReadOnly = true;
            // 
            // IsAvailable
            // 
            IsAvailable.DataPropertyName = "IsAvailable";
            IsAvailable.HeaderText = "IsAvailable";
            IsAvailable.Name = "IsAvailable";
            IsAvailable.ReadOnly = true;
            // 
            // Hotel
            // 
            Hotel.DataPropertyName = "HotelName";
            Hotel.HeaderText = "Hotel";
            Hotel.Name = "Hotel";
            Hotel.ReadOnly = true;
            Hotel.Resizable = DataGridViewTriState.True;
            Hotel.SortMode = DataGridViewColumnSortMode.Programmatic;
            // 
            // roomBindingSource2
            // 
            roomBindingSource2.DataSource = typeof(Models.Room);
            // 
            // roomBindingSource1
            // 
            roomBindingSource1.DataSource = typeof(Models.Room);
            // 
            // hotelBindingSource
            // 
            hotelBindingSource.DataSource = typeof(Models.Hotel);
            // 
            // textBox4_roomType
            // 
            textBox4_roomType.DataBindings.Add(new Binding("DataContext", roomBindingSource1, "Type", true));
            textBox4_roomType.Location = new Point(393, 128);
            textBox4_roomType.Name = "textBox4_roomType";
            textBox4_roomType.Size = new Size(241, 23);
            textBox4_roomType.TabIndex = 24;
            toolTip1.SetToolTip(textBox4_roomType, "Single, Double or Suite\r\n");
            // 
            // menuStrip1
            // 
            menuStrip1.Dock = DockStyle.None;
            menuStrip1.Font = new Font("Cambria", 12F, FontStyle.Bold);
            menuStrip1.GripStyle = ToolStripGripStyle.Visible;
            menuStrip1.Items.AddRange(new ToolStripItem[] { addToolStripMenuItem, deleteToolStripMenuItem, updateToolStripMenuItem, viewToolStripMenuItem });
            menuStrip1.Location = new Point(662, 21);
            menuStrip1.Name = "menuStrip1";
            menuStrip1.Size = new Size(262, 27);
            menuStrip1.TabIndex = 15;
            menuStrip1.Text = "menuStrip1";
            // 
            // addToolStripMenuItem
            // 
            addToolStripMenuItem.ForeColor = Color.OrangeRed;
            addToolStripMenuItem.Name = "addToolStripMenuItem";
            addToolStripMenuItem.Size = new Size(51, 23);
            addToolStripMenuItem.Text = "Add";
            // 
            // deleteToolStripMenuItem
            // 
            deleteToolStripMenuItem.ForeColor = Color.OrangeRed;
            deleteToolStripMenuItem.Name = "deleteToolStripMenuItem";
            deleteToolStripMenuItem.Size = new Size(67, 23);
            deleteToolStripMenuItem.Text = "Delete";
            // 
            // updateToolStripMenuItem
            // 
            updateToolStripMenuItem.ForeColor = Color.OrangeRed;
            updateToolStripMenuItem.Name = "updateToolStripMenuItem";
            updateToolStripMenuItem.Size = new Size(75, 23);
            updateToolStripMenuItem.Text = "Update";
            // 
            // viewToolStripMenuItem
            // 
            viewToolStripMenuItem.ForeColor = Color.OrangeRed;
            viewToolStripMenuItem.Name = "viewToolStripMenuItem";
            viewToolStripMenuItem.Size = new Size(57, 23);
            viewToolStripMenuItem.Text = "View";
            // 
            // roomid
            // 
            roomid.AutoSize = true;
            roomid.Location = new Point(293, 68);
            roomid.Name = "roomid";
            roomid.Size = new Size(52, 15);
            roomid.TabIndex = 16;
            roomid.Text = "Room Id";
            // 
            // RoomNumber
            // 
            RoomNumber.AutoSize = true;
            RoomNumber.Location = new Point(293, 99);
            RoomNumber.Name = "RoomNumber";
            RoomNumber.Size = new Size(84, 15);
            RoomNumber.TabIndex = 17;
            RoomNumber.Text = "Room number";
            // 
            // Type
            // 
            Type.AutoSize = true;
            Type.Location = new Point(293, 131);
            Type.Name = "Type";
            Type.Size = new Size(31, 15);
            Type.TabIndex = 18;
            Type.Text = "Type";
            // 
            // PricePerNight
            // 
            PricePerNight.AutoSize = true;
            PricePerNight.DataBindings.Add(new Binding("Text", roomBindingSource1, "PricePerNight", true));
            PricePerNight.Location = new Point(293, 164);
            PricePerNight.Name = "PricePerNight";
            PricePerNight.Size = new Size(86, 15);
            PricePerNight.TabIndex = 19;
            PricePerNight.Text = "Price per Night";
            // 
            // Availlability
            // 
            Availlability.AutoSize = true;
            Availlability.DataBindings.Add(new Binding("Text", roomBindingSource1, "IsAvailable", true));
            Availlability.Location = new Point(293, 196);
            Availlability.Name = "Availlability";
            Availlability.Size = new Size(68, 15);
            Availlability.TabIndex = 20;
            Availlability.Text = "Availlability";
            // 
            // textBox2_roomid
            // 
            textBox2_roomid.DataBindings.Add(new Binding("DataContext", roomBindingSource1, "Id", true));
            textBox2_roomid.Location = new Point(393, 69);
            textBox2_roomid.Name = "textBox2_roomid";
            textBox2_roomid.ReadOnly = true;
            textBox2_roomid.Size = new Size(241, 23);
            textBox2_roomid.TabIndex = 22;
            // 
            // textBox3_roomNumber
            // 
            textBox3_roomNumber.DataBindings.Add(new Binding("DataContext", roomBindingSource1, "RoomNumber", true));
            textBox3_roomNumber.Location = new Point(393, 99);
            textBox3_roomNumber.Name = "textBox3_roomNumber";
            textBox3_roomNumber.Size = new Size(241, 23);
            textBox3_roomNumber.TabIndex = 23;
            // 
            // textBox5_priceperNight
            // 
            textBox5_priceperNight.DataBindings.Add(new Binding("DataContext", roomBindingSource1, "PricePerNight", true));
            textBox5_priceperNight.Location = new Point(393, 161);
            textBox5_priceperNight.Name = "textBox5_priceperNight";
            textBox5_priceperNight.Size = new Size(241, 23);
            textBox5_priceperNight.TabIndex = 25;
            // 
            // return_image
            // 
            return_image.Image = (Image)resources.GetObject("return_image.Image");
            return_image.Location = new Point(901, 2);
            return_image.Name = "return_image";
            return_image.Size = new Size(16, 16);
            return_image.SizeMode = PictureBoxSizeMode.AutoSize;
            return_image.TabIndex = 28;
            return_image.TabStop = false;
            return_image.Click += ReturnToAdminForm_Click;
            // 
            // IsAvaillable
            // 
            IsAvaillable.AutoSize = true;
            IsAvaillable.Checked = true;
            IsAvaillable.CheckState = CheckState.Checked;
            IsAvaillable.DataBindings.Add(new Binding("CheckState", roomBindingSource, "IsAvailable", true, DataSourceUpdateMode.OnPropertyChanged));
            IsAvaillable.Location = new Point(394, 195);
            IsAvaillable.Name = "IsAvaillable";
            IsAvaillable.Size = new Size(74, 19);
            IsAvaillable.TabIndex = 29;
            IsAvaillable.Text = "Available";
            IsAvaillable.UseVisualStyleBackColor = true;
            // 
            // comboBoxHotel
            // 
            comboBoxHotel.DropDownStyle = ComboBoxStyle.DropDownList;
            comboBoxHotel.FormattingEnabled = true;
            comboBoxHotel.Items.AddRange(new object[] { "Building A", "Building B" });
            comboBoxHotel.Location = new Point(393, 261);
            comboBoxHotel.Name = "comboBoxHotel";
            comboBoxHotel.Size = new Size(121, 23);
            comboBoxHotel.TabIndex = 30;
            // 
            // roomsBindingSource
            // 
            roomsBindingSource.DataMember = "Rooms";
            roomsBindingSource.DataSource = hotelBindingSource;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.DataBindings.Add(new Binding("Text", roomBindingSource1, "IsAvailable", true));
            label2.Location = new Point(293, 261);
            label2.Name = "label2";
            label2.Size = new Size(83, 15);
            label2.TabIndex = 31;
            label2.Text = "Hotel Building";
            // 
            // btnPrevious
            // 
            btnPrevious.BackColor = Color.Transparent;
            btnPrevious.ForeColor = Color.OrangeRed;
            btnPrevious.Location = new Point(788, 458);
            btnPrevious.Name = "btnPrevious";
            btnPrevious.Size = new Size(75, 23);
            btnPrevious.TabIndex = 32;
            btnPrevious.Text = "previous";
            btnPrevious.UseVisualStyleBackColor = false;
            btnPrevious.Click += btnPrevious_Click;
            // 
            // btnNext
            // 
            btnNext.BackColor = Color.Transparent;
            btnNext.ForeColor = Color.OrangeRed;
            btnNext.Location = new Point(869, 458);
            btnNext.Name = "btnNext";
            btnNext.Size = new Size(75, 23);
            btnNext.TabIndex = 33;
            btnNext.Text = "next";
            btnNext.UseVisualStyleBackColor = false;
            btnNext.Click += btnNext_Click;
            // 
            // labelPageNum
            // 
            labelPageNum.AutoSize = true;
            labelPageNum.BackColor = SystemColors.ControlLight;
            labelPageNum.BorderStyle = BorderStyle.FixedSingle;
            labelPageNum.Font = new Font("Segoe UI", 9.75F, FontStyle.Italic, GraphicsUnit.Point, 161);
            labelPageNum.ForeColor = Color.OrangeRed;
            labelPageNum.Location = new Point(872, 503);
            labelPageNum.Name = "labelPageNum";
            labelPageNum.Size = new Size(74, 19);
            labelPageNum.TabIndex = 34;
            labelPageNum.Text = "Page 1 of 1";
            labelPageNum.TextAlign = ContentAlignment.TopCenter;
            // 
            // label3Capacity
            // 
            label3Capacity.AutoSize = true;
            label3Capacity.DataBindings.Add(new Binding("Text", roomBindingSource1, "Capacity", true));
            label3Capacity.Location = new Point(293, 230);
            label3Capacity.Name = "label3Capacity";
            label3Capacity.Size = new Size(53, 15);
            label3Capacity.TabIndex = 35;
            label3Capacity.Text = "Capacity";
            // 
            // textBox2Capacity
            // 
            textBox2Capacity.DataBindings.Add(new Binding("DataContext", roomBindingSource1, "Capacity", true));
            textBox2Capacity.Location = new Point(393, 227);
            textBox2Capacity.Name = "textBox2Capacity";
            textBox2Capacity.Size = new Size(241, 23);
            textBox2Capacity.TabIndex = 36;
            // 
            // RoomClass
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.Control;
            ClientSize = new Size(992, 530);
            Controls.Add(textBox2Capacity);
            Controls.Add(label3Capacity);
            Controls.Add(labelPageNum);
            Controls.Add(btnNext);
            Controls.Add(btnPrevious);
            Controls.Add(label2);
            Controls.Add(comboBoxHotel);
            Controls.Add(IsAvaillable);
            Controls.Add(return_image);
            Controls.Add(textBox5_priceperNight);
            Controls.Add(textBox4_roomType);
            Controls.Add(textBox3_roomNumber);
            Controls.Add(textBox2_roomid);
            Controls.Add(Availlability);
            Controls.Add(PricePerNight);
            Controls.Add(Type);
            Controls.Add(RoomNumber);
            Controls.Add(roomid);
            Controls.Add(RoomsClass);
            Controls.Add(button1);
            Controls.Add(textBox1);
            Controls.Add(pictureBox2);
            Controls.Add(label1);
            Controls.Add(pictureBox1);
            Controls.Add(menuStrip1);
            FormBorderStyle = FormBorderStyle.None;
            MainMenuStrip = menuStrip1;
            Margin = new Padding(3, 2, 3, 2);
            Name = "RoomClass";
            Text = "RoomsClass";
            ((System.ComponentModel.ISupportInitialize)roomBindingSource).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ((System.ComponentModel.ISupportInitialize)RoomsClass).EndInit();
            ((System.ComponentModel.ISupportInitialize)roomBindingSource2).EndInit();
            ((System.ComponentModel.ISupportInitialize)roomBindingSource1).EndInit();
            ((System.ComponentModel.ISupportInitialize)hotelBindingSource).EndInit();
            menuStrip1.ResumeLayout(false);
            menuStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)return_image).EndInit();
            ((System.ComponentModel.ISupportInitialize)roomsBindingSource).EndInit();
            ResumeLayout(false);
            PerformLayout();


        }

        #endregion

        private Button button1;
        private TextBox textBox1;
        private PictureBox pictureBox2;
        private Label label1;
        private PictureBox pictureBox1;
        private DataGridViewTextBoxColumn fullNameDataGridViewTextBoxColumn;
        private BindingSource roomBindingSource;
        private DataGridView RoomsClass;
        private DataGridViewTextBoxColumn telephoneDataGridViewTextBoxColumn;
        private ToolTip toolTip1;
        private MenuStrip menuStrip1;
        private ToolStripMenuItem addToolStripMenuItem;
        private ToolStripMenuItem deleteToolStripMenuItem;
        private ToolStripMenuItem updateToolStripMenuItem;
        private ToolStripMenuItem viewToolStripMenuItem;
        private Label roomid;
        private Label RoomNumber;
        private Label Type;
        private Label PricePerNight;
        private Label Availlability;
        private TextBox textBox2_roomid;
        private TextBox textBox3_roomNumber;
        private TextBox textBox4_roomType;
        private TextBox textBox5_priceperNight;
        private PictureBox return_image;
        private CheckBox IsAvaillable;
        private BindingSource roomBindingSource1;
        private BindingSource hotelBindingSource;
        private ComboBox comboBoxHotel;
        private Label label2;
        private BindingSource roomsBindingSource;
        private Button btnPrevious;
        private Button btnNext;
        private BindingSource roomBindingSource2;
        private DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
        private DataGridViewTextBoxColumn dataGridViewTextBoxColumn3;
        private DataGridViewCheckBoxColumn IsAvailable;
        private DataGridViewTextBoxColumn Hotel;
        private Label labelPageNum;
        private Label label3Capacity;
        private TextBox textBox2Capacity;
    }
}