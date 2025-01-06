using Aniflix.Model;
using Insight.Database;

namespace Aniflix.Interfaces
{
    public interface IFilmesRepository
    {
        void GravarFilmes(
         string p_codigo, string p_titulo, string p_audio, string p_sinopse,
         string p_titulo_original, string p_data_lancamento, string p_franquia,
         string p_genero, string p_tags, string p_diretor, string p_estrelas, string p_estudio);
        public void VerificarCodigo(string p_codigo, TextBox textBox);
        [Sql("SELECT * FROM filmes WHERE codigo = @Codigo")]
        Filmes GetFilmeByCodigo(string codigo);

        [Sql("SELECT * FROM filmes")]
        IEnumerable<Filmes> GetAllFilmes();

        // load first record mysql
        [Sql("SELECT * FROM filmes LIMIT 1")]
        Filmes GetFirstFilme();

    }
}