using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Reflection.Emit;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace ProgressBar
{
    public partial class Durum : Form
    {
        public int kalan;
        public Durum()
        {
            InitializeComponent();
        }

        private void Form2_Load(object sender, EventArgs e)
        {
            kalan = progressBar1.Maximum;
            timer1.Start();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            if (kalan == 0)
            {
                timer1.Stop();
                this.Close();
            }

            int aralik;
            aralik = progressBar1.Maximum - progressBar1.Minimum;

            int oran = (aralik - kalan) / aralik * 100;
            label1.Text = oran + "% tamamlandı";

            progressBar1.Value = progressBar1.Maximum - kalan;
            kalan -= 1;

        }
    }
}
