namespace Ogrenci
{
    public partial class Form1 : Form
    {
        public struct Ogrenci
        {
            public string ad;
            public string soyad;

            public Ogrenci(string adi, string soyadi)
            {
                this.ad = adi;
                this.soyad = soyadi;
            }
        }

        public Form1()
        {
            InitializeComponent();
        }

        public void Goruntule(Ogrenci ogr)
        {
            MessageBox.Show(ogr.ad + " " + ogr.soyad);
        }

        public void Test2()
        {
            // 1 - ��renci de�eri tan�mland��� s�rada
            // stack alan�nda yer ayr�l�r
            Ogrenci Ali = new Ogrenci();
            // 2 - New ile tan�mlanan de�i�kenler de stack
            // alan�nda olu�turulur.
            // Fark�, bu de�i�kenin ba�lang�� de�eri almas�d�r.
            Ogrenci Veli = new Ogrenci("Veli", "Mehmet");
            // 3 - Parametre olarak sipari� nesnesinin
            // adresi verilir
            Goruntule(Veli);
        }
    }
}