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
            button1 = new Button();
            textBox1 = new TextBox();
            pictureBox2 = new PictureBox();
            label1 = new Label();
            pictureBox1 = new PictureBox();
            customerBindingSource = new BindingSource(components);
            dataGridView1 = new DataGridView();
            idDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            toolTip1 = new ToolTip(components);
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
            label7 = new Label();
            textBox2_roomid = new TextBox();
            textBox3_roomNumber = new TextBox();
            textBox4_roomType = new TextBox();
            textBox5_priceperNight = new TextBox();
            textBox7 = new TextBox();
            return_image = new PictureBox();
            roomBindingSource = new BindingSource(components);
            IsAvaillabel = new CheckBox();
            IsAvailable = new DataGridViewCheckBoxColumn();
            HotelId = new DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)customerBindingSource).BeginInit();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            menuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)return_image).BeginInit();
            ((System.ComponentModel.ISupportInitialize)roomBindingSource).BeginInit();
            SuspendLayout();
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
            // customerBindingSource
            // 
            customerBindingSource.DataSource = typeof(Models.Customer);
            // 
            // dataGridView1
            // 
            dataGridView1.AutoGenerateColumns = false;
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Columns.AddRange(new DataGridViewColumn[] { idDataGridViewTextBoxColumn, IsAvailable, HotelId });
            dataGridView1.DataSource = roomBindingSource;
            dataGridView1.Location = new Point(256, 297);
            dataGridView1.Margin = new Padding(3, 2, 3, 2);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.RowHeadersWidth = 51;
            dataGridView1.Size = new Size(678, 224);
            dataGridView1.TabIndex = 13;
            dataGridView1.CellContentClick += this.dataGridView1_CellContentClick;
            // 
            // idDataGridViewTextBoxColumn
            // 
            idDataGridViewTextBoxColumn.DataPropertyName = "Id";
            idDataGridViewTextBoxColumn.HeaderText = "Id";
            idDataGridViewTextBoxColumn.MinimumWidth = 6;
            idDataGridViewTextBoxColumn.Name = "idDataGridViewTextBoxColumn";
            idDataGridViewTextBoxColumn.Width = 125;
            // 
            // menuStrip1
            // 
            menuStrip1.Dock = DockStyle.None;
            menuStrip1.Font = new Font("Cambria", 12F, FontStyle.Bold);
            menuStrip1.GripStyle = ToolStripGripStyle.Visible;
            menuStrip1.Items.AddRange(new ToolStripItem[] { addToolStripMenuItem, deleteToolStripMenuItem, updateToolStripMenuItem, viewToolStripMenuItem });
            menuStrip1.Location = new Point(761, 2);
            menuStrip1.Name = "menuStrip1";
            menuStrip1.Size = new Size(262, 27);
            menuStrip1.TabIndex = 15;
            menuStrip1.Text = "menuStrip1";
            menuStrip1.ItemClicked += menuStrip1_ItemClicked;
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
            roomid.DataBindings.Add(new Binding("DataContext", roomBindingSource, "Id", true));
            roomid.Location = new Point(293, 68);
            roomid.Name = "roomid";
            roomid.Size = new Size(52, 15);
            roomid.TabIndex = 16;
            roomid.Text = "Room Id";
            roomid.Click += this.label2_Click;
            // 
            // RoomNumber
            // 
            RoomNumber.AutoSize = true;
            RoomNumber.DataBindings.Add(new Binding("DataContext", roomBindingSource, "RoomNumber", true));
            RoomNumber.Location = new Point(293, 99);
            RoomNumber.Name = "RoomNumber";
            RoomNumber.Size = new Size(84, 15);
            RoomNumber.TabIndex = 17;
            RoomNumber.Text = "Room number";
            // 
            // Type
            // 
            Type.AutoSize = true;
            Type.DataBindings.Add(new Binding("DataContext", roomBindingSource, "Type", true));
            Type.Location = new Point(293, 131);
            Type.Name = "Type";
            Type.Size = new Size(31, 15);
            Type.TabIndex = 18;
            Type.Text = "Type";
            // 
            // PricePerNight
            // 
            PricePerNight.AutoSize = true;
            PricePerNight.DataBindings.Add(new Binding("DataContext", roomBindingSource, "PricePerNight", true));
            PricePerNight.Location = new Point(293, 164);
            PricePerNight.Name = "PricePerNight";
            PricePerNight.Size = new Size(86, 15);
            PricePerNight.TabIndex = 19;
            PricePerNight.Text = "Price per Night";
            PricePerNight.Click += this.label5_Click;
            // 
            // Availlability
            // 
            Availlability.AutoSize = true;
            Availlability.DataBindings.Add(new Binding("DataContext", roomBindingSource, "IsAvailable", true));
            Availlability.Location = new Point(293, 196);
            Availlability.Name = "Availlability";
            Availlability.Size = new Size(68, 15);
            Availlability.TabIndex = 20;
            Availlability.Text = "Availlability";
            Availlability.Click += this.label6_Click;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(293, 230);
            label7.Name = "label7";
            label7.Size = new Size(49, 15);
            label7.TabIndex = 21;
            label7.Text = "Hotel Id";
            label7.Click += this.label7_Click;
            // 
            // textBox2_roomid
            // 
            textBox2_roomid.DataBindings.Add(new Binding("DataContext", roomBindingSource, "Id", true));
            textBox2_roomid.Location = new Point(393, 69);
            textBox2_roomid.Name = "textBox2_roomid";
            textBox2_roomid.Size = new Size(241, 23);
            textBox2_roomid.TabIndex = 22;
            // 
            // textBox3_roomNumber
            // 
            textBox3_roomNumber.DataBindings.Add(new Binding("DataContext", roomBindingSource, "RoomNumber", true));
            textBox3_roomNumber.Location = new Point(393, 99);
            textBox3_roomNumber.Name = "textBox3_roomNumber";
            textBox3_roomNumber.Size = new Size(241, 23);
            textBox3_roomNumber.TabIndex = 23;
            // 
            // textBox4_roomType
            // 
            textBox4_roomType.DataBindings.Add(new Binding("DataContext", roomBindingSource, "Type", true));
            textBox4_roomType.Location = new Point(393, 128);
            textBox4_roomType.Name = "textBox4_roomType";
            textBox4_roomType.Size = new Size(241, 23);
            textBox4_roomType.TabIndex = 24;
            // 
            // textBox5_priceperNight
            // 
            textBox5_priceperNight.DataBindings.Add(new Binding("DataContext", roomBindingSource, "PricePerNight", true));
            textBox5_priceperNight.Location = new Point(393, 161);
            textBox5_priceperNight.Name = "textBox5_priceperNight";
            textBox5_priceperNight.Size = new Size(241, 23);
            textBox5_priceperNight.TabIndex = 25;
            // 
            // textBox7
            // 
            textBox7.Location = new Point(393, 222);
            textBox7.Name = "textBox7";
            textBox7.PlaceholderText = "For future expansion of hotel buildings";
            textBox7.Size = new Size(241, 23);
            textBox7.TabIndex = 27;
            // 
            // return_image
            // 
            return_image.Image = (Image)resources.GetObject("return_image.Image");
            return_image.Location = new Point(742, 12);
            return_image.Name = "return_image";
            return_image.Size = new Size(16, 16);
            return_image.SizeMode = PictureBoxSizeMode.AutoSize;
            return_image.TabIndex = 28;
            return_image.TabStop = false;
            // 
            // roomBindingSource
            // 
            roomBindingSource.DataSource = typeof(Models.Room);
            // 
            // IsAvaillabel
            // 
            IsAvaillabel.AutoSize = true;
            IsAvaillabel.Checked = true;
            IsAvaillabel.CheckState = CheckState.Checked;
            IsAvaillabel.DataBindings.Add(new Binding("CheckState", roomBindingSource, "IsAvailable", true));
            IsAvaillabel.Location = new Point(394, 195);
            IsAvaillabel.Name = "IsAvaillabel";
            IsAvaillabel.Size = new Size(83, 19);
            IsAvaillabel.TabIndex = 29;
            IsAvaillabel.Text = "checkBox1";
            IsAvaillabel.UseVisualStyleBackColor = true;
            IsAvaillabel.CheckedChanged += this.checkBox1_CheckedChanged;
            // 
            // IsAvailable
            // 
            IsAvailable.DataPropertyName = "IsAvailable";
            IsAvailable.HeaderText = "IsAvailable";
            IsAvailable.Name = "IsAvailable";
            // 
            // HotelId
            // 
            HotelId.DataPropertyName = "HotelId";
            HotelId.HeaderText = "HotelId";
            HotelId.Name = "HotelId";
            // 
            // RoomClass
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.Control;
            ClientSize = new Size(992, 530);
            Controls.Add(IsAvaillabel);
            Controls.Add(return_image);
            Controls.Add(textBox7);
            Controls.Add(textBox5_priceperNight);
            Controls.Add(textBox4_roomType);
            Controls.Add(textBox3_roomNumber);
            Controls.Add(textBox2_roomid);
            Controls.Add(label7);
            Controls.Add(Availlability);
            Controls.Add(PricePerNight);
            Controls.Add(Type);
            Controls.Add(RoomNumber);
            Controls.Add(roomid);
            Controls.Add(dataGridView1);
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
            Text = "MyTemplateForm1";
            ((System.ComponentModel.ISupportInitialize)pictureBox2).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ((System.ComponentModel.ISupportInitialize)customerBindingSource).EndInit();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            menuStrip1.ResumeLayout(false);
            menuStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)return_image).EndInit();
            ((System.ComponentModel.ISupportInitialize)roomBindingSource).EndInit();
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
        private BindingSource customerBindingSource;
        private DataGridView dataGridView1;
        private DataGridViewTextBoxColumn idDataGridViewTextBoxColumn;
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
        private Label label7;
        private TextBox textBox2_roomid;
        private TextBox textBox3_roomNumber;
        private TextBox textBox4_roomType;
        private TextBox textBox5_priceperNight;
        private TextBox textBox7;
        private PictureBox return_image;
        private BindingSource roomBindingSource;
        private CheckBox IsAvaillabel;
        private DataGridViewCheckBoxColumn IsAvailable;
        private DataGridViewTextBoxColumn HotelId;
    }
}