using System.Reflection;

namespace MenuKullanimi
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
        }

        private void toolStripButton1_Click(object sender, EventArgs e)
        {
        }

        private void richTextBox1_TextChanged(object sender, EventArgs e)
        {
            lblKarakterUzunlugu.Text = richTextBox1.TextLength.ToString();
            notifyIcon1.BalloonTipTitle = "Yeni Bildirim";
            notifyIcon1.BalloonTipText = "Bildirim geldi";
            notifyIcon1.BalloonTipIcon = ToolTipIcon.Info;
            notifyIcon1.ShowBalloonTip(30000);
        }

        private void richTextBox1_KeyDown(object sender, KeyEventArgs e)
        {
            if (Console.NumberLock == true)
            {
                lblNumLock.Text = "NumLock Açýk";
                lblNumLock.ForeColor = Color.Blue;
            }
            else
            {
                lblNumLock.Text = "NumLock kapalý";
                lblNumLock.ForeColor = Color.Red;
            }
            if (Console.CapsLock == true)
            {
                lblCapsLock.Text = "CapsLock açýk";
                lblCapsLock.ForeColor = Color.Blue;
            }
            else
            {
                lblCapsLock.Text = "CapsLock kapalý";
                lblCapsLock.ForeColor = Color.Red;
            }
        }
    }
}