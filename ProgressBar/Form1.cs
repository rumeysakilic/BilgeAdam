namespace ProgressBar
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {
            checkBox1.Checked = true;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Durum frmDurum = new Durum();
            frmDurum.timer1.Interval ( Convert.ToInt32(textBox1.Text));

            if (checkBox1.Checked)
            {
                frmDurum.ShowDialog();

            }
        }
    }
}