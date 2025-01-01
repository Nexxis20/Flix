using Aniflix.Extensions;
using Microsoft.Extensions.Configuration;
using Syncfusion.WinForms.Controls;
using System.Globalization;

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
            var tmdbSettings = configuration!.GetSection("TMDB");

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

            if (
           DateTime.TryParseExact(
               FilmesDataLancamentoText.Text,
               "dd/MM/yyyy",
               CultureInfo.InvariantCulture,
               DateTimeStyles.None,
               out dataLancamento
           )
       )
            {
                string ano = dataLancamento.Year.ToString();
                FilmesTagsText.Text = "#Filme #Filme" + ano;
            }

            if (movie!.Genres.Count > 2)
            {
                HashSet<string> hashtags = [];

                static void FormatGenre(string genre, HashSet<string> hashtags)
                {
                    Dictionary<string, string> specialWords = new()
                {
                    { "ficção científica", "ficçãocientífica ficcaocientifica" },
                    { "romântico", "romântico romantico" },
                    { "romântica", "romântica romantica" },
                    { "comédia", "comédia comedia" },
                    { "mistério", "mistério misterio" },
                };

                    string lowerGenre = genre.ToLower();

                    if (specialWords.TryGetValue(lowerGenre, out string? value))
                    {
                        foreach (var tag in value.Split(' '))
                        {
                            hashtags.Add($"#{tag}");
                        }
                    }
                    else
                    {
                        string clean = new(genre.RemoveDiacritics().Where(char.IsAscii).ToArray());
                        hashtags.Add($"#{genre.ToLower().Replace(" ", "")}");
                        hashtags.Add($"#{clean.ToLower().Replace(" ", "")}");
                    }
                }

                FormatGenre(movie.Genres[0].Name, hashtags);
                FormatGenre(movie.Genres[1].Name, hashtags);
                FormatGenre(movie.Genres[2].Name, hashtags);
                FilmesGeneroText.Text = string.Join(" ", hashtags);
            }

            var credits = client.GetMovieCreditsAsync(Convert.ToInt32(FilmesCodigoText.Text)).Result;

            var directors = credits
                .Crew.Where(person => person.Job == "Director")
                .Take(4)
                .Select(person => $"#{person.Name.Replace(" ", "")}")
                .ToList();

            FilmesDiretorText.Text = string.Join(" ", StringExtensions.CleanAndFormatNames(directors));

            var stars = credits
                .Cast.Take(5)
                .Select(person => $"#{person.Name.Replace(" ", "")}")
                .ToList();

            FilmesEstrelasText.Text = string.Join(" ", StringExtensions.CleanAndFormatNames(stars));

            var studios = movie
                .ProductionCompanies.Take(5)
                .Select(company => $"#{company.Name.Replace(" ", "")}")
                .ToList();

            var cleanedList = studios
                .Select(str =>
                    str.Aggregate(
                        "",
                        (result, c) => (char.IsLetterOrDigit(c) || c == '#') ? result + c : result
                    )
                )
                .ToList();

            FilmesEstudioText.Text = string.Join(" ", cleanedList);

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