using Microsoft.VisualBasic;

namespace ŞifrelemeAlgoritması
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnSifrele_Click(object sender, EventArgs e)
        {
            string yazi = null;

            // Algoritma 1 - 1
            do
            {
                yazi = txtSifrelenecekYazi.Text;
            }
            while (!(yazi.Length > 0));
            // Algoritma 1 - 2
            char[] karakterler = yazi.ToCharArray();

            int uzunluk = karakterler.Length - 1;
            string[] kodlar = new string[uzunluk + 1];

            int i;
            // kelimedeki her karakterin ASCII kodu alınır
            for (i = 0; i <= uzunluk; i++)
            {
                // Algoritma 1 - 3
                kodlar[i] = (Microsoft.VisualBasic.Strings.Asc(karakterler[i])).ToString();
            }
            string SiraliKodlar = null;
            short j = 0;
            while (j <= kodlar.Length - 1)
            {
                j += 1;
                // Alogritma 2 - 1
                string AsciiKodu = kodlar[j]; byte eklenecek = System.Convert.ToByte(4 - AsciiKodu.Length);
                for (i = 0; i <= eklenecek - 1; i++)
                {
                    // Alogritma 2 - 3
                    AsciiKodu = AsciiKodu.Insert(0, "0");
                }
                // Alogritma 2 - 4
                SiraliKodlar += AsciiKodu;
                j += 1;
            }
            // Algoritma 3 - 1
            j = 0;
            string Sifre = null;
            // Algoritma 3 - 2
            while (j < SiraliKodlar.Length / 2)
            {
                j += 1;
            }
            //Algoritma 3 - 3
            Sifre += Strings.Mid(SiraliKodlar, j + 1, 1);
            // Algoritma 3 - 3
            Sifre += Strings.Mid(SiraliKodlar, j + 1, 1);
            // Algoritma 3 - 4
            Sifre += SiraliKodlar.Substring(SiraliKodlar.Length - j - 1, 1);
        }
    }
}