using Aniflix.Interfaces;
using Aniflix.Model;
using Aniflix.Repository;
using Insight.Database;

namespace Aniflix.Controllers
{
    public class FilmesController
    {
        public void RegistrarNovoFilme(string p_codigo, string p_titulo, string p_audio, string p_sinopse, string p_titulo_original, string p_data_lancamento, string p_franquia,
            string p_genero, string p_tags, string p_diretor, string p_estrelas, string p_estudio)
        {
            var filmes = new Filmes
            {
                Codigo = p_codigo,
                Titulo = p_titulo,
                Audio = p_audio,
                Sinopse = p_sinopse,
                TituloOriginal = p_titulo_original,
                DataLancamento = p_data_lancamento,
                Franquia = p_franquia,
                Genero = p_genero,
                Tags = p_tags,
                Diretor = p_diretor,
                Estrelas = p_estrelas,
                Estudio = p_estudio
            };

            using var connection = new ConnectionRepository().GetConnection();
            IFilmesRepository i = connection.As<IFilmesRepository>();
            i.GravarFilmes(filmes);
        }
    }
}
