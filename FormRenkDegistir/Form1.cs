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
            string karsilamaMesaji = " BilgeAdama ho�geldiniz!";
            int saat = DateTime.Now.Hour;
            MessageBox.Show(saat + karsilamaMesaji);
            if ((9 <= saat && saat < 12))
            {
                karsilamaMesaji = karsilamaMesaji.Insert(0, "G�nayd�n,");
            }
            else if (12 <= saat && saat < 16)
            {
                karsilamaMesaji = karsilamaMesaji.Insert(0, "�yi g�nler, ");
            }
            else if (16 <= saat && saat < 18)
            {
                karsilamaMesaji = karsilamaMesaji.Insert(0, "�yi ak�amlar, ");
            }
            // Formun ba�l��� kar��lama mesaj�n�
            // g�sterecek �ekilde ayarlan�r
            this.Text = karsilamaMesaji;
            timer1.Stop();
        }
    }
}