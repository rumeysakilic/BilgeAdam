using System.Windows.Forms;

namespace InternetTarayıcısı
{
    public partial class Form1 : Form
    {
        public void YeniSayfa(string link)
        {
            // Dinamik kontroller oluşturulur.
            TabPage sayfa = new TabPage(link);
            AxSHDocVw.AxWebBrowser tarayici = new AxSHDocVw.AxWebBrowser();
            tarayici.Dock = DockStyle.Fill;
            // Tarayıcı TabPage kontrolüne eklenir
            sayfa.Controls.Add(tarayici);
            // Oluşturulan sayfa TabControl nesnesine eklenir.
            TabControl1.TabPages.Add(sayfa);
            // Yeni açılan sayfa seçili olarak gösterilir
            TabControl1.SelectedTab = sayfa;
            // Tarayıcı, verilen bağlantıyı görüntüler
            tarayici.Navigate(link);
        }

        public void AyniSayfa(string link)
        {
            // Internet sitesi, seçilen sayfada gösterilir.
            TabPage sayfa = null;
            sayfa = TabControl1.SelectedTab;

            AxSHDocVw.AxWebBrowser tarayici = null;
            // Tarayıcı, sayfanın kontrolleri içinde bulunur.
            // Sayfada başka kontrol bulunmadığı için, ilk
            // kontrol tarayıcıdır.
            tarayici = ((AxSHDocVw.AxWebBrowser)(sayfa.Controls[0]));
            sayfa.Text = link;
            tarayici.Navigate(link);
        }

        public Form1()
        {
            InitializeComponent();
        }

        private void radioButton2_CheckedChanged(object sender, EventArgs e)
        {
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            LinkLabel1.Links.Add(0, 9, "http://www.bilgeadam.com");
            this.AcceptButton = btnGit;
        }

        private void btnGit_Click(object sender, EventArgs e)
        {
            // Girilen bağlantının başında http ifadesi
            // bulunmuyorsa bu ifade eklenir
            if (!(txtAdres.Text.StartsWith("http://")))
            {
                txtAdres.Text = txtAdres.Text.Insert(0, "http://");
            }
            // TabControl nesnesinde sayfa yoksa ya da Yeni Sayfa
            // seçeneği seçilmişse, adres yeni sayfada gösterilir.
            if (rbYeniSayfa.Checked || TabControl1.TabPages.Count == 0)
            {
                YeniSayfa(txtAdres.Text);
            }
            else
            {
                AyniSayfa(txtAdres.Text);
            }
        }

        private void LinkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            YeniSayfa(System.Convert.ToString(e.Link.LinkData));
        }

        private void btnSayfaKapat_Click(object sender, EventArgs e)
        {
            TabPage sayfa = null;
            sayfa = TabControl1.SelectedTab;

            if (!(sayfa == null))
            {
                sayfa.Dispose();
            }
        }

        private void btnTumunuKapat_Click(object sender, EventArgs e)
        {
            foreach (System.Windows.Forms.TabPage sayfa in TabControl1.TabPages)
            {
                sayfa.Dispose();
            }
        }
    }
}