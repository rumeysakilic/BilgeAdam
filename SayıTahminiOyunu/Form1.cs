using System.Windows.Forms;

namespace SayıTahminiOyunu
{
    public partial class Form1 : Form
    {
        private int bulunacakSayi;

        public int DortHaneliSayi()
        {
            Random r = new Random();
            int sayi = r.Next(10000);
            //Sayı 4 haneli olana kadar tekrar uretlir
            while (sayi < 1000)
            {
                sayi = r.Next(10000);
            }
            return sayi;
        }

        public bool SayiKontrol(int sayi)
        {
            char[] rakamlar = sayi.ToString().ToCharArray();
            //Rakamlar tek tek birbiriyle kontrol edilir
            //Tekrarlanan rakam varsa False döner
            for (int i = 0; i < rakamlar.Length - 2; i++)
            {
                for (int j = 0; j <= rakamlar.Length - 1; j++)
                {
                    if (rakamlar[i] == rakamlar[j])
                    {
                        return false;
                    }
                }
            }
            return true;
        }

        public int SayiUret()
        {
            int sayi = DortHaneliSayi();
            //Sayıdaki rakamlar tekrar edilirse
            if (DomainUpDown1.SelectedIndex == 1)
            {
                return sayi;
            }
            //Sayının rakamları birbirinden farklı
            //olana kadar sayı uretilir
            while (!(SayiKontrol(sayi)))
            {
                sayi = DortHaneliSayi();
            }
            return sayi;
        }

        public Form1()
        {
            InitializeComponent();
        }

        private void YeniOyun_Click(object sender, EventArgs e)
        {
            bulunacakSayi = SayiUret();
            lblMesaj.Text = "Yeni Oyun! Sayı üretildi...";
        }

        private void txtTahmin_Validating(object sender, System.ComponentModel.CancelEventArgs e)
        {
            if (txtTahmin.Text.Length == 4)
            {
                errorProvider1.SetError(txtTahmin, "");
            }
            else
            {
                errorProvider1.SetError(txtTahmin, "Sayı yanlış girildi");
                e.Cancel = true;
            }
        }

        public string TahminKontrol(int sayi)
        {
            string sonuc = "";
            //Sonuc kümesindeki artı ve eksi sayısı
            byte arti = 0;
            byte eksi = 0;
            byte i, j;
            char[] sdizi;
            sdizi = sayi.ToString().ToCharArray();
            char[] sBulunacak;
            sBulunacak = sayi.ToString().ToCharArray();
            //Yerleri tutan sayılar bulunur
            for (i = 0; i <= 3; i++)
            {
                if (sdizi[i] == sBulunacak[i])
                {
                    arti += 1;
                }
            }
            //Yerleri tutmayan sayıların kontrolü
            for (i = 0; i <= 3; i++)
            {
                for (j = 0; j <= 3; j++)
                {
                    if (i != j)
                    {
                        if (sdizi[i] == sBulunacak[j])
                        {
                            eksi += 1;
                            break;
                        }
                    }
                }
            }
            if (arti == 0 & eksi == 0)
            {
                sonuc = "0";
            }
            else if (arti == 4)
            {
                sonuc = "Tebrikler";
            }
            else if (arti != 0 && eksi != 0)
            {
                sonuc = "+" + arti + "-" + eksi;
            }
            else if (arti == 0)
            {
                sonuc = "-" + eksi;
            }
            return sonuc;
        }

        private void btnTahminEt_Click(object sender, EventArgs e)
        {
            ListBox1.Items.Add(TahminKontrol(int.Parse(txtTahmin.Text)));
        }
    }
}