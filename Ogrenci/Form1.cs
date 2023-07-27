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
            // 1 - Öðrenci deðeri tanýmlandýðý sýrada
            // stack alanýnda yer ayrýlýr
            Ogrenci Ali = new Ogrenci();
            // 2 - New ile tanýmlanan deðiþkenler de stack
            // alanýnda oluþturulur.
            // Farký, bu deðiþkenin baþlangýç deðeri almasýdýr.
            Ogrenci Veli = new Ogrenci("Veli", "Mehmet");
            // 3 - Parametre olarak sipariþ nesnesinin
            // adresi verilir
            Goruntule(Veli);
        }
    }
}