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
                lblMesaj.Text = "Stok Durumu ve Tarih S�ras� se�iniz.";
                // Algoritma 1 - 2
            }
            else if (cmbStokDurumu.SelectedIndex == -1)
            {
                lblMesaj.Text = "Stok Durumunu se�iniz.";
                // Algoritma 1 - 3
            }
            else if (cmbTarihSirasi.SelectedIndex == -1)
            {
                lblMesaj.Text = "Tarih S�ras�n� se�iniz.";
                // Algoritma 1 - 4
            }
            else if (lbKategoriler.SelectedIndex == -1)
            {
                lblMesaj.Text = "Kategori se�iniz.";
            }
            else
            {
                // Algoritma 1 - 5
                switch (lbKategoriler.SelectedIndex)
                {
                    case 0:
                        // Sadece stokta bulunan �r�nler eklenir.
                        // Algoritma 2 - 2
                        lbUrunler.Items.Add("MSDN Tv Visual C# 5");
                        lbUrunler.Items.Add("MSDN Tv Visual C# 4");

                        // Stokta bulunan veya bulunmayan �r�nlerin Hepsi
                        // se�iliyse, kalan �r�nler de listeye eklenir.
                        // Algoritma 2 - 3
                        if (cmbStokDurumu.SelectedIndex == 1)
                        {
                            // Algoritma 2 - 4
                            lbUrunler.Items.Add("MSDN Tv Visual C#");
                            lbUrunler.Items.Add("MSDN Tv Visual C# 2");
                            lbUrunler.Items.Add("MSDN Tv Visual C# 3");
                        }

                        // Eski �r�nlerin g�sterilmesi istenmiyorsa
                        // listeden ��kart�l�r.
                        // Algoritma 2 - 5
                        if (cmbTarihSirasi.SelectedIndex == 0)
                        {
                            // Algoritma 2 - 6
                            lbUrunler.Items.Remove("MSDN Tv Visual C#");
                            lbUrunler.Items.Remove("MSDN Tv Visual C# 2");
                        }
                        break;

                    case 1:
                        lbUrunler.Items.Add("Yaz�l�m Uzmanl��� 1");
                        lbUrunler.Items.Add("Yaz�l�m Uzmanl��� 2");
                        lbUrunler.Items.Add("Yaz�l�m M�hendisli�i Orta D�zey");
                        lbUrunler.Items.Add("Yaz�l�m M�hendisli�i �leri D�zey");

                        if (cmbStokDurumu.SelectedIndex == 1)
                        {
                            lbUrunler.Items.Add("Yaz�l�m M�hendisli�i Ba�lang�� D�zeyi");

                            lbUrunler.Items.Add("Access Giri�");
                        }

                        if (cmbTarihSirasi.SelectedIndex == 0)
                        {
                            lbUrunler.Items.Remove("Yaz�l�m Uzmanl��� 1");
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
                        lblSecilenUrunler.Text = lbKategoriler.Text + " Kategorisindeki �r�nler";
                }
            }
        }
    }
}