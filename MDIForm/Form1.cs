namespace MDIForm
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            AltForm f = new AltForm();
            // Olu�turulan form, ana forma ba�lan�r.
            f.MdiParent = this;
            f.Show();
        }
    }
}