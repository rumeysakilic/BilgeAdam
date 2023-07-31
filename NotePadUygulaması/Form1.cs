using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace NotePadUygulaması
{
    public partial class Form1 : Form
    {
        private bool Kaydedildi = true;
        private string DosyaIsmi;

        public void DurumDegistir()
        {
            StatusBar1.Text = DosyaIsmi;
            if (Kaydedildi)
            {
                StatusBar1.Text = "Kaydedildi";
            }
            else
            {
                StatusBar1.Text = "Kaydedilmedi";
            }
        }

        // Kaydetme işlemi
        public void Kaydet()
        {
            if (DosyaIsmi == "")
            {
                FarkliKaydet();
            }
            else
            {
                richTextBox1.SaveFile(DosyaIsmi);
                Kaydedildi = true;
            }
            DurumDegistir();
        }

        // Farklı kaydetme işlemi
        public void FarkliKaydet()
        {
            string dosya;
            // Kaydedilecek yeri seçmek için
            // SaveFileDialog kutusu gösterilir
            // Dosya yoksa otomatik olarak oluşturulması sağlanır
            saveFileDialog1.CreatePrompt = true;

            if (saveFileDialog1.ShowDialog() == DialogResult.OK)
            {
                dosya = saveFileDialog1.FileName;
                richTextBox1.SaveFile(dosya);
                DosyaIsmi = dosya;
                Kaydedildi = true;
            }
            DurumDegistir();
        }

        public void DosyaAc(bool yeniDosya)
        {
            if (!(Kaydedildi))
            {
                switch (MessageBox.Show("Dosya kaydedilsin mi ? ", "", MessageBoxButtons.YesNoCancel))
                {
                    case DialogResult.OK: // Kaydetme işlemi yapılır
                        Kaydet();
                        break;

                    case DialogResult.Cancel:
                        // İşlem iptal edildi
                        return;
                }
            }
            if (!(yeniDosya))
            {
                // Varolan bir dosya alır.
                string dosya = null;
                if (openFileDialog1.ShowDialog() == DialogResult.OK)
                {
                    dosya = openFileDialog1.FileName;
                    richTextBox1.LoadFile(dosya);
                    DosyaIsmi = dosya;
                }
            }
            else
            {
                // Yeni bir dosya açılır
                richTextBox1.Clear();
                DosyaIsmi = "";
            }

            Kaydedildi = true;
            DurumDegistir();
        }

        public void Bul()
        {
            // Bulma formu görüntülenir, iptal tuşuna basıldıysa çıkılır
            frmBul bul = new frmBul();
            if (!(bul.ShowDialog() == DialogResult.OK))
            { return; }

            string aranan = bul.txtAranan.Text;
            if (aranan == "") { return; }

            // Bulduktan sonra kelimenin tümünü işaretlenmesi bilgisi alınır
            bool TumKelimeyiSec = bul.cbTumKelimeyiSec.Checked;
            // Bulunan ilk indis alınır.
            int start = richTextBox1.Find(aranan);
            if (!(TumKelimeyiSec))
            {
                // Sadece aranan kelime seçilir.
                richTextBox1.Select(start, aranan.Length);
            }
            else
            {
                int son = start;
                int bas = start;

                while (son < richTextBox1.Text.Length - 1 && richTextBox1.Text.Substring(son, 1) != " ")
                {
                    son += 1;
                }

                while (bas > -1 &&
               richTextBox1.Text.Substring(bas, 1) != " ")
                {
                    bas -= 1;
                }

                richTextBox1.Select(bas + 1, son - bas - 1
               );
            }
        }

        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
        }

        private void toolStripStatusLabel1_Click(object sender, EventArgs e)
        {
        }

        private void toolStripButton1_Click(object sender, EventArgs e)
        {
            // Basılan düğmenin indisine göre işlem yapılır.
            switch (toolStripButton1.ImageIndex)
            {
                case 0:
                    //Kaydet
                    Kaydet();
                    break;

                case 1:
                    // Ac
                    DosyaAc(false);
                    break;

                case 3:
                    // Kopyala
                    richTextBox1.Copy();
                    break;

                case 4:
                    // Kes
                    richTextBox1.Cut();
                    break;

                case 5:
                    // Yapıştır
                    richTextBox1.Paste();
                    break;

                case 7:
                    // Geri Al
                    richTextBox1.Undo();
                    break;

                case 8:
                    // Tekrarla
                    richTextBox1.Redo();
                    break;

                case 10:
                    // Madde işaretle
                    richTextBox1.SelectionBullet = richTextBox1.SelectionBullet;
                    break;

                case 11:
                    // Sola Hizala
                    richTextBox1.SelectionAlignment = HorizontalAlignment.Left;
                    break;

                case 12:
                    // Ortala
                    richTextBox1.SelectionAlignment = HorizontalAlignment.Center;
                    break;

                case 13:
                    // Sağa Hizala
                    richTextBox1.SelectionAlignment = HorizontalAlignment.Right;
                    break;
            }
        }

        private void richTextBox1_TextChanged(object sender, EventArgs e)
        {
            Kaydedildi = false;
            DurumDegistir();
        }
    }
}