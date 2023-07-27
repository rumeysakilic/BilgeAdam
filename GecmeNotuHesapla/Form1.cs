namespace GecmeNotuHesapla
{
    public partial class Form1 : Form
    {
        public float NotHesapla(int final, float vizeKatsayisi, params int[] vizeler)
        {
            int vizeToplam = 0;
            double vizeOrtalama = 0.0;
            int i;
            for (i = 0; i < vizeler.Length - 1; i++)
            {
                vizeToplam = vizeler[i];
            }
            if (i > 0)
            {
                vizeOrtalama = vizeToplam / i;
            }
            float finalKatSayisi = 1 - vizeKatsayisi;
            return finalKatSayisi * final + vizeKatsayisi * (float)vizeOrtalama;
        }

        public Form1()
        {
            InitializeComponent();
        }

        private void label2_Click(object sender, EventArgs e)
        {
        }

        private void button1_Click(object sender, EventArgs e)
        {
            float gecmeNotu = NotHesapla(72, 0.6f, 45, 87);
            label2.Text = Convert.ToString(gecmeNotu);
            MessageBox.Show(Convert.ToString(gecmeNotu));
        }
    }
}