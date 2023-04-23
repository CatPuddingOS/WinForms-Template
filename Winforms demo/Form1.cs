using System.Runtime.InteropServices;

namespace Winforms_demo
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            // b_DarkMode.Image = imageList1.Images[0];
        }
        public const int WM_NCLBUTTONDOWN = 0xA1;
        public const int HT_CAPTION = 0x2;

        [DllImportAttribute("user32.dll")]
        public static extern int SendMessage(IntPtr hWnd, int Msg, int wParam, int lParam);
        [DllImportAttribute("user32.dll")]
        public static extern bool ReleaseCapture();

        private void MovementPanel_top_MouseDown(object sender, System.Windows.Forms.MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                ReleaseCapture();
                SendMessage(Handle, WM_NCLBUTTONDOWN, HT_CAPTION, 0);
            }
        }

        private void b_quit_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        private void b_quit_MouseEnter(object sender, EventArgs e)
        {
            b_quit.BackColor = Color.FromArgb(24, 30, 54);
        }

        private void b_DarkMode_Click(object sender, EventArgs e)
        {

        }
    }
}