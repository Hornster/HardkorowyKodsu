using System.Configuration;

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
            var appSettingsReader = new AppSettingsReader();

            var serverUrl = appSettingsReader.GetValue("ServerUrl", typeof(string)).ToString();
            var requestTimeout = (int)appSettingsReader.GetValue("RequestTimeout", typeof(int));
            HttpClient.Timeout = TimeSpan.FromSeconds(requestTimeout);
            HttpClient.BaseAddress = new Uri(serverUrl);
            var appBackbones = new AppBackbones();
            Application.Run(new MainView(appBackbones));
        }
    }
}