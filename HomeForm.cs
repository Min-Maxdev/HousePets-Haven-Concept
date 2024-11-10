using System.Runtime.InteropServices;

namespace HousePets_Airbnb
{
    public partial class HomeForm : Form
    {
        private FrontPageForm frontPage;
        public HomeForm(FrontPageForm form)
        {
            InitializeComponent();
            frontPage = form;

        }

        [DllImport("user32.dll")]
        public static extern bool ReleaseCapture();

        [DllImport("user32.dll")]
        public static extern int SendMessage(IntPtr hWnd, int wMsg, int wParam, int lParam);

        private void HomeForm_MouseDown(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                ReleaseCapture();
                SendMessage(Handle, 0xA1, 0x2, 0);
            }
        }

        private void LogOutButton_Click(object sender, EventArgs e)
        {
            frontPage.Show();
            Close();
        }

        private void MinButton_Click(object sender, EventArgs e)
        {
            WindowState = FormWindowState.Minimized;
        }

        private void ExitButton_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void BrowseButton_Click(object sender, EventArgs e)
        {
            SidePanel.Location = new Point(0,BrowseButton.Location.Y);
        }

        private void FavoritesButton_Click(object sender, EventArgs e)
        {
            SidePanel.Location = new Point(0, FavoritesButton.Location.Y);
        }

        private void ChatButton_Click(object sender, EventArgs e)
        {
            SidePanel.Location = new Point(0, ChatButton.Location.Y);
        }

        //Pet Sit
        private void PetSitButton_Click(object sender, EventArgs e)
        {
            SidePanel.Location = new Point(0, PetSitButton.Location.Y);
        }

        private void createPetSit()
        {
            
        }

        //Favorites

    }
}
