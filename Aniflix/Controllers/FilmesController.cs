using Aniflix.Interfaces;
using Aniflix.Model;
using Aniflix.Repository;
using Insight.Database;

namespace Aniflix.Controllers
{
    public class FilmesController : IFilmesRepository
    {
        public void InsereFilmes(FilmesModel filmes)
        {
            try
            {
                var connection = new ConnectionRepository().GetConnection();
                connection.Execute("insert_filme", new
                {
                    filmes.Codigo,
                    filmes.Titulo,
                    filmes.Audio,
                    filmes.Sinopse,
                    filmes.TituloOriginal,
                    filmes.DataLancamento,
                    filmes.Franquia,
                    filmes.Genero,
                    filmes.Tags,
                    filmes.Diretor,
                    filmes.Estrelas,
                    filmes.Estudio
                });

                MessageBox.Show("Aniflix - Filmes", filmes.Titulo + " inserido com sucesso!", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Erro", "Erro:" + ex.Message, MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        public List<FilmesModel> ListaFilmes()
        {
            throw new NotImplementedException();
        }
    }
}
