using System.Windows.Forms.VisualStyles;

namespace StokUrun
{
    public partial class Form1 : Form
    {
        //Kategoriye göre stoktaki ürünlerin belirlenmesi
        public int StokDurumu(string kategori)
        {
            switch (kategori)
            {
                case "Film":
                    return 1100;
                case "Müzik":
                    return 982;
                case "Bilgisayar":
                    return 302;
                case "Kitap":
                    return 1222;
                default:
                    return 10;
            }
        }
        public Form1()
        {
            InitializeComponent();
        }

        private void chlistKategoriler_SelectedIndexChanged(object sender, EventArgs e)
        {
            int toplam = 0;
            //Listede seçilen ögelerin ürün adeti toplanýr
            for (int i = 0; i <= chlistKategoriler.Items.Count - 1; i++)
            {
                if (chlistKategoriler.GetItemChecked(i))
                {
                    object secilen = null;
                    secilen = chlistKategoriler.Items[i];
                    //Stok durumunu gösteren fonksiyon
                    toplam += StokDurumu((string)secilen);
                }
            }
            ToplamUrun.Text = "Seçilen kategorilerdeki toplam ürün: " + toplam;
        }

        private void btnEkle_Click(object sender, EventArgs e)
        {
            chlistKategoriler.Items.Add(txtKategoriAdý.Text);

        }
    }
}