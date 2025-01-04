using Aniflix.Interfaces;
using Aniflix.Model;
using Aniflix.Repository;
using Insight.Database;

namespace Aniflix.Controllers
{
    public static class FilmesController
    {
        public static void Insert(FilmesModel filmes, int codigo, string titulo)
        {
            var connection = new ConnectionRepository().GetConnection();
            IFilmesRepository i = connection.As<IFilmesRepository>();
            codigo = filmes.Codigo;
            titulo = filmes.Titulo;

            i.GravarFilmes(filmes);
        }

    }
}
