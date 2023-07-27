namespace YasOrtalamasiBul
{
    public partial class Form1 : Form
    {
        public void YasOrtalamasi(string sinif, params byte[] Yaslar)
        {
            int toplam = 0;
            double ortalama = 0.0;

            int i;
            for (i = 0; i <= Yaslar.Length - 1; i++)
            {
                toplam += Yaslar[i];
            }

            // Parametre verilmezse i = 0 olur
            if (i > 0)
            {
                ortalama = toplam / i;
            }
            MessageBox.Show(sinif + " s�n�f�n�n ya� ortalamas�: " + ortalama);
        }

        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
        }

        private void button1_Click(object sender, EventArgs e)
        {
            // �lk parametre verildikten sonra,
            // istenen say�da parametre verilebilir
            YasOrtalamasi("YU6112", 45, 14, 25, 28);
            // Ya�lar parametre olarak verilmeyebilir
            YasOrtalamasi("YU6112");
        }
    }
}