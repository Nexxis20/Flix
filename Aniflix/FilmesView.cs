using Microsoft.Extensions.Configuration;
using Syncfusion.WinForms.Controls;

namespace Aniflix
{
    public partial class FilmesView : SfForm
    {
        DateTime dataLancamento;
        private IConfiguration? configuration;

        public FilmesView()
        {
            InitializeComponent();
            ConfigureAppSettings();
        }
        private void ConfigureAppSettings()
        {
            var builder = new ConfigurationBuilder()
                .SetBasePath(Directory.GetCurrentDirectory())
                .AddJsonFile("appsettings.json", optional: false, reloadOnChange: true);

            configuration = builder.Build();
        }

        private void FilmesCodigoText_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar))
            {
                e.Handled = true;
            }
        }
        private static string FormatString(string input)
        {
            return "#" + input.Replace(" ", string.Empty);
        }

        public void GetFilmes()
        {
            var tmdbSettings = configuration.GetSection("TMDB");

            var client = new TMDbLib.Client.TMDbClient(tmdbSettings["key"])
            {
                DefaultLanguage = "pt-BR",
                DefaultCountry = "BR",
            };

            var movie = client.GetMovieAsync(FilmesCodigoText.Text).Result;

            if (movie != null)
            {
                FilmesTituloText.Text = movie.Title;
                FilmesSinopseText.Text = movie.Overview;
                FilmesTituloOriginalText.Text = movie.OriginalTitle;
                FilmesDataLancamentoText.Text = movie.ReleaseDate?.ToString("dd/MM/yyyy");
                FilmesFranquiaText.Text = FormatString(FilmesTituloText.Text);
            }
            else
            {
                MessageBox.Show("Nenhum filme encontrado.");
                FilmesCodigoText.Focus();
            }
        }
        private void FilmesCodigoText_TextChanged(object sender, EventArgs e)
        {
            GetFilmes();
        }
    }

    public class Settings
    {
        public string? TMDBKey { get; set; }
    }
}