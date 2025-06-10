namespace Hotel_Philoxenia
{
    partial class ToolsClass
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ToolsClass));
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
            comboBoxBookingId = new ComboBox();
            bookingBindingSource = new BindingSource(components);
            return_image = new PictureBox();
            roomsBindingSource = new BindingSource(components);
            ToolBookingId = new Label();
            button2 = new Button();
            dateTimePicker2_depart = new DateTimePicker();
            dateTimePicker_arrival = new DateTimePicker();
            label10 = new Label();
            label4 = new Label();
            textBox_TotalCost = new TextBox();
            textBox_CostPerDay = new TextBox();
            label9 = new Label();
            label7 = new Label();
            label2 = new Label();
            textBox_Discount = new TextBox();
            pictureBox3 = new PictureBox();
            button3_finalConfirmation = new Button();
            cancel_rsv_button = new Button();
            ((System.ComponentModel.ISupportInitialize)roomBindingSource).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)roomBindingSource2).BeginInit();
            ((System.ComponentModel.ISupportInitialize)roomBindingSource1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)hotelBindingSource).BeginInit();
            ((System.ComponentModel.ISupportInitialize)bookingBindingSource).BeginInit();
            ((System.ComponentModel.ISupportInitialize)return_image).BeginInit();
            ((System.ComponentModel.ISupportInitialize)roomsBindingSource).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox3).BeginInit();
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
            // hotelBindingSource
            // 
            //hotelBindingSource.DataSource = typeof(Models.Hotel);
            // 
            // comboBoxBookingId
            // 
            comboBoxBookingId.AllowDrop = true;
            comboBoxBookingId.DataBindings.Add(new Binding("SelectedValue", bookingBindingSource, "Id", true));
            comboBoxBookingId.DataBindings.Add(new Binding("DataContext", bookingBindingSource, "Id", true));
            comboBoxBookingId.DataBindings.Add(new Binding("SelectedItem", bookingBindingSource, "Id", true));
            comboBoxBookingId.FormattingEnabled = true;
            comboBoxBookingId.Location = new Point(535, 100);
            comboBoxBookingId.Margin = new Padding(3, 4, 3, 4);
            comboBoxBookingId.Name = "comboBoxBookingId";
            comboBoxBookingId.Size = new Size(498, 28);
            comboBoxBookingId.TabIndex = 30;
            toolTip1.SetToolTip(comboBoxBookingId, "Select the booking for the receipt");
            comboBoxBookingId.SelectedIndexChanged += comboBoxBookingId_SelectedIndexChanged;
            // 
            // bookingBindingSource
            // 
            bookingBindingSource.DataSource = typeof(Models.Booking);
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
            // ToolBookingId
            // 
            ToolBookingId.AutoSize = true;
            ToolBookingId.Font = new Font("Futura Hv BT", 9F, FontStyle.Regular, GraphicsUnit.Point, 161);
            ToolBookingId.Location = new Point(402, 110);
            ToolBookingId.Name = "ToolBookingId";
            ToolBookingId.Size = new Size(127, 18);
            ToolBookingId.TabIndex = 29;
            ToolBookingId.Text = "Find Reservation";
            // 
            // button2
            // 
            button2.BackColor = Color.OrangeRed;
            button2.Font = new Font("Alexandria", 15.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            button2.ForeColor = Color.Transparent;
            button2.Location = new Point(703, 576);
            button2.Margin = new Padding(3, 4, 3, 4);
            button2.Name = "button2";
            button2.Size = new Size(343, 108);
            button2.TabIndex = 31;
            button2.Text = "Export Invoice to PDF";
            button2.TextAlign = ContentAlignment.MiddleRight;
            button2.UseVisualStyleBackColor = false;
            button2.Click += button2_Click;
            // 
            // dateTimePicker2_depart
            // 
            dateTimePicker2_depart.CustomFormat = "dd/MM/yyyy";
            dateTimePicker2_depart.Location = new Point(533, 273);
            dateTimePicker2_depart.Margin = new Padding(3, 4, 3, 4);
            dateTimePicker2_depart.Name = "dateTimePicker2_depart";
            dateTimePicker2_depart.Size = new Size(204, 27);
            dateTimePicker2_depart.TabIndex = 65;
            dateTimePicker2_depart.ValueChanged += dateTimePicker2_depart_ValueChanged;
            // 
            // dateTimePicker_arrival
            // 
            dateTimePicker_arrival.CustomFormat = "dd/MM/yyyy";
            dateTimePicker_arrival.Location = new Point(533, 212);
            dateTimePicker_arrival.Margin = new Padding(3, 4, 3, 4);
            dateTimePicker_arrival.Name = "dateTimePicker_arrival";
            dateTimePicker_arrival.Size = new Size(204, 27);
            dateTimePicker_arrival.TabIndex = 64;
            dateTimePicker_arrival.ValueChanged += dateTimePicker_arrival_ValueChanged;
            // 
            // label10
            // 
            label10.AutoSize = true;
            label10.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 161);
            label10.ForeColor = Color.FromArgb(0, 192, 192);
            label10.Location = new Point(601, 243);
            label10.Name = "label10";
            label10.Size = new Size(78, 28);
            label10.TabIndex = 63;
            label10.Text = "Depart";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 161);
            label4.ForeColor = Color.FromArgb(0, 192, 192);
            label4.Location = new Point(603, 180);
            label4.Name = "label4";
            label4.Size = new Size(76, 28);
            label4.TabIndex = 62;
            label4.Text = "Arrival";
            // 
            // textBox_TotalCost
            // 
            textBox_TotalCost.Location = new Point(900, 494);
            textBox_TotalCost.Margin = new Padding(3, 4, 3, 4);
            textBox_TotalCost.Name = "textBox_TotalCost";
            textBox_TotalCost.ReadOnly = true;
            textBox_TotalCost.Size = new Size(133, 27);
            textBox_TotalCost.TabIndex = 61;
            // 
            // textBox_CostPerDay
            // 
            textBox_CostPerDay.DataBindings.Add(new Binding("DataContext", roomBindingSource2, "PricePerNight", true));
            textBox_CostPerDay.Location = new Point(937, 345);
            textBox_CostPerDay.Margin = new Padding(3, 4, 3, 4);
            textBox_CostPerDay.Name = "textBox_CostPerDay";
            textBox_CostPerDay.Size = new Size(96, 27);
            textBox_CostPerDay.TabIndex = 60;
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Font = new Font("Segoe UI", 15.75F, FontStyle.Bold, GraphicsUnit.Point, 161);
            label9.ForeColor = Color.OrangeRed;
            label9.Location = new Point(887, 453);
            label9.Name = "label9";
            label9.Size = new Size(146, 37);
            label9.TabIndex = 59;
            label9.Text = "Total Cost";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 161);
            label7.ForeColor = Color.FromArgb(0, 192, 192);
            label7.Location = new Point(900, 313);
            label7.Name = "label7";
            label7.Size = new Size(133, 28);
            label7.TabIndex = 58;
            label7.Text = "Cost per Day";
            label7.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 161);
            label2.ForeColor = Color.FromArgb(0, 192, 192);
            label2.Location = new Point(906, 376);
            label2.Name = "label2";
            label2.Size = new Size(127, 28);
            label2.TabIndex = 66;
            label2.Text = "Discount -%";
            label2.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // textBox_Discount
            // 
            textBox_Discount.DataBindings.Add(new Binding("DataContext", roomBindingSource2, "PricePerNight", true));
            textBox_Discount.Location = new Point(937, 408);
            textBox_Discount.Margin = new Padding(3, 4, 3, 4);
            textBox_Discount.Name = "textBox_Discount";
            textBox_Discount.Size = new Size(96, 27);
            textBox_Discount.TabIndex = 67;
            // 
            // pictureBox3
            // 
            pictureBox3.Image = Properties.Resources.customer_checkout;
            pictureBox3.Location = new Point(402, 212);
            pictureBox3.Name = "pictureBox3";
            pictureBox3.Size = new Size(106, 88);
            pictureBox3.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox3.TabIndex = 68;
            pictureBox3.TabStop = false;
            // 
            // button3_finalConfirmation
            // 
            button3_finalConfirmation.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 161);
            button3_finalConfirmation.ForeColor = Color.Green;
            button3_finalConfirmation.Location = new Point(900, 528);
            button3_finalConfirmation.Name = "button3_finalConfirmation";
            button3_finalConfirmation.Size = new Size(133, 43);
            button3_finalConfirmation.TabIndex = 69;
            button3_finalConfirmation.Text = "Confirm";
            button3_finalConfirmation.UseVisualStyleBackColor = true;
            button3_finalConfirmation.Click += button3_FinalConfirmation_Click;
            // 
            // cancel_rsv_button
            // 
            cancel_rsv_button.ForeColor = Color.Red;
            cancel_rsv_button.Location = new Point(558, 343);
            cancel_rsv_button.Name = "cancel_rsv_button";
            cancel_rsv_button.Size = new Size(133, 29);
            cancel_rsv_button.TabIndex = 70;
            cancel_rsv_button.Text = "Cancel Booking";
            cancel_rsv_button.UseVisualStyleBackColor = true;
            cancel_rsv_button.Click += cancel_rsv_button_Click;
            // 
            // ToolsClass
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.Control;
            ClientSize = new Size(1134, 707);
            Controls.Add(cancel_rsv_button);
            Controls.Add(button3_finalConfirmation);
            Controls.Add(pictureBox3);
            Controls.Add(textBox_Discount);
            Controls.Add(label2);
            Controls.Add(dateTimePicker2_depart);
            Controls.Add(dateTimePicker_arrival);
            Controls.Add(label10);
            Controls.Add(label4);
            Controls.Add(textBox_TotalCost);
            Controls.Add(textBox_CostPerDay);
            Controls.Add(label9);
            Controls.Add(label7);
            Controls.Add(button2);
            Controls.Add(comboBoxBookingId);
            Controls.Add(ToolBookingId);
            Controls.Add(return_image);
            Controls.Add(button1);
            Controls.Add(textBox1);
            Controls.Add(pictureBox2);
            Controls.Add(label1);
            Controls.Add(pictureBox1);
            FormBorderStyle = FormBorderStyle.None;
            Name = "ToolsClass";
            Text = "RoomsClass";
            ((System.ComponentModel.ISupportInitialize)roomBindingSource).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ((System.ComponentModel.ISupportInitialize)roomBindingSource2).EndInit();
            ((System.ComponentModel.ISupportInitialize)roomBindingSource1).EndInit();
            ((System.ComponentModel.ISupportInitialize)hotelBindingSource).EndInit();
            ((System.ComponentModel.ISupportInitialize)bookingBindingSource).EndInit();
            ((System.ComponentModel.ISupportInitialize)return_image).EndInit();
            //((System.ComponentModel.ISupportInitialize)roomsBindingSource).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox3).EndInit();
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
        private Label ToolBookingId;
        private ComboBox comboBoxBookingId;
        private BindingSource bookingBindingSource;
        private Button button2;
        private DateTimePicker dateTimePicker2_depart;
        private DateTimePicker dateTimePicker_arrival;
        private Label label10;
        private Label label4;
        private TextBox textBox_TotalCost;
        private TextBox textBox_CostPerDay;
        private Label label9;
        private Label label7;
        private Label label2;
        private TextBox textBox_Discount;
        private PictureBox pictureBox3;
        private Button button3_finalConfirmation;
        private Button cancel_rsv_button;
    }
}