namespace WaveEngine
{
    internal static class Program
    {
        public static Boolean inProgress = true;

        /// <summary>
        ///  The main entry point for the application.
        /// </summary>
        [STAThread]

        static void Main()
        {
            // To customize application configuration such as set high DPI settings or default font,
            // see https://aka.ms/applicationconfiguration.
            ApplicationConfiguration.Initialize();
            WaveEngine waveEngine = new WaveEngine();
            Application.Run(waveEngine);
        }

        
    }
}