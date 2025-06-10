namespace Hotel_Philoxenia.Forms
{
    partial class BookingClass
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(BookingClass));
            roomBindingSource = new BindingSource(components);
            button1 = new Button();
            textBox1 = new TextBox();
            pictureBox2 = new PictureBox();
            label1 = new Label();
            pictureBox1 = new PictureBox();
            roomBindingSource2 = new BindingSource(components);
            roomBindingSource1 = new BindingSource(components);
            hotelBindingSource = new BindingSource(components);
            toolTip1 = new ToolTip(components);
            return_image = new PictureBox();
            roomsBindingSource = new BindingSource(components);
            label2 = new Label();
            label3 = new Label();
            label4Capacity = new Label();
            label5 = new Label();
            label6 = new Label();
            label8 = new Label();
            DtReservationFrom = new DateTimePicker();
            DtReservationTo = new DateTimePicker();
            NudPersons = new NumericUpDown();
            dataGridView1 = new DataGridView();
            roomBindingSource3 = new BindingSource(components);
            button2 = new Button();
            button3 = new Button();
            comboBox1 = new ComboBox();
            comboBox2 = new ComboBox();
            roomBindingSource4 = new BindingSource(components);
            button4CreateReservation = new Button();
            button4Search = new Button();
            textBox2 = new TextBox();
            roomNumberDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            typeDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            pricePerNightDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            Capacity = new DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)roomBindingSource).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)roomBindingSource2).BeginInit();
            ((System.ComponentModel.ISupportInitialize)roomBindingSource1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)hotelBindingSource).BeginInit();
            ((System.ComponentModel.ISupportInitialize)return_image).BeginInit();
            ((System.ComponentModel.ISupportInitialize)roomsBindingSource).BeginInit();
            ((System.ComponentModel.ISupportInitialize)NudPersons).BeginInit();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)roomBindingSource3).BeginInit();
            ((System.ComponentModel.ISupportInitialize)roomBindingSource4).BeginInit();
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
            button1.Location = new Point(69, 453);
            button1.Name = "button1";
            button1.Size = new Size(114, 69);
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
            textBox1.Location = new Point(0, 611);
            textBox1.Multiline = true;
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(247, 83);
            textBox1.TabIndex = 11;
            textBox1.Text = " Rue Philoxenia, Athens\r\n11257\r\nemail: philoxenia@yahoo.gr\r\ntel.: 210-2233456\r\n";
            textBox1.TextAlign = HorizontalAlignment.Center;
            // 
            // pictureBox2
            // 
            pictureBox2.Image = (Image)resources.GetObject("pictureBox2.Image");
            pictureBox2.Location = new Point(0, 3);
            pictureBox2.Name = "pictureBox2";
            pictureBox2.Size = new Size(256, 61);
            pictureBox2.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox2.TabIndex = 9;
            pictureBox2.TabStop = false;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Cambria", 16.2F, FontStyle.Bold, GraphicsUnit.Point, 161);
            label1.ForeColor = Color.OrangeRed;
            label1.Location = new Point(15, 83);
            label1.Name = "label1";
            label1.Size = new Size(229, 33);
            label1.TabIndex = 10;
            label1.Text = "Hotel Philoxenia";
            label1.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // pictureBox1
            // 
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(-3, 132);
            pictureBox1.Margin = new Padding(0);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(262, 257);
            pictureBox1.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox1.TabIndex = 8;
            pictureBox1.TabStop = false;
            // 
            // roomBindingSource2
            // 
            roomBindingSource2.DataSource = typeof(Models.Room);
            // 
            // roomBindingSource1
            // 
            roomBindingSource1.DataSource = typeof(Models.Room);
            // 
            // return_image
            // 
            return_image.Image = (Image)resources.GetObject("return_image.Image");
            return_image.Location = new Point(1030, 3);
            return_image.Margin = new Padding(3, 4, 3, 4);
            return_image.Name = "return_image";
            return_image.Size = new Size(16, 16);
            return_image.SizeMode = PictureBoxSizeMode.AutoSize;
            return_image.TabIndex = 28;
            return_image.TabStop = false;
            return_image.Click += ReturnToAdminForm_Click;
            // 
            // roomsBindingSource
            // 
            roomsBindingSource.DataMember = "Rooms";
            roomsBindingSource.DataSource = hotelBindingSource;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 161);
            label2.ForeColor = Color.FromArgb(0, 192, 192);
            label2.Location = new Point(272, 86);
            label2.Name = "label2";
            label2.Size = new Size(109, 28);
            label2.TabIndex = 29;
            label2.Text = "Date from";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 161);
            label3.ForeColor = Color.FromArgb(0, 192, 192);
            label3.Location = new Point(692, 86);
            label3.Name = "label3";
            label3.Size = new Size(83, 28);
            label3.TabIndex = 30;
            label3.Text = "Date to";
            // 
            // label4Capacity
            // 
            label4Capacity.AutoSize = true;
            label4Capacity.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 161);
            label4Capacity.ForeColor = Color.FromArgb(0, 192, 192);
            label4Capacity.Location = new Point(272, 132);
            label4Capacity.Name = "label4Capacity";
            label4Capacity.Size = new Size(93, 28);
            label4Capacity.TabIndex = 31;
            label4Capacity.Text = "Capacity";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 161);
            label5.ForeColor = Color.FromArgb(0, 192, 192);
            label5.Location = new Point(272, 395);
            label5.Name = "label5";
            label5.Size = new Size(102, 28);
            label5.TabIndex = 32;
            label5.Text = "Customer";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 161);
            label6.ForeColor = Color.FromArgb(0, 192, 192);
            label6.Location = new Point(272, 470);
            label6.Name = "label6";
            label6.Size = new Size(67, 28);
            label6.TabIndex = 33;
            label6.Text = "Room";
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Location = new Point(213, 44);
            label8.Name = "label8";
            label8.Size = new Size(50, 20);
            label8.TabIndex = 35;
            label8.Text = "label8";
            // 
            // DtReservationFrom
            // 
            DtReservationFrom.CalendarForeColor = Color.Cyan;
            DtReservationFrom.CustomFormat = "dd/MM/yyyy";
            DtReservationFrom.Location = new Point(411, 89);
            DtReservationFrom.Margin = new Padding(3, 4, 3, 4);
            DtReservationFrom.MinDate = new DateTime(2025, 6, 1, 0, 0, 0, 0);
            DtReservationFrom.Name = "DtReservationFrom";
            DtReservationFrom.Size = new Size(204, 27);
            DtReservationFrom.TabIndex = 37;
            DtReservationFrom.Value = new DateTime(2025, 6, 1, 15, 21, 55, 0);
            DtReservationFrom.ValueChanged += DtReservationFrom_ValueChanged;
            // 
            // DtReservationTo
            // 
            DtReservationTo.CustomFormat = "dd/MM/yyyy";
            DtReservationTo.Location = new Point(802, 89);
            DtReservationTo.Margin = new Padding(3, 4, 3, 4);
            DtReservationTo.Name = "DtReservationTo";
            DtReservationTo.Size = new Size(204, 27);
            DtReservationTo.TabIndex = 38;
            // 
            // NudPersons
            // 
            NudPersons.Location = new Point(411, 137);
            NudPersons.Margin = new Padding(3, 4, 3, 4);
            NudPersons.Name = "NudPersons";
            NudPersons.Size = new Size(70, 27);
            NudPersons.TabIndex = 39;
            NudPersons.ValueChanged += NudPersons_ValueChanged;
            // 
            // dataGridView1
            // 
            dataGridView1.AllowUserToAddRows = false;
            dataGridView1.AllowUserToDeleteRows = false;
            dataGridView1.AutoGenerateColumns = false;
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Columns.AddRange(new DataGridViewColumn[] { roomNumberDataGridViewTextBoxColumn, typeDataGridViewTextBoxColumn, pricePerNightDataGridViewTextBoxColumn, Capacity });
            dataGridView1.DataSource = roomBindingSource2;
            dataGridView1.GridColor = SystemColors.InactiveCaption;
            dataGridView1.Location = new Point(411, 193);
            dataGridView1.Margin = new Padding(3, 4, 3, 4);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.ReadOnly = true;
            dataGridView1.RowHeadersWidth = 51;
            dataGridView1.Size = new Size(594, 179);
            dataGridView1.TabIndex = 41;
            // 
            // roomBindingSource3
            // 
            roomBindingSource3.DataSource = typeof(Models.Room);
            // 
            // button2
            // 
            button2.Location = new Point(919, 392);
            button2.Margin = new Padding(3, 4, 3, 4);
            button2.Name = "button2";
            button2.Size = new Size(86, 31);
            button2.TabIndex = 42;
            button2.Text = "Select";
            button2.UseVisualStyleBackColor = true;
            // 
            // button3
            // 
            button3.Location = new Point(920, 431);
            button3.Margin = new Padding(3, 4, 3, 4);
            button3.Name = "button3";
            button3.Size = new Size(86, 31);
            button3.TabIndex = 43;
            button3.Text = "Add New";
            button3.UseVisualStyleBackColor = true;
            button3.Click += button3_Click;
            // 
            // comboBox1
            // 
            comboBox1.FormattingEnabled = true;
            comboBox1.Location = new Point(411, 395);
            comboBox1.Margin = new Padding(3, 4, 3, 4);
            comboBox1.Name = "comboBox1";
            comboBox1.Size = new Size(483, 28);
            comboBox1.TabIndex = 44;
            // 
            // comboBox2
            // 
            comboBox2.DataSource = roomBindingSource2;
            comboBox2.DisplayMember = "RoomNumber";
            comboBox2.FormattingEnabled = true;
            comboBox2.Location = new Point(411, 466);
            comboBox2.Margin = new Padding(3, 4, 3, 4);
            comboBox2.Name = "comboBox2";
            comboBox2.Size = new Size(234, 28);
            comboBox2.TabIndex = 45;
            comboBox2.ValueMember = "Id";
            // 
            // roomBindingSource4
            // 
            roomBindingSource4.DataSource = typeof(Models.Room);
            // 
            // button4CreateReservation
            // 
            button4CreateReservation.BackColor = Color.LightGray;
            button4CreateReservation.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 161);
            button4CreateReservation.ForeColor = Color.DarkOrchid;
            button4CreateReservation.Location = new Point(772, 611);
            button4CreateReservation.Margin = new Padding(3, 4, 3, 4);
            button4CreateReservation.Name = "button4CreateReservation";
            button4CreateReservation.Size = new Size(234, 49);
            button4CreateReservation.TabIndex = 49;
            button4CreateReservation.Text = "Create Reservation";
            button4CreateReservation.UseVisualStyleBackColor = false;
            button4CreateReservation.Click += button4CreateReservation_Click;
            // 
            // button4Search
            // 
            button4Search.BackColor = Color.FromArgb(192, 255, 255);
            button4Search.Font = new Font("Segoe UI", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 161);
            button4Search.ForeColor = SystemColors.InfoText;
            button4Search.Location = new Point(891, 155);
            button4Search.Name = "button4Search";
            button4Search.Size = new Size(115, 31);
            button4Search.TabIndex = 50;
            button4Search.Text = "Search availability";
            button4Search.UseVisualStyleBackColor = false;
            button4Search.Click += Button4Search_Click;
            // 
            // textBox2
            // 
            textBox2.Location = new Point(413, 434);
            textBox2.Name = "textBox2";
            textBox2.Size = new Size(481, 27);
            textBox2.TabIndex = 51;
            // 
            // roomNumberDataGridViewTextBoxColumn
            // 
            roomNumberDataGridViewTextBoxColumn.DataPropertyName = "RoomNumber";
            roomNumberDataGridViewTextBoxColumn.HeaderText = "RoomNumber";
            roomNumberDataGridViewTextBoxColumn.MinimumWidth = 6;
            roomNumberDataGridViewTextBoxColumn.Name = "roomNumberDataGridViewTextBoxColumn";
            roomNumberDataGridViewTextBoxColumn.ReadOnly = true;
            roomNumberDataGridViewTextBoxColumn.Width = 125;
            // 
            // typeDataGridViewTextBoxColumn
            // 
            typeDataGridViewTextBoxColumn.DataPropertyName = "Type";
            typeDataGridViewTextBoxColumn.HeaderText = "Type";
            typeDataGridViewTextBoxColumn.MinimumWidth = 6;
            typeDataGridViewTextBoxColumn.Name = "typeDataGridViewTextBoxColumn";
            typeDataGridViewTextBoxColumn.ReadOnly = true;
            typeDataGridViewTextBoxColumn.Width = 125;
            // 
            // pricePerNightDataGridViewTextBoxColumn
            // 
            pricePerNightDataGridViewTextBoxColumn.DataPropertyName = "PricePerNight";
            pricePerNightDataGridViewTextBoxColumn.HeaderText = "PricePerNight";
            pricePerNightDataGridViewTextBoxColumn.MinimumWidth = 6;
            pricePerNightDataGridViewTextBoxColumn.Name = "pricePerNightDataGridViewTextBoxColumn";
            pricePerNightDataGridViewTextBoxColumn.ReadOnly = true;
            pricePerNightDataGridViewTextBoxColumn.Width = 125;
            // 
            // Capacity
            // 
            Capacity.DataPropertyName = "Capacity";
            Capacity.HeaderText = "Capacity";
            Capacity.MinimumWidth = 6;
            Capacity.Name = "Capacity";
            Capacity.ReadOnly = true;
            Capacity.Width = 125;
            // 
            // BookingClass
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.Control;
            ClientSize = new Size(1134, 707);
            Controls.Add(textBox2);
            Controls.Add(button4Search);
            Controls.Add(button4CreateReservation);
            Controls.Add(comboBox2);
            Controls.Add(comboBox1);
            Controls.Add(button3);
            Controls.Add(button2);
            Controls.Add(dataGridView1);
            Controls.Add(NudPersons);
            Controls.Add(DtReservationTo);
            Controls.Add(DtReservationFrom);
            Controls.Add(label8);
            Controls.Add(label6);
            Controls.Add(label5);
            Controls.Add(label4Capacity);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(return_image);
            Controls.Add(button1);
            Controls.Add(textBox1);
            Controls.Add(pictureBox2);
            Controls.Add(label1);
            Controls.Add(pictureBox1);
            FormBorderStyle = FormBorderStyle.None;
            Name = "BookingClass";
            Text = "RoomsClass";
            ((System.ComponentModel.ISupportInitialize)roomBindingSource).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ((System.ComponentModel.ISupportInitialize)roomBindingSource2).EndInit();
            ((System.ComponentModel.ISupportInitialize)roomBindingSource1).EndInit();
            ((System.ComponentModel.ISupportInitialize)hotelBindingSource).EndInit();
            ((System.ComponentModel.ISupportInitialize)return_image).EndInit();
            //((System.ComponentModel.ISupportInitialize)roomsBindingSource).EndInit();
            ((System.ComponentModel.ISupportInitialize)NudPersons).EndInit();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ((System.ComponentModel.ISupportInitialize)roomBindingSource3).EndInit();
            ((System.ComponentModel.ISupportInitialize)roomBindingSource4).EndInit();
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
        private DataGridViewTextBoxColumn telephoneDataGridViewTextBoxColumn;
        private ToolTip toolTip1;
        private PictureBox return_image;
        private BindingSource roomBindingSource1;
        private BindingSource hotelBindingSource;
        private BindingSource roomsBindingSource;
        private BindingSource roomBindingSource2;
        private Label label2;
        private Label label3;
        private Label label4Capacity;
        private Label label5;
        private Label label6;
        private Label label8;
        private DateTimePicker DtReservationFrom;
        private DateTimePicker DtReservationTo;
        private NumericUpDown NudPersons;
        private DataGridView dataGridView1;
        private BindingSource roomBindingSource3;
        private Button button2;
        private Button button3;
        private ComboBox comboBox1;
        private ComboBox comboBox2;
        private DataGridViewCheckBoxColumn isAvailableDataGridViewCheckBoxColumn;
        private BindingSource roomBindingSource4;
        private Button button4CreateReservation;
        private Button button4Search;
        private TextBox textBox2;
        private DataGridViewTextBoxColumn roomNumberDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn typeDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn pricePerNightDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn Capacity;
    }
}