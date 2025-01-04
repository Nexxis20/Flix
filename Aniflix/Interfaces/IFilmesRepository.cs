using Aniflix.Model;

namespace Aniflix.Interfaces
{
    public interface IFilmesRepository
    {
        void NovoFilme(FilmesModel filmes);
        List<FilmesModel> ListaFilmes();
    }
}
