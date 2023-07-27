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
                    MessageBox.Show("Yazýlar birbirine eþit");
                    break;

                case 1:
                    MessageBox.Show(yazi1 + ", " + yazi2 + " kelimesinden sonra geliyor");
                    break;

                case -1:
                    MessageBox.Show(yazi1 + ", " + yazi2 + " kelimesinden önce geliyor");
                    break;
            }
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
        }

        private void button2_Click(object sender, EventArgs e)
        {
            string kurum = "BilgeAdam";
            label2.Text = String.Concat("Kurum: ", kurum, "Þubeler: ",
            "\n", " Fatih", " Bakýrköy", " Kadýköy", " Beþiktaþ", " Town Center");
        }

        private void button3_Click(object sender, EventArgs e)
        {
            string yazi = "BilgeAdam";
            char[] Karakterler = new char[11];
            // Yazýnýn 5. karakterinden itibaren alýnan 4 karakter,
            // karakterler dizisinin 3. indisinden baþlanarak
            // diziye kopyalanýr.
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