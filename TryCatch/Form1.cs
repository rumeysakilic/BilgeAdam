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
                MessageBox.Show("Bölme iþlemi baþarýlý, sonuç: " + sonuc.ToString());
            }
            catch (Exception ex)
            {
                MessageBox.Show("Bölme iþlemi baþarýsýz. Hata Mesajý: " + ex.Message);
            }
            finally
            {
                MessageBox.Show("Ben her zaman çalýþýrým");
            }
        }
    }
}