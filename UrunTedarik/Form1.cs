namespace UrunTedarik
{
    public partial class Form1 : Form
    {
        public struct Urun
        {
            public string ismi;
            public double fiyat;

            public Urun(String urunIsmi, double urunFiyat)
            {
                ismi = urunIsmi;
                fiyat = urunFiyat;
            }

            public override string ToString()
            {
                return string.Format("{0} - {1:C}", ismi, fiyat);
            }
        }

        public void UrunEkle()
        {
            Urun u = new Urun();

            u = new Urun("Kalem", 1.49);
            lbTedarikci.Items.Add(u);
            u = new Urun("Silgi", 0.39);
            lbTedarikci.Items.Add(u);
            u = new Urun("Defter", 4.99);
            lbTedarikci.Items.Add(u);
            u = new Urun("Cetvel", 1.99);
            lbTedarikci.Items.Add(u);
            u = new Urun("Pergel", 2.99);
            lbTedarikci.Items.Add(u);
            u = new Urun("Not Defteri", 3.79);
            lbTedarikci.Items.Add(u);
        }

        public Form1()
        {
            InitializeComponent();
        }

        private void label2_Click(object sender, EventArgs e)
        {
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            lbTedarikci.SelectionMode = SelectionMode.MultiExtended;
            lbStok.SelectionMode = SelectionMode.MultiExtended;

            UrunEkle();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            // Tedarikçiden alýnan ürünler stok listesine eklenir
            foreach (object item in lbTedarikci.SelectedItems)
            {
                lbStok.Items.Add(item);
            }
            // Stok listesine eklenen tüm ürünler
            // tedarikçi listesinden çýkartýlýr
            foreach (object item in lbStok.Items)
            {
                lbTedarikci.Items.Remove(item);
            }
            btnCikar.Enabled = true;
            btnHesapla.Enabled = true;
        }

        private void btnCikar_Click(object sender, EventArgs e)
        {
            // Tedarikçiden alýnan ürünler stok listesine eklenir
            foreach (object item in lbStok.SelectedItems)
            {
                lbTedarikci.Items.Add(item);
                // Stok listesine eklenen tüm ürünler
                // tedarikçi listesinden çýkartýlýr
                foreach (object items in lbTedarikci.Items)
                {
                    lbStok.Items.Remove(item);
                }

                if (lbStok.Items.Count == 0)
                {
                    btnCikar.Enabled = false;
                    btnHesapla.Enabled = false;
                }
            }
        }

        private void btnHesapla_Click(object sender, EventArgs e)
        {
            double toplam = 0;

            for (int i = 0; i <= lbStok.Items.Count - 1; i++)
            {
                Urun urun = ((Form1.Urun)(lbStok.Items[i]));
                toplam += urun.fiyat;
            }
            txtToplam.Text = System.Convert.ToString(toplam);
        }

        private void lbStok_SelectedIndexChanged(object sender, EventArgs e)
        {
            Urun secilen = new Form1.Urun();
            secilen = ((Urun)(lbStok.SelectedItem));

            lblUrunFiyat.Text = string.Format("{0:C}", secilen.fiyat);
        }
    }
}