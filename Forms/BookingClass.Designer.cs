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
            label4 = new Label();
            label5 = new Label();
            label6 = new Label();
            label7 = new Label();
            label8 = new Label();
            label9 = new Label();
            DtReservationFrom = new DateTimePicker();
            DtReservationTo = new DateTimePicker();
            NudPersons = new NumericUpDown();
            BtnSearchRoom = new Button();
            dataGridView1 = new DataGridView();
            idDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            roomNumberDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            typeDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            HotelName = new DataGridViewTextBoxColumn();
            Column1 = new DataGridViewTextBoxColumn();
            roomBindingSource3 = new BindingSource(components);
            button2 = new Button();
            button3 = new Button();
            comboBox1 = new ComboBox();
            comboBox2 = new ComboBox();
            textBox2 = new TextBox();
            textBox3 = new TextBox();
            textBox4 = new TextBox();
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
            label2.Location = new Point(248, 67);
            label2.Name = "label2";
            label2.Size = new Size(87, 21);
            label2.TabIndex = 29;
            label2.Text = "Date from";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 161);
            label3.ForeColor = Color.FromArgb(0, 192, 192);
            label3.Location = new Point(608, 66);
            label3.Name = "label3";
            label3.Size = new Size(66, 21);
            label3.TabIndex = 30;
            label3.Text = "Date to";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 161);
            label4.ForeColor = Color.FromArgb(0, 192, 192);
            label4.Location = new Point(248, 140);
            label4.Name = "label4";
            label4.Size = new Size(76, 21);
            label4.TabIndex = 31;
            label4.Text = "Capacity";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 161);
            label5.ForeColor = Color.FromArgb(0, 192, 192);
            label5.Location = new Point(248, 338);
            label5.Name = "label5";
            label5.Size = new Size(83, 21);
            label5.TabIndex = 32;
            label5.Text = "Customer";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 161);
            label6.ForeColor = Color.FromArgb(0, 192, 192);
            label6.Location = new Point(248, 398);
            label6.Name = "label6";
            label6.Size = new Size(55, 21);
            label6.TabIndex = 33;
            label6.Text = "Room";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 161);
            label7.ForeColor = Color.FromArgb(0, 192, 192);
            label7.Location = new Point(248, 452);
            label7.Name = "label7";
            label7.Size = new Size(106, 21);
            label7.TabIndex = 34;
            label7.Text = "Cost per Day";
            label7.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Location = new Point(186, 33);
            label8.Name = "label8";
            label8.Size = new Size(38, 15);
            label8.TabIndex = 35;
            label8.Text = "label8";
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Font = new Font("Segoe UI", 15.75F, FontStyle.Bold, GraphicsUnit.Point, 161);
            label9.ForeColor = Color.OrangeRed;
            label9.Location = new Point(858, 464);
            label9.Name = "label9";
            label9.Size = new Size(110, 30);
            label9.TabIndex = 36;
            label9.Text = "Total Cost";
            // 
            // DtReservationFrom
            // 
            DtReservationFrom.CustomFormat = "dd/MM/yyyy";
            DtReservationFrom.Location = new Point(360, 62);
            DtReservationFrom.Name = "DtReservationFrom";
            DtReservationFrom.Size = new Size(211, 23);
            DtReservationFrom.TabIndex = 37;
            // 
            // DtReservationTo
            // 
            DtReservationTo.CustomFormat = "dd/MM/yyyy";
            DtReservationTo.Location = new Point(680, 62);
            DtReservationTo.Name = "DtReservationTo";
            DtReservationTo.Size = new Size(200, 23);
            DtReservationTo.TabIndex = 38;
            // 
            // NudPersons
            // 
            NudPersons.Location = new Point(360, 143);
            NudPersons.Name = "NudPersons";
            NudPersons.Size = new Size(61, 23);
            NudPersons.TabIndex = 39;
            // 
            // BtnSearchRoom
            // 
            BtnSearchRoom.Location = new Point(427, 143);
            BtnSearchRoom.Name = "BtnSearchRoom";
            BtnSearchRoom.Size = new Size(143, 23);
            BtnSearchRoom.TabIndex = 40;
            BtnSearchRoom.Text = "Search";
            BtnSearchRoom.UseVisualStyleBackColor = true;
            // 
            // dataGridView1
            // 
            dataGridView1.AllowUserToAddRows = false;
            dataGridView1.AllowUserToDeleteRows = false;
            dataGridView1.AutoGenerateColumns = false;
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Columns.AddRange(new DataGridViewColumn[] { idDataGridViewTextBoxColumn, roomNumberDataGridViewTextBoxColumn, typeDataGridViewTextBoxColumn, HotelName, Column1 });
            dataGridView1.DataSource = roomBindingSource3;
            dataGridView1.GridColor = SystemColors.InactiveCaption;
            dataGridView1.Location = new Point(360, 186);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.ReadOnly = true;
            dataGridView1.Size = new Size(520, 134);
            dataGridView1.TabIndex = 41;
            // 
            // idDataGridViewTextBoxColumn
            // 
            idDataGridViewTextBoxColumn.DataPropertyName = "Id";
            idDataGridViewTextBoxColumn.HeaderText = "Id";
            idDataGridViewTextBoxColumn.Name = "idDataGridViewTextBoxColumn";
            idDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // roomNumberDataGridViewTextBoxColumn
            // 
            roomNumberDataGridViewTextBoxColumn.DataPropertyName = "RoomNumber";
            roomNumberDataGridViewTextBoxColumn.HeaderText = "RoomNumber";
            roomNumberDataGridViewTextBoxColumn.Name = "roomNumberDataGridViewTextBoxColumn";
            roomNumberDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // typeDataGridViewTextBoxColumn
            // 
            typeDataGridViewTextBoxColumn.DataPropertyName = "Type";
            typeDataGridViewTextBoxColumn.HeaderText = "Type";
            typeDataGridViewTextBoxColumn.Name = "typeDataGridViewTextBoxColumn";
            typeDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // HotelName
            // 
            HotelName.DataPropertyName = "HotelName";
            HotelName.HeaderText = "HotelName";
            HotelName.Name = "HotelName";
            HotelName.ReadOnly = true;
            // 
            // Column1
            // 
            Column1.HeaderText = "Capacity";
            Column1.Name = "Column1";
            Column1.ReadOnly = true;
            // 
            // roomBindingSource3
            // 
            roomBindingSource3.DataSource = typeof(Models.Room);
            // 
            // button2
            // 
            button2.Location = new Point(805, 338);
            button2.Name = "button2";
            button2.Size = new Size(75, 23);
            button2.TabIndex = 42;
            button2.Text = "button2";
            button2.UseVisualStyleBackColor = true;
            // 
            // button3
            // 
            button3.Location = new Point(805, 367);
            button3.Name = "button3";
            button3.Size = new Size(75, 23);
            button3.TabIndex = 43;
            button3.Text = "button3";
            button3.UseVisualStyleBackColor = true;
            // 
            // comboBox1
            // 
            comboBox1.FormattingEnabled = true;
            comboBox1.Location = new Point(360, 338);
            comboBox1.Name = "comboBox1";
            comboBox1.Size = new Size(423, 23);
            comboBox1.TabIndex = 44;
            // 
            // comboBox2
            // 
            comboBox2.FormattingEnabled = true;
            comboBox2.Location = new Point(360, 396);
            comboBox2.Name = "comboBox2";
            comboBox2.Size = new Size(205, 23);
            comboBox2.TabIndex = 45;
            // 
            // textBox2
            // 
            textBox2.Location = new Point(360, 367);
            textBox2.Name = "textBox2";
            textBox2.Size = new Size(421, 23);
            textBox2.TabIndex = 46;
            // 
            // textBox3
            // 
            textBox3.Location = new Point(360, 450);
            textBox3.Name = "textBox3";
            textBox3.Size = new Size(205, 23);
            textBox3.TabIndex = 47;
            // 
            // textBox4
            // 
            textBox4.Location = new Point(805, 497);
            textBox4.Name = "textBox4";
            textBox4.Size = new Size(163, 23);
            textBox4.TabIndex = 48;
            // 
            // BookingClass
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.Control;
            ClientSize = new Size(992, 530);
            Controls.Add(textBox4);
            Controls.Add(textBox3);
            Controls.Add(textBox2);
            Controls.Add(comboBox2);
            Controls.Add(comboBox1);
            Controls.Add(button3);
            Controls.Add(button2);
            Controls.Add(dataGridView1);
            Controls.Add(BtnSearchRoom);
            Controls.Add(NudPersons);
            Controls.Add(DtReservationTo);
            Controls.Add(DtReservationFrom);
            Controls.Add(label9);
            Controls.Add(label8);
            Controls.Add(label7);
            Controls.Add(label6);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(return_image);
            Controls.Add(button1);
            Controls.Add(textBox1);
            Controls.Add(pictureBox2);
            Controls.Add(label1);
            Controls.Add(pictureBox1);
            FormBorderStyle = FormBorderStyle.None;
            Margin = new Padding(3, 2, 3, 2);
            Name = "BookingClass";
            Text = "RoomsClass";
            ((System.ComponentModel.ISupportInitialize)roomBindingSource).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ((System.ComponentModel.ISupportInitialize)roomBindingSource2).EndInit();
            ((System.ComponentModel.ISupportInitialize)roomBindingSource1).EndInit();
            ((System.ComponentModel.ISupportInitialize)hotelBindingSource).EndInit();
            ((System.ComponentModel.ISupportInitialize)return_image).EndInit();
            ((System.ComponentModel.ISupportInitialize)roomsBindingSource).EndInit();
            ((System.ComponentModel.ISupportInitialize)NudPersons).EndInit();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ((System.ComponentModel.ISupportInitialize)roomBindingSource3).EndInit();
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
        private Label label4;
        private Label label5;
        private Label label6;
        private Label label7;
        private Label label8;
        private Label label9;
        private DateTimePicker DtReservationFrom;
        private DateTimePicker DtReservationTo;
        private NumericUpDown NudPersons;
        private Button BtnSearchRoom;
        private DataGridView dataGridView1;
        private BindingSource roomBindingSource3;
        private DataGridViewTextBoxColumn idDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn roomNumberDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn typeDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn HotelName;
        private DataGridViewTextBoxColumn Column1;
        private Button button2;
        private Button button3;
        private ComboBox comboBox1;
        private ComboBox comboBox2;
        private TextBox textBox2;
        private TextBox textBox3;
        private TextBox textBox4;
    }
}