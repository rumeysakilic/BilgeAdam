using static System.Windows.Forms.VisualStyles.VisualStyleElement;
using System.Reflection;
using Microsoft.VisualBasic;

namespace TekSayilar
{
    public partial class Form1 : Form
    {
        public int i;

        public Form1()
        {
            InitializeComponent();
        }

        public void TekSayiYazdir()
        {
            if (!(Kontrol())) { return; }

            txtSayilar.Clear();
            int alt = Convert.ToInt32(txtAltSayi.Text);
            int ust = Convert.ToInt32(txtUstSayi.Text);
            // Sayýlar metin kutusuna, tek sayýlarýn yazdýrýlmasý
            for (i = alt; i <= ust; i++)
            {
                if (i % 2 == 1)
                {
                    txtSayilar.Text += i + Constants.vbCrLf;
                }
            }
        }

        public bool IsNumeric(string value)
        {
            return value.All(char.IsNumber);
        }

        public bool Kontrol()
        {
            int ust = Convert.ToInt32(txtUstSayi.Text);
            int alt = Convert.ToInt32(txtAltSayi.Text);
            // Metin kutularýna sayý girildiyse
            if (IsNumeric(txtUstSayi.Text) & IsNumeric(txtAltSayi.Text))
            {
                // ve alt limit 0 dan büyük, ve üst limitten küçükse

                if (ust > alt & alt > 0)
                {
                    // giriþ doðru yapýlmýþtýr
                    return true;
                }
            }
            // Kod buraya gelirse, giriþ yanlýþ yapýlmýþtýr
            return false;
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            // Form yüklenirken kontrollerin ayarlanmasý:
            txtAltSayi.MaxLength = 2;
            txtUstSayi.MaxLength = 4;

            txtSayilar.Multiline = true;
            txtSayilar.ScrollBars = ScrollBars.Vertical;

            txtClipBoard.ReadOnly = true;
            txtClipBoard.Multiline = true;
        }

        private void txtUstSayi_TextChanged(object sender, EventArgs e)
        {
            // Bu olay hem txtUstSayi hem de txtAltSayi kontrolünün
            // TextChanged olayýnda gerçekleþir.
            // Handles ifadesinden sonra kontroller virgülle ayrýlmýþtýr
            TekSayiYazdir();
        }

        private void btnKaydet_Click(object sender, EventArgs e)
        {
            txtClipBoard.Text = txtSayilar.Text;
            // Sayýlarýn kopyalanmasý için, önce seçilmesi gerekir
            txtSayilar.SelectAll();
            txtSayilar.Cut();
        }

        private void btnYukle_Click(object sender, EventArgs e)
        {
            // Cut yordamý çaðýrýldýktan sonra veriler kopyalanýr.
            // Paste ile bu kopyalanan veriler geri yazdýrýlýr.

            txtSayilar.Clear();
            txtSayilar.Paste();
        }
    }
}