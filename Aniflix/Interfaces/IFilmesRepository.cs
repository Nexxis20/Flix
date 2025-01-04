using Aniflix.Model;

namespace Aniflix.Interfaces
{
    public interface IFilmesRepository
    {
        void GravarFilmes(FilmesModel filmes);
        List<FilmesModel> ListaFilmes();
    }
}
