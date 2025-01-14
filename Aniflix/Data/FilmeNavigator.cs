using Aniflix.Model;

namespace Aniflix.Data
{
    public class FilmesNavigator
    {
        private readonly List<Filmes> _filmes;
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
            return null;
        }
        public Filmes? GetPrevious()
        {
            if (_currentIndex > 0)
            {
                _currentIndex--;
                return _filmes[_currentIndex];
            }
            return null;
        }
    }
}