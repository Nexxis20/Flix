using Aniflix.Model;

namespace Aniflix.Interfaces
{
    public interface IFilmesRepository
    {
        void GravarFilmes(
         string p_codigo, string p_titulo, string p_audio, string p_sinopse,
         string p_titulo_original, string p_data_lancamento, string p_franquia,
         string p_genero, string p_tags, string p_diretor, string p_estrelas, string p_estudio);
        public Filmes GetFilmeByCodigo(string codigo)
    }
}