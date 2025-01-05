using Syncfusion.WinForms.Controls;

namespace Aniflix
{
    public partial class AniflixView : SfForm
    {
        public AniflixView()
        {
            InitializeComponent();
        }

        private void Filmes_Click(object sender, EventArgs e)
        {
            var filmesView = new FilmesView();
            filmesView.Show();
        }
    }
}
