
namespace Hotel_Philoxenia.Forms
{
    partial class LoginForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(LoginForm));
            panel1 = new Panel();
            loginRegistration = new Button();
            label2 = new Label();
            label1 = new Label();
            pictureBox1 = new PictureBox();
            textBox2 = new TextBox();
            loginUsername = new TextBox();
            loginPassword = new TextBox();
            label3 = new Label();
            label4 = new Label();
            loginShowPassBtn = new CheckBox();
            loginLogin = new Button();
            label5 = new Label();
            label6 = new Label();
            button1 = new Button();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.BackColor = Color.Black;
            panel1.Controls.Add(loginRegistration);
            panel1.Controls.Add(label2);
            panel1.Controls.Add(label1);
            panel1.Controls.Add(pictureBox1);
            panel1.ForeColor = SystemColors.ControlLight;
            panel1.Location = new Point(1, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(250, 450);
            panel1.TabIndex = 0;
            // 
            // loginRegistration
            // 
            loginRegistration.BackColor = Color.OrangeRed;
            loginRegistration.Cursor = Cursors.Hand;
            loginRegistration.ForeColor = SystemColors.Control;
            loginRegistration.Location = new Point(72, 383);
            loginRegistration.Name = "loginRegistration";
            loginRegistration.Size = new Size(107, 29);
            loginRegistration.TabIndex = 3;
            loginRegistration.Text = "Registration";
            loginRegistration.UseVisualStyleBackColor = false;
            loginRegistration.Click += loginRegistration_Click;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Cambria", 13.8F, FontStyle.Bold, GraphicsUnit.Point, 161);
            label2.ForeColor = Color.White;
            label2.Location = new Point(48, 353);
            label2.Name = "label2";
            label2.Size = new Size(161, 27);
            label2.TabIndex = 2;
            label2.Text = "New Member?";
            label2.Click += label2_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Cambria", 13.8F, FontStyle.Bold, GraphicsUnit.Point, 161);
            label1.ForeColor = Color.Cyan;
            label1.Location = new Point(36, 22);
            label1.Name = "label1";
            label1.Size = new Size(185, 27);
            label1.TabIndex = 1;
            label1.Text = "Hotel Philoxenia";
            label1.Click += label1_Click;
            // 
            // pictureBox1
            // 
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(36, 52);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(185, 116);
            pictureBox1.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox1.TabIndex = 0;
            pictureBox1.TabStop = false;
            pictureBox1.Click += pictureBox1_Click;
            // 
            // textBox2
            // 
            textBox2.BackColor = SystemColors.Control;
            textBox2.BorderStyle = BorderStyle.None;
            textBox2.Font = new Font("Cambria", 24F, FontStyle.Bold, GraphicsUnit.Point, 161);
            textBox2.ForeColor = Color.OrangeRed;
            textBox2.Location = new Point(430, 52);
            textBox2.Name = "textBox2";
            textBox2.Size = new Size(203, 47);
            textBox2.TabIndex = 2;
            textBox2.Text = "Welcome!";
            textBox2.TextAlign = HorizontalAlignment.Center;
            textBox2.TextChanged += textBox2_TextChanged;
            // 
            // loginUsername
            // 
            loginUsername.Location = new Point(351, 160);
            loginUsername.Name = "loginUsername";
            loginUsername.Size = new Size(335, 27);
            loginUsername.TabIndex = 3;
            loginUsername.TextChanged += loginUsername_TextChanged;
            // 
            // loginPassword
            // 
            loginPassword.Location = new Point(351, 239);
            loginPassword.Name = "loginPassword";
            loginPassword.Size = new Size(335, 27);
            loginPassword.TabIndex = 4;
            loginPassword.TextChanged += loginPassword_TextChanged;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(286, 148);
            label3.Name = "label3";
            label3.Size = new Size(0, 20);
            label3.TabIndex = 5;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(286, 216);
            label4.Name = "label4";
            label4.Size = new Size(0, 20);
            label4.TabIndex = 6;
            // 
            // loginShowPassBtn
            // 
            loginShowPassBtn.AutoSize = true;
            loginShowPassBtn.Font = new Font("Cambria", 7.8F, FontStyle.Italic, GraphicsUnit.Point, 161);
            loginShowPassBtn.Location = new Point(573, 283);
            loginShowPassBtn.Name = "loginShowPassBtn";
            loginShowPassBtn.Size = new Size(113, 19);
            loginShowPassBtn.TabIndex = 7;
            loginShowPassBtn.Text = "Show Password";
            loginShowPassBtn.UseVisualStyleBackColor = true;
            loginShowPassBtn.CheckedChanged += loginShowPassBtn_CheckedChanged;
            // 
            // loginLogin
            // 
            loginLogin.BackColor = SystemColors.Control;
            loginLogin.Cursor = Cursors.Hand;
            loginLogin.Font = new Font("Cambria", 16.2F, FontStyle.Bold, GraphicsUnit.Point, 161);
            loginLogin.ForeColor = Color.OrangeRed;
            loginLogin.Location = new Point(632, 363);
            loginLogin.Name = "loginLogin";
            loginLogin.Size = new Size(156, 49);
            loginLogin.TabIndex = 8;
            loginLogin.Text = "Login";
            loginLogin.UseVisualStyleBackColor = false;
            loginLogin.Click += loginLogin_Click;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Cambria", 10.8F, FontStyle.Regular, GraphicsUnit.Point, 161);
            label5.Location = new Point(478, 136);
            label5.Name = "label5";
            label5.Size = new Size(89, 21);
            label5.TabIndex = 9;
            label5.Text = "Username";
            label5.Click += label5_Click;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Cambria", 10.8F, FontStyle.Regular, GraphicsUnit.Point, 161);
            label6.Location = new Point(478, 215);
            label6.Name = "label6";
            label6.Size = new Size(86, 21);
            label6.TabIndex = 10;
            label6.Text = "Password";
            label6.Click += label6_Click;
            // 
            // button1
            // 
            button1.Location = new Point(757, 12);
            button1.Name = "button1";
            button1.Size = new Size(31, 29);
            button1.TabIndex = 26;
            button1.Text = "X";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // LoginForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.Control;
            ClientSize = new Size(800, 450);
            Controls.Add(button1);
            Controls.Add(label6);
            Controls.Add(label5);
            Controls.Add(loginLogin);
            Controls.Add(loginShowPassBtn);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(loginPassword);
            Controls.Add(loginUsername);
            Controls.Add(textBox2);
            Controls.Add(panel1);
            FormBorderStyle = FormBorderStyle.None;
            Name = "LoginForm";
            Text = "LoginForm";
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }




        private void label3_Click(object sender, EventArgs e)
        {
            
        }

        #endregion

        private Panel panel1;
        private PictureBox pictureBox1;
        private Label label1;
        private Label label2;
        private Button loginRegistration;
        private TextBox textBox2;
        private TextBox loginUsername;
        private TextBox loginPassword;
        private Label label3;
        private Label label4;
        private CheckBox loginShowPassBtn;
        private Button loginLogin;
        private Label label5;
        private Label label6;
        private Button button1;
    }
}