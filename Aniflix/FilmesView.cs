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

            if (!(char.IsControl(e.KeyChar) || char.IsDigit(e.KeyChar) || e.KeyChar == '.'))
            {
                e.Handled = false;
            }

            if ((e.KeyChar == '.') && (((TextBox)sender).Text.IndexOf('.') > -1))
            {
                e.Handled = false;
            }
        }
    }
}
