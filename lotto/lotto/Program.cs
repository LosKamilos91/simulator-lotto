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
            ApplicationConfiguration.Initialize();
            
            bool closeSimulator = true;
            while (closeSimulator)
            {
                Lotto menuLotto = new Lotto();
                Application.Run(menuLotto);
                if (menuLotto.openWindowWhenClickSelectInMenu)
                {
                    Application.Run(menuLotto.dashboardPanel.select);
                    closeSimulator = true;
                    Application.Run(menuLotto.dashboardPanel);
                }
                else if (menuLotto.openWindowWhenClickRandomInMenu)
                {
                    Application.Run(menuLotto.dashboardPanel);
                    closeSimulator = true;
                }
                else
                {
                    closeSimulator = false;
                }
            }






        }
    }
}