namespace StartPage
{
    public partial class Start : Form
    {
        public Start()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Hello World! The time is " + DateTime.Now);
            goster.Text = textBox1.Text;
            goster.Height = 25;
            goster.Width = 100;
            goster.BringToFront();
        }

        private void button1_MouseClick(object sender, MouseEventArgs e)
        {
        }
    }
}