namespace Yazılım___Sistem_Zümreleri_Eğitim_Anketleri
{
    public partial class Form1 : Form
    {
        // Ozet bilgilerinin tutulduğu değişken 
        private string AnketOzet;
        // Onaylama düğmesinin aktif hale gelmesi için 
        // tüm oylamaların yapılmış olması gerekir 
        private bool IcerikOyuSecildi, AracOyuSecildi;
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            // Sistem ve yazılım seçeneklerini tutan
            // GroupBox kontrolleri gizlenir: 
            grpSistem.Visible = false;
            grpYazilim.Visible = false;
            // Anketleri tutan Panel kontrolü gizlenir 
            pnlAnket.Visible = false;
            // Onayla düğmesi oylamadan önce
            // Onayla düğmesi oylamadan önce pasif haldedir 
            btnOnayla.Enabled = false;
        }

        private void radioButton4_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void radioButton3_CheckedChanged(object sender, EventArgs e)
        {

        }
    }
}