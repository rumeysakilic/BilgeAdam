using System.Collections;
using System.Windows.Forms;

namespace SilinenlerGeriAl
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            ArrayList silinenler = new ArrayList();
            void GeriAl()
            {
                // Metin kutusunda geri al�nacak bir veri varsa
                if (textBox1.CanUndo)
                {
                    // Eski de�erler listeye eklenir.
                    silinenler.Add(textBox1.Text);
                    textBox1.Undo();
                    GeriAlinanKelimeler();
                }
            }
            // Listeleme i�lemini yapan yordam
            void GeriAlinanKelimeler()
            {
                listBox1.Items.Clear();
                for (int i = 0; i < silinenler.Count; i++)
                {
                    // i indisli Item, liste kutusuna eklenir.
                    listBox1.Items.Add(silinenler[i]);
                }
            }
        }
    }
}