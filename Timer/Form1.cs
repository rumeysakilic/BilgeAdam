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
            // Baþlangýç zamaný "KalanSure" deðiþkenine atanýr.
            kalanSure = System.Convert.ToInt32(txtSure.Text);

            // Kalan süre kullanýcýya gösterilir.
            textSure.Text = System.Convert.ToString(kalanSure);

            // ListBox kontrolüne kayýt girilir.
            lbKayit.Items.Add("Kronometre basladi: " + DateAndTime.Now.TimeOfDay.ToString());

            // ComboBox kontrolünden seçilen deðer,
            // Timer kontrolünün çalýþma hýzýný belirler.
            tmrKronometre.Interval = System.Convert.ToInt32(cmbInterval.Text);

            // Timer kontrolünü çalýþtýrýr.
            tmrKronometre.Start();
        }

        private void btnDur_Click(object sender, EventArgs e)
        {
            // Timer kontrolünü durdurur.
            tmrKronometre.Stop();

            // ListBox kontrolüne kayýt girilir.
            lbKayit.Items.Add("Kronometre durduruldu: " + DateAndTime.Now.TimeOfDay.ToString());
        }

        private void tmrKronometre_Tick(object sender, EventArgs e)
        {
            // Her saniye geçtiðinde sure deðeri 1 azalacaktýr.
            kalanSure = kalanSure - 1;

            // KalanSure deðeri kullancýya gösterilir
            textSure.Text = System.Convert.ToString(kalanSure);

            // KalanSure deðeri sýfýra ulaþmýþsa kronometre durdurulur.
            if (kalanSure == 0)
            {
                tmrKronometre.Stop();
                lbKayit.Items.Add("Süre Doldu: " + DateAndTime.Now.TimeOfDay.ToString());
                MessageBox.Show("Süre doldu");
            }
        }
    }
}