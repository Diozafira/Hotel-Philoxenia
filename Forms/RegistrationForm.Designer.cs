namespace Hotel_Philoxenia.Forms
{
    partial class RegistrationForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(RegistrationForm));
            label6 = new Label();
            label5 = new Label();
            registerSignup = new Button();
            registerShowPassBtn = new CheckBox();
            registerPassword = new TextBox();
            registerUsername = new TextBox();
            textBox2 = new TextBox();
            register_close = new TextBox();
            label3 = new Label();
            registerConfirmPass = new TextBox();
            panel1 = new Panel();
            registerLogin = new Button();
            label2 = new Label();
            label1 = new Label();
            pictureBox1 = new PictureBox();
            label4 = new Label();
            button1 = new Button();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // label6
            // 
            label6.Location = new Point(0, 0);
            label6.Name = "label6";
            label6.Size = new Size(100, 23);
            label6.TabIndex = 22;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Cambria", 10.8F, FontStyle.Regular, GraphicsUnit.Point, 161);
            label5.Location = new Point(478, 136);
            label5.Name = "label5";
            label5.Size = new Size(89, 21);
            label5.TabIndex = 17;
            label5.Text = "Username";
            label5.Click += label5_Click;
            // 
            // registerSignup
            // 
            registerSignup.BackColor = SystemColors.Control;
            registerSignup.Cursor = Cursors.Hand;
            registerSignup.Font = new Font("Cambria", 16.2F, FontStyle.Bold, GraphicsUnit.Point, 161);
            registerSignup.ForeColor = Color.OrangeRed;
            registerSignup.Location = new Point(632, 381);
            registerSignup.Name = "registerSignup";
            registerSignup.Size = new Size(156, 49);
            registerSignup.TabIndex = 16;
            registerSignup.Text = "SignUp";
            registerSignup.UseVisualStyleBackColor = false;
            registerSignup.Click += registerSignup_Click;
            // 
            // registerShowPassBtn
            // 
            registerShowPassBtn.AutoSize = true;
            registerShowPassBtn.Font = new Font("Cambria", 7.8F, FontStyle.Italic, GraphicsUnit.Point, 161);
            registerShowPassBtn.Location = new Point(573, 338);
            registerShowPassBtn.Name = "registerShowPassBtn";
            registerShowPassBtn.Size = new Size(113, 19);
            registerShowPassBtn.TabIndex = 15;
            registerShowPassBtn.Text = "Show Password";
            registerShowPassBtn.UseVisualStyleBackColor = true;
            registerShowPassBtn.CheckedChanged += registerShowPassBtn_CheckedChanged;
            // 
            // registerPassword
            // 
            registerPassword.Location = new Point(351, 227);
            registerPassword.Name = "registerPassword";
            registerPassword.Size = new Size(335, 27);
            registerPassword.TabIndex = 14;
            registerPassword.TextChanged += registerPassword_TextChanged;
            // 
            // registerUsername
            // 
            registerUsername.Location = new Point(351, 160);
            registerUsername.Name = "registerUsername";
            registerUsername.Size = new Size(335, 27);
            registerUsername.TabIndex = 13;
            registerUsername.TextChanged += label5_Click;
            // 
            // textBox2
            // 
            textBox2.BackColor = SystemColors.Control;
            textBox2.BorderStyle = BorderStyle.None;
            textBox2.Font = new Font("Cambria", 24F, FontStyle.Bold, GraphicsUnit.Point, 161);
            textBox2.ForeColor = Color.OrangeRed;
            textBox2.Location = new Point(420, 54);
            textBox2.Name = "textBox2";
            textBox2.Size = new Size(203, 47);
            textBox2.TabIndex = 12;
            textBox2.Text = "Register";
            textBox2.TextAlign = HorizontalAlignment.Center;
            textBox2.TextChanged += registerHeaderTextChanged;
            // 
            // register_close
            // 
            register_close.Location = new Point(0, 0);
            register_close.Name = "register_close";
            register_close.Size = new Size(100, 27);
            register_close.TabIndex = 23;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Cambria", 10.8F, FontStyle.Regular, GraphicsUnit.Point, 161);
            label3.Location = new Point(451, 266);
            label3.Name = "label3";
            label3.Size = new Size(152, 21);
            label3.TabIndex = 20;
            label3.Text = "Confirm Password";
            // 
            // registerConfirmPass
            // 
            registerConfirmPass.Location = new Point(351, 290);
            registerConfirmPass.Name = "registerConfirmPass";
            registerConfirmPass.Size = new Size(335, 27);
            registerConfirmPass.TabIndex = 19;
            // 
            // panel1
            // 
            panel1.BackColor = Color.Black;
            panel1.Controls.Add(registerLogin);
            panel1.Controls.Add(label2);
            panel1.Controls.Add(label1);
            panel1.Controls.Add(pictureBox1);
            panel1.ForeColor = SystemColors.ControlLight;
            panel1.Location = new Point(0, 2);
            panel1.Name = "panel1";
            panel1.Size = new Size(250, 450);
            panel1.TabIndex = 21;
            // 
            // registerLogin
            // 
            registerLogin.BackColor = Color.OrangeRed;
            registerLogin.Cursor = Cursors.Hand;
            registerLogin.ForeColor = SystemColors.Control;
            registerLogin.Location = new Point(72, 383);
            registerLogin.Name = "registerLogin";
            registerLogin.Size = new Size(107, 29);
            registerLogin.TabIndex = 3;
            registerLogin.Text = "Login";
            registerLogin.UseVisualStyleBackColor = false;
            registerLogin.Click += registerLogin_Click;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Cambria", 13.8F, FontStyle.Bold, GraphicsUnit.Point, 161);
            label2.ForeColor = Color.White;
            label2.Location = new Point(21, 353);
            label2.Name = "label2";
            label2.Size = new Size(215, 27);
            label2.TabIndex = 2;
            label2.Text = "Already a member?";
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
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Cambria", 10.8F, FontStyle.Regular, GraphicsUnit.Point, 161);
            label4.Location = new Point(478, 203);
            label4.Name = "label4";
            label4.Size = new Size(86, 21);
            label4.TabIndex = 24;
            label4.Text = "Password";
            // 
            // button1
            // 
            button1.Location = new Point(757, 12);
            button1.Name = "button1";
            button1.Size = new Size(31, 29);
            button1.TabIndex = 25;
            button1.Text = "X";
            button1.UseVisualStyleBackColor = true;
            button1.Click += Button1_Click;
            // 
            // RegistrationForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(button1);
            Controls.Add(label4);
            Controls.Add(panel1);
            Controls.Add(label3);
            Controls.Add(registerConfirmPass);
            Controls.Add(label6);
            Controls.Add(label5);
            Controls.Add(registerSignup);
            Controls.Add(registerShowPassBtn);
            Controls.Add(registerPassword);
            Controls.Add(registerUsername);
            Controls.Add(textBox2);
            Controls.Add(register_close);
            FormBorderStyle = FormBorderStyle.None;
            Name = "RegistrationForm";
            Text = "RegistrationForm";
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private Label label6;
        private Label label5;
        private Button registerSignup;
        private CheckBox registerShowPassBtn;
        private TextBox registerPassword;
        private TextBox registerUsername;
        private TextBox textBox2;
        private TextBox register_close;
        private Label label3;
        private TextBox registerConfirmPass;
        private Panel panel1;
        private Button registerLogin;
        private Label label2;
        private Label label1;
        private PictureBox pictureBox1;
        private Label label4;
        private Button button1;
    }
}