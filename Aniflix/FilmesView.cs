﻿namespace Aniflix
{
    public partial class FilmesView : Form
    {
        public FilmesView()
        {
            InitializeComponent();
        }
        private void FilmesCodigoText_KeyPress(object sender, KeyPressEventArgs e)
        {

            if (!char.IsControl(e.KeyChar) || !char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
            }
        }
    }
}