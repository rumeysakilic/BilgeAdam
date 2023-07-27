namespace Alarm
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            nYil.Minimum = 1;
            nAy.Minimum = 1;
            nGun.Minimum = 1;
            nSaat.Minimum = 0;
            nDakika.Minimum = 0;

            nYil.Maximum = 2099;
            nAy.Maximum = 12;
            nGun.Maximum = 31;
            nSaat.Maximum = 23;
            nDakika.Maximum = 59;

            nYil.Value = DateTime.Now.Year;
            nAy.Value = DateTime.Now.Month;
            nGun.Value = DateTime.Now.Day;
            nSaat.Value = DateTime.Now.Hour;
            nDakika.Value = DateTime.Now.Minute;
        }

        private void nGun_ValueChanged(object sender, EventArgs e)
        {
            string tarih;
            tarih = nGun.Value + "." + nAy.Value + "." + nYil.Value;
            if (DateTime.TryParse(tarih, out DateTime result))
            {
                MessageBox.Show(tarih);
            }
            string zaman;
            zaman = nSaat.Value + ":" + nDakika.Value;
            if (DateTime.TryParse(tarih, out DateTime result1))
            {
                MessageBox.Show(zaman);
            }
        }
    }
}