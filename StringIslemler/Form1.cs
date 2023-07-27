namespace StringIslemler
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string yazi1 = "BilgeAdam";
            string yazi2 = textBox1.Text;

            switch (yazi1.CompareTo(yazi2))
            {
                case 0:
                    MessageBox.Show("Yaz�lar birbirine e�it");
                    break;

                case 1:
                    MessageBox.Show(yazi1 + ", " + yazi2 + " kelimesinden sonra geliyor");
                    break;

                case -1:
                    MessageBox.Show(yazi1 + ", " + yazi2 + " kelimesinden �nce geliyor");
                    break;
            }
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
        }

        private void button2_Click(object sender, EventArgs e)
        {
            string kurum = "BilgeAdam";
            label2.Text = String.Concat("Kurum: ", kurum, "�ubeler: ",
            "\n", " Fatih", " Bak�rk�y", " Kad�k�y", " Be�ikta�", " Town Center");
        }

        private void button3_Click(object sender, EventArgs e)
        {
            string yazi = "BilgeAdam";
            char[] Karakterler = new char[11];
            // Yaz�n�n 5. karakterinden itibaren al�nan 4 karakter,
            // karakterler dizisinin 3. indisinden ba�lanarak
            // diziye kopyalan�r.
            yazi.CopyTo(5, Karakterler, 3, 4);
            for (int i = 0; i < Karakterler.Length - 1; i++)
            {
                label3.Text = Convert.ToString(Karakterler[i]);
            }
            // Karakterler dizisinin son hali:
            // _ _ _ A d a m _ _ _ _
        }
    }
}