using Microsoft.VisualBasic;

namespace StructOgrenci
{
    public partial class Form1 : Form
    {
        public struct Ogrenci
        {
            public string Isim;
            public string Soyad;
            public char Sube;
            public float OrtalamaNotu;
            public bool DevamEdiyor;
        }

        public Ogrenci[] ogrenciler = new Ogrenci[2];

        public Form1()
        {
            InitializeComponent();
        }

        public void Form1_Load(object sender, EventArgs e)
        {
            Ogrenci ogrenci1 = new Ogrenci();

            ogrenci1.Isim = "Ali";
            ogrenci1.Soyad = "Topal";
            ogrenci1.Sube = 'C';
            ogrenci1.OrtalamaNotu = 67.1f;
            ogrenci1.DevamEdiyor = true;

            Ogrenci ogrenci2 = new Ogrenci();

            ogrenci2.Isim = "Ahmet";
            ogrenci2.Soyad = "Soydan";
            ogrenci2.Sube = 'C';
            ogrenci2.OrtalamaNotu = 72.9f;
            ogrenci2.DevamEdiyor = true;

            ogrenciler[0] = ogrenci1;
            ogrenciler[1] = ogrenci2;
        }

        private void btnOgrenciEkle_Click(object sender, EventArgs e)
        {
            // ogrenciler dizisinde boþ yer kalmadýðý için
            // diziyi, eski deðerleri kaybetmeden tekrar
            // boyutlandýrmak gerekir.
            Ogrenci[] gecici = new Ogrenci[3];
            System.Array.Copy(ogrenciler, gecici, 2);
            ogrenciler = gecici;

            Ogrenci ogrenci = new Ogrenci();

            ogrenci.Isim = "Veli";
            ogrenci.Soyad = "Kýnýk";
            ogrenci.Sube = 'D';
            ogrenci.OrtalamaNotu = 92.1f;
            ogrenci.DevamEdiyor = false;

            ogrenciler[2] = ogrenci;

            MessageBox.Show("Kayýt Eklendi....");
            textBox1.Text = ogrenciler[0].Isim + ogrenciler[0].Soyad
                + ogrenciler[1].Isim + ogrenciler[1].Soyad
                + ogrenciler[2].Isim + ogrenciler[2].Soyad;
        }

        private void btnOzellikleriGoruntule_Click(object sender, EventArgs e)
        {
            int indis = Int32.Parse(textBox2.Text);
            Ogrenci secilenOgrenci = new Ogrenci();
            secilenOgrenci = (Ogrenci)ogrenciler[indis];

            string bilgiler = null;

            bilgiler += secilenOgrenci.Isim + " " + secilenOgrenci.Soyad;
            bilgiler += "\n";
            bilgiler += "Notu: " + secilenOgrenci.OrtalamaNotu + "\n";
            bilgiler += "Þubesi: " + secilenOgrenci.Sube + "\n";
            bilgiler += "Devam ediyor mu: " + secilenOgrenci.DevamEdiyor;

            MessageBox.Show(bilgiler, "Öðrenci Bilgileri", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void btnOrtalamaHesapla_Click(object sender, EventArgs e)
        {
            double not1 = ogrenciler[0].OrtalamaNotu;
            double not2 = ogrenciler[1].OrtalamaNotu;
            double not3 = ogrenciler[2].OrtalamaNotu;

            int ortalama = ((int)((not1 + not2 + not3) / 3));
            MessageBox.Show(ortalama.ToString());
        }
    }
}