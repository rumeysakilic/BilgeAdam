namespace YaziTipiGoruntule
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            for (int i = 0; i <= 10; i++)
            {
                dFont.Items.Add(System.Drawing.FontFamily.Families[i].Name);
            }
            dFont.Wrap = true;
        }

        private void dFont_SelectedItemChanged(object sender, EventArgs e)
        {
            if (dFont.SelectedIndex >= 0)
            {
                textBox1.Font = new Font(dFont.SelectedItem.ToString(), 15);
            }
        }
    }
}