namespace Aniflix
{
    internal static class Program
    {
        [STAThread]
        static void Main()
        {
            //Syncfusion.Licensing.SyncfusionLicenseProvider.RegisterLicense("MzY1MTA5NUAzMjM4MmUzMDJlMzBnZFVTUVlZUHR0YzFlU2gwU3Y0UUtqenpleVFjZlMyQy9Mc2Vpb21uSzAwPQ==");
            ApplicationConfiguration.Initialize();
            Application.Run(new AniflixView());
        }
    }
}