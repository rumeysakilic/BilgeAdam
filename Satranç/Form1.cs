namespace Satranç
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnGoster_Click(object sender, EventArgs e)
        {
            lbHareketAlani.Items.Clear();
            int a, b;

            Random r = new Random();
            bool[,] tahta = new bool[8, 8];

            for (a = 0; a <= 7; a++)
            {
                for (b = 0; b <= 7; b++)
                {
                    int sonuc = (r.Next() % 2);

                    if (sonuc == 1)
                    {
                        tahta[a, b] = true;
                    }
                    else
                    {
                        tahta[a, b] = false;
                    }
                }
            }
            byte x = byte.Parse(txtFilinXKoordinati.Text);
            byte y = byte.Parse(txtFilinYKoordinati.Text);
            int i = 1;
            while (x - i >= 0 & y - i >= 0)
            {
                if (!(tahta[x - i, y - i]))
                {
                    lbHareketAlani.Items.Add((x - i).ToString() + " - " + (y - i).ToString());
                    i += 1;
                }
                else
                {
                    break;
                }
            }
            i = 1;
            while (x + i < tahta.GetLength(0) & y - i >= 0)
            {
                if (!(tahta[x + i, y - i]))
                {
                    lbHareketAlani.Items.Add((x + i).ToString() + " - " + (y - i).ToString());
                    i += 1;
                }
                else
                {
                    break;
                }
            }
            i = 1;
            while (!(x + i >= tahta.GetLength(0) | y + i >= tahta.GetLength(1)))
            {
                if (!(tahta[x + i, y + i]))
                {
                    lbHareketAlani.Items.Add((x + i).ToString() + " - " + (y + i).ToString());
                    i += 1;
                }
                else
                {
                    break;
                }
            }
            i = 1;
            while (x - i >= 0 & y + i < tahta.GetLength(1))
            {
                if (!(tahta[x - i, y + i]))
                {
                    lbHareketAlani.Items.Add((x - i).ToString() + " - " + (y + i).ToString());
                    i += 1;
                }
                else
                {
                    break;
                }
            }
        }
    }
}