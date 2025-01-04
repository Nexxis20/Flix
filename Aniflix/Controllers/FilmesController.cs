using Aniflix.Interfaces;
using Aniflix.Model;
using Aniflix.Repository;

namespace Aniflix.Controllers
{
    public class FilmesController : IFilmesRepository
    {
        public void InsereFilmes(Filmes filmes)
        {
            var factory = new ConnectionRepository();
            factory.GetConnection().Insert(filmes);


        }

        public List<Filmes> ListaFilmes()
        {
            throw new NotImplementedException();
        }
    }
}
