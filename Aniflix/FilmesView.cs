using Aniflix.Controllers;
using Aniflix.Data;
using Aniflix.Extensions;
using Aniflix.Model;
using Aniflix.Repository;
using Insight.Database;
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

        private void GetFilmes()
        {
            using var connection = new ConnectionRepository().GetConnection();
            var codigoExistente = connection.ExecuteScalarSql<long>("SELECT COUNT(1) FROM filmes WHERE codigo = @Codigo", new { Codigo = FilmesCodigoText.Text });

            if (codigoExistente > 0)
            {
                MessageBox.Show("O código informado já está registrado na base de dados.", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                FilmesCodigoText.Focus();
            }

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
                FilmesFranquiaText.Text = FormatString(StringExtensions.RemoveDiacritics(FilmesTituloText.Text));
            }
            else
            {
                MessageBox.Show("Nenhum filme encontrado.", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
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

            if (movie!.Genres != null && movie!.Genres.Count > 2)
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

            var stars = credits
                .Cast.Take(5)
                .Select(person => $"#{person.Name.Replace(" ", "")}")
                .ToList();

            var studios = movie
                .ProductionCompanies.Take(5)
                .Select(company => $"#{company.Name.Replace(" ", "")}")
                .ToList();

            FilmesDiretorText.Text = string.Join(" ", StringExtensions.ClearLists(directors));
            FilmesEstrelasText.Text = string.Join(" ", StringExtensions.ClearLists(stars));
            FilmesEstudioText.Text = string.Join(" ", StringExtensions.ClearLists(studios));
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
        private void FilmesCodigoText_Leave(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(FilmesCodigoText.Text))
            {
                MessageBox.Show("Por favor, insira o código do filme.");
                FilmesCodigoText.Focus();
            }
            else
            {
                GetFilmes();
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