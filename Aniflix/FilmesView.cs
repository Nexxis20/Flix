using Aniflix.Controllers;
using Aniflix.Data;
using Aniflix.Extensions;
using Aniflix.Model;
using Aniflix.Repository;
using Insight.Database;
using Microsoft.Extensions.Configuration;
using Syncfusion.WinForms.Controls;
using System.Data;
using System.Globalization;

namespace Aniflix
{
    public partial class FilmesView : SfForm
    {
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

        private async Task GetFilmesAsync()
        {
            try
            {
                using var connection = new ConnectionRepository().GetConnection();
                var filmesController = new FilmesController(connection);
                filmesController.VerificarCodigo(FilmesCodigoText.Text, FilmesCodigoText);

                var tmdbSettings = configuration!.GetSection("TMDB");

                var client = new TMDbLib.Client.TMDbClient(tmdbSettings["key"])
                {
                    DefaultLanguage = "pt-BR",
                    DefaultCountry = "BR",
                };

                var movieTask = client.GetMovieAsync(FilmesCodigoText.Text);
                var creditsTask = client.GetMovieCreditsAsync(Convert.ToInt32(FilmesCodigoText.Text));

                await Task.WhenAll(movieTask, creditsTask);

                var movie = movieTask.Result;
                var credits = creditsTask.Result;

                if (movie != null)
                {
                    Invoke((Action)(() =>
                    {
                        FilmesTituloText.Text = movie.Title;
                        FilmesSinopseText.Text = movie.Overview;
                        FilmesTituloOriginalText.Text = movie.OriginalTitle;
                        FilmesDataLancamentoText.Text = movie.ReleaseDate?.ToString("dd/MM/yyyy");
                        FilmesFranquiaText.Text = FormatString(FilmesTituloText.Text.Replace("-", string.Empty));
                    }));

                    if (
                        DateTime.TryParseExact(
                            FilmesDataLancamentoText.Text,
                            "dd/MM/yyyy",
                            CultureInfo.InvariantCulture,
                            DateTimeStyles.None,
                            out var releaseData
                        )
                    )
                    {
                        string ano = releaseData.Year.ToString();
                        FilmesTagsText.Text = $"#Filme #Filme{ano}";
                    }

                    if (movie.Genres != null && movie.Genres.Count > 2)
                    {
                        var hashtags = new HashSet<string>();

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
                }
                else
                {
                    Invoke((Action)(() =>
                    {
                        MessageBox.Show("Nenhum filme encontrado.", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        FilmesCodigoText.Focus();
                    }));
                }

                if (credits != null && credits.Crew != null)
                {
                    var directors = credits
                    .Crew.Where(person => person.Job == "Director")
                    .Take(4)
                    .Select(person => $"#{person.Name.Replace(" ", "")}")
                    .ToList();

                    Invoke((Action)(() =>
                    {
                        FilmesDiretorText.Text = string.Join(" ", StringExtensions.ClearLists(directors));
                    }));
                }
                else
                {
                    Invoke((Action)(() =>
                    {
                        FilmesDiretorText.Text = string.Empty;
                    }));
                }

                if (credits != null && credits.Cast != null)
                {

                    var stars = credits
                    .Cast.Take(5)
                    .Select(person => $"#{person.Name.Replace(" ", "")}")
                    .ToList();
                    Invoke((Action)(() =>
                    {
                        FilmesEstrelasText.Text = string.Join(" ", StringExtensions.ClearLists(stars));
                    }));
                }
                else
                {
                    Invoke((Action)(() =>
                    {
                        FilmesEstrelasText.Text = string.Empty;
                    }));
                }

                if (movie != null && movie.ProductionCompanies != null)
                {

                    var studios = movie!
                    .ProductionCompanies.Take(5)
                    .Select(company => $"#{company.Name.Replace(" ", "")}")
                    .ToList();
                    Invoke((Action)(() =>
                    {
                        FilmesEstudioText.Text = string.Join(" ", StringExtensions.ClearLists(studios));
                    }));
                }
                else
                {
                    Invoke((Action)(() =>
                    {
                        FilmesEstudioText.Text = string.Empty;
                    }));
                }
            }
            catch (Exception ex)
            {
                Invoke((Action)(() =>
                {
                    MessageBox.Show($"Erro ao buscar o filme: {ex.Message}", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }));
            }
        }

        private void UpdateData()
        {
            var model = new FilmesData(
                titulo: FilmesTituloText.Text,
                audio: FilmesAudioBox.SelectedItem?.ToString() ?? string.Empty,
                sinopse: FilmesSinopseText.Text,
                tituloOriginal: FilmesTituloOriginalText.Text,
                dataLancamento: FilmesDataLancamentoText.Text,
                franquia: FilmesFranquiaText.Text,
                genero: FilmesGeneroText.Text,
                tags: FilmesTagsText.Text,
                diretor: FilmesDiretorText.Text,
                estrelas: FilmesEstrelasText.Text,
                estudio: FilmesEstudioText.Text
                );
            FilmesResumoText.Text = model.GetFormattedText();
        }
        private async void FilmesCodigoText_Leave(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(FilmesCodigoText.Text))
            {
                MessageBox.Show("Por favor, insira o código do filme.");
                FilmesCodigoText.Focus();
            }
            else
            {
                HabilitarButtons(true);
                await GetFilmesAsync();
            }
        }
        private void FilmesTituloText_TextChanged(object sender, EventArgs e)
        {
            UpdateData();
        }

        private void FilmesAudioBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            UpdateData();
        }

        private void FilmesSinopseText_TextChanged(object sender, EventArgs e)
        {
            UpdateData();
        }

        private void FilmesTituloOriginalText_TextChanged(object sender, EventArgs e)
        {
            UpdateData();
        }

        private void FilmesDataLancamentoText_TextChanged(object sender, EventArgs e)
        {
            UpdateData();
        }

        private void FilmesFranquiaText_TextChanged(object sender, EventArgs e)
        {
            UpdateData();
        }

        private void FilmesGeneroText_TextChanged(object sender, EventArgs e)
        {
            UpdateData();
        }

        private void FilmesTagsText_TextChanged(object sender, EventArgs e)
        {
            UpdateData();
        }

        private void FilmesDiretorText_TextChanged(object sender, EventArgs e)
        {
            UpdateData();
        }

        private void FilmesEstrelasText_TextChanged(object sender, EventArgs e)
        {
            UpdateData();
        }

        private void FilmesEstudioText_TextChanged(object sender, EventArgs e)
        {
            UpdateData();
        }
        private void FilmesView_Load(object sender, EventArgs e)
        {
            FilmesAudioBox.SelectedIndex = 0;
            HabilitarButtons(false);

            using var connection = new ConnectionRepository().GetConnection();
            var filmeController = new FilmesController(connection);


        }

        private void HabilitarButtons(bool enabled)
        {
            Copiar.Enabled = enabled;
            Salvar.Enabled = enabled;
            Editar.Enabled = enabled;
            Anterior.Enabled = enabled;
            Proximo.Enabled = enabled;
        }

        private void Copiar_Click(object sender, EventArgs e)
        {
            FilmesResumoText.SelectAll();
            FilmesResumoText.Copy();
        }
        private Filmes MapFormToFilmes()
        {
            return new Filmes
            {
                Codigo = FilmesCodigoText.Text,
                Titulo = FilmesTituloText.Text,
                Audio = FilmesAudioBox.SelectedItem?.ToString() ?? string.Empty,
                Sinopse = FilmesSinopseText.Text,
                TituloOriginal = FilmesTituloOriginalText.Text,
                DataLancamento = FilmesDataLancamentoText.Text,
                Franquia = FilmesFranquiaText.Text,
                Genero = FilmesGeneroText.Text,
                Tags = FilmesTagsText.Text,
                Diretor = FilmesDiretorText.Text,
                Estrelas = FilmesEstrelasText.Text,
                Estudio = FilmesEstudioText.Text
            };
        }
        private void Salvar_Click(object sender, EventArgs e)
        {
            var filmes = MapFormToFilmes();
            using var connection = new ConnectionRepository().GetConnection();
            var filmesController = new FilmesController(connection);
            filmesController.GravarFilmes(
                filmes.Codigo!, filmes.Titulo!, filmes.Audio!, filmes.Sinopse!, filmes.TituloOriginal!,
                filmes.DataLancamento!, filmes.Franquia!, filmes.Genero!, filmes.Tags!, filmes.Diretor!,
                filmes.Estrelas!, filmes.Estudio!
            );
            MessageBox.Show("Filme " + filmes.Titulo + " inserido com sucesso!", "Sucesso", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }
    }
    public class Settings
    {
        public string? TMDBKey { get; set; }
    }
}