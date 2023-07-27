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

        // Timer kontrol�nde kullan�lacak s�re
        public int kalanSure = 5;

        // Bilinen kelime say�s�
        public int tekrar = 0;

        //Temizle yordam�
        public void Temizle()
        {
            kalanSure = 5;
            textBox1.Text = "";
            textBox1.Focus();
        }

        //OyunuBaslat yordam�
        public void OyunuBaslat()
        {
            Temizle();
            kelime = textBox1.Text;

            tmrSure.Start();

            SonrakiKelimeBilgi();
        }

        //OyunuBitir yordam�
        public void OyunuBitir(string neden)
        {
            tmrSure.Stop();
            Bilgi(neden);

            Temizle();

            int puan;
            puan = PuanHesapla(OyunSeviyesi,
           System.Convert.ToInt16(tekrar));
            MessageBox.Show("Puan�n�z: " + puan);
        }

        //Bilgi yordam�
        public void Bilgi(string kelime)
        {
            lblMesaj.Text = kelime;
        }

        // SonrakiKelimeBilgi yordam�
        public void SonrakiKelimeBilgi()
        {
            string mesaj = null;
            mesaj += Microsoft.VisualBasic.Strings.Right(kelime, OyunSeviyesi);
            mesaj += " ile ba�layan bir kelime girin";

            Bilgi(mesaj);
        }

        //SeviyeAtla yordam�
        public void SeviyeAtla(byte seviye)
        {
            OyunSeviyesi = seviye;

            OyunuBitir(seviye + ". seviyeye ge�ildi");
            SonrakiKelimeBilgi();
        }

        //Kontrol fonksiyonu
        public bool Kontrol(string kelime1, string kelime2
)
        {
            // �kinci kelimenin ba��nda oyun seviyesi kadar
            // karakter al�n�r.
            string bas = kelime2.Substring(0, OyunSeviyesi);
            // �kinci kelime, ilk kelimenin sonu ile ba�l�yorsa
            // do�ru girilmi�tir. True de�eri d�ner.
            return kelime1.EndsWith(bas);
        }

        //Puan Hesapla yordam�
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
                neden += OyunSeviyesi + " harfi ile ba�lamyor";

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
                OyunuBitir("S�reniz doldu");
            }
            else
            {
                kalanSure -= 1;
            }
        }
    }
}