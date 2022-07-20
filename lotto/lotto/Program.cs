namespace lotto
{
    internal static class Program
    {
        /// <summary>
        ///  The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            // To customize application configuration such as set high DPI settings or default font,
            // see https://aka.ms/applicationconfiguration.
            ApplicationConfiguration.Initialize();
            
            bool close = true;
            while (close)
            {
                Lotto menuLotto = new Lotto();
                Application.Run(menuLotto);
                if (menuLotto.openWindowWhenClickSelectInMenu)
                {
                    Application.Run(menuLotto.dashboardPanel.select);
                    close = true;
                }
                else if (menuLotto.openWindowWhenClickRandomInMenu)
                {
                    Application.Run(menuLotto.dashboardPanel);
                    close = true;
                }
                else
                {
                    close = false;
                }
            }






        }
    }
}