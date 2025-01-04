using Aniflix.Interfaces;
using Aniflix.Model;

namespace Aniflix.Controllers
{
    public class FilmesController : IFilmesRepository
    {
        public void InsereFilmes(Filmes filmes)
        {
            var factory = new ConnectionFactory();
            factory.GetConnection().Insert(filmes);


        }

        public List<Filmes> ListaFilmes()
        {
            throw new NotImplementedException();
        }
    }
}
