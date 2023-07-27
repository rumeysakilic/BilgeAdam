namespace TryCatch
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            int sayi, sonuc;
            try
            {
                Random r = new Random();
                sayi = r.Next(3);
                sonuc = 100 / sayi;
                MessageBox.Show("B�lme i�lemi ba�ar�l�, sonu�: " + sonuc.ToString());
            }
            catch (Exception ex)
            {
                MessageBox.Show("B�lme i�lemi ba�ar�s�z. Hata Mesaj�: " + ex.Message);
            }
            finally
            {
                MessageBox.Show("Ben her zaman �al���r�m");
            }
        }
    }
}