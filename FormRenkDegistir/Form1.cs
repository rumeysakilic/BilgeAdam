namespace FormRenkDegistir
{
    public partial class Form1 : Form
    {
        public bool Beyaz = true;

        public Form1()
        {
            InitializeComponent();
            timer1.Interval = 1000;
            timer1.Start();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            if (Beyaz)
            {
                this.BackColor = Color.Black;
                Beyaz = false;
            }
            else
            {
                this.BackColor = Color.White;
                Beyaz = true;
            }
            string karsilamaMesaji = " BilgeAdama hoþgeldiniz!";
            int saat = DateTime.Now.Hour;
            MessageBox.Show(saat + karsilamaMesaji);
            if ((9 <= saat && saat < 12))
            {
                karsilamaMesaji = karsilamaMesaji.Insert(0, "Günaydýn,");
            }
            else if (12 <= saat && saat < 16)
            {
                karsilamaMesaji = karsilamaMesaji.Insert(0, "Ýyi günler, ");
            }
            else if (16 <= saat && saat < 18)
            {
                karsilamaMesaji = karsilamaMesaji.Insert(0, "Ýyi akþamlar, ");
            }
            // Formun baþlýðý karþýlama mesajýný
            // gösterecek þekilde ayarlanýr
            this.Text = karsilamaMesaji;
            timer1.Stop();
        }
    }
}