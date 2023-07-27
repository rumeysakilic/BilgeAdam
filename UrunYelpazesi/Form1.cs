namespace UrunYelpazesi
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnListele_Click(object sender, EventArgs e)
        {
            lblMesaj.Text = "";
            lbUrunler.Items.Clear();
            // Algoritma 1 - 1
            if (cmbStokDurumu.SelectedIndex == -1 && cmbTarihSirasi.SelectedIndex == -1)
            {
                lblMesaj.Text = "Stok Durumu ve Tarih Sýrasý seçiniz.";
                // Algoritma 1 - 2
            }
            else if (cmbStokDurumu.SelectedIndex == -1)
            {
                lblMesaj.Text = "Stok Durumunu seçiniz.";
                // Algoritma 1 - 3
            }
            else if (cmbTarihSirasi.SelectedIndex == -1)
            {
                lblMesaj.Text = "Tarih Sýrasýný seçiniz.";
                // Algoritma 1 - 4
            }
            else if (lbKategoriler.SelectedIndex == -1)
            {
                lblMesaj.Text = "Kategori seçiniz.";
            }
            else
            {
                // Algoritma 1 - 5
                switch (lbKategoriler.SelectedIndex)
                {
                    case 0:
                        // Sadece stokta bulunan ürünler eklenir.
                        // Algoritma 2 - 2
                        lbUrunler.Items.Add("MSDN Tv Visual C# 5");
                        lbUrunler.Items.Add("MSDN Tv Visual C# 4");

                        // Stokta bulunan veya bulunmayan ürünlerin Hepsi
                        // seçiliyse, kalan ürünler de listeye eklenir.
                        // Algoritma 2 - 3
                        if (cmbStokDurumu.SelectedIndex == 1)
                        {
                            // Algoritma 2 - 4
                            lbUrunler.Items.Add("MSDN Tv Visual C#");
                            lbUrunler.Items.Add("MSDN Tv Visual C# 2");
                            lbUrunler.Items.Add("MSDN Tv Visual C# 3");
                        }

                        // Eski ürünlerin gösterilmesi istenmiyorsa
                        // listeden çýkartýlýr.
                        // Algoritma 2 - 5
                        if (cmbTarihSirasi.SelectedIndex == 0)
                        {
                            // Algoritma 2 - 6
                            lbUrunler.Items.Remove("MSDN Tv Visual C#");
                            lbUrunler.Items.Remove("MSDN Tv Visual C# 2");
                        }
                        break;

                    case 1:
                        lbUrunler.Items.Add("Yazýlým Uzmanlýðý 1");
                        lbUrunler.Items.Add("Yazýlým Uzmanlýðý 2");
                        lbUrunler.Items.Add("Yazýlým Mühendisliði Orta Düzey");
                        lbUrunler.Items.Add("Yazýlým Mühendisliði Ýleri Düzey");

                        if (cmbStokDurumu.SelectedIndex == 1)
                        {
                            lbUrunler.Items.Add("Yazýlým Mühendisliði Baþlangýç Düzeyi");

                            lbUrunler.Items.Add("Access Giriþ");
                        }

                        if (cmbTarihSirasi.SelectedIndex == 0)
                        {
                            lbUrunler.Items.Remove("Yazýlým Uzmanlýðý 1");
                        }
                        break;

                    case 2:
                        lbUrunler.Items.Add("Visual Studio 6.0");
                        lbUrunler.Items.Add("Visual C# .NET Standard 2003");
                        lbUrunler.Items.Add("Visual C# C# Standard 2003");

                        if (cmbStokDurumu.SelectedIndex == 1)
                        {
                            lbUrunler.Items.Add("Visual Studio .NET 2005");
                        }

                        if (cmbTarihSirasi.SelectedIndex == 0)
                        {
                            lbUrunler.Items.Remove("Visual Studio 6.0");
                        }
                        break;
                        // Algoritma 1 - 6
                        lblSecilenUrunler.Text = lbKategoriler.Text + " Kategorisindeki Ürünler";
                }
            }
        }
    }
}