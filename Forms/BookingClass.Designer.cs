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
            roomid = new Label();
            RoomNumber = new Label();
            PricePerNight = new Label();
            textBox2_customerId = new TextBox();
            return_image = new PictureBox();
            roomsBindingSource = new BindingSource(components);
            label2 = new Label();
            checkBox1 = new CheckBox();
            label3 = new Label();
            comboBox1 = new ComboBox();
            comboBox2 = new ComboBox();
            dateTimePicker1 = new DateTimePicker();
            dateTimePicker2 = new DateTimePicker();
            label4 = new Label();
            textBox2 = new TextBox();
            dataGridView1 = new DataGridView();
            button2 = new Button();
            label5 = new Label();
            textBox3 = new TextBox();
            ((System.ComponentModel.ISupportInitialize)roomBindingSource).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)roomBindingSource2).BeginInit();
            ((System.ComponentModel.ISupportInitialize)roomBindingSource1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)hotelBindingSource).BeginInit();
            ((System.ComponentModel.ISupportInitialize)return_image).BeginInit();
            ((System.ComponentModel.ISupportInitialize)roomsBindingSource).BeginInit();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
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
            //button1.Click += button1_Click;
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
            // roomid
            // 
            roomid.AutoSize = true;
            roomid.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 161);
            roomid.Location = new Point(293, 33);
            roomid.Name = "roomid";
            roomid.Size = new Size(75, 15);
            roomid.TabIndex = 16;
            roomid.Text = "Customer Id";
            // 
            // RoomNumber
            // 
            RoomNumber.AutoSize = true;
            RoomNumber.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 161);
            RoomNumber.Location = new Point(293, 73);
            RoomNumber.Name = "RoomNumber";
            RoomNumber.Size = new Size(36, 15);
            RoomNumber.TabIndex = 17;
            RoomNumber.Text = "From";
            // 
            // PricePerNight
            // 
            PricePerNight.AutoSize = true;
            PricePerNight.DataBindings.Add(new Binding("Text", roomBindingSource1, "PricePerNight", true));
            PricePerNight.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 161);
            PricePerNight.Location = new Point(542, 73);
            PricePerNight.Name = "PricePerNight";
            PricePerNight.Size = new Size(20, 15);
            PricePerNight.TabIndex = 19;
            PricePerNight.Text = "To";
            // 
            // textBox2_customerId
            // 
            textBox2_customerId.DataBindings.Add(new Binding("DataContext", roomBindingSource1, "Id", true));
            textBox2_customerId.Location = new Point(371, 25);
            textBox2_customerId.Name = "textBox2_customerId";
            textBox2_customerId.Size = new Size(150, 23);
            textBox2_customerId.TabIndex = 22;
            toolTip1.SetToolTip(textBox2_customerId, "Fill the customer's id to make the reservation\r\n");
            //textBox2_customerId.TextChanged += this.textBox2_customerId_TextChanged;
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
            // 
            // roomsBindingSource
            // 
            roomsBindingSource.DataMember = "Rooms";
            roomsBindingSource.DataSource = hotelBindingSource;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 11.25F, FontStyle.Italic, GraphicsUnit.Point, 161);
            label2.Location = new Point(293, 150);
            label2.Name = "label2";
            label2.Size = new Size(68, 20);
            label2.TabIndex = 36;
            label2.Text = "Breakfast";
            // 
            // checkBox1
            // 
            checkBox1.AutoSize = true;
            checkBox1.Location = new Point(359, 155);
            checkBox1.Name = "checkBox1";
            checkBox1.Size = new Size(15, 14);
            checkBox1.TabIndex = 37;
            checkBox1.UseVisualStyleBackColor = true;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 161);
            label3.Location = new Point(502, 179);
            label3.Name = "label3";
            label3.Size = new Size(60, 25);
            label3.TabIndex = 38;
            label3.Text = "Room";
            //label3.Click += this.label3_Click;
            // 
            // comboBox1
            // 
            comboBox1.FormattingEnabled = true;
            comboBox1.Location = new Point(296, 207);
            comboBox1.Name = "comboBox1";
            comboBox1.Size = new Size(225, 23);
            comboBox1.TabIndex = 39;
            comboBox1.Text = "cmbRoomType";
            // 
            // comboBox2
            // 
            comboBox2.FormattingEnabled = true;
            comboBox2.Location = new Point(542, 207);
            comboBox2.Name = "comboBox2";
            comboBox2.Size = new Size(204, 23);
            comboBox2.TabIndex = 40;
            comboBox2.Text = "cmbAvaillableRooms";
            // 
            // dateTimePicker1
            // 
            dateTimePicker1.CalendarForeColor = Color.OrangeRed;
            dateTimePicker1.CalendarTitleForeColor = Color.OrangeRed;
            dateTimePicker1.Location = new Point(296, 107);
            dateTimePicker1.Name = "dateTimePicker1";
            dateTimePicker1.Size = new Size(225, 23);
            dateTimePicker1.TabIndex = 42;
            // 
            // dateTimePicker2
            // 
            dateTimePicker2.Location = new Point(546, 107);
            dateTimePicker2.Name = "dateTimePicker2";
            dateTimePicker2.Size = new Size(200, 23);
            dateTimePicker2.TabIndex = 43;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 161);
            label4.ForeColor = Color.OrangeRed;
            label4.Location = new Point(823, 458);
            label4.Name = "label4";
            label4.Size = new Size(94, 25);
            label4.TabIndex = 44;
            label4.Text = "Total Cost";
            label4.TextAlign = ContentAlignment.TopRight;
            // 
            // textBox2
            // 
            textBox2.Location = new Point(759, 486);
            textBox2.Name = "textBox2";
            textBox2.Size = new Size(158, 23);
            textBox2.TabIndex = 45;
            // 
            // dataGridView1
            // 
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Location = new Point(293, 281);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.Size = new Size(453, 111);
            dataGridView1.TabIndex = 46;
            // 
            // button2
            // 
            button2.Font = new Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 161);
            button2.ForeColor = Color.OrangeRed;
            button2.Location = new Point(652, 398);
            button2.Name = "button2";
            button2.Size = new Size(94, 37);
            button2.TabIndex = 47;
            button2.Text = "Select";
            button2.UseVisualStyleBackColor = true;
            //button2.Click += this.button2_Click_1;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 161);
            label5.Location = new Point(546, 33);
            label5.Name = "label5";
            label5.Size = new Size(88, 15);
            label5.TabIndex = 48;
            label5.Text = "Customer Afm";
            //label5.Click += this.label5_Click;
            // 
            // textBox3
            // 
            textBox3.DataBindings.Add(new Binding("DataContext", roomBindingSource1, "Id", true));
            textBox3.Location = new Point(637, 25);
            textBox3.Name = "textBox3";
            textBox3.Size = new Size(109, 23);
            textBox3.TabIndex = 49;
            toolTip1.SetToolTip(textBox3, "Fill the customer's id to make the reservation\r\n");
            // 
            // bookings
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.Control;
            ClientSize = new Size(992, 530);
            Controls.Add(textBox3);
            Controls.Add(label5);
            Controls.Add(button2);
            Controls.Add(dataGridView1);
            Controls.Add(textBox2);
            Controls.Add(label4);
            Controls.Add(dateTimePicker2);
            Controls.Add(dateTimePicker1);
            Controls.Add(comboBox2);
            Controls.Add(comboBox1);
            Controls.Add(label3);
            Controls.Add(checkBox1);
            Controls.Add(label2);
            Controls.Add(return_image);
            Controls.Add(textBox2_customerId);
            Controls.Add(PricePerNight);
            Controls.Add(RoomNumber);
            Controls.Add(roomid);
            Controls.Add(button1);
            Controls.Add(textBox1);
            Controls.Add(pictureBox2);
            Controls.Add(label1);
            Controls.Add(pictureBox1);
            FormBorderStyle = FormBorderStyle.None;
            Margin = new Padding(3, 2, 3, 2);
            Name = "bookings";
            Text = "RoomsClass";
            ((System.ComponentModel.ISupportInitialize)roomBindingSource).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ((System.ComponentModel.ISupportInitialize)roomBindingSource2).EndInit();
            ((System.ComponentModel.ISupportInitialize)roomBindingSource1).EndInit();
            ((System.ComponentModel.ISupportInitialize)hotelBindingSource).EndInit();
            ((System.ComponentModel.ISupportInitialize)return_image).EndInit();
            ((System.ComponentModel.ISupportInitialize)roomsBindingSource).EndInit();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
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
        private Label roomid;
        private Label RoomNumber;
        private Label PricePerNight;
        private TextBox textBox2_customerId;
        private PictureBox return_image;
        private BindingSource roomBindingSource1;
        private BindingSource hotelBindingSource;
        private BindingSource roomsBindingSource;
        private BindingSource roomBindingSource2;
        private Label label2;
        private CheckBox checkBox1;
        private Label label3;
        private ComboBox comboBox1;
        private ComboBox comboBox2;
        private DateTimePicker dateTimePicker1;
        private DateTimePicker dateTimePicker2;
        private Label label4;
        private TextBox textBox2;
        private DataGridView dataGridView1;
        private Button button2;
        private Label label5;
        private TextBox textBox3;
    }
}