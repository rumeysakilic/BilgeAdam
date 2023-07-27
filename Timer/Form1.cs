using Microsoft.VisualBasic;

namespace Timer
{
    public partial class Form1 : Form
    {
        public int kalanSure;

        public Form1()
        {
            InitializeComponent();
        }

        private void btnBasla_Click(object sender, EventArgs e)
        {
            // Ba�lang�� zaman� "KalanSure" de�i�kenine atan�r.
            kalanSure = System.Convert.ToInt32(txtSure.Text);

            // Kalan s�re kullan�c�ya g�sterilir.
            textSure.Text = System.Convert.ToString(kalanSure);

            // ListBox kontrol�ne kay�t girilir.
            lbKayit.Items.Add("Kronometre basladi: " + DateAndTime.Now.TimeOfDay.ToString());

            // ComboBox kontrol�nden se�ilen de�er,
            // Timer kontrol�n�n �al��ma h�z�n� belirler.
            tmrKronometre.Interval = System.Convert.ToInt32(cmbInterval.Text);

            // Timer kontrol�n� �al��t�r�r.
            tmrKronometre.Start();
        }

        private void btnDur_Click(object sender, EventArgs e)
        {
            // Timer kontrol�n� durdurur.
            tmrKronometre.Stop();

            // ListBox kontrol�ne kay�t girilir.
            lbKayit.Items.Add("Kronometre durduruldu: " + DateAndTime.Now.TimeOfDay.ToString());
        }

        private void tmrKronometre_Tick(object sender, EventArgs e)
        {
            // Her saniye ge�ti�inde sure de�eri 1 azalacakt�r.
            kalanSure = kalanSure - 1;

            // KalanSure de�eri kullanc�ya g�sterilir
            textSure.Text = System.Convert.ToString(kalanSure);

            // KalanSure de�eri s�f�ra ula�m��sa kronometre durdurulur.
            if (kalanSure == 0)
            {
                tmrKronometre.Stop();
                lbKayit.Items.Add("S�re Doldu: " + DateAndTime.Now.TimeOfDay.ToString());
                MessageBox.Show("S�re doldu");
            }
        }
    }
}