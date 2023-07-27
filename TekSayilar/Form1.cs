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
            // Say�lar metin kutusuna, tek say�lar�n yazd�r�lmas�
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
            // Metin kutular�na say� girildiyse
            if (IsNumeric(txtUstSayi.Text) & IsNumeric(txtAltSayi.Text))
            {
                // ve alt limit 0 dan b�y�k, ve �st limitten k���kse

                if (ust > alt & alt > 0)
                {
                    // giri� do�ru yap�lm��t�r
                    return true;
                }
            }
            // Kod buraya gelirse, giri� yanl�� yap�lm��t�r
            return false;
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            // Form y�klenirken kontrollerin ayarlanmas�:
            txtAltSayi.MaxLength = 2;
            txtUstSayi.MaxLength = 4;

            txtSayilar.Multiline = true;
            txtSayilar.ScrollBars = ScrollBars.Vertical;

            txtClipBoard.ReadOnly = true;
            txtClipBoard.Multiline = true;
        }

        private void txtUstSayi_TextChanged(object sender, EventArgs e)
        {
            // Bu olay hem txtUstSayi hem de txtAltSayi kontrol�n�n
            // TextChanged olay�nda ger�ekle�ir.
            // Handles ifadesinden sonra kontroller virg�lle ayr�lm��t�r
            TekSayiYazdir();
        }

        private void btnKaydet_Click(object sender, EventArgs e)
        {
            txtClipBoard.Text = txtSayilar.Text;
            // Say�lar�n kopyalanmas� i�in, �nce se�ilmesi gerekir
            txtSayilar.SelectAll();
            txtSayilar.Cut();
        }

        private void btnYukle_Click(object sender, EventArgs e)
        {
            // Cut yordam� �a��r�ld�ktan sonra veriler kopyalan�r.
            // Paste ile bu kopyalanan veriler geri yazd�r�l�r.

            txtSayilar.Clear();
            txtSayilar.Paste();
        }
    }
}