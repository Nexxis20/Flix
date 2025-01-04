using Aniflix.Model;

namespace Aniflix.Interfaces
{
    public interface IFilmesRepository
    {
        void InsereFilmes(FilmesModel filmes);
        List<FilmesModel> ListaFilmes();
    }
}
