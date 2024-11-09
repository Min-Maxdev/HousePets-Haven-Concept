namespace HousePets_Airbnb
{
    partial class FrontPageForm
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            LoginPicBox = new PictureBox();
            LogoPicBox = new PictureBox();
            SignUpButton = new Button();
            LogInButton = new Button();
            UserTextBox = new TextBox();
            PassTextBox = new TextBox();
            UsernameLabel = new Label();
            PasswordLabel = new Label();
            ErrorLabel = new Label();
            ((System.ComponentModel.ISupportInitialize)LoginPicBox).BeginInit();
            ((System.ComponentModel.ISupportInitialize)LogoPicBox).BeginInit();
            SuspendLayout();
            // 
            // LoginPicBox
            // 
            LoginPicBox.ImageLocation = "D:\\PROGRAMMING\\2ND YEAR\\visual studio projects\\HousePets Airbnb\\misc\\spiral.gif";
            LoginPicBox.Location = new Point(446, -3);
            LoginPicBox.Name = "LoginPicBox";
            LoginPicBox.Size = new Size(728, 769);
            LoginPicBox.SizeMode = PictureBoxSizeMode.StretchImage;
            LoginPicBox.TabIndex = 0;
            LoginPicBox.TabStop = false;
            // 
            // LogoPicBox
            // 
            LogoPicBox.ImageLocation = "D:\\PROGRAMMING\\2ND YEAR\\visual studio projects\\HousePets Airbnb\\misc\\logo.png";
            LogoPicBox.Location = new Point(68, 23);
            LogoPicBox.Name = "LogoPicBox";
            LogoPicBox.Size = new Size(314, 347);
            LogoPicBox.SizeMode = PictureBoxSizeMode.Zoom;
            LogoPicBox.TabIndex = 3;
            LogoPicBox.TabStop = false;
            // 
            // SignUpButton
            // 
            SignUpButton.BackColor = Color.ForestGreen;
            SignUpButton.FlatStyle = FlatStyle.Popup;
            SignUpButton.Font = new Font("Segoe UI", 15F);
            SignUpButton.ForeColor = Color.White;
            SignUpButton.Location = new Point(68, 623);
            SignUpButton.Name = "SignUpButton";
            SignUpButton.Size = new Size(314, 38);
            SignUpButton.TabIndex = 4;
            SignUpButton.Text = "Sign-Up";
            SignUpButton.UseVisualStyleBackColor = false;
            SignUpButton.Click += SignUpButton_Click_1;
            // 
            // LogInButton
            // 
            LogInButton.BackColor = Color.SteelBlue;
            LogInButton.FlatStyle = FlatStyle.Popup;
            LogInButton.Font = new Font("Segoe UI", 15F);
            LogInButton.ForeColor = Color.White;
            LogInButton.Location = new Point(68, 667);
            LogInButton.Name = "LogInButton";
            LogInButton.Size = new Size(314, 38);
            LogInButton.TabIndex = 5;
            LogInButton.Text = "Log-In";
            LogInButton.UseVisualStyleBackColor = false;
            LogInButton.Click += LogInButton_Click_1;
            // 
            // UserTextBox
            // 
            UserTextBox.BackColor = Color.Gainsboro;
            UserTextBox.BorderStyle = BorderStyle.FixedSingle;
            UserTextBox.Cursor = Cursors.IBeam;
            UserTextBox.Font = new Font("Segoe UI", 15F);
            UserTextBox.Location = new Point(68, 442);
            UserTextBox.Multiline = true;
            UserTextBox.Name = "UserTextBox";
            UserTextBox.Size = new Size(314, 35);
            UserTextBox.TabIndex = 6;
            UserTextBox.Click += UserTextBox_Click;
            // 
            // PassTextBox
            // 
            PassTextBox.BackColor = Color.Gainsboro;
            PassTextBox.BorderStyle = BorderStyle.FixedSingle;
            PassTextBox.Cursor = Cursors.IBeam;
            PassTextBox.Font = new Font("Segoe UI", 15F);
            PassTextBox.Location = new Point(68, 503);
            PassTextBox.Multiline = true;
            PassTextBox.Name = "PassTextBox";
            PassTextBox.PasswordChar = '*';
            PassTextBox.Size = new Size(314, 35);
            PassTextBox.TabIndex = 7;
            PassTextBox.Click += UserTextBox_Click;
            // 
            // UsernameLabel
            // 
            UsernameLabel.AutoSize = true;
            UsernameLabel.Location = new Point(68, 424);
            UsernameLabel.Name = "UsernameLabel";
            UsernameLabel.Size = new Size(60, 15);
            UsernameLabel.TabIndex = 8;
            UsernameLabel.Text = "Username";
            // 
            // PasswordLabel
            // 
            PasswordLabel.AutoSize = true;
            PasswordLabel.Location = new Point(68, 485);
            PasswordLabel.Name = "PasswordLabel";
            PasswordLabel.Size = new Size(57, 15);
            PasswordLabel.TabIndex = 9;
            PasswordLabel.Text = "Password";
            // 
            // ErrorLabel
            // 
            ErrorLabel.AutoSize = true;
            ErrorLabel.Font = new Font("Segoe UI", 12F);
            ErrorLabel.ForeColor = Color.Red;
            ErrorLabel.Location = new Point(68, 389);
            ErrorLabel.Name = "ErrorLabel";
            ErrorLabel.Size = new Size(82, 21);
            ErrorLabel.TabIndex = 10;
            ErrorLabel.Text = "ErrorLabel";
            ErrorLabel.Visible = false;
            // 
            // FrontPageForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            BackgroundImageLayout = ImageLayout.None;
            ClientSize = new Size(1172, 762);
            ControlBox = false;
            Controls.Add(ErrorLabel);
            Controls.Add(PasswordLabel);
            Controls.Add(UsernameLabel);
            Controls.Add(PassTextBox);
            Controls.Add(UserTextBox);
            Controls.Add(LogInButton);
            Controls.Add(SignUpButton);
            Controls.Add(LogoPicBox);
            Controls.Add(LoginPicBox);
            FormBorderStyle = FormBorderStyle.None;
            KeyPreview = true;
            MaximizeBox = false;
            MinimizeBox = false;
            MinimumSize = new Size(1172, 762);
            Name = "FrontPageForm";
            ShowIcon = false;
            StartPosition = FormStartPosition.CenterScreen;
            Text = "HousePets Airbnb";
            MouseDown += FrontPageForm_MouseDown;
            ((System.ComponentModel.ISupportInitialize)LoginPicBox).EndInit();
            ((System.ComponentModel.ISupportInitialize)LogoPicBox).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private PictureBox LoginPicBox;
        private PictureBox LogoPicBox;
        private Button SignUpButton;
        private Button LogInButton;
        private TextBox UserTextBox;
        private TextBox PassTextBox;
        private Label UsernameLabel;
        private Label PasswordLabel;
        private Label ErrorLabel;
    }
}
