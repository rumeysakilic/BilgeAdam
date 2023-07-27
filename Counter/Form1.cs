namespace Counter
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

        private void btnBasla_Click(object sender, EventArgs e)
        {
            // Sayaç 2 saniyede bir çalýþacak
            timer1.Interval = 2000;
            timer1.Start();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            MessageBox.Show("Sayaç çalýþýyor...");
        }

        private void btnDur_Click(object sender, EventArgs e)
        {
            timer1.Stop();
            MessageBox.Show("Sayaç dururuluyor...");
        }
    }
}