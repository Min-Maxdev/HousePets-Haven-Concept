namespace HousePets_Airbnb
{
    partial class HostControl
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(HostControl));
            button1 = new Button();
            panel1 = new Panel();
            label2 = new Label();
            label1 = new Label();
            pictureBox1 = new PictureBox();
            panel2 = new Panel();
            label3 = new Label();
            label4 = new Label();
            pictureBox2 = new PictureBox();
            button2 = new Button();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).BeginInit();
            SuspendLayout();
            // 
            // button1
            // 
            button1.BackColor = Color.Lime;
            button1.Cursor = Cursors.Hand;
            button1.ImageAlign = ContentAlignment.TopCenter;
            button1.Location = new Point(0, 0);
            button1.Name = "button1";
            button1.Size = new Size(257, 331);
            button1.TabIndex = 1;
            button1.UseVisualStyleBackColor = false;
            // 
            // panel1
            // 
            panel1.Controls.Add(label2);
            panel1.Controls.Add(label1);
            panel1.Controls.Add(pictureBox1);
            panel1.Controls.Add(button1);
            panel1.Location = new Point(120, 147);
            panel1.Name = "panel1";
            panel1.Size = new Size(258, 332);
            panel1.TabIndex = 2;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.BackColor = Color.Lime;
            label2.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label2.Location = new Point(48, 267);
            label2.Name = "label2";
            label2.Size = new Size(166, 21);
            label2.TabIndex = 4;
            label2.Text = "a new hosting location";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = Color.Lime;
            label1.Font = new Font("Segoe UI", 24F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.Location = new Point(70, 210);
            label1.Name = "label1";
            label1.Size = new Size(116, 45);
            label1.TabIndex = 3;
            label1.Text = "Create";
            // 
            // pictureBox1
            // 
            pictureBox1.BackColor = Color.Lime;
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(48, 43);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(166, 148);
            pictureBox1.TabIndex = 2;
            pictureBox1.TabStop = false;
            // 
            // panel2
            // 
            panel2.Controls.Add(label3);
            panel2.Controls.Add(label4);
            panel2.Controls.Add(pictureBox2);
            panel2.Controls.Add(button2);
            panel2.Location = new Point(469, 147);
            panel2.Name = "panel2";
            panel2.Size = new Size(258, 332);
            panel2.TabIndex = 5;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.BackColor = Color.RoyalBlue;
            label3.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label3.Location = new Point(61, 267);
            label3.Name = "label3";
            label3.Size = new Size(143, 21);
            label3.TabIndex = 4;
            label3.Text = "an existing location";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.BackColor = Color.RoyalBlue;
            label4.Font = new Font("Segoe UI", 24F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label4.Location = new Point(63, 210);
            label4.Name = "label4";
            label4.Size = new Size(141, 45);
            label4.TabIndex = 3;
            label4.Text = "Manage";
            // 
            // pictureBox2
            // 
            pictureBox2.BackColor = Color.RoyalBlue;
            pictureBox2.Image = (Image)resources.GetObject("pictureBox2.Image");
            pictureBox2.Location = new Point(48, 43);
            pictureBox2.Name = "pictureBox2";
            pictureBox2.Size = new Size(166, 148);
            pictureBox2.TabIndex = 2;
            pictureBox2.TabStop = false;
            // 
            // button2
            // 
            button2.BackColor = Color.RoyalBlue;
            button2.Cursor = Cursors.Hand;
            button2.ImageAlign = ContentAlignment.TopCenter;
            button2.Location = new Point(0, 0);
            button2.Name = "button2";
            button2.Size = new Size(257, 331);
            button2.TabIndex = 1;
            button2.UseVisualStyleBackColor = false;
            // 
            // HostControl
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = (Image)resources.GetObject("$this.BackgroundImage");
            Controls.Add(panel2);
            Controls.Add(panel1);
            Name = "HostControl";
            Size = new Size(839, 697);
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Button button1;
        private Panel panel1;
        private Label label2;
        private Label label1;
        private PictureBox pictureBox1;
        private Panel panel2;
        private Label label3;
        private Label label4;
        private PictureBox pictureBox2;
        private Button button2;
    }
}
