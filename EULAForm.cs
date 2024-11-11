using System.Runtime.InteropServices;

namespace HousePets_Airbnb
{
    public partial class EULAForm : Form
    {
        public HomeForm homeform;

        public EULAForm(HomeForm form)
        {
            InitializeComponent();
            homeform = form;
        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            Hide();
            homeform.ShowDialog();
        }


        [DllImport("user32.dll")]
        public static extern bool ReleaseCapture();

        [DllImport("user32.dll")]
        public static extern int SendMessage(IntPtr hWnd, int wMsg, int wParam, int lParam);

        private void EULAForm_MouseDown(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                ReleaseCapture();
                SendMessage(Handle, 0xA1, 0x2, 0);
            }
        }
    }
}
