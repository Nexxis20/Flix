using Aniflix.Model;

namespace Aniflix.Data
{
    internal class FilmeNavigator
    {
        private List<Filmes> _filmes;
        private int _currentIndex;

        public FilmesNavigator(List<Filmes> filmes)
        {
            _filmes = filmes;
            _currentIndex = 0;
        }

        public Filmes? GetCurrent()
        {
            if (_filmes.Count == 0) return null;
            return _filmes[_currentIndex];
        }

        public Filmes? GetNext()
        {
            if (_currentIndex < _filmes.Count - 1)
            {
                _currentIndex++;
                return _filmes[_currentIndex];
            }
            return null; // Não há próximo registro
        }

        public Filmes? GetPrevious()
        {
            if (_currentIndex > 0)
            {
                _currentIndex--;
                return _filmes[_currentIndex];
            }
            return null; // Não há registro anterior
        }
    }
}
