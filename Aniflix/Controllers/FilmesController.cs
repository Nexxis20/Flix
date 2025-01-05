using Aniflix.Interfaces;
using Aniflix.Model;
using Insight.Database;
using System.Data;

namespace Aniflix.Controllers
{
    public class FilmesController(IDbConnection connection) : IFilmesRepository
    {
        private readonly IDbConnection _connection = connection;

        public void GravarFilmes(
            string p_codigo, string p_titulo, string p_audio, string p_sinopse,
            string p_titulo_original, string p_data_lancamento, string p_franquia,
            string p_genero, string p_tags, string p_diretor, string p_estrelas, string p_estudio)
        {
            var parameters = new
            {
                p_codigo,
                p_titulo,
                p_audio,
                p_sinopse,
                p_titulo_original,
                p_data_lancamento,
                p_franquia,
                p_genero,
                p_tags,
                p_diretor,
                p_estrelas,
                p_estudio
            };

            _connection.Execute("GravarFilmes", parameters, commandType: CommandType.StoredProcedure);
        }

        public List<Filmes> ListarFilmes()
        {

        }
    }
}