using static System.Windows.Forms.VisualStyles.VisualStyleElement;
using System.Reflection;

namespace HesapMakinesi
{
    public partial class Form1 : Form
    {
        private bool IslemSecildi = false;
        private double Sayi;
        private string Islem;

        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (!(IslemSecildi))
            {
                txtSayi.Text += ((System.Windows.Forms.Button)sender).Text;
            }
            else
            {
                txtSayi.Text = ((System.Windows.Forms.Button)sender).Text;
                IslemSecildi = false;
            }
        }

        private void carp_Click(object sender, EventArgs e)
        {
            Islem = ((System.Windows.Forms.Button)sender).Text;
            try
            {
                Sayi = double.Parse(txtSayi.Text);
                IslemSecildi = true;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Sayý düzgün formatta girilmedi");
            }
            finally
            {
                txtSayi.Text = "";
                txtSayi.Focus();
            }
        }

        private void esittir_Click(object sender, EventArgs e)
        {
            switch (Islem)
            {
                case "*":
                    Sayi *= double.Parse(txtSayi.Text);
                    break;

                case "/":
                    Sayi /= double.Parse(txtSayi.Text);
                    break;

                case "-":
                    Sayi -= double.Parse(txtSayi.Text);
                    break;

                case "+":
                    Sayi += double.Parse(txtSayi.Text);
                    break;
            }

            txtSayi.Text = Sayi.ToString();
        }

        private void temizle_Click(object sender, EventArgs e)
        {
            Sayi = 0;
            IslemSecildi = false;
            txtSayi.Text = "";
            txtSayi.Focus();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (!(IslemSecildi))
            {
                txtSayi.Text += ((System.Windows.Forms.Button)sender).Text;
            }
            else
            {
                txtSayi.Text = ((System.Windows.Forms.Button)sender).Text;
                IslemSecildi = false;
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            if (!(IslemSecildi))
            {
                txtSayi.Text += ((System.Windows.Forms.Button)sender).Text;
            }
            else
            {
                txtSayi.Text = ((System.Windows.Forms.Button)sender).Text;
                IslemSecildi = false;
            }
        }

        private void button4_Click(object sender, EventArgs e)
        {
            if (!(IslemSecildi))
            {
                txtSayi.Text += ((System.Windows.Forms.Button)sender).Text;
            }
            else
            {
                txtSayi.Text = ((System.Windows.Forms.Button)sender).Text;
                IslemSecildi = false;
            }
        }

        private void button5_Click(object sender, EventArgs e)
        {
            if (!(IslemSecildi))
            {
                txtSayi.Text += ((System.Windows.Forms.Button)sender).Text;
            }
            else
            {
                txtSayi.Text = ((System.Windows.Forms.Button)sender).Text;
                IslemSecildi = false;
            }
        }

        private void button6_Click(object sender, EventArgs e)
        {
            if (!(IslemSecildi))
            {
                txtSayi.Text += ((System.Windows.Forms.Button)sender).Text;
            }
            else
            {
                txtSayi.Text = ((System.Windows.Forms.Button)sender).Text;
                IslemSecildi = false;
            }
        }

        private void button7_Click(object sender, EventArgs e)
        {
            if (!(IslemSecildi))
            {
                txtSayi.Text += ((System.Windows.Forms.Button)sender).Text;
            }
            else
            {
                txtSayi.Text = ((System.Windows.Forms.Button)sender).Text;
                IslemSecildi = false;
            }
        }

        private void button8_Click(object sender, EventArgs e)
        {
            if (!(IslemSecildi))
            {
                txtSayi.Text += ((System.Windows.Forms.Button)sender).Text;
            }
            else
            {
                txtSayi.Text = ((System.Windows.Forms.Button)sender).Text;
                IslemSecildi = false;
            }
        }

        private void button9_Click(object sender, EventArgs e)
        {
            if (!(IslemSecildi))
            {
                txtSayi.Text += ((System.Windows.Forms.Button)sender).Text;
            }
            else
            {
                txtSayi.Text = ((System.Windows.Forms.Button)sender).Text;
                IslemSecildi = false;
            }
        }

        private void button10_Click(object sender, EventArgs e)
        {
            if (!(IslemSecildi))
            {
                txtSayi.Text += ((System.Windows.Forms.Button)sender).Text;
            }
            else
            {
                txtSayi.Text = ((System.Windows.Forms.Button)sender).Text;
                IslemSecildi = false;
            }
        }

        private void topla_Click(object sender, EventArgs e)
        {
            Islem = ((System.Windows.Forms.Button)sender).Text;
            try
            {
                Sayi = double.Parse(txtSayi.Text);
                IslemSecildi = true;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Sayý düzgün formatta girilmedi");
            }
            finally
            {
                txtSayi.Text = "";
                txtSayi.Focus();
            }
        }

        private void bolme_Click(object sender, EventArgs e)
        {
            Islem = ((System.Windows.Forms.Button)sender).Text;
            try
            {
                Sayi = double.Parse(txtSayi.Text);
                IslemSecildi = true;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Sayý düzgün formatta girilmedi");
            }
            finally
            {
                txtSayi.Text = "";
                txtSayi.Focus();
            }
        }

        private void cikarma_Click(object sender, EventArgs e)
        {
            Islem = ((System.Windows.Forms.Button)sender).Text;
            try
            {
                Sayi = double.Parse(txtSayi.Text);
                IslemSecildi = true;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Sayý düzgün formatta girilmedi");
            }
            finally
            {
                txtSayi.Text = "";
                txtSayi.Focus();
            }
        }
    }
}