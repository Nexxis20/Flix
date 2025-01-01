namespace Aniflix
{
    partial class AniflixView
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            Filmes = new Syncfusion.WinForms.Controls.SfButton();
            Sair = new Syncfusion.WinForms.Controls.SfButton();
            Series = new Syncfusion.WinForms.Controls.SfButton();
            GoreButton = new Syncfusion.WinForms.Controls.SfButton();
            BreakOut = new Syncfusion.WinForms.Controls.SfButton();
            Animes = new Syncfusion.WinForms.Controls.SfButton();
            GoreFilmes = new Syncfusion.WinForms.Controls.SfButton();
            sfButton2 = new Syncfusion.WinForms.Controls.SfButton();
            SuspendLayout();
            // 
            // Filmes
            // 
            Filmes.BackColor = Color.FromArgb(52, 152, 219);
            Filmes.Font = new Font("Inconsolata", 11.25F, FontStyle.Bold);
            Filmes.ForeColor = Color.White;
            Filmes.ImageSize = new Size(48, 48);
            Filmes.Location = new Point(300, 160);
            Filmes.Name = "Filmes";
            Filmes.Size = new Size(124, 108);
            Filmes.Style.BackColor = Color.FromArgb(52, 152, 219);
            Filmes.Style.ForeColor = Color.White;
            Filmes.Style.Image = Properties.Resources.filmstrip;
            Filmes.Style.ImageForeColor = Color.White;
            Filmes.TabIndex = 0;
            Filmes.Text = "Filmes";
            Filmes.TextAlign = ContentAlignment.BottomLeft;
            Filmes.TextImageRelation = TextImageRelation.Overlay;
            Filmes.UseVisualStyleBackColor = false;
            // 
            // Sair
            // 
            Sair.BackColor = Color.FromArgb(211, 72, 38);
            Sair.Font = new Font("Inconsolata", 11.25F, FontStyle.Bold);
            Sair.ForeColor = Color.White;
            Sair.ImageSize = new Size(48, 48);
            Sair.Location = new Point(595, 372);
            Sair.Name = "Sair";
            Sair.Size = new Size(159, 92);
            Sair.Style.BackColor = Color.FromArgb(211, 72, 38);
            Sair.Style.ForeColor = Color.White;
            Sair.Style.Image = Properties.Resources.exit_to_app;
            Sair.Style.ImageForeColor = Color.White;
            Sair.TabIndex = 1;
            Sair.Text = "Sair";
            Sair.TextAlign = ContentAlignment.BottomLeft;
            Sair.TextImageRelation = TextImageRelation.Overlay;
            Sair.UseVisualStyleBackColor = false;
            // 
            // Series
            // 
            Series.BackColor = Color.FromArgb(34, 132, 121);
            Series.Font = new Font("Inconsolata", 11.25F, FontStyle.Bold);
            Series.ForeColor = Color.White;
            Series.ImageSize = new Size(48, 48);
            Series.Location = new Point(300, 274);
            Series.Name = "Series";
            Series.Size = new Size(124, 92);
            Series.Style.BackColor = Color.FromArgb(34, 132, 121);
            Series.Style.ForeColor = Color.White;
            Series.Style.Image = Properties.Resources.camcorder;
            Series.Style.ImageForeColor = Color.White;
            Series.TabIndex = 2;
            Series.Text = "Séries";
            Series.TextAlign = ContentAlignment.BottomLeft;
            Series.TextImageRelation = TextImageRelation.Overlay;
            Series.UseVisualStyleBackColor = false;
            // 
            // GoreButton
            // 
            GoreButton.BackColor = Color.FromArgb(220, 97, 65);
            GoreButton.Font = new Font("Inconsolata", 11.25F, FontStyle.Bold);
            GoreButton.ForeColor = Color.White;
            GoreButton.ImageSize = new Size(48, 48);
            GoreButton.Location = new Point(300, 372);
            GoreButton.Name = "GoreButton";
            GoreButton.Size = new Size(124, 92);
            GoreButton.Style.BackColor = Color.FromArgb(220, 97, 65);
            GoreButton.Style.ForeColor = Color.White;
            GoreButton.Style.Image = Properties.Resources.balloon;
            GoreButton.Style.ImageForeColor = Color.White;
            GoreButton.TabIndex = 3;
            GoreButton.Text = "Gore";
            GoreButton.TextAlign = ContentAlignment.BottomLeft;
            GoreButton.TextImageRelation = TextImageRelation.Overlay;
            GoreButton.UseVisualStyleBackColor = false;
            // 
            // BreakOut
            // 
            BreakOut.BackColor = Color.FromArgb(82, 0, 101);
            BreakOut.Font = new Font("Inconsolata", 11.25F, FontStyle.Bold);
            BreakOut.ForeColor = Color.White;
            BreakOut.ImageSize = new Size(48, 48);
            BreakOut.Location = new Point(430, 274);
            BreakOut.Name = "BreakOut";
            BreakOut.Size = new Size(159, 92);
            BreakOut.Style.BackColor = Color.FromArgb(82, 0, 101);
            BreakOut.Style.ForeColor = Color.White;
            BreakOut.Style.Image = Properties.Resources.babel;
            BreakOut.Style.ImageForeColor = Color.White;
            BreakOut.TabIndex = 4;
            BreakOut.Text = "BreakOut - Filmes";
            BreakOut.TextAlign = ContentAlignment.BottomLeft;
            BreakOut.TextImageRelation = TextImageRelation.Overlay;
            BreakOut.UseVisualStyleBackColor = false;
            // 
            // Animes
            // 
            Animes.BackColor = Color.FromArgb(96, 61, 188);
            Animes.Font = new Font("Inconsolata", 11.25F, FontStyle.Bold);
            Animes.ForeColor = Color.White;
            Animes.ImageSize = new Size(48, 48);
            Animes.Location = new Point(430, 160);
            Animes.Name = "Animes";
            Animes.Size = new Size(324, 108);
            Animes.Style.BackColor = Color.FromArgb(96, 61, 188);
            Animes.Style.ForeColor = Color.White;
            Animes.Style.Image = Properties.Resources.animation_play;
            Animes.Style.ImageForeColor = Color.White;
            Animes.TabIndex = 5;
            Animes.Text = "Animes";
            Animes.TextAlign = ContentAlignment.BottomLeft;
            Animes.TextImageRelation = TextImageRelation.Overlay;
            Animes.UseVisualStyleBackColor = false;
            // 
            // GoreFilmes
            // 
            GoreFilmes.BackColor = Color.FromArgb(220, 97, 65);
            GoreFilmes.Font = new Font("Inconsolata", 11.25F, FontStyle.Bold);
            GoreFilmes.ForeColor = Color.White;
            GoreFilmes.ImageSize = new Size(48, 48);
            GoreFilmes.Location = new Point(430, 372);
            GoreFilmes.Name = "GoreFilmes";
            GoreFilmes.Size = new Size(159, 92);
            GoreFilmes.Style.BackColor = Color.FromArgb(220, 97, 65);
            GoreFilmes.Style.ForeColor = Color.White;
            GoreFilmes.Style.Image = Properties.Resources.balloon;
            GoreFilmes.Style.ImageForeColor = Color.White;
            GoreFilmes.TabIndex = 6;
            GoreFilmes.Text = "Gore - Séries";
            GoreFilmes.TextAlign = ContentAlignment.BottomLeft;
            GoreFilmes.TextImageRelation = TextImageRelation.Overlay;
            GoreFilmes.UseVisualStyleBackColor = false;
            // 
            // sfButton2
            // 
            sfButton2.BackColor = Color.FromArgb(82, 0, 101);
            sfButton2.Font = new Font("Inconsolata", 11.25F, FontStyle.Bold);
            sfButton2.ForeColor = Color.White;
            sfButton2.ImageSize = new Size(48, 48);
            sfButton2.Location = new Point(595, 274);
            sfButton2.Name = "sfButton2";
            sfButton2.Size = new Size(159, 92);
            sfButton2.Style.BackColor = Color.FromArgb(82, 0, 101);
            sfButton2.Style.ForeColor = Color.White;
            sfButton2.Style.Image = Properties.Resources.babel;
            sfButton2.Style.ImageForeColor = Color.White;
            sfButton2.TabIndex = 7;
            sfButton2.Text = "BreakOut - Séries";
            sfButton2.TextAlign = ContentAlignment.BottomLeft;
            sfButton2.TextImageRelation = TextImageRelation.Overlay;
            sfButton2.UseVisualStyleBackColor = false;
            // 
            // AniflixView
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1054, 624);
            Controls.Add(sfButton2);
            Controls.Add(GoreFilmes);
            Controls.Add(Animes);
            Controls.Add(BreakOut);
            Controls.Add(GoreButton);
            Controls.Add(Series);
            Controls.Add(Sair);
            Controls.Add(Filmes);
            MaximizeBox = false;
            Name = "AniflixView";
            StartPosition = FormStartPosition.CenterScreen;
            Style.MdiChild.IconHorizontalAlignment = HorizontalAlignment.Center;
            Style.MdiChild.IconVerticalAlignment = System.Windows.Forms.VisualStyles.VerticalAlignment.Center;
            Text = "Aniflix";
            ResumeLayout(false);
        }

        #endregion

        private Syncfusion.WinForms.Controls.SfButton Filmes;
        private Syncfusion.WinForms.Controls.SfButton Sair;
        private Syncfusion.WinForms.Controls.SfButton Series;
        private Syncfusion.WinForms.Controls.SfButton GoreButton;
        private Syncfusion.WinForms.Controls.SfButton BreakOut;
        private Syncfusion.WinForms.Controls.SfButton Animes;
        private Syncfusion.WinForms.Controls.SfButton GoreFilmes;
        private Syncfusion.WinForms.Controls.SfButton sfButton2;
    }
}
