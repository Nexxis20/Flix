using Aniflix.Model;

namespace Aniflix.Interfaces
{
    public interface IFilmesRepository
    {
        void GravarFilmes(Filmes filmes);
        List<Filmes> ListaFilmes();
    }
}
