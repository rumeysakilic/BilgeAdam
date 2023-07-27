using System.Windows.Forms;

namespace Siralama
{
    public partial class Form1 : Form
    {
        public string[] dizi = new string[5];

        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
        }

        private void btnListele_Click(object sender, EventArgs e)
        {
            dizi[0] = "Enis";
            dizi[1] = "Engin";
            dizi[2] = "Tamer";
            dizi[3] = "Kadir";
            dizi[4] = "Fulya";
            int i;
            for (i = 0; i <= dizi.Length - 1; i++)
            {
                lbSirasiz.Items.Add(dizi[i]);
            }
        }

        private void btnSirala_Click(object sender, EventArgs e)
        {
            int i;

            for (i = 1; i <= dizi.Length - 1; i++)
            {
                int j = i;
                while (j != 0 && String.Compare(dizi[j], dizi[j - 1]) == -1)
                {
                    // Yer deðiþtirme Algoritmasý
                    string temp = dizi[j - 1];
                    dizi[j - 1] = dizi[j];
                    dizi[j] = temp;
                    j -= 1;
                }
            }
            for (int t = 0; t <= dizi.Length - 1; t++)
            {
                lbSirali.Items.Add(dizi[t]);
            }
        }
    }
}