using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace IkiliArama
{
    public partial class Form1 : Form
    {
        public int[] dizi = new int[11];

        public Form1()
        {
            InitializeComponent();
        }

        private void btnAra_Click(object sender, EventArgs e)
        {
            int son = dizi.Length;
            int bas = -1;
            int orta;
            int indis;
            int hedef = int.Parse(textBox1.Text);

            while (son - bas > 1)
            {
                orta = (son + bas) / 2;
                if (dizi[orta] > hedef)
                {
                    son = orta;
                }
                else if (dizi[orta] < hedef)
                {
                    bas = orta;
                }
                else
                {
                    indis = orta;
                    MessageBox.Show("Ýndis: " + indis.ToString());
                    label2.Text = indis.ToString();
                    return;
                }
            }
            indis = -1;
            MessageBox.Show("Ýndis: " + indis + " Aranan deðer bulunamadý");
        }

        private void lbDizi_SelectedIndexChanged(object sender, EventArgs e)
        {
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            int i;
            Random r = new Random();
            for (i = 0; i < 10; i++)
            {
                dizi[i] = r.Next(1000);
            }
            Array.Sort(dizi);
            for (i = 0; i <= 10; i++)
            {
                lbDizi.Items.Add(dizi[i]);
            }
        }
    }
}