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
            ExitButton = new Button();
            FrontPagePicBox = new PictureBox();
            MinButton = new Button();
            PasswordLabel = new Label();
            ErrorLabel = new Label();
            UsernameLabel = new Label();
            PassTextBox = new TextBox();
            LogInButton = new Button();
            SignUpButton = new Button();
            UserTextBox = new TextBox();
            panel2 = new Panel();
            pictureBox2 = new PictureBox();
            panel1 = new Panel();
            ((System.ComponentModel.ISupportInitialize)LogoPicBox).BeginInit();
            ((System.ComponentModel.ISupportInitialize)FrontPagePicBox).BeginInit();
            panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).BeginInit();
            panel1.SuspendLayout();
            SuspendLayout();
            // 
            // LogoPicBox
            // 
            LogoPicBox.Anchor = AnchorStyles.Left;
            LogoPicBox.BackColor = Color.Transparent;
            LogoPicBox.Image = (Image)resources.GetObject("LogoPicBox.Image");
            LogoPicBox.ImageLocation = "";
            LogoPicBox.Location = new Point(72, 55);
            LogoPicBox.Name = "LogoPicBox";
            LogoPicBox.Size = new Size(314, 347);
            LogoPicBox.SizeMode = PictureBoxSizeMode.Zoom;
            LogoPicBox.TabIndex = 3;
            LogoPicBox.TabStop = false;
            // 
            // ExitButton
            // 
            ExitButton.Anchor = AnchorStyles.Left;
            ExitButton.BackColor = Color.Transparent;
            ExitButton.BackgroundImage = (Image)resources.GetObject("ExitButton.BackgroundImage");
            ExitButton.BackgroundImageLayout = ImageLayout.Zoom;
            ExitButton.FlatAppearance.BorderSize = 0;
            ExitButton.FlatStyle = FlatStyle.Flat;
            ExitButton.ForeColor = Color.Black;
            ExitButton.Location = new Point(410, 12);
            ExitButton.Name = "ExitButton";
            ExitButton.Size = new Size(27, 25);
            ExitButton.TabIndex = 11;
            ExitButton.UseVisualStyleBackColor = false;
            ExitButton.Click += ExitButton_Click;
            // 
            // FrontPagePicBox
            // 
            FrontPagePicBox.Dock = DockStyle.Right;
            FrontPagePicBox.Image = (Image)resources.GetObject("FrontPagePicBox.Image");
            FrontPagePicBox.ImageLocation = "";
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
            MinButton.FlatAppearance.BorderSize = 0;
            MinButton.FlatStyle = FlatStyle.Flat;
            MinButton.ForeColor = Color.Black;
            MinButton.Location = new Point(377, 12);
            MinButton.Name = "MinButton";
            MinButton.Size = new Size(27, 25);
            MinButton.TabIndex = 12;
            MinButton.UseVisualStyleBackColor = false;
            MinButton.Click += MinButton_Click;
            // 
            // PasswordLabel
            // 
            PasswordLabel.AutoSize = true;
            PasswordLabel.BackColor = Color.Transparent;
            PasswordLabel.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            PasswordLabel.Location = new Point(3, 75);
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
            ErrorLabel.Location = new Point(72, 409);
            ErrorLabel.Name = "ErrorLabel";
            ErrorLabel.Size = new Size(82, 21);
            ErrorLabel.TabIndex = 10;
            ErrorLabel.Text = "ErrorLabel";
            ErrorLabel.Visible = false;
            // 
            // UsernameLabel
            // 
            UsernameLabel.AutoSize = true;
            UsernameLabel.BackColor = Color.Transparent;
            UsernameLabel.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            UsernameLabel.Location = new Point(0, 10);
            UsernameLabel.Name = "UsernameLabel";
            UsernameLabel.Size = new Size(64, 15);
            UsernameLabel.TabIndex = 8;
            UsernameLabel.Text = "Username";
            // 
            // PassTextBox
            // 
            PassTextBox.Anchor = AnchorStyles.Left;
            PassTextBox.BackColor = Color.Gainsboro;
            PassTextBox.BorderStyle = BorderStyle.FixedSingle;
            PassTextBox.Cursor = Cursors.IBeam;
            PassTextBox.Font = new Font("Segoe UI", 15F);
            PassTextBox.Location = new Point(0, 93);
            PassTextBox.Multiline = true;
            PassTextBox.Name = "PassTextBox";
            PassTextBox.PasswordChar = '*';
            PassTextBox.Size = new Size(314, 35);
            PassTextBox.TabIndex = 7;
            PassTextBox.Click += UserTextBox_Click;
            // 
            // LogInButton
            // 
            LogInButton.Anchor = AnchorStyles.Left;
            LogInButton.BackColor = Color.SteelBlue;
            LogInButton.FlatStyle = FlatStyle.Popup;
            LogInButton.Font = new Font("Segoe UI", 15F);
            LogInButton.ForeColor = Color.White;
            LogInButton.Location = new Point(0, 227);
            LogInButton.Name = "LogInButton";
            LogInButton.Size = new Size(314, 38);
            LogInButton.TabIndex = 5;
            LogInButton.Text = "Log-In";
            LogInButton.UseVisualStyleBackColor = false;
            LogInButton.Click += LogInButton_Click_1;
            // 
            // SignUpButton
            // 
            SignUpButton.Anchor = AnchorStyles.Left;
            SignUpButton.BackColor = Color.ForestGreen;
            SignUpButton.FlatStyle = FlatStyle.Popup;
            SignUpButton.Font = new Font("Segoe UI", 15F);
            SignUpButton.ForeColor = Color.White;
            SignUpButton.Location = new Point(0, 183);
            SignUpButton.Name = "SignUpButton";
            SignUpButton.Size = new Size(314, 38);
            SignUpButton.TabIndex = 4;
            SignUpButton.Text = "Sign-Up";
            SignUpButton.UseVisualStyleBackColor = false;
            SignUpButton.Click += SignUpButton_Click_1;
            // 
            // UserTextBox
            // 
            UserTextBox.Anchor = AnchorStyles.Left;
            UserTextBox.BackColor = Color.Gainsboro;
            UserTextBox.BorderStyle = BorderStyle.FixedSingle;
            UserTextBox.Cursor = Cursors.IBeam;
            UserTextBox.Font = new Font("Segoe UI", 15F);
            UserTextBox.Location = new Point(0, 28);
            UserTextBox.Multiline = true;
            UserTextBox.Name = "UserTextBox";
            UserTextBox.Size = new Size(314, 35);
            UserTextBox.TabIndex = 6;
            UserTextBox.Click += UserTextBox_Click;
            // 
            // panel2
            // 
            panel2.BackColor = Color.Transparent;
            panel2.BackgroundImageLayout = ImageLayout.None;
            panel2.Controls.Add(UserTextBox);
            panel2.Controls.Add(SignUpButton);
            panel2.Controls.Add(LogInButton);
            panel2.Controls.Add(PassTextBox);
            panel2.Controls.Add(UsernameLabel);
            panel2.Controls.Add(PasswordLabel);
            panel2.Location = new Point(72, 433);
            panel2.Name = "panel2";
            panel2.Size = new Size(314, 267);
            panel2.TabIndex = 14;
            // 
            // pictureBox2
            // 
            pictureBox2.Image = (Image)resources.GetObject("pictureBox2.Image");
            pictureBox2.Location = new Point(59, 55);
            pictureBox2.Name = "pictureBox2";
            pictureBox2.Size = new Size(231, 219);
            pictureBox2.SizeMode = PictureBoxSizeMode.CenterImage;
            pictureBox2.TabIndex = 15;
            pictureBox2.TabStop = false;
            // 
            // panel1
            // 
            panel1.BackColor = Color.Transparent;
            panel1.Controls.Add(pictureBox2);
            panel1.Location = new Point(57, 433);
            panel1.Name = "panel1";
            panel1.Size = new Size(347, 332);
            panel1.TabIndex = 15;
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
            Controls.Add(panel2);
            Controls.Add(MinButton);
            Controls.Add(ExitButton);
            Controls.Add(FrontPagePicBox);
            Controls.Add(ErrorLabel);
            Controls.Add(LogoPicBox);
            Controls.Add(panel1);
            FormBorderStyle = FormBorderStyle.None;
            KeyPreview = true;
            MaximizeBox = false;
            MinimizeBox = false;
            Name = "FrontPageForm";
            ShowIcon = false;
            StartPosition = FormStartPosition.CenterScreen;
            Text = "HousePets Haven";
            MouseDown += FrontPageForm_MouseDown;
            ((System.ComponentModel.ISupportInitialize)LogoPicBox).EndInit();
            ((System.ComponentModel.ISupportInitialize)FrontPagePicBox).EndInit();
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).EndInit();
            panel1.ResumeLayout(false);
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private PictureBox LogoPicBox;
        private Button ExitButton;
        private PictureBox FrontPagePicBox;
        private Button MinButton;
        private Label PasswordLabel;
        private Label ErrorLabel;
        private Label UsernameLabel;
        private TextBox PassTextBox;
        private Button LogInButton;
        private Button SignUpButton;
        private TextBox UserTextBox;
        private Panel panel2;
        private PictureBox pictureBox2;
        private Panel panel1;
    }
}
