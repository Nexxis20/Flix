namespace Aniflix
{
    public partial class FilmesView : Form
    {
        public FilmesView()
        {
            InitializeComponent();
        }
        private void FilmesCodigoText_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar))
            {
                e.Handled = true;
            }
        }
    }
}