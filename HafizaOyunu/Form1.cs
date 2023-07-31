using static System.Windows.Forms.VisualStyles.VisualStyleElement;
using System.Reflection;
using System.Collections;
using System.Windows.Forms;

namespace HafizaOyunu
{
    public partial class Form1 : Form
    {
        private System.Windows.Forms.Button AcikKart;
        private bool acik = false;

        private void ButonaTiklandi(object sender, EventArgs e)
        {
            System.Windows.Forms.Button kart = (System.Windows.Forms.Button)sender;

            // E�er ilk kart a��l�yorsa
            if (!(acik))
            {
                // Kart g�r�nt�le
                kart.BackgroundImage = �mageList1.Images[int.Parse(kart.Tag.ToString())];
                AcikKart = kart;
                acik = true;

                // E�er ikinci kart a��l�yorsa
            }
            else
            {
                // A��lm�� kart�n resmi, yeni alan kartn
                // resmi ile ay�n�ysa, bu kartlar silinir
                if (kart.Tag == AcikKart.Tag)
                {
                    this.Controls.Remove(kart);
                    this.Controls.Remove(AcikKart);
                }
                else
                {
                    AcikKart.BackgroundImage = null;
                }
                acik = false;
            }
        }

        public void KartResimYukle()
        {
            // D��meler bir listeye alnr.
            ArrayList dugmeler = new ArrayList();
            foreach (System.Windows.Forms.Control c in this.Controls)
            {
                if (c is System.Windows.Forms.Button)
                {
                    dugmeler.Add(c);
                }
            }

            Random r = new Random();
            int i = 0;

            // Kartlar iki�er iki�er ele al�n�r. �ki karta da
            // ayn� resim atan�r. Ve bu iki kart d��meler
            // listesinden ��kart�l�r.
            while (dugmeler.Count > 0)
            {
                System.Windows.Forms.Button kart1 = null, kart2 = null;

                kart1 = (System.Windows.Forms.Button)dugmeler[r.Next(dugmeler.Count - 1)];
                kart1.Tag = i;
                dugmeler.Remove(kart1);

                kart2 = (System.Windows.Forms.Button)dugmeler[r.Next(dugmeler.Count - 1)];
                kart2.Tag = i;
                dugmeler.Remove(kart2);

                i += 1;
            }
        }

        public void KartYerlestir(int kartSayisi)
        {
            DugmeleriSil();
            int x = 10;
            int y = 50;

            for (int i = 1; i <= kartSayisi; i++)
            {
                // Dinamik bir d��me olu�turulur ve �zellikler ayarlan�r
                System.Windows.Forms.Button kart = new System.Windows.Forms.Button();
                kart.Height = 30;
                kart.Width = 30;
                kart.Location = new Point(x, y);

                kart.Click += new System.EventHandler(ButonaTiklandi);

                this.Controls.Add(kart);

                // Bir sonraki eklenecek olan d��me
                // ilk kontrol�n 70 piksel sa��nda olacakt�r
                x += 70;

                // D��me Form s�n�rlar� i�inde olmas� gerekir.
                if (x > this.Width)
                {
                    x = 10;
                    y += 50;
                }
            }
            KartResimYukle();
        }

        public void DugmeleriSil()
        {
            ArrayList silinecek = new ArrayList();

            // Form iindeki Button kontrolleri bir listede tutulur
            foreach (System.Windows.Forms.Control c in this.Controls)
            {
                if (c is System.Windows.Forms.Button)
                {
                    silinecek.Add(c);
                }
            }

            for (int i = 0; i <= silinecek.Count - 1; i++)
            {
                this.Controls.Remove((Control)silinecek[i]);
            }
        }

        public Form1()
        {
            InitializeComponent();
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
        }
    }
}