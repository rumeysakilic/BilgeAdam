namespace KelimeOyunu
{
    internal static class Program
    {
        /// <summary>
        ///  The main entry point for the application.
        /// </summary>
        [STAThread]
        public static void Main()
        {
            // To customize application configuration such as set high DPI settings or default font,
            // see https://aka.ms/applicationconfiguration.
            ApplicationConfiguration.Initialize();
            Application.Run(new oyun());
            // Uygulamanýn giriþ noktasý

            string KullaniciAdi = null;
            KullaniciAdi = Microsoft.VisualBasic.Interaction.InputBox("Kullanýcý Adý girin: ", "", "", -1, -1);

            if (KullaniciAdi == "")
            {
                return;
            }

            oyun oyun = new oyun();
            oyun.Text = KullaniciAdi + " yarýþýyor";
            oyun.ShowDialog();
        }
    }
}