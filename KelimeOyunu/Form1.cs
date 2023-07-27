using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace KelimeOyunu
{
    public partial class oyun : Form
    {
        // Kontrol edilecek kelime
        public string kelime;

        // Oyunun seviyesi
        public byte OyunSeviyesi = 1;

        // Timer kontrolünde kullanýlacak süre
        public int kalanSure = 5;

        // Bilinen kelime sayýsý
        public int tekrar = 0;

        //Temizle yordamý
        public void Temizle()
        {
            kalanSure = 5;
            textBox1.Text = "";
            textBox1.Focus();
        }

        //OyunuBaslat yordamý
        public void OyunuBaslat()
        {
            Temizle();
            kelime = textBox1.Text;

            tmrSure.Start();

            SonrakiKelimeBilgi();
        }

        //OyunuBitir yordamý
        public void OyunuBitir(string neden)
        {
            tmrSure.Stop();
            Bilgi(neden);

            Temizle();

            int puan;
            puan = PuanHesapla(OyunSeviyesi,
           System.Convert.ToInt16(tekrar));
            MessageBox.Show("Puanýnýz: " + puan);
        }

        //Bilgi yordamý
        public void Bilgi(string kelime)
        {
            lblMesaj.Text = kelime;
        }

        // SonrakiKelimeBilgi yordamý
        public void SonrakiKelimeBilgi()
        {
            string mesaj = null;
            mesaj += Microsoft.VisualBasic.Strings.Right(kelime, OyunSeviyesi);
            mesaj += " ile baþlayan bir kelime girin";

            Bilgi(mesaj);
        }

        //SeviyeAtla yordamý
        public void SeviyeAtla(byte seviye)
        {
            OyunSeviyesi = seviye;

            OyunuBitir(seviye + ". seviyeye geçildi");
            SonrakiKelimeBilgi();
        }

        //Kontrol fonksiyonu
        public bool Kontrol(string kelime1, string kelime2
)
        {
            // Ýkinci kelimenin baþýnda oyun seviyesi kadar
            // karakter alýnýr.
            string bas = kelime2.Substring(0, OyunSeviyesi);
            // Ýkinci kelime, ilk kelimenin sonu ile baþlýyorsa
            // doðru girilmiþtir. True deðeri döner.
            return kelime1.EndsWith(bas);
        }

        //Puan Hesapla yordamý
        public int PuanHesapla(byte seviye, short tekrar)
        {
            return (int)Math.Pow(tekrar, seviye);
        }

        public oyun()
        {
            InitializeComponent();
        }

        private void btnBasla_Click(object sender, EventArgs e)
        {
            OyunuBaslat();
        }

        private void btnGiris_Click(object sender, EventArgs e)
        {
            string girilen = textBox1.Text;

            if (!(Kontrol(kelime, girilen)))
            {
                string neden = null;
                neden = "Girilen kelime, ilk kelimenin son ";
                neden += OyunSeviyesi + " harfi ile baþlamyor";

                OyunuBitir(neden);
            }
            else if (tekrar > 5 * OyunSeviyesi)
            {
                SeviyeAtla(System.Convert.ToByte(OyunSeviyesi + 1));
            }
            else
            {
                tekrar += 1;
                kelime = girilen;
                SonrakiKelimeBilgi();
                Temizle();
            }
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            if (kalanSure <= 0)
            {
                OyunuBitir("Süreniz doldu");
            }
            else
            {
                kalanSure -= 1;
            }
        }
    }
}