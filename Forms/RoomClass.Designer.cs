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
            DataGridViewCellStyle dataGridViewCellStyle1 = new DataGridViewCellStyle();
            roomBindingSource = new BindingSource(components);
            button1 = new Button();
            textBox1 = new TextBox();
            pictureBox2 = new PictureBox();
            label1 = new Label();
            pictureBox1 = new PictureBox();
            RoomsClass = new DataGridView();
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
            textBox2_roomid = new TextBox();
            textBox3_roomNumber = new TextBox();
            textBox5_priceperNight = new TextBox();
            return_image = new PictureBox();
            roomsBindingSource = new BindingSource(components);
            btnPrevious = new Button();
            btnNext = new Button();
            labelPageNum = new Label();
            label3Capacity = new Label();
            textBox2Capacity = new TextBox();
            dataGridViewTextBoxColumn1 = new DataGridViewTextBoxColumn();
            dataGridViewTextBoxColumn2 = new DataGridViewTextBoxColumn();
            dataGridViewTextBoxColumn3 = new DataGridViewTextBoxColumn();
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
            // RoomsClass
            // 
            RoomsClass.AllowUserToAddRows = false;
            RoomsClass.AllowUserToDeleteRows = false;
            RoomsClass.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            RoomsClass.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            RoomsClass.Columns.AddRange(new DataGridViewColumn[] { dataGridViewTextBoxColumn1, dataGridViewTextBoxColumn2, dataGridViewTextBoxColumn3 });
            RoomsClass.GridColor = Color.FromArgb(255, 128, 0);
            RoomsClass.Location = new Point(335, 387);
            RoomsClass.Name = "RoomsClass";
            RoomsClass.ReadOnly = true;
            RoomsClass.RowHeadersWidth = 51;
            RoomsClass.Size = new Size(744, 203);
            RoomsClass.TabIndex = 13;
            // 
            // roomBindingSource2
            // 
            roomBindingSource2.DataSource = typeof(Models.Room);
            // 
            // roomBindingSource1
            // 
            roomBindingSource1.DataSource = typeof(Models.Room);
            // 
            // textBox4_roomType
            // 
            textBox4_roomType.DataBindings.Add(new Binding("DataContext", roomBindingSource1, "Type", true));
            textBox4_roomType.Location = new Point(449, 171);
            textBox4_roomType.Margin = new Padding(3, 4, 3, 4);
            textBox4_roomType.Name = "textBox4_roomType";
            textBox4_roomType.PlaceholderText = "Single, Double or Suite";
            textBox4_roomType.Size = new Size(275, 27);
            textBox4_roomType.TabIndex = 24;
            toolTip1.SetToolTip(textBox4_roomType, "Single, Double or Suite\r\n");
            // 
            // menuStrip1
            // 
            menuStrip1.Dock = DockStyle.None;
            menuStrip1.Font = new Font("Cambria", 12F, FontStyle.Bold);
            menuStrip1.GripStyle = ToolStripGripStyle.Visible;
            menuStrip1.ImageScalingSize = new Size(20, 20);
            menuStrip1.Items.AddRange(new ToolStripItem[] { addToolStripMenuItem, deleteToolStripMenuItem, updateToolStripMenuItem, viewToolStripMenuItem });
            menuStrip1.Location = new Point(757, 28);
            menuStrip1.Name = "menuStrip1";
            menuStrip1.Padding = new Padding(3, 3, 0, 3);
            menuStrip1.Size = new Size(319, 33);
            menuStrip1.TabIndex = 15;
            menuStrip1.Text = "menuStrip1";
            // 
            // addToolStripMenuItem
            // 
            addToolStripMenuItem.ForeColor = Color.OrangeRed;
            addToolStripMenuItem.Name = "addToolStripMenuItem";
            addToolStripMenuItem.Size = new Size(61, 27);
            addToolStripMenuItem.Text = "Add";
            // 
            // deleteToolStripMenuItem
            // 
            deleteToolStripMenuItem.ForeColor = Color.OrangeRed;
            deleteToolStripMenuItem.Name = "deleteToolStripMenuItem";
            deleteToolStripMenuItem.Size = new Size(84, 27);
            deleteToolStripMenuItem.Text = "Delete";
            // 
            // updateToolStripMenuItem
            // 
            updateToolStripMenuItem.ForeColor = Color.OrangeRed;
            updateToolStripMenuItem.Name = "updateToolStripMenuItem";
            updateToolStripMenuItem.Size = new Size(91, 27);
            updateToolStripMenuItem.Text = "Update";
            // 
            // viewToolStripMenuItem
            // 
            viewToolStripMenuItem.ForeColor = Color.OrangeRed;
            viewToolStripMenuItem.Name = "viewToolStripMenuItem";
            viewToolStripMenuItem.Size = new Size(70, 27);
            viewToolStripMenuItem.Text = "View";
            // 
            // roomid
            // 
            roomid.AutoSize = true;
            roomid.Location = new Point(335, 91);
            roomid.Name = "roomid";
            roomid.Size = new Size(66, 20);
            roomid.TabIndex = 16;
            roomid.Text = "Room Id";
            // 
            // RoomNumber
            // 
            RoomNumber.AutoSize = true;
            RoomNumber.Location = new Point(335, 132);
            RoomNumber.Name = "RoomNumber";
            RoomNumber.Size = new Size(104, 20);
            RoomNumber.TabIndex = 17;
            RoomNumber.Text = "Room number";
            // 
            // Type
            // 
            Type.AutoSize = true;
            Type.Location = new Point(335, 175);
            Type.Name = "Type";
            Type.Size = new Size(40, 20);
            Type.TabIndex = 18;
            Type.Text = "Type";
            // 
            // PricePerNight
            // 
            PricePerNight.AutoSize = true;
            PricePerNight.DataBindings.Add(new Binding("Text", roomBindingSource1, "PricePerNight", true));
            PricePerNight.Location = new Point(335, 219);
            PricePerNight.Name = "PricePerNight";
            PricePerNight.Size = new Size(108, 20);
            PricePerNight.TabIndex = 19;
            PricePerNight.Text = "Price per Night";
            // 
            // textBox2_roomid
            // 
            textBox2_roomid.DataBindings.Add(new Binding("DataContext", roomBindingSource1, "Id", true));
            textBox2_roomid.Location = new Point(449, 92);
            textBox2_roomid.Margin = new Padding(3, 4, 3, 4);
            textBox2_roomid.Name = "textBox2_roomid";
            textBox2_roomid.ReadOnly = true;
            textBox2_roomid.Size = new Size(275, 27);
            textBox2_roomid.TabIndex = 22;
            // 
            // textBox3_roomNumber
            // 
            textBox3_roomNumber.DataBindings.Add(new Binding("DataContext", roomBindingSource1, "RoomNumber", true));
            textBox3_roomNumber.Location = new Point(449, 132);
            textBox3_roomNumber.Margin = new Padding(3, 4, 3, 4);
            textBox3_roomNumber.Name = "textBox3_roomNumber";
            textBox3_roomNumber.Size = new Size(275, 27);
            textBox3_roomNumber.TabIndex = 23;
            // 
            // textBox5_priceperNight
            // 
            textBox5_priceperNight.DataBindings.Add(new Binding("DataContext", roomBindingSource1, "PricePerNight", true));
            textBox5_priceperNight.Location = new Point(449, 215);
            textBox5_priceperNight.Margin = new Padding(3, 4, 3, 4);
            textBox5_priceperNight.Name = "textBox5_priceperNight";
            textBox5_priceperNight.Size = new Size(275, 27);
            textBox5_priceperNight.TabIndex = 25;
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
            // btnPrevious
            // 
            btnPrevious.BackColor = Color.Transparent;
            btnPrevious.ForeColor = Color.OrangeRed;
            btnPrevious.Location = new Point(901, 611);
            btnPrevious.Margin = new Padding(3, 4, 3, 4);
            btnPrevious.Name = "btnPrevious";
            btnPrevious.Size = new Size(86, 31);
            btnPrevious.TabIndex = 32;
            btnPrevious.Text = "previous";
            btnPrevious.UseVisualStyleBackColor = false;
            btnPrevious.Click += btnPrevious_Click;
            // 
            // btnNext
            // 
            btnNext.BackColor = Color.Transparent;
            btnNext.ForeColor = Color.OrangeRed;
            btnNext.Location = new Point(993, 611);
            btnNext.Margin = new Padding(3, 4, 3, 4);
            btnNext.Name = "btnNext";
            btnNext.Size = new Size(86, 31);
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
            labelPageNum.Location = new Point(997, 671);
            labelPageNum.Name = "labelPageNum";
            labelPageNum.Size = new Size(95, 25);
            labelPageNum.TabIndex = 34;
            labelPageNum.Text = "Page 1 of 1";
            labelPageNum.TextAlign = ContentAlignment.TopCenter;
            // 
            // label3Capacity
            // 
            label3Capacity.AutoSize = true;
            label3Capacity.DataBindings.Add(new Binding("Text", roomBindingSource1, "Capacity", true));
            label3Capacity.Location = new Point(335, 259);
            label3Capacity.Name = "label3Capacity";
            label3Capacity.Size = new Size(66, 20);
            label3Capacity.TabIndex = 35;
            label3Capacity.Text = "Capacity";
            // 
            // textBox2Capacity
            // 
            textBox2Capacity.DataBindings.Add(new Binding("DataContext", roomBindingSource1, "Capacity", true));
            textBox2Capacity.Location = new Point(449, 256);
            textBox2Capacity.Margin = new Padding(3, 4, 3, 4);
            textBox2Capacity.Name = "textBox2Capacity";
            textBox2Capacity.Size = new Size(275, 27);
            textBox2Capacity.TabIndex = 36;
            // 
            // dataGridViewTextBoxColumn1
            // 
            dataGridViewTextBoxColumn1.DataPropertyName = "RoomNumber";
            dataGridViewTextBoxColumn1.HeaderText = "RoomNumber";
            dataGridViewTextBoxColumn1.MinimumWidth = 6;
            dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
            dataGridViewTextBoxColumn1.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn2
            // 
            dataGridViewTextBoxColumn2.DataPropertyName = "Type";
            dataGridViewTextBoxColumn2.HeaderText = "Type";
            dataGridViewTextBoxColumn2.MinimumWidth = 6;
            dataGridViewTextBoxColumn2.Name = "dataGridViewTextBoxColumn2";
            dataGridViewTextBoxColumn2.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn3
            // 
            dataGridViewTextBoxColumn3.DataPropertyName = "PricePerNight";
            dataGridViewCellStyle1.Format = "C2";
            dataGridViewCellStyle1.NullValue = "C2";
            dataGridViewTextBoxColumn3.DefaultCellStyle = dataGridViewCellStyle1;
            dataGridViewTextBoxColumn3.HeaderText = "PricePerNight";
            dataGridViewTextBoxColumn3.MinimumWidth = 6;
            dataGridViewTextBoxColumn3.Name = "dataGridViewTextBoxColumn3";
            dataGridViewTextBoxColumn3.ReadOnly = true;
            // 
            // RoomClass
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.Control;
            ClientSize = new Size(1134, 707);
            Controls.Add(textBox2Capacity);
            Controls.Add(label3Capacity);
            Controls.Add(labelPageNum);
            Controls.Add(btnNext);
            Controls.Add(btnPrevious);
            Controls.Add(return_image);
            Controls.Add(textBox5_priceperNight);
            Controls.Add(textBox4_roomType);
            Controls.Add(textBox3_roomNumber);
            Controls.Add(textBox2_roomid);
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
            //((System.ComponentModel.ISupportInitialize)roomsBindingSource).EndInit();
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
        private TextBox textBox2_roomid;
        private TextBox textBox3_roomNumber;
        private TextBox textBox4_roomType;
        private TextBox textBox5_priceperNight;
        private PictureBox return_image;
        private BindingSource roomBindingSource1;
        private BindingSource hotelBindingSource;
        private BindingSource roomsBindingSource;
        private Button btnPrevious;
        private Button btnNext;
        private BindingSource roomBindingSource2;
        private Label labelPageNum;
        private Label label3Capacity;
        private TextBox textBox2Capacity;
        private DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
        private DataGridViewTextBoxColumn dataGridViewTextBoxColumn3;
    }
}