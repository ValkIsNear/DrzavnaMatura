namespace DRZAVNA_MATURA_NOVO
{
    partial class DMForm
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
            TabControl = new TabControl();
            tabSkola = new TabPage();
            btnUcitajOdeljenja = new Button();
            chbSkolaJeMuzickaSkola = new CheckBox();
            lbOdeljenja = new ListBox();
            btnSnimiOdeljenja = new Button();
            btnObrisiOdeljenje = new Button();
            btnSacuvajOdeljenje = new Button();
            cbSkolaBrojOdeljenja = new ComboBox();
            lSkolaOdeljenje = new Label();
            cbSkolaStepenOdeljenja = new ComboBox();
            lSkolaTreciPredmet = new Label();
            cbSkolaTreciPredmet = new ComboBox();
            lSkolaDrugiPredmet = new Label();
            cbSkolaDrugiPredmet = new ComboBox();
            lSkolaPrviPredmet = new Label();
            cbSkolaPrviPredmet = new ComboBox();
            lSkolaJezikMature = new Label();
            cbSkolaJezikMature = new ComboBox();
            lSkolaTipMature = new Label();
            cbSkolaTipMature = new ComboBox();
            tabUcenici = new TabPage();
            cbUceniciStepen = new ComboBox();
            tbImePrezime = new TextBox();
            lImePrezime = new Label();
            bUcitajUcenike = new Button();
            chbUceniciJeMuzickaSkola = new CheckBox();
            lbUcenici = new ListBox();
            bSnimiUcenike = new Button();
            bObrisiUcenika = new Button();
            bSačuvajUčenika = new Button();
            cbUceniciBroj = new ComboBox();
            lUceniciOdeljenje = new Label();
            lUceniciTreciPredmet = new Label();
            cbUceniciTreciPredmet = new ComboBox();
            lUceniciDrugiPredmet = new Label();
            cbUceniciDrugiPredmet = new ComboBox();
            lUceniciPrviPredmet = new Label();
            cbUceniciPrviPredmet = new ComboBox();
            lUceniciJezikMature = new Label();
            cbUceniciJezikMature = new ComboBox();
            lUceniciTipMature = new Label();
            cbUceniciTipMatrue = new ComboBox();
            textBox1 = new TextBox();
            TabControl.SuspendLayout();
            tabSkola.SuspendLayout();
            tabUcenici.SuspendLayout();
            SuspendLayout();
            // 
            // TabControl
            // 
            TabControl.Controls.Add(tabSkola);
            TabControl.Controls.Add(tabUcenici);
            TabControl.Location = new Point(12, 12);
            TabControl.Name = "TabControl";
            TabControl.SelectedIndex = 0;
            TabControl.Size = new Size(1213, 356);
            TabControl.TabIndex = 0;
            // 
            // tabSkola
            // 
            tabSkola.Controls.Add(btnUcitajOdeljenja);
            tabSkola.Controls.Add(chbSkolaJeMuzickaSkola);
            tabSkola.Controls.Add(lbOdeljenja);
            tabSkola.Controls.Add(btnSnimiOdeljenja);
            tabSkola.Controls.Add(btnObrisiOdeljenje);
            tabSkola.Controls.Add(btnSacuvajOdeljenje);
            tabSkola.Controls.Add(cbSkolaBrojOdeljenja);
            tabSkola.Controls.Add(lSkolaOdeljenje);
            tabSkola.Controls.Add(cbSkolaStepenOdeljenja);
            tabSkola.Controls.Add(lSkolaTreciPredmet);
            tabSkola.Controls.Add(cbSkolaTreciPredmet);
            tabSkola.Controls.Add(lSkolaDrugiPredmet);
            tabSkola.Controls.Add(cbSkolaDrugiPredmet);
            tabSkola.Controls.Add(lSkolaPrviPredmet);
            tabSkola.Controls.Add(cbSkolaPrviPredmet);
            tabSkola.Controls.Add(lSkolaJezikMature);
            tabSkola.Controls.Add(cbSkolaJezikMature);
            tabSkola.Controls.Add(lSkolaTipMature);
            tabSkola.Controls.Add(cbSkolaTipMature);
            tabSkola.Location = new Point(4, 24);
            tabSkola.Name = "tabSkola";
            tabSkola.Padding = new Padding(3);
            tabSkola.Size = new Size(1205, 328);
            tabSkola.TabIndex = 0;
            tabSkola.Text = "Škola";
            tabSkola.UseVisualStyleBackColor = true;
            // 
            // btnUcitajOdeljenja
            // 
            btnUcitajOdeljenja.Location = new Point(311, 296);
            btnUcitajOdeljenja.Name = "btnUcitajOdeljenja";
            btnUcitajOdeljenja.Size = new Size(133, 23);
            btnUcitajOdeljenja.TabIndex = 18;
            btnUcitajOdeljenja.Text = "Učitaj odeljenja";
            btnUcitajOdeljenja.UseVisualStyleBackColor = true;
            btnUcitajOdeljenja.Click += btnUcitajOdeljenja_Click;
            // 
            // chbSkolaJeMuzickaSkola
            // 
            chbSkolaJeMuzickaSkola.AutoSize = true;
            chbSkolaJeMuzickaSkola.Location = new Point(130, 90);
            chbSkolaJeMuzickaSkola.Name = "chbSkolaJeMuzickaSkola";
            chbSkolaJeMuzickaSkola.Size = new Size(101, 19);
            chbSkolaJeMuzickaSkola.TabIndex = 17;
            chbSkolaJeMuzickaSkola.Text = "Muzička Škola";
            chbSkolaJeMuzickaSkola.UseVisualStyleBackColor = true;
            chbSkolaJeMuzickaSkola.CheckedChanged += chbJeMuzickaSkola_CheckedChanged;
            // 
            // lbOdeljenja
            // 
            lbOdeljenja.FormattingEnabled = true;
            lbOdeljenja.ItemHeight = 15;
            lbOdeljenja.Location = new Point(465, 30);
            lbOdeljenja.Name = "lbOdeljenja";
            lbOdeljenja.Size = new Size(714, 289);
            lbOdeljenja.TabIndex = 16;
            lbOdeljenja.SelectedIndexChanged += lbOdeljenja_SelectedIndexChanged;
            // 
            // btnSnimiOdeljenja
            // 
            btnSnimiOdeljenja.Location = new Point(311, 267);
            btnSnimiOdeljenja.Name = "btnSnimiOdeljenja";
            btnSnimiOdeljenja.Size = new Size(133, 23);
            btnSnimiOdeljenja.TabIndex = 15;
            btnSnimiOdeljenja.Text = "Snimi odeljenja";
            btnSnimiOdeljenja.UseVisualStyleBackColor = true;
            btnSnimiOdeljenja.Click += btnSnimiOdeljenja_Click;
            // 
            // btnObrisiOdeljenje
            // 
            btnObrisiOdeljenje.Location = new Point(130, 296);
            btnObrisiOdeljenje.Name = "btnObrisiOdeljenje";
            btnObrisiOdeljenje.Size = new Size(112, 23);
            btnObrisiOdeljenje.TabIndex = 14;
            btnObrisiOdeljenje.Text = "Obriši odeljenje";
            btnObrisiOdeljenje.UseVisualStyleBackColor = true;
            btnObrisiOdeljenje.Click += btnObrisiOdeljenje_Click;
            // 
            // btnSacuvajOdeljenje
            // 
            btnSacuvajOdeljenje.Location = new Point(130, 267);
            btnSacuvajOdeljenje.Name = "btnSacuvajOdeljenje";
            btnSacuvajOdeljenje.Size = new Size(112, 23);
            btnSacuvajOdeljenje.TabIndex = 13;
            btnSacuvajOdeljenje.Text = "Sačuvaj odeljenje";
            btnSacuvajOdeljenje.UseVisualStyleBackColor = true;
            btnSacuvajOdeljenje.Click += btnSacuvajOdeljenje_Click;
            // 
            // cbSkolaBrojOdeljenja
            // 
            cbSkolaBrojOdeljenja.DropDownStyle = ComboBoxStyle.DropDownList;
            cbSkolaBrojOdeljenja.FormattingEnabled = true;
            cbSkolaBrojOdeljenja.Location = new Point(298, 30);
            cbSkolaBrojOdeljenja.Name = "cbSkolaBrojOdeljenja";
            cbSkolaBrojOdeljenja.Size = new Size(146, 23);
            cbSkolaBrojOdeljenja.TabIndex = 12;
            cbSkolaBrojOdeljenja.SelectedIndexChanged += cbSkolaOdeljenje_Changed;
            // 
            // lSkolaOdeljenje
            // 
            lSkolaOdeljenje.AutoSize = true;
            lSkolaOdeljenje.Location = new Point(23, 30);
            lSkolaOdeljenje.Name = "lSkolaOdeljenje";
            lSkolaOdeljenje.Size = new Size(57, 15);
            lSkolaOdeljenje.TabIndex = 11;
            lSkolaOdeljenje.Text = "Odeljenje";
            // 
            // cbSkolaStepenOdeljenja
            // 
            cbSkolaStepenOdeljenja.DropDownStyle = ComboBoxStyle.DropDownList;
            cbSkolaStepenOdeljenja.FormattingEnabled = true;
            cbSkolaStepenOdeljenja.Location = new Point(130, 30);
            cbSkolaStepenOdeljenja.Name = "cbSkolaStepenOdeljenja";
            cbSkolaStepenOdeljenja.Size = new Size(162, 23);
            cbSkolaStepenOdeljenja.TabIndex = 10;
            cbSkolaStepenOdeljenja.SelectedIndexChanged += cbSkolaOdeljenje_Changed;
            // 
            // lSkolaTreciPredmet
            // 
            lSkolaTreciPredmet.AutoSize = true;
            lSkolaTreciPredmet.Location = new Point(23, 205);
            lSkolaTreciPredmet.Name = "lSkolaTreciPredmet";
            lSkolaTreciPredmet.Size = new Size(79, 15);
            lSkolaTreciPredmet.TabIndex = 9;
            lSkolaTreciPredmet.Text = "Treci Predmet";
            // 
            // cbSkolaTreciPredmet
            // 
            cbSkolaTreciPredmet.DropDownStyle = ComboBoxStyle.DropDownList;
            cbSkolaTreciPredmet.FormattingEnabled = true;
            cbSkolaTreciPredmet.Location = new Point(130, 202);
            cbSkolaTreciPredmet.Name = "cbSkolaTreciPredmet";
            cbSkolaTreciPredmet.Size = new Size(314, 23);
            cbSkolaTreciPredmet.TabIndex = 8;
            // 
            // lSkolaDrugiPredmet
            // 
            lSkolaDrugiPredmet.AutoSize = true;
            lSkolaDrugiPredmet.Location = new Point(23, 176);
            lSkolaDrugiPredmet.Name = "lSkolaDrugiPredmet";
            lSkolaDrugiPredmet.Size = new Size(84, 15);
            lSkolaDrugiPredmet.TabIndex = 7;
            lSkolaDrugiPredmet.Text = "Drugi Predmet";
            // 
            // cbSkolaDrugiPredmet
            // 
            cbSkolaDrugiPredmet.DropDownStyle = ComboBoxStyle.DropDownList;
            cbSkolaDrugiPredmet.FormattingEnabled = true;
            cbSkolaDrugiPredmet.Location = new Point(130, 173);
            cbSkolaDrugiPredmet.Name = "cbSkolaDrugiPredmet";
            cbSkolaDrugiPredmet.Size = new Size(314, 23);
            cbSkolaDrugiPredmet.TabIndex = 6;
            // 
            // lSkolaPrviPredmet
            // 
            lSkolaPrviPredmet.AutoSize = true;
            lSkolaPrviPredmet.Location = new Point(23, 147);
            lSkolaPrviPredmet.Name = "lSkolaPrviPredmet";
            lSkolaPrviPredmet.Size = new Size(75, 15);
            lSkolaPrviPredmet.TabIndex = 5;
            lSkolaPrviPredmet.Text = "Prvi Predmet";
            // 
            // cbSkolaPrviPredmet
            // 
            cbSkolaPrviPredmet.DropDownStyle = ComboBoxStyle.DropDownList;
            cbSkolaPrviPredmet.FormattingEnabled = true;
            cbSkolaPrviPredmet.Location = new Point(130, 144);
            cbSkolaPrviPredmet.Name = "cbSkolaPrviPredmet";
            cbSkolaPrviPredmet.Size = new Size(314, 23);
            cbSkolaPrviPredmet.TabIndex = 4;
            // 
            // lSkolaJezikMature
            // 
            lSkolaJezikMature.AutoSize = true;
            lSkolaJezikMature.Location = new Point(23, 118);
            lSkolaJezikMature.Name = "lSkolaJezikMature";
            lSkolaJezikMature.Size = new Size(72, 15);
            lSkolaJezikMature.TabIndex = 3;
            lSkolaJezikMature.Text = "Jezik Mature";
            // 
            // cbSkolaJezikMature
            // 
            cbSkolaJezikMature.DropDownStyle = ComboBoxStyle.DropDownList;
            cbSkolaJezikMature.FormattingEnabled = true;
            cbSkolaJezikMature.Location = new Point(130, 115);
            cbSkolaJezikMature.Name = "cbSkolaJezikMature";
            cbSkolaJezikMature.Size = new Size(314, 23);
            cbSkolaJezikMature.TabIndex = 2;
            // 
            // lSkolaTipMature
            // 
            lSkolaTipMature.AutoSize = true;
            lSkolaTipMature.Location = new Point(23, 62);
            lSkolaTipMature.Name = "lSkolaTipMature";
            lSkolaTipMature.Size = new Size(64, 15);
            lSkolaTipMature.TabIndex = 1;
            lSkolaTipMature.Text = "Tip Mature";
            // 
            // cbSkolaTipMature
            // 
            cbSkolaTipMature.DropDownStyle = ComboBoxStyle.DropDownList;
            cbSkolaTipMature.FormattingEnabled = true;
            cbSkolaTipMature.Location = new Point(130, 59);
            cbSkolaTipMature.Name = "cbSkolaTipMature";
            cbSkolaTipMature.Size = new Size(314, 23);
            cbSkolaTipMature.TabIndex = 0;
            cbSkolaTipMature.SelectedIndexChanged += cbSkolaTipMature_SelectedIndexChanged;
            // 
            // tabUcenici
            // 
            tabUcenici.Controls.Add(textBox1);
            tabUcenici.Controls.Add(cbUceniciStepen);
            tabUcenici.Controls.Add(tbImePrezime);
            tabUcenici.Controls.Add(lImePrezime);
            tabUcenici.Controls.Add(bUcitajUcenike);
            tabUcenici.Controls.Add(chbUceniciJeMuzickaSkola);
            tabUcenici.Controls.Add(lbUcenici);
            tabUcenici.Controls.Add(bSnimiUcenike);
            tabUcenici.Controls.Add(bObrisiUcenika);
            tabUcenici.Controls.Add(bSačuvajUčenika);
            tabUcenici.Controls.Add(cbUceniciBroj);
            tabUcenici.Controls.Add(lUceniciOdeljenje);
            tabUcenici.Controls.Add(lUceniciTreciPredmet);
            tabUcenici.Controls.Add(cbUceniciTreciPredmet);
            tabUcenici.Controls.Add(lUceniciDrugiPredmet);
            tabUcenici.Controls.Add(cbUceniciDrugiPredmet);
            tabUcenici.Controls.Add(lUceniciPrviPredmet);
            tabUcenici.Controls.Add(cbUceniciPrviPredmet);
            tabUcenici.Controls.Add(lUceniciJezikMature);
            tabUcenici.Controls.Add(cbUceniciJezikMature);
            tabUcenici.Controls.Add(lUceniciTipMature);
            tabUcenici.Controls.Add(cbUceniciTipMatrue);
            tabUcenici.Location = new Point(4, 24);
            tabUcenici.Name = "tabUcenici";
            tabUcenici.Padding = new Padding(3);
            tabUcenici.Size = new Size(1205, 328);
            tabUcenici.TabIndex = 1;
            tabUcenici.Text = "Učenici";
            tabUcenici.UseVisualStyleBackColor = true;
            // 
            // cbUceniciStepen
            // 
            cbUceniciStepen.DropDownStyle = ComboBoxStyle.DropDownList;
            cbUceniciStepen.FormattingEnabled = true;
            cbUceniciStepen.Location = new Point(132, 22);
            cbUceniciStepen.Name = "cbUceniciStepen";
            cbUceniciStepen.Size = new Size(162, 23);
            cbUceniciStepen.TabIndex = 40;
            cbUceniciStepen.SelectedIndexChanged += cbUceniciOdeljenje_Changed;
            // 
            // tbImePrezime
            // 
            tbImePrezime.Location = new Point(132, 51);
            tbImePrezime.Name = "tbImePrezime";
            tbImePrezime.PlaceholderText = "Upiši ime i prezime učenika";
            tbImePrezime.Size = new Size(126, 23);
            tbImePrezime.TabIndex = 39;
            tbImePrezime.KeyDown += TbImePrezime_KeyDown;
            // 
            // lImePrezime
            // 
            lImePrezime.AutoSize = true;
            lImePrezime.Location = new Point(25, 54);
            lImePrezime.Name = "lImePrezime";
            lImePrezime.Size = new Size(78, 15);
            lImePrezime.TabIndex = 38;
            lImePrezime.Text = "Ime i prezime";
            // 
            // bUcitajUcenike
            // 
            bUcitajUcenike.Location = new Point(313, 288);
            bUcitajUcenike.Name = "bUcitajUcenike";
            bUcitajUcenike.Size = new Size(133, 23);
            bUcitajUcenike.TabIndex = 37;
            bUcitajUcenike.Text = "Učitaj učenike";
            bUcitajUcenike.UseVisualStyleBackColor = true;
            bUcitajUcenike.Click += bUcitajUcenike_Click;
            // 
            // chbUceniciJeMuzickaSkola
            // 
            chbUceniciJeMuzickaSkola.AutoSize = true;
            chbUceniciJeMuzickaSkola.Location = new Point(132, 119);
            chbUceniciJeMuzickaSkola.Name = "chbUceniciJeMuzickaSkola";
            chbUceniciJeMuzickaSkola.Size = new Size(101, 19);
            chbUceniciJeMuzickaSkola.TabIndex = 36;
            chbUceniciJeMuzickaSkola.Text = "Muzička Škola";
            chbUceniciJeMuzickaSkola.UseVisualStyleBackColor = true;
            chbUceniciJeMuzickaSkola.CheckedChanged += chbUceniciJeMuzickaSkola_CheckedChanged;
            // 
            // lbUcenici
            // 
            lbUcenici.FormattingEnabled = true;
            lbUcenici.ItemHeight = 15;
            lbUcenici.Location = new Point(467, 22);
            lbUcenici.Name = "lbUcenici";
            lbUcenici.Size = new Size(714, 289);
            lbUcenici.TabIndex = 35;
            lbUcenici.SelectedIndexChanged += lbUcenici_SelectedIndexChanged;
            // 
            // bSnimiUcenike
            // 
            bSnimiUcenike.Location = new Point(313, 259);
            bSnimiUcenike.Name = "bSnimiUcenike";
            bSnimiUcenike.Size = new Size(133, 23);
            bSnimiUcenike.TabIndex = 34;
            bSnimiUcenike.Text = "Snimi učenike";
            bSnimiUcenike.UseVisualStyleBackColor = true;
            bSnimiUcenike.Click += bSnimiUcenike_Click;
            // 
            // bObrisiUcenika
            // 
            bObrisiUcenika.Location = new Point(132, 288);
            bObrisiUcenika.Name = "bObrisiUcenika";
            bObrisiUcenika.Size = new Size(112, 23);
            bObrisiUcenika.TabIndex = 33;
            bObrisiUcenika.Text = "Obriši učenika";
            bObrisiUcenika.UseVisualStyleBackColor = true;
            bObrisiUcenika.Click += bObrisiUcenika_Click;
            // 
            // bSačuvajUčenika
            // 
            bSačuvajUčenika.Location = new Point(132, 259);
            bSačuvajUčenika.Name = "bSačuvajUčenika";
            bSačuvajUčenika.Size = new Size(112, 23);
            bSačuvajUčenika.TabIndex = 32;
            bSačuvajUčenika.Text = "Sačuvaj učenika";
            bSačuvajUčenika.UseVisualStyleBackColor = true;
            bSačuvajUčenika.Click += bSačuvajUčenika_Click;
            // 
            // cbUceniciBroj
            // 
            cbUceniciBroj.DropDownStyle = ComboBoxStyle.DropDownList;
            cbUceniciBroj.FormattingEnabled = true;
            cbUceniciBroj.Location = new Point(300, 22);
            cbUceniciBroj.Name = "cbUceniciBroj";
            cbUceniciBroj.Size = new Size(146, 23);
            cbUceniciBroj.TabIndex = 31;
            cbUceniciBroj.SelectedIndexChanged += cbUceniciOdeljenje_Changed;
            // 
            // lUceniciOdeljenje
            // 
            lUceniciOdeljenje.AutoSize = true;
            lUceniciOdeljenje.Location = new Point(23, 30);
            lUceniciOdeljenje.Name = "lUceniciOdeljenje";
            lUceniciOdeljenje.Size = new Size(57, 15);
            lUceniciOdeljenje.TabIndex = 30;
            lUceniciOdeljenje.Text = "Odeljenje";
            // 
            // lUceniciTreciPredmet
            // 
            lUceniciTreciPredmet.AutoSize = true;
            lUceniciTreciPredmet.Location = new Point(25, 234);
            lUceniciTreciPredmet.Name = "lUceniciTreciPredmet";
            lUceniciTreciPredmet.Size = new Size(79, 15);
            lUceniciTreciPredmet.TabIndex = 28;
            lUceniciTreciPredmet.Text = "Treci Predmet";
            // 
            // cbUceniciTreciPredmet
            // 
            cbUceniciTreciPredmet.DropDownStyle = ComboBoxStyle.DropDownList;
            cbUceniciTreciPredmet.FormattingEnabled = true;
            cbUceniciTreciPredmet.Location = new Point(132, 231);
            cbUceniciTreciPredmet.Name = "cbUceniciTreciPredmet";
            cbUceniciTreciPredmet.Size = new Size(314, 23);
            cbUceniciTreciPredmet.TabIndex = 27;
            // 
            // lUceniciDrugiPredmet
            // 
            lUceniciDrugiPredmet.AutoSize = true;
            lUceniciDrugiPredmet.Location = new Point(25, 205);
            lUceniciDrugiPredmet.Name = "lUceniciDrugiPredmet";
            lUceniciDrugiPredmet.Size = new Size(84, 15);
            lUceniciDrugiPredmet.TabIndex = 26;
            lUceniciDrugiPredmet.Text = "Drugi Predmet";
            // 
            // cbUceniciDrugiPredmet
            // 
            cbUceniciDrugiPredmet.DropDownStyle = ComboBoxStyle.DropDownList;
            cbUceniciDrugiPredmet.FormattingEnabled = true;
            cbUceniciDrugiPredmet.Location = new Point(132, 202);
            cbUceniciDrugiPredmet.Name = "cbUceniciDrugiPredmet";
            cbUceniciDrugiPredmet.Size = new Size(314, 23);
            cbUceniciDrugiPredmet.TabIndex = 25;
            // 
            // lUceniciPrviPredmet
            // 
            lUceniciPrviPredmet.AutoSize = true;
            lUceniciPrviPredmet.Location = new Point(25, 176);
            lUceniciPrviPredmet.Name = "lUceniciPrviPredmet";
            lUceniciPrviPredmet.Size = new Size(75, 15);
            lUceniciPrviPredmet.TabIndex = 24;
            lUceniciPrviPredmet.Text = "Prvi Predmet";
            // 
            // cbUceniciPrviPredmet
            // 
            cbUceniciPrviPredmet.DropDownStyle = ComboBoxStyle.DropDownList;
            cbUceniciPrviPredmet.FormattingEnabled = true;
            cbUceniciPrviPredmet.Location = new Point(132, 173);
            cbUceniciPrviPredmet.Name = "cbUceniciPrviPredmet";
            cbUceniciPrviPredmet.Size = new Size(314, 23);
            cbUceniciPrviPredmet.TabIndex = 23;
            // 
            // lUceniciJezikMature
            // 
            lUceniciJezikMature.AutoSize = true;
            lUceniciJezikMature.Location = new Point(25, 147);
            lUceniciJezikMature.Name = "lUceniciJezikMature";
            lUceniciJezikMature.Size = new Size(72, 15);
            lUceniciJezikMature.TabIndex = 22;
            lUceniciJezikMature.Text = "Jezik Mature";
            // 
            // cbUceniciJezikMature
            // 
            cbUceniciJezikMature.DropDownStyle = ComboBoxStyle.DropDownList;
            cbUceniciJezikMature.FormattingEnabled = true;
            cbUceniciJezikMature.Location = new Point(132, 144);
            cbUceniciJezikMature.Name = "cbUceniciJezikMature";
            cbUceniciJezikMature.Size = new Size(314, 23);
            cbUceniciJezikMature.TabIndex = 21;
            // 
            // lUceniciTipMature
            // 
            lUceniciTipMature.AutoSize = true;
            lUceniciTipMature.Location = new Point(25, 91);
            lUceniciTipMature.Name = "lUceniciTipMature";
            lUceniciTipMature.Size = new Size(64, 15);
            lUceniciTipMature.TabIndex = 20;
            lUceniciTipMature.Text = "Tip Mature";
            // 
            // cbUceniciTipMatrue
            // 
            cbUceniciTipMatrue.DropDownStyle = ComboBoxStyle.DropDownList;
            cbUceniciTipMatrue.FormattingEnabled = true;
            cbUceniciTipMatrue.Location = new Point(132, 88);
            cbUceniciTipMatrue.Name = "cbUceniciTipMatrue";
            cbUceniciTipMatrue.Size = new Size(314, 23);
            cbUceniciTipMatrue.TabIndex = 19;
            cbUceniciTipMatrue.SelectedIndexChanged += cbUceniciTipMature_SelectedIndexChanged;
            // 
            // textBox1
            // 
            textBox1.Location = new Point(264, 51);
            textBox1.Name = "textBox1";
            textBox1.PlaceholderText = "Upiši ime i prezime učenika";
            textBox1.Size = new Size(182, 23);
            textBox1.TabIndex = 41;
            // 
            // DMForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1235, 381);
            Controls.Add(TabControl);
            Name = "DMForm";
            Text = "Državna Matura";
            TabControl.ResumeLayout(false);
            tabSkola.ResumeLayout(false);
            tabSkola.PerformLayout();
            tabUcenici.ResumeLayout(false);
            tabUcenici.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private TabControl TabControl;
        private TabPage tabSkola;
        private TabPage tabUcenici;
        private ComboBox cbSkolaTipMature;
        private Label lSkolaTipMature;
        private ComboBox cbSkolaJezikMature;
        private Label lSkolaJezikMature;
        private Label lSkolaPrviPredmet;
        private ComboBox cbSkolaPrviPredmet;
        private Label lSkolaDrugiPredmet;
        private ComboBox cbSkolaDrugiPredmet;
        private Label lSkolaTreciPredmet;
        private ComboBox cbSkolaTreciPredmet;
        private Label lSkolaOdeljenje;
        private ComboBox cbSkolaStepenOdeljenja;
        private ComboBox cbSkolaBrojOdeljenja;
        private ListBox lbOdeljenja;
        private Button btnSnimiOdeljenja;
        private Button btnObrisiOdeljenje;
        private Button btnSacuvajOdeljenje;
        private CheckBox chbSkolaJeMuzickaSkola;
        private Button btnUcitajOdeljenja;
        private Button bUcitajUcenike;
        private CheckBox chbUceniciJeMuzickaSkola;
        private ListBox lbUcenici;
        private Button bSnimiUcenike;
        private Button bObrisiUcenika;
        private Button bSačuvajUčenika;
        private ComboBox cbUceniciBroj;
        private Label lUceniciOdeljenje;
        private Label lUceniciTreciPredmet;
        private ComboBox cbUceniciTreciPredmet;
        private Label lUceniciDrugiPredmet;
        private ComboBox cbUceniciDrugiPredmet;
        private Label lUceniciPrviPredmet;
        private ComboBox cbUceniciPrviPredmet;
        private Label lUceniciJezikMature;
        private ComboBox cbUceniciJezikMature;
        private Label lUceniciTipMature;
        private ComboBox cbUceniciTipMatrue;
        private TextBox tbImePrezime;
        private Label lImePrezime;
        private ComboBox cbUceniciStepen;
        private TextBox textBox1;
    }
}
