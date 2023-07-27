namespace Uygulama
{
    public partial class Form1 : Form
    {
        public int sureKontrol = 0;

        public Form1()
        {
            InitializeComponent();
            //10 saniyede bir, ListBox kontrolüne, kullanýcýdan alýnan deðerleri
            //ekleyen kodlarý yazýn.
            timer1.Interval = 1000; // 10 saniye (10000 milisaniye)
            timer1.Start();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            sureKontrol = sureKontrol + 1;
            if (sureKontrol == 10)
            {
                timer1.Stop();
                string deger = textBox1.Text;
                listBox1.Items.Add(deger);
                MessageBox.Show(deger);
                sureKontrol = 0;
                timer1.Interval = 1000;
                timer1.Start();
            }
        }
    }
}