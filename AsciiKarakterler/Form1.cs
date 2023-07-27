namespace AsciiKarakterler
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btn_goruntule_Click(object sender, EventArgs e)
        {
            listBox1.Items.Add("Karakter - ASCII kod karþýlýðý");
            for (int i = 50; i <= 255; i = i + 2)
            {
                char karakter = (char)i;
                listBox1.Items.Add(karakter + " " + i);
            }
            //Rastgele 10 elemanlý dizi
            int[] dizi = new int[10];
            Random r = new Random();
            for (int i = 0; i < dizi.Length; i++)
            {
                dizi[i] = r.Next(100);
                listBox2.Items.Add(dizi[i]);
            }
        }
    }
}