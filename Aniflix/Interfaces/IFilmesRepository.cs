using Aniflix.Model;

namespace Aniflix.Interfaces
{
    public interface IFilmesRepository
    {
        void InsereFilmes(Filmes filmes);
        List<Filmes> ListaFilmes();
    }
}
