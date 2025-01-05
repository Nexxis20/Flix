using Aniflix.Interfaces;
using Aniflix.Model;
using Aniflix.Repository;
using Insight.Database;

namespace Aniflix.Controllers
{
    public class FilmesController
    {
        public void RegistrarNovoFilme(string codigo, string titulo, string audio, string sinopse, string tituloOriginal, string data_lancamento, string franquia,
            string genero, string tags, string diretor, string estrelas, string estudio)
        {
            var filmes = new Filmes
            {
                Codigo = codigo,
                Titulo = titulo,
                Audio = audio,
                Sinopse = sinopse,
                TituloOriginal = tituloOriginal,
                DataLancamento = data_lancamento,
                Franquia = franquia,
                Genero = genero,
                Tags = tags,
                Diretor = diretor,
                Estrelas = estrelas,
                Estudio = estudio
            };

            using var connection = new ConnectionRepository().GetConnection();
            IFilmesRepository i = connection.As<IFilmesRepository>();
            i.GravarFilmes(filmes);
        }
    }
}
