using Aniflix.Interfaces;
using Aniflix.Model;
using Aniflix.Repository;
using Insight.Database;

namespace Aniflix.Controllers
{
    public static class FilmesController
    {
        public static void RegistrarNovoFilme(int codigo, string titulo, string audio, string sinopse, string titulo_original, string data_lancamento, string franquia,
            string genero, string tags, string diretor, string estrelas, string estudio)
        {
            var filmes = new FilmesModel
            {
                Codigo = codigo,
                Titulo = titulo,
                Audio = audio,
                Sinopse = sinopse,
                TituloOriginal = titulo_original,
                DataLancamento = data_lancamento,
                Franquia = franquia,
                Genero = genero,
                Tags = tags,
                Diretor = diretor,
                Estrelas = estrelas,
                Estudio = estudio
            };

            var connection = new ConnectionRepository().GetConnection();
            IFilmesRepository i = connection.As<IFilmesRepository>();
            i.GravarFilmes(filmes);
        }
    }
}
