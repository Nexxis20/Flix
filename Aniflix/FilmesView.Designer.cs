namespace Aniflix
{
    partial class FilmesView
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
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
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            FilmesCodigoText = new Syncfusion.Windows.Forms.Tools.TextBoxExt();
            autoLabel1 = new Syncfusion.Windows.Forms.Tools.AutoLabel();
            autoLabel2 = new Syncfusion.Windows.Forms.Tools.AutoLabel();
            autoLabel3 = new Syncfusion.Windows.Forms.Tools.AutoLabel();
            autoLabel5 = new Syncfusion.Windows.Forms.Tools.AutoLabel();
            autoLabel6 = new Syncfusion.Windows.Forms.Tools.AutoLabel();
            autoLabel7 = new Syncfusion.Windows.Forms.Tools.AutoLabel();
            autoLabel8 = new Syncfusion.Windows.Forms.Tools.AutoLabel();
            autoLabel9 = new Syncfusion.Windows.Forms.Tools.AutoLabel();
            autoLabel10 = new Syncfusion.Windows.Forms.Tools.AutoLabel();
            autoLabel11 = new Syncfusion.Windows.Forms.Tools.AutoLabel();
            FilmesTituloText = new Syncfusion.Windows.Forms.Tools.TextBoxExt();
            FilmesAudioBox = new ComboBox();
            autoLabel12 = new Syncfusion.Windows.Forms.Tools.AutoLabel();
            FilmesSinopseText = new Syncfusion.Windows.Forms.Tools.TextBoxExt();
            FilmesTituloOriginalText = new Syncfusion.Windows.Forms.Tools.TextBoxExt();
            autoLabel4 = new Syncfusion.Windows.Forms.Tools.AutoLabel();
            FilmesDataLancamentoText = new MaskedTextBox();
            FilmesFranquiaText = new Syncfusion.Windows.Forms.Tools.TextBoxExt();
            FilmesGeneroText = new Syncfusion.Windows.Forms.Tools.TextBoxExt();
            FilmesTagsText = new Syncfusion.Windows.Forms.Tools.TextBoxExt();
            FilmesEstrelasText = new Syncfusion.Windows.Forms.Tools.TextBoxExt();
            FilmesDiretorText = new Syncfusion.Windows.Forms.Tools.TextBoxExt();
            FilmesEstudioText = new Syncfusion.Windows.Forms.Tools.TextBoxExt();
            FilmesResumoText = new Syncfusion.Windows.Forms.Tools.TextBoxExt();
            autoLabel13 = new Syncfusion.Windows.Forms.Tools.AutoLabel();
            ((System.ComponentModel.ISupportInitialize)FilmesCodigoText).BeginInit();
            ((System.ComponentModel.ISupportInitialize)FilmesTituloText).BeginInit();
            ((System.ComponentModel.ISupportInitialize)FilmesSinopseText).BeginInit();
            ((System.ComponentModel.ISupportInitialize)FilmesTituloOriginalText).BeginInit();
            ((System.ComponentModel.ISupportInitialize)FilmesFranquiaText).BeginInit();
            ((System.ComponentModel.ISupportInitialize)FilmesGeneroText).BeginInit();
            ((System.ComponentModel.ISupportInitialize)FilmesTagsText).BeginInit();
            ((System.ComponentModel.ISupportInitialize)FilmesEstrelasText).BeginInit();
            ((System.ComponentModel.ISupportInitialize)FilmesDiretorText).BeginInit();
            ((System.ComponentModel.ISupportInitialize)FilmesEstudioText).BeginInit();
            ((System.ComponentModel.ISupportInitialize)FilmesResumoText).BeginInit();
            SuspendLayout();
            // 
            // FilmesCodigoText
            // 
            FilmesCodigoText.BeforeTouchSize = new Size(612, 478);
            FilmesCodigoText.Location = new Point(12, 27);
            FilmesCodigoText.Name = "FilmesCodigoText";
            FilmesCodigoText.PlaceholderText = "Código do Filme";
            FilmesCodigoText.Size = new Size(123, 23);
            FilmesCodigoText.TabIndex = 0;
            FilmesCodigoText.KeyPress += FilmesCodigoText_KeyPress;
            FilmesCodigoText.Leave += FilmesCodigoText_Leave;
            // 
            // autoLabel1
            // 
            autoLabel1.Location = new Point(12, 9);
            autoLabel1.Name = "autoLabel1";
            autoLabel1.Size = new Size(95, 15);
            autoLabel1.TabIndex = 1;
            autoLabel1.Text = "Código do Filme";
            // 
            // autoLabel2
            // 
            autoLabel2.Location = new Point(141, 9);
            autoLabel2.Name = "autoLabel2";
            autoLabel2.Size = new Size(38, 15);
            autoLabel2.TabIndex = 2;
            autoLabel2.Text = "Título";
            // 
            // autoLabel3
            // 
            autoLabel3.Location = new Point(12, 53);
            autoLabel3.Name = "autoLabel3";
            autoLabel3.Size = new Size(48, 15);
            autoLabel3.TabIndex = 3;
            autoLabel3.Text = "Sinopse";
            // 
            // autoLabel5
            // 
            autoLabel5.Location = new Point(489, 244);
            autoLabel5.Name = "autoLabel5";
            autoLabel5.Size = new Size(116, 15);
            autoLabel5.TabIndex = 5;
            autoLabel5.Text = "Data de Lançamento";
            // 
            // autoLabel6
            // 
            autoLabel6.Location = new Point(12, 288);
            autoLabel6.Name = "autoLabel6";
            autoLabel6.Size = new Size(53, 15);
            autoLabel6.TabIndex = 6;
            autoLabel6.Text = "Franquia";
            // 
            // autoLabel7
            // 
            autoLabel7.Location = new Point(12, 332);
            autoLabel7.Name = "autoLabel7";
            autoLabel7.Size = new Size(94, 15);
            autoLabel7.TabIndex = 7;
            autoLabel7.Text = "Gênero do Filme";
            // 
            // autoLabel8
            // 
            autoLabel8.Location = new Point(471, 332);
            autoLabel8.Name = "autoLabel8";
            autoLabel8.Size = new Size(31, 15);
            autoLabel8.TabIndex = 8;
            autoLabel8.Text = "Tags";
            // 
            // autoLabel9
            // 
            autoLabel9.Location = new Point(12, 376);
            autoLabel9.Name = "autoLabel9";
            autoLabel9.Size = new Size(43, 15);
            autoLabel9.TabIndex = 9;
            autoLabel9.Text = "Diretor";
            // 
            // autoLabel10
            // 
            autoLabel10.Location = new Point(12, 420);
            autoLabel10.Name = "autoLabel10";
            autoLabel10.Size = new Size(46, 15);
            autoLabel10.TabIndex = 10;
            autoLabel10.Text = "Estrelas";
            // 
            // autoLabel11
            // 
            autoLabel11.Location = new Point(12, 464);
            autoLabel11.Name = "autoLabel11";
            autoLabel11.Size = new Size(46, 15);
            autoLabel11.TabIndex = 11;
            autoLabel11.Text = "Estúdio";
            // 
            // FilmesTituloText
            // 
            FilmesTituloText.BeforeTouchSize = new Size(612, 478);
            FilmesTituloText.Location = new Point(141, 27);
            FilmesTituloText.Name = "FilmesTituloText";
            FilmesTituloText.PlaceholderText = "Título ";
            FilmesTituloText.Size = new Size(324, 23);
            FilmesTituloText.TabIndex = 18;
            FilmesTituloText.TextChanged += FilmesTituloText_TextChanged;
            // 
            // FilmesAudioBox
            // 
            FilmesAudioBox.FormattingEnabled = true;
            FilmesAudioBox.Items.AddRange(new object[] { "Dublado", "Legendado", "Nacional", "Desconhecido" });
            FilmesAudioBox.Location = new Point(471, 27);
            FilmesAudioBox.Name = "FilmesAudioBox";
            FilmesAudioBox.Size = new Size(153, 23);
            FilmesAudioBox.TabIndex = 19;
            FilmesAudioBox.Text = "Tipo de Áudio";
            FilmesAudioBox.SelectedIndexChanged += FilmesAudioBox_SelectedIndexChanged;
            // 
            // autoLabel12
            // 
            autoLabel12.Location = new Point(471, 9);
            autoLabel12.Name = "autoLabel12";
            autoLabel12.Size = new Size(39, 15);
            autoLabel12.TabIndex = 20;
            autoLabel12.Text = "Áudio";
            // 
            // FilmesSinopseText
            // 
            FilmesSinopseText.BeforeTouchSize = new Size(612, 478);
            FilmesSinopseText.Location = new Point(12, 71);
            FilmesSinopseText.Multiline = true;
            FilmesSinopseText.Name = "FilmesSinopseText";
            FilmesSinopseText.PlaceholderText = "Sinopse";
            FilmesSinopseText.Size = new Size(612, 170);
            FilmesSinopseText.TabIndex = 22;
            FilmesSinopseText.TextChanged += FilmesSinopseText_TextChanged;
            // 
            // FilmesTituloOriginalText
            // 
            FilmesTituloOriginalText.BeforeTouchSize = new Size(612, 478);
            FilmesTituloOriginalText.Location = new Point(12, 262);
            FilmesTituloOriginalText.Name = "FilmesTituloOriginalText";
            FilmesTituloOriginalText.PlaceholderText = "Título Original";
            FilmesTituloOriginalText.Size = new Size(471, 23);
            FilmesTituloOriginalText.TabIndex = 24;
            FilmesTituloOriginalText.TextChanged += FilmesTituloOriginalText_TextChanged;
            // 
            // autoLabel4
            // 
            autoLabel4.Location = new Point(12, 244);
            autoLabel4.Name = "autoLabel4";
            autoLabel4.Size = new Size(83, 15);
            autoLabel4.TabIndex = 23;
            autoLabel4.Text = "Título Original";
            // 
            // FilmesDataLancamentoText
            // 
            FilmesDataLancamentoText.Location = new Point(489, 262);
            FilmesDataLancamentoText.Mask = "00/00/0000";
            FilmesDataLancamentoText.Name = "FilmesDataLancamentoText";
            FilmesDataLancamentoText.Size = new Size(135, 23);
            FilmesDataLancamentoText.TabIndex = 25;
            FilmesDataLancamentoText.ValidatingType = typeof(DateTime);
            FilmesDataLancamentoText.TextChanged += FilmesDataLancamentoText_TextChanged;
            // 
            // FilmesFranquiaText
            // 
            FilmesFranquiaText.BeforeTouchSize = new Size(612, 478);
            FilmesFranquiaText.Location = new Point(12, 306);
            FilmesFranquiaText.Name = "FilmesFranquiaText";
            FilmesFranquiaText.PlaceholderText = "Franquia";
            FilmesFranquiaText.Size = new Size(612, 23);
            FilmesFranquiaText.TabIndex = 26;
            FilmesFranquiaText.TextChanged += FilmesFranquiaText_TextChanged;
            // 
            // FilmesGeneroText
            // 
            FilmesGeneroText.BeforeTouchSize = new Size(612, 478);
            FilmesGeneroText.Location = new Point(12, 350);
            FilmesGeneroText.Name = "FilmesGeneroText";
            FilmesGeneroText.PlaceholderText = "Gênero do Filme";
            FilmesGeneroText.Size = new Size(453, 23);
            FilmesGeneroText.TabIndex = 27;
            FilmesGeneroText.TextChanged += FilmesGeneroText_TextChanged;
            // 
            // FilmesTagsText
            // 
            FilmesTagsText.BeforeTouchSize = new Size(612, 478);
            FilmesTagsText.Location = new Point(471, 350);
            FilmesTagsText.Name = "FilmesTagsText";
            FilmesTagsText.PlaceholderText = "Tags";
            FilmesTagsText.Size = new Size(153, 23);
            FilmesTagsText.TabIndex = 28;
            FilmesTagsText.TextChanged += FilmesTagsText_TextChanged;
            // 
            // FilmesEstrelasText
            // 
            FilmesEstrelasText.BeforeTouchSize = new Size(612, 478);
            FilmesEstrelasText.Location = new Point(12, 438);
            FilmesEstrelasText.Name = "FilmesEstrelasText";
            FilmesEstrelasText.PlaceholderText = "Estrelas";
            FilmesEstrelasText.Size = new Size(612, 23);
            FilmesEstrelasText.TabIndex = 29;
            FilmesEstrelasText.TextChanged += FilmesEstrelasText_TextChanged;
            // 
            // FilmesDiretorText
            // 
            FilmesDiretorText.BeforeTouchSize = new Size(612, 478);
            FilmesDiretorText.Location = new Point(12, 394);
            FilmesDiretorText.Name = "FilmesDiretorText";
            FilmesDiretorText.PlaceholderText = "Diretor";
            FilmesDiretorText.Size = new Size(612, 23);
            FilmesDiretorText.TabIndex = 30;
            FilmesDiretorText.TextChanged += FilmesDiretorText_TextChanged;
            // 
            // FilmesEstudioText
            // 
            FilmesEstudioText.BeforeTouchSize = new Size(612, 478);
            FilmesEstudioText.Location = new Point(12, 482);
            FilmesEstudioText.Name = "FilmesEstudioText";
            FilmesEstudioText.PlaceholderText = "Estúdio";
            FilmesEstudioText.Size = new Size(612, 23);
            FilmesEstudioText.TabIndex = 31;
            FilmesEstudioText.TextChanged += FilmesEstudioText_TextChanged;
            // 
            // FilmesResumoText
            // 
            FilmesResumoText.BeforeTouchSize = new Size(612, 478);
            FilmesResumoText.Location = new Point(630, 27);
            FilmesResumoText.Multiline = true;
            FilmesResumoText.Name = "FilmesResumoText";
            FilmesResumoText.PlaceholderText = "Resumo";
            FilmesResumoText.Size = new Size(612, 478);
            FilmesResumoText.TabIndex = 32;
            // 
            // autoLabel13
            // 
            autoLabel13.Location = new Point(630, 9);
            autoLabel13.Name = "autoLabel13";
            autoLabel13.Size = new Size(50, 15);
            autoLabel13.TabIndex = 33;
            autoLabel13.Text = "Resumo";
            // 
            // FilmesView
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1273, 777);
            Controls.Add(autoLabel13);
            Controls.Add(FilmesResumoText);
            Controls.Add(FilmesEstudioText);
            Controls.Add(FilmesDiretorText);
            Controls.Add(FilmesEstrelasText);
            Controls.Add(FilmesTagsText);
            Controls.Add(FilmesGeneroText);
            Controls.Add(FilmesFranquiaText);
            Controls.Add(FilmesDataLancamentoText);
            Controls.Add(FilmesTituloOriginalText);
            Controls.Add(autoLabel4);
            Controls.Add(FilmesSinopseText);
            Controls.Add(autoLabel12);
            Controls.Add(FilmesAudioBox);
            Controls.Add(FilmesTituloText);
            Controls.Add(autoLabel11);
            Controls.Add(autoLabel10);
            Controls.Add(autoLabel9);
            Controls.Add(autoLabel8);
            Controls.Add(autoLabel7);
            Controls.Add(autoLabel6);
            Controls.Add(autoLabel5);
            Controls.Add(autoLabel3);
            Controls.Add(autoLabel2);
            Controls.Add(autoLabel1);
            Controls.Add(FilmesCodigoText);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            MaximizeBox = false;
            Name = "FilmesView";
            StartPosition = FormStartPosition.CenterScreen;
            Style.MdiChild.IconHorizontalAlignment = HorizontalAlignment.Center;
            Style.MdiChild.IconVerticalAlignment = System.Windows.Forms.VisualStyles.VerticalAlignment.Center;
            Text = "FilmesView";
            ((System.ComponentModel.ISupportInitialize)FilmesCodigoText).EndInit();
            ((System.ComponentModel.ISupportInitialize)FilmesTituloText).EndInit();
            ((System.ComponentModel.ISupportInitialize)FilmesSinopseText).EndInit();
            ((System.ComponentModel.ISupportInitialize)FilmesTituloOriginalText).EndInit();
            ((System.ComponentModel.ISupportInitialize)FilmesFranquiaText).EndInit();
            ((System.ComponentModel.ISupportInitialize)FilmesGeneroText).EndInit();
            ((System.ComponentModel.ISupportInitialize)FilmesTagsText).EndInit();
            ((System.ComponentModel.ISupportInitialize)FilmesEstrelasText).EndInit();
            ((System.ComponentModel.ISupportInitialize)FilmesDiretorText).EndInit();
            ((System.ComponentModel.ISupportInitialize)FilmesEstudioText).EndInit();
            ((System.ComponentModel.ISupportInitialize)FilmesResumoText).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Syncfusion.Windows.Forms.Tools.TextBoxExt FilmesCodigoText;
        private Syncfusion.Windows.Forms.Tools.AutoLabel autoLabel1;
        private Syncfusion.Windows.Forms.Tools.AutoLabel autoLabel2;
        private Syncfusion.Windows.Forms.Tools.AutoLabel autoLabel3;
        private Syncfusion.Windows.Forms.Tools.AutoLabel autoLabel5;
        private Syncfusion.Windows.Forms.Tools.AutoLabel autoLabel6;
        private Syncfusion.Windows.Forms.Tools.AutoLabel autoLabel7;
        private Syncfusion.Windows.Forms.Tools.AutoLabel autoLabel8;
        private Syncfusion.Windows.Forms.Tools.AutoLabel autoLabel9;
        private Syncfusion.Windows.Forms.Tools.AutoLabel autoLabel10;
        private Syncfusion.Windows.Forms.Tools.AutoLabel autoLabel11;
        private Syncfusion.Windows.Forms.Tools.TextBoxExt FilmesTituloText;
        private ComboBox FilmesAudioBox;
        private Syncfusion.Windows.Forms.Tools.AutoLabel autoLabel12;
        private Syncfusion.Windows.Forms.Tools.TextBoxExt FilmesSinopseText;
        private Syncfusion.Windows.Forms.Tools.TextBoxExt FilmesTituloOriginalText;
        private Syncfusion.Windows.Forms.Tools.AutoLabel autoLabel4;
        private MaskedTextBox FilmesDataLancamentoText;
        private Syncfusion.Windows.Forms.Tools.TextBoxExt FilmesFranquiaText;
        private Syncfusion.Windows.Forms.Tools.TextBoxExt FilmesGeneroText;
        private Syncfusion.Windows.Forms.Tools.TextBoxExt FilmesTagsText;
        private Syncfusion.Windows.Forms.Tools.TextBoxExt FilmesEstrelasText;
        private Syncfusion.Windows.Forms.Tools.TextBoxExt FilmesDiretorText;
        private Syncfusion.Windows.Forms.Tools.TextBoxExt FilmesEstudioText;
        private Syncfusion.Windows.Forms.Tools.TextBoxExt FilmesResumoText;
        private Syncfusion.Windows.Forms.Tools.AutoLabel autoLabel13;
    }
}