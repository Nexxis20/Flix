using Aniflix.Data;
using Aniflix.Interfaces;
using Aniflix.Model;

namespace Aniflix.Controllers
{
    private static string connection = new ConnectionFactory();
    public class FilmesController : IFilmesRepository
    {
        public void InsereFilmes(Filmes filmes)
        {
            var repo = ConnectionFactory.
        }

        public List<Filmes> ListaFilmes()
        {
            throw new NotImplementedException();
        }
    }
}
