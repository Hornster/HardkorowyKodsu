namespace HardkorowyKodsu
{
    internal static class Program
    {
        public static HttpClient HttpClient { get; private set; } = new HttpClient();
        /// <summary>
        ///  The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            // To customize application configuration such as set high DPI settings or default font,
            // see https://aka.ms/applicationconfiguration.
            ApplicationConfiguration.Initialize();
            HttpClient.Timeout = TimeSpan.FromSeconds(3);
            HttpClient.BaseAddress = new Uri("https://localhost:44375/api/");
            var appBackbones = new AppBackbones();
            Application.Run(new MainView(appBackbones));
        }
    }
}