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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrontPageForm));
            LogoPicBox = new PictureBox();
            SignUpButton = new Button();
            LogInButton = new Button();
            UserTextBox = new TextBox();
            PassTextBox = new TextBox();
            UsernameLabel = new Label();
            PasswordLabel = new Label();
            ErrorLabel = new Label();
            ExitButton = new Button();
            FrontPagePicBox = new PictureBox();
            MinButton = new Button();
            ((System.ComponentModel.ISupportInitialize)LogoPicBox).BeginInit();
            ((System.ComponentModel.ISupportInitialize)FrontPagePicBox).BeginInit();
            SuspendLayout();
            // 
            // LogoPicBox
            // 
            LogoPicBox.Anchor = AnchorStyles.Left;
            LogoPicBox.BackColor = Color.Transparent;
            LogoPicBox.ImageLocation = "D:\\PROGRAMMING\\2ND YEAR\\visual studio projects\\HousePets Airbnb\\misc\\logo2.png";
            LogoPicBox.Location = new Point(72, 55);
            LogoPicBox.Name = "LogoPicBox";
            LogoPicBox.Size = new Size(314, 347);
            LogoPicBox.SizeMode = PictureBoxSizeMode.Zoom;
            LogoPicBox.TabIndex = 3;
            LogoPicBox.TabStop = false;
            // 
            // SignUpButton
            // 
            SignUpButton.Anchor = AnchorStyles.Left;
            SignUpButton.BackColor = Color.ForestGreen;
            SignUpButton.FlatStyle = FlatStyle.Popup;
            SignUpButton.Font = new Font("Segoe UI", 15F);
            SignUpButton.ForeColor = Color.White;
            SignUpButton.Location = new Point(72, 617);
            SignUpButton.Name = "SignUpButton";
            SignUpButton.Size = new Size(314, 38);
            SignUpButton.TabIndex = 4;
            SignUpButton.Text = "Sign-Up";
            SignUpButton.UseVisualStyleBackColor = false;
            SignUpButton.Click += SignUpButton_Click_1;
            // 
            // LogInButton
            // 
            LogInButton.Anchor = AnchorStyles.Left;
            LogInButton.BackColor = Color.SteelBlue;
            LogInButton.FlatStyle = FlatStyle.Popup;
            LogInButton.Font = new Font("Segoe UI", 15F);
            LogInButton.ForeColor = Color.White;
            LogInButton.Location = new Point(72, 661);
            LogInButton.Name = "LogInButton";
            LogInButton.Size = new Size(314, 38);
            LogInButton.TabIndex = 5;
            LogInButton.Text = "Log-In";
            LogInButton.UseVisualStyleBackColor = false;
            LogInButton.Click += LogInButton_Click_1;
            // 
            // UserTextBox
            // 
            UserTextBox.Anchor = AnchorStyles.Left;
            UserTextBox.BackColor = Color.Gainsboro;
            UserTextBox.BorderStyle = BorderStyle.FixedSingle;
            UserTextBox.Cursor = Cursors.IBeam;
            UserTextBox.Font = new Font("Segoe UI", 15F);
            UserTextBox.Location = new Point(72, 474);
            UserTextBox.Multiline = true;
            UserTextBox.Name = "UserTextBox";
            UserTextBox.Size = new Size(314, 35);
            UserTextBox.TabIndex = 6;
            UserTextBox.Click += UserTextBox_Click;
            // 
            // PassTextBox
            // 
            PassTextBox.Anchor = AnchorStyles.Left;
            PassTextBox.BackColor = Color.Gainsboro;
            PassTextBox.BorderStyle = BorderStyle.FixedSingle;
            PassTextBox.Cursor = Cursors.IBeam;
            PassTextBox.Font = new Font("Segoe UI", 15F);
            PassTextBox.Location = new Point(72, 535);
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
            UsernameLabel.BackColor = Color.Transparent;
            UsernameLabel.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            UsernameLabel.Location = new Point(72, 456);
            UsernameLabel.Name = "UsernameLabel";
            UsernameLabel.Size = new Size(64, 15);
            UsernameLabel.TabIndex = 8;
            UsernameLabel.Text = "Username";
            // 
            // PasswordLabel
            // 
            PasswordLabel.AutoSize = true;
            PasswordLabel.BackColor = Color.Transparent;
            PasswordLabel.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            PasswordLabel.Location = new Point(72, 517);
            PasswordLabel.Name = "PasswordLabel";
            PasswordLabel.Size = new Size(59, 15);
            PasswordLabel.TabIndex = 9;
            PasswordLabel.Text = "Password";
            // 
            // ErrorLabel
            // 
            ErrorLabel.AutoSize = true;
            ErrorLabel.BackColor = Color.Transparent;
            ErrorLabel.Font = new Font("Segoe UI", 12F);
            ErrorLabel.ForeColor = Color.Red;
            ErrorLabel.Location = new Point(72, 424);
            ErrorLabel.Name = "ErrorLabel";
            ErrorLabel.Size = new Size(82, 21);
            ErrorLabel.TabIndex = 10;
            ErrorLabel.Text = "ErrorLabel";
            ErrorLabel.Visible = false;
            // 
            // ExitButton
            // 
            ExitButton.Anchor = AnchorStyles.Left;
            ExitButton.BackColor = Color.Transparent;
            ExitButton.BackgroundImage = (Image)resources.GetObject("ExitButton.BackgroundImage");
            ExitButton.BackgroundImageLayout = ImageLayout.Zoom;
            ExitButton.FlatStyle = FlatStyle.Flat;
            ExitButton.ForeColor = Color.Black;
            ExitButton.Location = new Point(404, 13);
            ExitButton.Name = "ExitButton";
            ExitButton.Size = new Size(40, 36);
            ExitButton.TabIndex = 11;
            ExitButton.UseVisualStyleBackColor = false;
            ExitButton.Click += ExitButton_Click;
            // 
            // FrontPagePicBox
            // 
            FrontPagePicBox.Dock = DockStyle.Right;
            FrontPagePicBox.ImageLocation = "D:\\PROGRAMMING\\2ND YEAR\\visual studio projects\\HousePets Airbnb\\misc\\pet_movie_square2.gif";
            FrontPagePicBox.Location = new Point(456, 0);
            FrontPagePicBox.Name = "FrontPagePicBox";
            FrontPagePicBox.Size = new Size(716, 762);
            FrontPagePicBox.SizeMode = PictureBoxSizeMode.StretchImage;
            FrontPagePicBox.TabIndex = 0;
            FrontPagePicBox.TabStop = false;
            // 
            // MinButton
            // 
            MinButton.Anchor = AnchorStyles.Left;
            MinButton.BackColor = Color.Transparent;
            MinButton.BackgroundImage = (Image)resources.GetObject("MinButton.BackgroundImage");
            MinButton.BackgroundImageLayout = ImageLayout.Zoom;
            MinButton.FlatStyle = FlatStyle.Flat;
            MinButton.ForeColor = Color.Black;
            MinButton.Location = new Point(359, 13);
            MinButton.Name = "MinButton";
            MinButton.Size = new Size(39, 36);
            MinButton.TabIndex = 12;
            MinButton.UseVisualStyleBackColor = false;
            MinButton.Click += MinButton_Click;
            // 
            // FrontPageForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            BackgroundImage = (Image)resources.GetObject("$this.BackgroundImage");
            BackgroundImageLayout = ImageLayout.None;
            CausesValidation = false;
            ClientSize = new Size(1172, 762);
            ControlBox = false;
            Controls.Add(MinButton);
            Controls.Add(ExitButton);
            Controls.Add(FrontPagePicBox);
            Controls.Add(ErrorLabel);
            Controls.Add(PasswordLabel);
            Controls.Add(UsernameLabel);
            Controls.Add(PassTextBox);
            Controls.Add(UserTextBox);
            Controls.Add(LogInButton);
            Controls.Add(SignUpButton);
            Controls.Add(LogoPicBox);
            FormBorderStyle = FormBorderStyle.None;
            KeyPreview = true;
            MaximizeBox = false;
            MinimizeBox = false;
            Name = "FrontPageForm";
            ShowIcon = false;
            StartPosition = FormStartPosition.CenterScreen;
            Text = "HousePets Airbnb";
            MouseDown += FrontPageForm_MouseDown;
            ((System.ComponentModel.ISupportInitialize)LogoPicBox).EndInit();
            ((System.ComponentModel.ISupportInitialize)FrontPagePicBox).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private PictureBox LogoPicBox;
        private Button SignUpButton;
        private Button LogInButton;
        private TextBox UserTextBox;
        private TextBox PassTextBox;
        private Label UsernameLabel;
        private Label PasswordLabel;
        private Label ErrorLabel;
        private Button ExitButton;
        private PictureBox FrontPagePicBox;
        private Button MinButton;
    }
}
