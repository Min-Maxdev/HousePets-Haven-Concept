namespace HousePets_Airbnb
{
    partial class HomeForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(HomeForm));
            LogOutButton = new Button();
            MinButton = new Button();
            ExitButton = new Button();
            panel1 = new Panel();
            ChatButton = new Button();
            SidePanel = new Panel();
            FavoritesButton = new Button();
            HostButton = new Button();
            pictureBox1 = new PictureBox();
            BrowseButton = new Button();
            panel11 = new Panel();
            button3 = new Button();
            button2 = new Button();
            button1 = new Button();
            openFileDialog1 = new OpenFileDialog();
            browseControl1 = new BrowseControl();
            hostControl1 = new HostControl();
            flowLayoutPanel1 = new FlowLayoutPanel();
            button4 = new Button();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            panel11.SuspendLayout();
            flowLayoutPanel1.SuspendLayout();
            SuspendLayout();
            // 
            // LogOutButton
            // 
            LogOutButton.BackgroundImageLayout = ImageLayout.Zoom;
            LogOutButton.FlatAppearance.BorderSize = 0;
            LogOutButton.FlatStyle = FlatStyle.Flat;
            LogOutButton.Font = new Font("Segoe UI", 18F, FontStyle.Bold);
            LogOutButton.Image = (Image)resources.GetObject("LogOutButton.Image");
            LogOutButton.ImageAlign = ContentAlignment.MiddleLeft;
            LogOutButton.Location = new Point(12, 568);
            LogOutButton.Name = "LogOutButton";
            LogOutButton.Size = new Size(298, 48);
            LogOutButton.TabIndex = 0;
            LogOutButton.Text = "Log-Out";
            LogOutButton.UseVisualStyleBackColor = true;
            LogOutButton.Click += LogOutButton_Click;
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
            MinButton.Location = new Point(247, 1);
            MinButton.Name = "MinButton";
            MinButton.Size = new Size(27, 25);
            MinButton.TabIndex = 13;
            MinButton.UseVisualStyleBackColor = false;
            MinButton.Click += MinButton_Click;
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
            ExitButton.Location = new Point(275, 1);
            ExitButton.Name = "ExitButton";
            ExitButton.Size = new Size(27, 25);
            ExitButton.TabIndex = 14;
            ExitButton.UseVisualStyleBackColor = false;
            ExitButton.Click += ExitButton_Click;
            // 
            // panel1
            // 
            panel1.BackColor = Color.White;
            panel1.BorderStyle = BorderStyle.FixedSingle;
            panel1.Controls.Add(ChatButton);
            panel1.Controls.Add(SidePanel);
            panel1.Controls.Add(FavoritesButton);
            panel1.Controls.Add(HostButton);
            panel1.Controls.Add(MinButton);
            panel1.Controls.Add(pictureBox1);
            panel1.Controls.Add(BrowseButton);
            panel1.Controls.Add(LogOutButton);
            panel1.Controls.Add(ExitButton);
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(309, 762);
            panel1.TabIndex = 15;
            panel1.MouseDown += HomeForm_MouseDown;
            // 
            // ChatButton
            // 
            ChatButton.BackgroundImageLayout = ImageLayout.None;
            ChatButton.FlatAppearance.BorderSize = 0;
            ChatButton.FlatStyle = FlatStyle.Flat;
            ChatButton.Font = new Font("Segoe UI", 18F, FontStyle.Bold);
            ChatButton.Image = (Image)resources.GetObject("ChatButton.Image");
            ChatButton.ImageAlign = ContentAlignment.MiddleLeft;
            ChatButton.Location = new Point(12, 412);
            ChatButton.Name = "ChatButton";
            ChatButton.Size = new Size(298, 48);
            ChatButton.TabIndex = 20;
            ChatButton.Text = "Chat";
            ChatButton.UseVisualStyleBackColor = true;
            ChatButton.Click += ChatButton_Click;
            // 
            // SidePanel
            // 
            SidePanel.BackColor = Color.Aqua;
            SidePanel.Location = new Point(0, 250);
            SidePanel.Name = "SidePanel";
            SidePanel.Size = new Size(10, 48);
            SidePanel.TabIndex = 16;
            // 
            // FavoritesButton
            // 
            FavoritesButton.BackgroundImageLayout = ImageLayout.None;
            FavoritesButton.FlatAppearance.BorderSize = 0;
            FavoritesButton.FlatStyle = FlatStyle.Flat;
            FavoritesButton.Font = new Font("Segoe UI", 18F, FontStyle.Bold);
            FavoritesButton.Image = (Image)resources.GetObject("FavoritesButton.Image");
            FavoritesButton.ImageAlign = ContentAlignment.MiddleLeft;
            FavoritesButton.Location = new Point(12, 358);
            FavoritesButton.Name = "FavoritesButton";
            FavoritesButton.Size = new Size(296, 48);
            FavoritesButton.TabIndex = 19;
            FavoritesButton.Text = "Favorites";
            FavoritesButton.UseVisualStyleBackColor = true;
            FavoritesButton.Click += FavoritesButton_Click;
            // 
            // HostButton
            // 
            HostButton.BackColor = Color.White;
            HostButton.BackgroundImageLayout = ImageLayout.None;
            HostButton.FlatAppearance.BorderSize = 0;
            HostButton.FlatStyle = FlatStyle.Flat;
            HostButton.Font = new Font("Segoe UI", 18F, FontStyle.Bold);
            HostButton.Image = (Image)resources.GetObject("HostButton.Image");
            HostButton.ImageAlign = ContentAlignment.MiddleLeft;
            HostButton.Location = new Point(12, 304);
            HostButton.Name = "HostButton";
            HostButton.Size = new Size(298, 48);
            HostButton.TabIndex = 18;
            HostButton.Text = "Host";
            HostButton.UseVisualStyleBackColor = false;
            HostButton.Click += HostButton_Click;
            // 
            // pictureBox1
            // 
            pictureBox1.Anchor = AnchorStyles.Left;
            pictureBox1.BackColor = Color.Transparent;
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.ImageLocation = "";
            pictureBox1.Location = new Point(55, 22);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(199, 194);
            pictureBox1.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox1.TabIndex = 17;
            pictureBox1.TabStop = false;
            // 
            // BrowseButton
            // 
            BrowseButton.BackColor = Color.Transparent;
            BrowseButton.BackgroundImageLayout = ImageLayout.None;
            BrowseButton.FlatAppearance.BorderSize = 0;
            BrowseButton.FlatStyle = FlatStyle.Flat;
            BrowseButton.Font = new Font("Segoe UI", 18F, FontStyle.Bold);
            BrowseButton.Image = (Image)resources.GetObject("BrowseButton.Image");
            BrowseButton.ImageAlign = ContentAlignment.MiddleLeft;
            BrowseButton.Location = new Point(12, 250);
            BrowseButton.Name = "BrowseButton";
            BrowseButton.Size = new Size(298, 48);
            BrowseButton.TabIndex = 15;
            BrowseButton.Text = "Browse";
            BrowseButton.UseVisualStyleBackColor = false;
            BrowseButton.Click += BrowseButton_Click;
            // 
            // panel11
            // 
            panel11.BorderStyle = BorderStyle.FixedSingle;
            panel11.Controls.Add(flowLayoutPanel1);
            panel11.Controls.Add(button3);
            panel11.Controls.Add(button2);
            panel11.Controls.Add(button1);
            panel11.Location = new Point(309, 0);
            panel11.Name = "panel11";
            panel11.Size = new Size(863, 65);
            panel11.TabIndex = 17;
            // 
            // button3
            // 
            button3.BackColor = Color.Black;
            button3.BackgroundImageLayout = ImageLayout.None;
            button3.Cursor = Cursors.Hand;
            button3.FlatAppearance.BorderSize = 0;
            button3.FlatStyle = FlatStyle.Flat;
            button3.Image = (Image)resources.GetObject("button3.Image");
            button3.Location = new Point(708, 11);
            button3.Name = "button3";
            button3.Size = new Size(36, 37);
            button3.TabIndex = 23;
            button3.UseVisualStyleBackColor = false;
            // 
            // button2
            // 
            button2.BackColor = Color.Black;
            button2.BackgroundImageLayout = ImageLayout.None;
            button2.Cursor = Cursors.Hand;
            button2.FlatAppearance.BorderSize = 0;
            button2.FlatStyle = FlatStyle.Flat;
            button2.Image = (Image)resources.GetObject("button2.Image");
            button2.Location = new Point(750, 11);
            button2.Name = "button2";
            button2.Size = new Size(36, 37);
            button2.TabIndex = 22;
            button2.UseVisualStyleBackColor = false;
            // 
            // button1
            // 
            button1.BackColor = Color.Black;
            button1.BackgroundImageLayout = ImageLayout.None;
            button1.Cursor = Cursors.Hand;
            button1.FlatAppearance.BorderSize = 0;
            button1.FlatStyle = FlatStyle.Flat;
            button1.Image = (Image)resources.GetObject("button1.Image");
            button1.Location = new Point(792, 11);
            button1.Name = "button1";
            button1.Size = new Size(36, 37);
            button1.TabIndex = 21;
            button1.UseVisualStyleBackColor = false;
            // 
            // openFileDialog1
            // 
            openFileDialog1.FileName = "openFileDialog1";
            // 
            // browseControl1
            // 
            browseControl1.Location = new Point(309, 65);
            browseControl1.Name = "browseControl1";
            browseControl1.Size = new Size(839, 697);
            browseControl1.TabIndex = 18;
            // 
            // hostControl1
            // 
            hostControl1.BackgroundImage = (Image)resources.GetObject("hostControl1.BackgroundImage");
            hostControl1.Location = new Point(309, 65);
            hostControl1.Name = "hostControl1";
            hostControl1.Size = new Size(839, 697);
            hostControl1.TabIndex = 19;
            // 
            // flowLayoutPanel1
            // 
            flowLayoutPanel1.AutoScroll = true;
            flowLayoutPanel1.BorderStyle = BorderStyle.FixedSingle;
            flowLayoutPanel1.Controls.Add(button4);
            flowLayoutPanel1.Location = new Point(-1, -1);
            flowLayoutPanel1.Name = "flowLayoutPanel1";
            flowLayoutPanel1.Size = new Size(698, 65);
            flowLayoutPanel1.TabIndex = 21;
            // 
            // button4
            // 
            button4.BackgroundImage = (Image)resources.GetObject("button4.BackgroundImage");
            button4.BackgroundImageLayout = ImageLayout.None;
            button4.Cursor = Cursors.Hand;
            button4.FlatAppearance.BorderSize = 0;
            button4.FlatStyle = FlatStyle.Flat;
            button4.Location = new Point(3, 3);
            button4.Name = "button4";
            button4.Size = new Size(690, 57);
            button4.TabIndex = 0;
            button4.UseVisualStyleBackColor = true;
            // 
            // HomeForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            BackgroundImageLayout = ImageLayout.Stretch;
            CausesValidation = false;
            ClientSize = new Size(1150, 762);
            ControlBox = false;
            Controls.Add(browseControl1);
            Controls.Add(panel11);
            Controls.Add(panel1);
            Controls.Add(hostControl1);
            DoubleBuffered = true;
            FormBorderStyle = FormBorderStyle.None;
            MaximizeBox = false;
            MdiChildrenMinimizedAnchorBottom = false;
            MinimizeBox = false;
            Name = "HomeForm";
            ShowIcon = false;
            SizeGripStyle = SizeGripStyle.Show;
            StartPosition = FormStartPosition.CenterScreen;
            Text = "HousePets Haven";
            MouseDown += HomeForm_MouseDown;
            panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            panel11.ResumeLayout(false);
            flowLayoutPanel1.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private Button LogOutButton;
        private Button MinButton;
        private Button ExitButton;
        private Panel panel1;
        private Button BrowseButton;
        private PictureBox pictureBox1;
        private Panel SidePanel;
        private Button FavoritesButton;
        private Button HostButton;
        private Button ChatButton;
        private Panel panel11;
        private OpenFileDialog openFileDialog1;
        private BrowseControl browseControl1;
        private HostControl hostControl1;
        private Button button1;
        private Button button3;
        private Button button2;
        private FlowLayoutPanel flowLayoutPanel1;
        private Button button4;
    }
}