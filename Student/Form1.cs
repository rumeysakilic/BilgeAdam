namespace Student
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            comboBox1.Items.Add("Lise");
            comboBox1.Items.Add("Üniversite");
            comboBox1.Items.Add("Yüksek Lisans");
            comboBox1.Items.Add("Doktora");
        }

        private void button1_Click(object sender, EventArgs e)
        {
            listBox1.Items.Add("A1");
            listBox1.Items.Add("A2");
            listBox1.Items.Add("B1");
            listBox1.Items.Add("B2");
            listBox1.Items.Add("C1");
            listBox1.Items.Add("C2");
        }
    }
}