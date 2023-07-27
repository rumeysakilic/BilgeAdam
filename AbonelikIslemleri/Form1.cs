namespace AbonelikIslemleri
{
    public partial class Form1 : Form
    {
        public double toplam;

        public Form1()
        {
            InitializeComponent();
        }

        private void checkBox2_CheckedChanged(object sender, EventArgs e)
        {
        }

        private void Form1_Load(object sender, EventArgs e)
        {
        }

        private void button1_Click(object sender, EventArgs e)
        {
            toplam = Convert.ToInt32(txtAcilisTutari.Text);
            if (cbKDV.Checked)
            {
                toplam *= 1.18;
            }
            if (cbOzelIletisimIlkFatura.Checked)
            {
                toplam += 22;
            }
            if (OzelIletisim.Checked)
            {
                toplam *= 1.25;
            }
            else
            {
                MessageBox.Show("Lütfen bir seçenek seçiniz");
            }
            txtToplam.Text = toplam.ToString();
        }
    }
}