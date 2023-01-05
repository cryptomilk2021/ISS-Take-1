namespace ISS_Take_1
{
    internal static class Program
    {
        public class Global
        {
            public static string SatID = "";
            public static string Longitude = "";
            public static string Latitude = "";
            public static string TimeStamp = "";
            public static string NbrOfHits = "";
        }
        /// <summary>
        ///  The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()

        {
            // To customize application configuration such as set high DPI settings or default font,
            // see https://aka.ms/applicationconfiguration.

            
            ApplicationConfiguration.Initialize();
            Application.Run(new Form1());
        }
    }
}