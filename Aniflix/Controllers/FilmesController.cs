using Aniflix.Interfaces;
using Aniflix.Model;
using Aniflix.Repository;
using Insight.Database;

namespace Aniflix.Controllers
{
    public class FilmesController
    {
        public static void InsereFilmes(FilmesModel filmes)
        {

            var connection = new ConnectionRepository().GetConnection();
            IFilmesRepository i = connection.As<IFilmesRepository>();
            i.InsereFilmes(filmes);
        }

    }
}
