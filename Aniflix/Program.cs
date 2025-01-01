namespace Aniflix
{
    internal static class Program
    {
        [STAThread]
        static void Main()
        {
            Syncfusion.Licensing.SyncfusionLicenseProvider.RegisterLicense("Ngo9BigBOggjHTQxAR8/V1NMaF5cXmRCf1FpRmJGdld5fUVHYVZUTXxaS00DNHVRdkdmWX5ecXVVQmNeUUxwVkY=");
            ApplicationConfiguration.Initialize();
            Application.Run(new FilmesView());
        }
    }
}