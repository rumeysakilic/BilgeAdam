namespace SwitchCase
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string karsilamaMesaji = " BilgeAdama hoþgeldiniz!";
            int saat = DateTime.Now.Hour;
            switch (saat)
            {
                case 9:
                case 10:
                case 11:
                    karsilamaMesaji = karsilamaMesaji.Insert(0, "Günaydýn,");
                    MessageBox.Show(karsilamaMesaji);
                    break;

                case 12:
                case 13:
                case 14:
                case 15:
                    karsilamaMesaji = karsilamaMesaji.Insert(0, "Ýyi günler,");
                    MessageBox.Show(karsilamaMesaji);
                    break;

                case 16:
                case 17:
                    karsilamaMesaji = karsilamaMesaji.Insert(0, "Ýyi akþamlar,");
                    MessageBox.Show(karsilamaMesaji);
                    break;

                default:
                    karsilamaMesaji = karsilamaMesaji.Insert(0, "Merhaba,");
                    MessageBox.Show(karsilamaMesaji);
                    break;
            }
        }
    }
}