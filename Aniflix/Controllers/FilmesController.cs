using Aniflix.Interfaces;
using Aniflix.Model;
using Aniflix.Repository;
using Insight.Database;

namespace Aniflix.Controllers
{
    public class FilmesController : IFilmesRepository
    {
        public void InsereFilmes(Filmes filmes)
        {
            var factory = new ConnectionRepository().GetConnection();
            factory.Execute("insert_filmes", new
            {
                filmes.
                filmes.Titulo,
                filmes.Descricao,
                filmes.Ano,
                filmes.Diretor,
                filmes.Genero,

                filmes.Avaliacao,
                filmes.Imagem
            });

        }

        public List<Filmes> ListaFilmes()
        {
            throw new NotImplementedException();
        }
    }
}
