using System.Runtime.InteropServices;

namespace HousePets_Airbnb
{
    public partial class FrontPageForm : Form
    {
        public FrontPageForm()
        {
            InitializeComponent();
            ErrorLabel.Visible = false;
            Accounts.addAccount("admin", "pass");
        }

        // Importing user32.dll for drag function
        [DllImport("user32.dll")]
        public static extern bool ReleaseCapture();

        [DllImport("user32.dll")]
        public static extern int SendMessage(IntPtr hWnd, int wMsg, int wParam, int lParam);

        //drags the form when held
        private void FrontPageForm_MouseDown(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                ReleaseCapture();
                SendMessage(Handle, 0xA1, 0x2, 0);
            }
        }

        private void SignUpButton_Click_1(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(UserTextBox.Text) && string.IsNullOrEmpty(PassTextBox.Text))
            {
                ErrorLabel.ForeColor = Color.Red;
                ErrorLabel.Text = "Invalid Username or Password";
                ErrorLabel.Visible = true;
            }
            else if (!Accounts.addAccount(UserTextBox.Text, PassTextBox.Text))
            {
                ErrorLabel.ForeColor = Color.Red;
                ErrorLabel.Text = "Username Already Exist";
                ErrorLabel.Visible = true;
            }
            else
            {
                ErrorLabel.ForeColor = Color.Green;
                ErrorLabel.Text = "Signed-Up Successfully";
                ErrorLabel.Visible = true;
            }
        }

        private void LogInButton_Click_1(object sender, EventArgs e)
        {
            if (!Accounts.verify(UserTextBox.Text, PassTextBox.Text))
            {
                ErrorLabel.ForeColor = Color.Red;
                ErrorLabel.Text = "Invalid Username or Password";
                ErrorLabel.Visible = true;
            }
            else
            {
                ErrorLabel.ForeColor = Color.Green;
                ErrorLabel.Text = "Logged-In Successfully";
                ErrorLabel.Visible = true;
            }
        }

        private void UserTextBox_Click(object sender, EventArgs e)
        {
            ErrorLabel.Visible = false;
        }

        private void MinButton_Click(object sender, EventArgs e)
        {
            WindowState = FormWindowState.Minimized;
        }

        private void ExitButton_Click(Object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
