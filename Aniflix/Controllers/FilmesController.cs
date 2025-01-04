using Aniflix.Interfaces;
using Aniflix.Model;
using Aniflix.Repository;
using Insight.Database;

namespace Aniflix.Controllers
{
    public static class FilmesController
    {
        public static void RegistrarNovoFilme(FilmesModel filmes, int codigo, string titulo, string audio, string sinopse, string titulo_original, string data_lancamento, string franquia,
            string genero, string tags, string diretor, string estrelas, string estudio)
        {
            filmes.Codigo = codigo;
            filmes.Titulo = titulo;
            filmes.Audio = audio;
            filmes.Sinopse = sinopse;
            filmes.TituloOriginal = titulo_original;
            filmes.DataLancamento = data_lancamento;
            filmes.Franquia = franquia;
            filmes.Genero = genero;
            filmes.Tags = tags;
            filmes.Diretor = diretor;
            filmes.Estrelas = estrelas;
            filmes.Estudio = estudio;
            var connection = new ConnectionRepository().GetConnection();
            IFilmesRepository i = connection.As<IFilmesRepository>();
            i.GravarFilmes(filmes);
        }
    }
}
