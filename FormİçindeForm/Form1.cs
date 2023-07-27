namespace FormİçindeForm
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            yeniForm yeni = new yeniForm();
            yeni.ShowDialog();
            MessageBox.Show("Yeni form kapatıldı");
        }

        private void timer2_Tick(object sender, EventArgs e)
        {

        }
    }
}