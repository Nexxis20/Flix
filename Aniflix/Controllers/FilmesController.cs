using System.Data;
using Aniflix.Interfaces;
using Aniflix.Model;
using Insight.Database;

namespace Aniflix.Controllers
{
    public class FilmesController(IDbConnection connection) : IFilmesRepository
    {
        private readonly IDbConnection _connection = connection;

        public IEnumerable<Filmes> GetAllFilmes()
        {
            var repository = _connection.As<IFilmesRepository>();
            return repository.GetAllFilmes();
        }
        public Filmes GetFilmeByCodigo(string codigo)
        {
            var repository = _connection.As<IFilmesRepository>();
            return repository.GetFilmeByCodigo(codigo);
        }

        public Filmes GetFirstFilme()
        {
            var repository = _connection.As<IFilmesRepository>();
            return repository.GetFirstFilme();
        }

        public List<Filmes> GetListFilmes()
        {
            var repository = _connection.As<IFilmesRepository>();
            return repository.GetListFilmes();
        }

        public void GravarFilmes(
            string p_codigo, string p_titulo, string p_audio, string p_sinopse,
            string p_titulo_original, string p_data_lancamento, string p_franquia,
            string p_genero, string p_tags, string p_diretor, string p_estrelas,
            string p_estudio, string p_mcu)
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
                p_estudio,
                p_mcu
            };

            _connection.Execute("GravarFilmes", parameters, commandType: CommandType.StoredProcedure);
        }

        public void VerificarCodigo(string p_codigo, TextBox textBox)
        {
            var codigoExistente = _connection.ExecuteScalarSql<long>("SELECT COUNT(1) FROM filmes WHERE codigo = @Codigo", new { Codigo = p_codigo });

            if (codigoExistente > 0)
            {
                MessageBox.Show("O código informado já está registrado na base de dados.", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                textBox.Focus();
            }
        }
    }
}