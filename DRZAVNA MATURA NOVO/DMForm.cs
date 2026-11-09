using System;
using System.IO;
using System.Text;
using System.Windows.Forms;

namespace DRZAVNA_MATURA_NOVO
{
    public partial class DMForm : Form
    {
        private Odeljenje? trenutnoOdeljenje;
        private Ucenik? trenutniUcenik;

        #region Inicijalizacija
        public DMForm()
        {
            InitializeComponent();
            InitializeCustomComponents();
            LoadOdeljenjaList(); // Učitaj postojeća odeljenja
            LoadUcenikeList();
        }
        private void InitializeCustomComponents()
        {
            // Podaci
            // Za Škola tab - koristi kopije
            cbSkolaStepenOdeljenja.DataSource = new List<string>(Liste.StepenOdeljenja);
            cbSkolaBrojOdeljenja.DataSource = new List<string>(Liste.BrojOdeljenja);
            cbSkolaTipMature.DataSource = new List<string>(Liste.TipMature);
            cbSkolaJezikMature.DataSource = new List<string>(Liste.Jezici);
            cbSkolaPrviPredmet.DataSource = new List<string>(Liste.PrviPredmet);
            cbSkolaDrugiPredmet.DataSource = new List<string>(Liste.DrugiPredmet);

            // Za Učenici tab - koristi kopije
            cbUceniciStepen.DataSource = new List<string>(Liste.StepenOdeljenja);
            cbUceniciBroj.DataSource = new List<string>(Liste.BrojOdeljenja);
            cbUceniciTipMatrue.DataSource = new List<string>(Liste.TipMature);
            cbUceniciJezikMature.DataSource = new List<string>(Liste.Jezici);
            cbUceniciPrviPredmet.DataSource = new List<string>(Liste.PrviPredmet);
            cbUceniciDrugiPredmet.DataSource = new List<string>(Liste.DrugiPredmet);

            chbSkolaJeMuzickaSkola.Checked = false; // Podrazumevano nije muzička škola
            chbUceniciJeMuzickaSkola.Checked = false; // Podrazumevano nije muzička škola

            // Sakrij treći predmet i checkbox na početku
            cbSkolaTreciPredmet.Visible = false;
            lSkolaTreciPredmet.Visible = false;
            chbSkolaJeMuzickaSkola.Visible = false;

            cbUceniciTreciPredmet.Visible = false;
            lUceniciTreciPredmet.Visible = false;
            chbUceniciJeMuzickaSkola.Visible = false;

            // Inicijalno popunjavanje trećeg predmeta
            cbSkolaTipMature_SelectedIndexChanged(null, null);
            cbUceniciTipMature_SelectedIndexChanged(null, null);
        }
        #endregion

        #region Škola tab - Metode za rad sa odeljenjima
        private void LoadOdeljenjaList(Odeljenje? odeljenjeZaSelekciju = null)
        {
            lbOdeljenja.DataSource = null;
            lbOdeljenja.DataSource = OdeljenjaManager.GetAllOdeljenja();
            lbOdeljenja.DisplayMember = "ToString";

            if (odeljenjeZaSelekciju != null)
            {
                var odeljenjeUListi = OdeljenjaManager.GetAllOdeljenja()
                    .FirstOrDefault(o => o.Stepen == odeljenjeZaSelekciju.Stepen &&
                                         o.Broj == odeljenjeZaSelekciju.Broj);
                if (odeljenjeUListi != null)
                {
                    lbOdeljenja.SelectedItem = odeljenjeUListi;
                    PrekopirajPodatkeIzSkoleUUcenike(); // Automatski prekopiraj podatke u Učenici tab
                }
            }

            int brojOdeljenja = OdeljenjaManager.GetAllOdeljenja().Count;
            this.Text = $"Državna Matura - {brojOdeljenja} odeljenja";
        }

        private void LoadOdeljenje(string stepen, string broj)
        {
            trenutnoOdeljenje = OdeljenjaManager.GetOdeljenjeByStepenAndBroj(stepen, broj);

            if (trenutnoOdeljenje != null)
            {
                cbSkolaTipMature.SelectedItem = trenutnoOdeljenje.TipMature;
                cbSkolaJezikMature.SelectedItem = trenutnoOdeljenje.JezikMature;
                cbSkolaPrviPredmet.SelectedItem = trenutnoOdeljenje.PrviPredmet;
                cbSkolaDrugiPredmet.SelectedItem = trenutnoOdeljenje.DrugiPredmet;

                if (trenutnoOdeljenje.TipMature == "Umetnička matura")
                {
                    chbSkolaJeMuzickaSkola.Visible = true;
                    bool jeMuzicka = !string.IsNullOrEmpty(trenutnoOdeljenje.TreciPredmet);
                    chbSkolaJeMuzickaSkola.Checked = jeMuzicka;
                    cbSkolaTreciPredmet.Visible = jeMuzicka;
                    lSkolaTreciPredmet.Visible = jeMuzicka;

                    if (jeMuzicka && trenutnoOdeljenje.TreciPredmet != null)
                    {
                        cbSkolaTreciPredmet.SelectedItem = trenutnoOdeljenje.TreciPredmet;
                    }
                }
                else
                {
                    chbSkolaJeMuzickaSkola.Visible = false;
                    cbSkolaTreciPredmet.Visible = true;
                    lSkolaTreciPredmet.Visible = true;
                    cbSkolaTreciPredmet.SelectedItem = trenutnoOdeljenje.TreciPredmet;
                }

                PrekopirajPodatkeIzSkoleUUcenike(); // Automatski prekopiraj ažurirane podatke u Učenici tab
            }
        }

        private void UpdateCurrentOdeljenje()
        {
            if (trenutnoOdeljenje != null)
            {
                trenutnoOdeljenje.TipMature = cbSkolaTipMature.SelectedItem?.ToString();
                trenutnoOdeljenje.JezikMature = cbSkolaJezikMature.SelectedItem?.ToString();
                trenutnoOdeljenje.PrviPredmet = cbSkolaPrviPredmet.SelectedItem?.ToString();
                trenutnoOdeljenje.DrugiPredmet = cbSkolaDrugiPredmet.SelectedItem?.ToString();

                if (trenutnoOdeljenje.TipMature == "Umetnička matura")
                {
                    if (chbSkolaJeMuzickaSkola.Checked && cbSkolaTreciPredmet.Visible)
                    {
                        trenutnoOdeljenje.TreciPredmet = cbSkolaTreciPredmet.SelectedItem?.ToString();
                    }
                    else
                    {
                        trenutnoOdeljenje.TreciPredmet = null;
                    }
                }
                else
                {
                    trenutnoOdeljenje.TreciPredmet = cbSkolaTreciPredmet.SelectedItem?.ToString();
                }

                PrekopirajPodatkeIzSkoleUUcenike(); // Automatski prekopiraj ažurirane podatke u Učenici tab
            }
        }
        #endregion

        #region Učenici tab - Metode za rad sa učenicima
        private void LoadUcenikeList()
        {
            lbUcenici.DataSource = null;
            lbUcenici.DataSource = UceniciManager.GetAllUcenici();
            lbUcenici.DisplayMember = "ToString";

            lbUcenici.ClearSelected();

            ClearUcenikForm();
        }

        private void LoadUcenik(Ucenik? ucenik)
        {
            if (ucenik != null)
            {
                trenutniUcenik = ucenik;
                tbImePrezime.Text = ucenik.ImePrezime;
                cbUceniciStepen.SelectedItem = ucenik.Stepen;
                cbUceniciBroj.SelectedItem = ucenik.Broj;
                cbUceniciTipMatrue.SelectedItem = ucenik.TipMature;
                cbUceniciJezikMature.SelectedItem = ucenik.JezikMature;
                cbUceniciPrviPredmet.SelectedItem = ucenik.PrviPredmet;
                cbUceniciDrugiPredmet.SelectedItem = ucenik.DrugiPredmet;

                if (ucenik.TipMature == "Umetnička matura")
                {
                    chbUceniciJeMuzickaSkola.Visible = true;
                    bool jeMuzicka = !string.IsNullOrEmpty(ucenik.TreciPredmet);
                    chbUceniciJeMuzickaSkola.Checked = jeMuzicka;
                    cbUceniciTreciPredmet.Visible = jeMuzicka;
                    lUceniciTreciPredmet.Visible = jeMuzicka;

                    if (jeMuzicka && ucenik.TreciPredmet != null)
                    {
                        cbUceniciTreciPredmet.SelectedItem = ucenik.TreciPredmet;
                    }
                }
                else
                {
                    chbUceniciJeMuzickaSkola.Visible = false;
                    cbUceniciTreciPredmet.Visible = true;
                    lUceniciTreciPredmet.Visible = true;
                    cbUceniciTreciPredmet.SelectedItem = ucenik.TreciPredmet;
                }
            }
        }

        private void UpdateCurrentUcenik()
        {
            if (trenutniUcenik != null)
            {
                trenutniUcenik.ImePrezime = tbImePrezime.Text.Trim();
                trenutniUcenik.Stepen = cbUceniciStepen.SelectedItem?.ToString();
                trenutniUcenik.Broj = cbUceniciBroj.SelectedItem?.ToString();
                trenutniUcenik.TipMature = cbUceniciTipMatrue.SelectedItem?.ToString();
                trenutniUcenik.JezikMature = cbUceniciJezikMature.SelectedItem?.ToString();
                trenutniUcenik.PrviPredmet = cbUceniciPrviPredmet.SelectedItem?.ToString();
                trenutniUcenik.DrugiPredmet = cbUceniciDrugiPredmet.SelectedItem?.ToString();

                if (trenutniUcenik.TipMature == "Umetnička matura")
                {
                    if (chbUceniciJeMuzickaSkola.Checked && cbUceniciTreciPredmet.Visible)
                    {
                        trenutniUcenik.TreciPredmet = cbUceniciTreciPredmet.SelectedItem?.ToString();
                    }
                    else
                    {
                        trenutniUcenik.TreciPredmet = null;
                    }
                }
                else
                {
                    trenutniUcenik.TreciPredmet = cbUceniciTreciPredmet.SelectedItem?.ToString();
                }
            }
        }

        private void ClearUcenikForm()
        {
            tbImePrezime.Text = "";
            trenutniUcenik = null;
        }

        private void LoadOdeljenjePodatkeZaUcenika()
        {
            string? stepen = cbUceniciStepen.SelectedItem?.ToString();
            string? broj = cbUceniciBroj.SelectedItem?.ToString();

            if (!string.IsNullOrEmpty(stepen) && !string.IsNullOrEmpty(broj))
            {
                var odeljenje = OdeljenjaManager.GetOdeljenjeByStepenAndBroj(stepen, broj);
                if (odeljenje != null && trenutniUcenik == null)
                {
                    cbUceniciTipMatrue.SelectedItem = odeljenje.TipMature;
                    cbUceniciJezikMature.SelectedItem = odeljenje.JezikMature;
                    cbUceniciPrviPredmet.SelectedItem = odeljenje.PrviPredmet;
                    cbUceniciDrugiPredmet.SelectedItem = odeljenje.DrugiPredmet;

                    if (odeljenje.TipMature == "Umetnička matura" && !string.IsNullOrEmpty(odeljenje.TreciPredmet))
                    {
                        chbUceniciJeMuzickaSkola.Checked = true;
                        cbUceniciTreciPredmet.SelectedItem = odeljenje.TreciPredmet;
                    }
                }
            }
        }
        #endregion

        #region Metode za prekopiranje podataka
        private void PrekopirajPodatkeIzSkoleUUcenike()
        {
            // Proveri da li je odeljenje selektovano u tabu Škola
            string? stepen = cbSkolaStepenOdeljenja.SelectedItem?.ToString();
            string? broj = cbSkolaBrojOdeljenja.SelectedItem?.ToString();

            if (string.IsNullOrEmpty(stepen) || string.IsNullOrEmpty(broj))
            {
                MessageBox.Show("Prvo izaberite odeljenje u tabu Škola!",
                    "Upozorenje", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            // Pronađi odeljenje
            var odeljenje = OdeljenjaManager.GetOdeljenjeByStepenAndBroj(stepen, broj);

            if (odeljenje == null)
            {
                MessageBox.Show($"Odeljenje {stepen}-{broj} ne postoji! Prvo ga sačuvajte u tabu Škola.",
                    "Upozorenje", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            // Prekopiraj podatke u combo box-ove na tabu Učenici
            cbUceniciStepen.SelectedItem = stepen;
            cbUceniciBroj.SelectedItem = broj;
            cbUceniciTipMatrue.SelectedItem = odeljenje.TipMature;
            cbUceniciJezikMature.SelectedItem = odeljenje.JezikMature;
            cbUceniciPrviPredmet.SelectedItem = odeljenje.PrviPredmet;
            cbUceniciDrugiPredmet.SelectedItem = odeljenje.DrugiPredmet;

            // Obradi treći predmet u zavisnosti od tipa mature
            if (odeljenje.TipMature == "Umetnička matura")
            {
                // Prikaži checkbox za muzičku školu
                chbUceniciJeMuzickaSkola.Visible = true;

                // Proveri da li odeljenje ima treći predmet (muzička škola)
                if (!string.IsNullOrEmpty(odeljenje.TreciPredmet))
                {
                    chbUceniciJeMuzickaSkola.Checked = true;
                    cbUceniciTreciPredmet.Visible = true;
                    lUceniciTreciPredmet.Visible = true;

                    // Postavi listu trećih predmeta za umetničku maturu
                    cbUceniciTreciPredmet.DataSource = new List<string>(Liste.UmetnickaTreciPredmet);
                    cbUceniciTreciPredmet.SelectedItem = odeljenje.TreciPredmet;
                }
                else
                {
                    chbUceniciJeMuzickaSkola.Checked = false;
                    cbUceniciTreciPredmet.Visible = false;
                    lUceniciTreciPredmet.Visible = false;
                }
            }
            else
            {
                // Za opštu i stručnu maturu
                chbUceniciJeMuzickaSkola.Visible = false;
                chbUceniciJeMuzickaSkola.Checked = false;
                cbUceniciTreciPredmet.Visible = true;
                lUceniciTreciPredmet.Visible = true;

                // Postavi odgovarajuću listu trećih predmeta
                switch (odeljenje.TipMature)
                {
                    case "Opšta matura":
                        cbUceniciTreciPredmet.DataSource = new List<string>(Liste.OpstaTreciPredmet);
                        break;
                    case "Stručna matura":
                        cbUceniciTreciPredmet.DataSource = new List<string>(Liste.StrucnaTreciPredmet);
                        break;
                }

                // Ako odeljenje ima treći predmet, postavi ga
                if (!string.IsNullOrEmpty(odeljenje.TreciPredmet))
                {
                    cbUceniciTreciPredmet.SelectedItem = odeljenje.TreciPredmet;
                }
            }
        }
        #endregion

        #region Event Handlers - Škola tab
        private void cbSkolaTipMature_SelectedIndexChanged(object? sender, EventArgs? e)
        {
            string? selectedType = cbSkolaTipMature.SelectedItem?.ToString();

            switch (selectedType)
            {
                case "Opšta matura":
                    cbSkolaTreciPredmet.DataSource = Liste.OpstaTreciPredmet;
                    chbSkolaJeMuzickaSkola.Visible = false;
                    chbSkolaJeMuzickaSkola.Checked = false;
                    cbSkolaTreciPredmet.Visible = true;
                    lSkolaTreciPredmet.Visible = true;
                    break;
                case "Stručna matura":
                    cbSkolaTreciPredmet.DataSource = Liste.StrucnaTreciPredmet;
                    chbSkolaJeMuzickaSkola.Visible = false;
                    chbSkolaJeMuzickaSkola.Checked = false;
                    cbSkolaTreciPredmet.Visible = true;
                    lSkolaTreciPredmet.Visible = true;
                    break;
                case "Umetnička matura":
                    cbSkolaTreciPredmet.DataSource = Liste.UmetnickaTreciPredmet;
                    chbSkolaJeMuzickaSkola.Visible = true;
                    chbSkolaJeMuzickaSkola.Checked = false;
                    cbSkolaTreciPredmet.Visible = false;
                    lSkolaTreciPredmet.Visible = false;
                    break;
                default:
                    cbSkolaTreciPredmet.DataSource = null;
                    break;
            }
        }

        private void chbJeMuzickaSkola_CheckedChanged(object? sender, EventArgs? e)
        {
            string? selectedType = cbSkolaTipMature.SelectedItem?.ToString();
            if (selectedType == "Umetnička matura")
            {
                if (chbSkolaJeMuzickaSkola.Checked)
                {
                    cbSkolaTreciPredmet.Visible = true;
                    lSkolaTreciPredmet.Visible = true;
                    if (cbSkolaTreciPredmet.Items.Count > 0)
                        cbSkolaTreciPredmet.SelectedIndex = 0;
                }
                else
                {
                    cbSkolaTreciPredmet.Visible = false;
                    lSkolaTreciPredmet.Visible = false;
                }
            }
        }

        private void cbSkolaOdeljenje_Changed(object? sender, EventArgs? e)
        {
            string? stepen = cbSkolaStepenOdeljenja.SelectedItem?.ToString();
            string? broj = cbSkolaBrojOdeljenja.SelectedItem?.ToString();
            if (!string.IsNullOrEmpty(stepen) && !string.IsNullOrEmpty(broj))
            {
                LoadOdeljenje(stepen, broj);
            }
        }

        private void lbOdeljenja_SelectedIndexChanged(object? sender, EventArgs? e)
        {
            if (lbOdeljenja.SelectedItem is Odeljenje odeljenje)
            {
                cbSkolaStepenOdeljenja.SelectedItem = odeljenje.Stepen;
                cbSkolaBrojOdeljenja.SelectedItem = odeljenje.Broj;
                LoadOdeljenje(odeljenje.Stepen, odeljenje.Broj);
            }
        }

        private void btnSacuvajOdeljenje_Click(object sender, EventArgs e)
        {
            string? stepen = cbSkolaStepenOdeljenja.SelectedItem?.ToString();
            string? broj = cbSkolaBrojOdeljenja.SelectedItem?.ToString();

            if (string.IsNullOrEmpty(stepen) || string.IsNullOrEmpty(broj))
            {
                MessageBox.Show("Morate izabrati stepen i broj odeljenja!",
                    "Upozorenje", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            if (trenutnoOdeljenje == null)
            {
                string? treciPredmet = cbSkolaTreciPredmet.Visible ? cbSkolaTreciPredmet.SelectedItem?.ToString() : null;

                Odeljenje novoOdeljenje = new Odeljenje
                {
                    Stepen = stepen,
                    Broj = broj,
                    TipMature = cbSkolaTipMature.SelectedItem?.ToString(),
                    JezikMature = cbSkolaJezikMature.SelectedItem?.ToString(),
                    PrviPredmet = cbSkolaPrviPredmet.SelectedItem?.ToString(),
                    DrugiPredmet = cbSkolaDrugiPredmet.SelectedItem?.ToString(),
                    TreciPredmet = treciPredmet
                };

                OdeljenjaManager.AddOdeljenje(novoOdeljenje);
                trenutnoOdeljenje = novoOdeljenje;
                LoadOdeljenjaList(trenutnoOdeljenje);

                MessageBox.Show($"Odeljenje {stepen}-{broj} je uspešno sačuvano!",
                    "Uspeh", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                UpdateCurrentOdeljenje();
                LoadOdeljenjaList(trenutnoOdeljenje);
                MessageBox.Show($"Odeljenje {stepen}-{broj} je uspešno ažurirano!",
                    "Uspeh", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void btnObrisiOdeljenje_Click(object sender, EventArgs e)
        {
            if (trenutnoOdeljenje != null)
            {
                DialogResult result = MessageBox.Show($"Da li ste sigurni da želite da obrišete odeljenje {trenutnoOdeljenje.Stepen}-{trenutnoOdeljenje.Broj}?",
                    "Potvrda brisanja", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

                if (result == DialogResult.Yes)
                {
                    OdeljenjaManager.RemoveOdeljenje(trenutnoOdeljenje);
                    trenutnoOdeljenje = null;
                    LoadOdeljenjaList();
                    MessageBox.Show("Odeljenje je uspešno obrisano!",
                        "Uspeh", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
            else
            {
                MessageBox.Show("Nema odeljenja za brisanje!",
                    "Informacija", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void btnSnimiOdeljenja_Click(object sender, EventArgs e)
        {
            var odeljenja = OdeljenjaManager.GetAllOdeljenja();
            if (odeljenja.Count == 0)
            {
                MessageBox.Show("Nema odeljenja za snimanje!",
                    "Upozorenje", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            using (SaveFileDialog saveFileDialog = new SaveFileDialog())
            {
                saveFileDialog.Filter = "CSV fajlovi (*.csv)|*.csv";
                saveFileDialog.DefaultExt = "csv";
                saveFileDialog.FileName = $"odeljenja_{DateTime.Now:yyyyMMdd_HHmmss}.csv";

                if (saveFileDialog.ShowDialog() == DialogResult.OK)
                {
                    try
                    {
                        SnimiOdeljenjaUCSV(saveFileDialog.FileName, odeljenja);
                        MessageBox.Show($"Uspešno sačuvano {odeljenja.Count} odeljenja!",
                            "Uspeh", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show($"Greška: {ex.Message}", "Greška",
                            MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
            }
        }

        private void btnUcitajOdeljenja_Click(object sender, EventArgs e)
        {
            using (OpenFileDialog openFileDialog = new OpenFileDialog())
            {
                openFileDialog.Filter = "CSV fajlovi (*.csv)|*.csv";
                openFileDialog.Title = "Izaberite CSV fajl za učitavanje odeljenja";

                if (openFileDialog.ShowDialog() == DialogResult.OK)
                {
                    try
                    {
                        // Prvo pročitaj zaglavlje da proveriš tip fajla
                        string header = "";
                        using (StreamReader reader = new StreamReader(openFileDialog.FileName, Encoding.UTF8))
                        {
                            header = reader.ReadLine() ?? "";
                        }

                        // Proveri da li je fajl sa odeljenjima
                        if (!header.Contains("Stepen,Broj,Tip mature") ||
                            header.Contains("Ime i prezime"))
                        {
                            MessageBox.Show("Izabrani fajl nije validan fajl sa odeljenjima!\n\n" +
                                "Fajl sa odeljenjima treba da sadrži kolone:\n" +
                                "Stepen, Broj, Tip mature, Jezik mature, Prvi predmet, Drugi predmet, Treći predmet",
                                "Neispravan fajl", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                            return;
                        }

                        // Ako je zaglavlje ispravno, nastavi sa učitavanjem
                        var ucitanaOdeljenja = UcitajOdeljenjaIzCSV(openFileDialog.FileName);

                        if (ucitanaOdeljenja.Count == 0)
                        {
                            MessageBox.Show("Fajl ne sadrži validna odeljenja!",
                                "Upozorenje", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                            return;
                        }

                        DialogResult result = MessageBox.Show(
                            $"Pronađeno {ucitanaOdeljenja.Count} odeljenja.\nDa li želite da dodate na postojeću listu?\n\n" +
                            "Da = Dodaj (preskači duplikate)\nNe = Zameni postojeću listu\nOtkaži = Odustani",
                            "Učitavanje", MessageBoxButtons.YesNoCancel, MessageBoxIcon.Question);

                        if (result == DialogResult.Cancel) return;

                        if (result == DialogResult.No)
                        {
                            OdeljenjaManager.ClearAll();
                        }

                        int dodato = 0;
                        foreach (var odeljenje in ucitanaOdeljenja)
                        {
                            var postojece = OdeljenjaManager.GetOdeljenjeByStepenAndBroj(odeljenje.Stepen, odeljenje.Broj);
                            if (postojece == null)
                            {
                                OdeljenjaManager.AddOdeljenje(odeljenje);
                                dodato++;
                            }
                        }

                        LoadOdeljenjaList();
                        MessageBox.Show($"Uspešno učitano {dodato} odeljenja!",
                            "Uspeh", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show($"Greška: {ex.Message}", "Greška",
                            MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
            }
        }
        #endregion

        #region Event Handlers - Učenici tab
        private void cbUceniciTipMature_SelectedIndexChanged(object? sender, EventArgs? e)
        {
            string? selectedType = cbUceniciTipMatrue.SelectedItem?.ToString();

            switch (selectedType)
            {
                case "Opšta matura":
                    cbUceniciTreciPredmet.DataSource = Liste.OpstaTreciPredmet;
                    chbUceniciJeMuzickaSkola.Visible = false;
                    chbUceniciJeMuzickaSkola.Checked = false;
                    cbUceniciTreciPredmet.Visible = true;
                    lUceniciTreciPredmet.Visible = true;
                    break;
                case "Stručna matura":
                    cbUceniciTreciPredmet.DataSource = Liste.StrucnaTreciPredmet;
                    chbUceniciJeMuzickaSkola.Visible = false;
                    chbUceniciJeMuzickaSkola.Checked = false;
                    cbUceniciTreciPredmet.Visible = true;
                    lUceniciTreciPredmet.Visible = true;
                    break;
                case "Umetnička matura":
                    cbUceniciTreciPredmet.DataSource = Liste.UmetnickaTreciPredmet;
                    chbUceniciJeMuzickaSkola.Visible = true;
                    chbUceniciJeMuzickaSkola.Checked = false;
                    cbUceniciTreciPredmet.Visible = false;
                    lUceniciTreciPredmet.Visible = false;
                    break;
                default:
                    cbUceniciTreciPredmet.DataSource = null;
                    break;
            }
        }

        private void chbUceniciJeMuzickaSkola_CheckedChanged(object? sender, EventArgs? e)
        {
            string? selectedType = cbUceniciTipMatrue.SelectedItem?.ToString();
            if (selectedType == "Umetnička matura")
            {
                if (chbUceniciJeMuzickaSkola.Checked)
                {
                    cbUceniciTreciPredmet.Visible = true;
                    lUceniciTreciPredmet.Visible = true;
                    if (cbUceniciTreciPredmet.Items.Count > 0)
                        cbUceniciTreciPredmet.SelectedIndex = 0;
                }
                else
                {
                    cbUceniciTreciPredmet.Visible = false;
                    lUceniciTreciPredmet.Visible = false;
                }
            }
        }

        private void cbUceniciOdeljenje_Changed(object? sender, EventArgs? e)
        {
            LoadOdeljenjePodatkeZaUcenika();
        }

        private void lbUcenici_SelectedIndexChanged(object? sender, EventArgs? e)
        {
            if (lbUcenici.SelectedItem is Ucenik ucenik)
            {
                LoadUcenik(ucenik);
            }
        }

        private void bSačuvajUčenika_Click(object sender, EventArgs e)
        {
            string imePrezime = tbImePrezime.Text.Trim();
            string? stepen = cbUceniciStepen.SelectedItem?.ToString();
            string? broj = cbUceniciBroj.SelectedItem?.ToString();

            if (string.IsNullOrEmpty(imePrezime))
            {
                MessageBox.Show("Morate uneti ime i prezime učenika!",
                    "Upozorenje", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            if (string.IsNullOrEmpty(stepen) || string.IsNullOrEmpty(broj))
            {
                MessageBox.Show("Morate izabrati odeljenje!",
                    "Upozorenje", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            if (trenutniUcenik == null)
            {
                string? treciPredmet = cbUceniciTreciPredmet.Visible ? cbUceniciTreciPredmet.SelectedItem?.ToString() : null;

                Ucenik noviUcenik = new Ucenik
                {
                    ImePrezime = imePrezime,
                    Stepen = stepen,
                    Broj = broj,
                    TipMature = cbUceniciTipMatrue.SelectedItem?.ToString(),
                    JezikMature = cbUceniciJezikMature.SelectedItem?.ToString(),
                    PrviPredmet = cbUceniciPrviPredmet.SelectedItem?.ToString(),
                    DrugiPredmet = cbUceniciDrugiPredmet.SelectedItem?.ToString(),
                    TreciPredmet = treciPredmet
                };

                UceniciManager.AddUcenik(noviUcenik);
                trenutniUcenik = noviUcenik;
                LoadUcenikeList();

                MessageBox.Show($"Učenik {imePrezime} je uspešno sačuvan!",
                    "Uspeh", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                UpdateCurrentUcenik();
                LoadUcenikeList();
                MessageBox.Show($"Učenik {imePrezime} je uspešno ažuriran!",
                    "Uspeh", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }

            trenutniUcenik = null;
        }

        private void bObrisiUcenika_Click(object sender, EventArgs e)
        {
            if (trenutniUcenik != null)
            {
                DialogResult result = MessageBox.Show($"Da li ste sigurni da želite da obrišete učenika {trenutniUcenik.ImePrezime}?",
                    "Potvrda brisanja", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

                if (result == DialogResult.Yes)
                {
                    UceniciManager.RemoveUcenik(trenutniUcenik);
                    ClearUcenikForm();
                    LoadUcenikeList();
                    MessageBox.Show("Učenik je uspešno obrisan!",
                        "Uspeh", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
            else
            {
                MessageBox.Show("Nema učenika za brisanje!",
                    "Informacija", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void bSnimiUcenike_Click(object sender, EventArgs e)
        {
            var ucenici = UceniciManager.GetAllUcenici();
            if (ucenici.Count == 0)
            {
                MessageBox.Show("Nema učenika za snimanje!",
                    "Upozorenje", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            using (SaveFileDialog saveFileDialog = new SaveFileDialog())
            {
                saveFileDialog.Filter = "CSV fajlovi (*.csv)|*.csv";
                saveFileDialog.DefaultExt = "csv";
                saveFileDialog.FileName = $"ucenici_{DateTime.Now:yyyyMMdd_HHmmss}.csv";

                if (saveFileDialog.ShowDialog() == DialogResult.OK)
                {
                    try
                    {
                        SnimiUcenikeUCSV(saveFileDialog.FileName, ucenici);
                        MessageBox.Show($"Uspešno sačuvano {ucenici.Count} učenika!",
                            "Uspeh", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show($"Greška: {ex.Message}", "Greška",
                            MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
            }
        }

        private void bUcitajUcenike_Click(object sender, EventArgs e)
        {
            using (OpenFileDialog openFileDialog = new OpenFileDialog())
            {
                openFileDialog.Filter = "CSV fajlovi (*.csv)|*.csv";
                openFileDialog.Title = "Izaberite CSV fajl za učitavanje učenika";

                if (openFileDialog.ShowDialog() == DialogResult.OK)
                {
                    try
                    {
                        // Prvo pročitaj zaglavlje da proveriš tip fajla
                        string header = "";
                        using (StreamReader reader = new StreamReader(openFileDialog.FileName, Encoding.UTF8))
                        {
                            header = reader.ReadLine() ?? "";
                        }

                        // Proveri da li je fajl sa učenicima
                        if (!header.Contains("Ime i prezime") || !header.Contains("Stepen,Broj"))
                        {
                            MessageBox.Show("Izabrani fajl nije validan fajl sa učenicima!\n\n" +
                                "Fajl sa učenicima treba da sadrži kolone:\n" +
                                "Stepen, Broj, Ime i prezime, Tip mature, Jezik mature, Prvi predmet, Drugi predmet, Treći predmet",
                                "Neispravan fajl", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                            return;
                        }

                        var ucitaniUcenici = UcitajUcenikeIzCSV(openFileDialog.FileName);

                        if (ucitaniUcenici.Count == 0)
                        {
                            MessageBox.Show("Fajl ne sadrži validne učenike!",
                                "Upozorenje", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                            return;
                        }

                        DialogResult result = MessageBox.Show(
                            $"Pronađeno {ucitaniUcenici.Count} učenika.\nDa li želite da dodate na postojeću listu?\n\n" +
                            "Da = Dodaj (preskači duplikate)\nNe = Zameni postojeću listu\nOtkaži = Odustani",
                            "Učitavanje", MessageBoxButtons.YesNoCancel, MessageBoxIcon.Question);

                        if (result == DialogResult.Cancel) return;

                        if (result == DialogResult.No)
                        {
                            UceniciManager.ClearAll();
                        }

                        int dodato = 0;
                        foreach (var ucenik in ucitaniUcenici)
                        {
                            var postojeci = UceniciManager.GetUcenikByOdeljenjeAndIme(
                                ucenik.Stepen, ucenik.Broj, ucenik.ImePrezime);
                            if (postojeci == null)
                            {
                                UceniciManager.AddUcenik(ucenik);
                                dodato++;
                            }
                        }

                        LoadUcenikeList();
                        MessageBox.Show($"Uspešno učitano {dodato} učenika!",
                            "Uspeh", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show($"Greška: {ex.Message}", "Greška",
                            MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
            }
        }
        private void TbImePrezime_KeyDown(object sender, KeyEventArgs e)
        {
            // Proveri da li je pritisnut Enter
            if (e.KeyCode == Keys.Enter)
            {
                e.SuppressKeyPress = true; // Spreči "ding" zvuk
                e.Handled = true; // Označi da je događaj obrađen

                // Pozovi čuvanje učenika
                bSačuvajUčenika_Click(sender, e);
            }
        }
        #endregion

        #region CSV Konstante
        private const string ODELJENJA_HEADER = "Stepen,Broj,Tip mature,Jezik mature,Prvi predmet,Drugi predmet,Treći predmet";
        private const string UCENICI_HEADER = "Stepen,Broj,Ime i prezime,Tip mature,Jezik mature,Prvi predmet,Drugi predmet,Treći predmet";
        #endregion

        #region CSV Operacije
        private void SnimiOdeljenjaUCSV(string putanja, List<Odeljenje> odeljenja)
        {
            using (StreamWriter writer = new StreamWriter(putanja, false, Encoding.UTF8))
            {
                writer.WriteLine("Stepen,Broj,Tip mature,Jezik mature,Prvi predmet,Drugi predmet,Treći predmet");
                foreach (var o in odeljenja)
                {
                    writer.WriteLine($"{EscapeForCSV(o.Stepen)},{EscapeForCSV(o.Broj)}," +
                        $"{EscapeForCSV(o.TipMature)},{EscapeForCSV(o.JezikMature)}," +
                        $"{EscapeForCSV(o.PrviPredmet)},{EscapeForCSV(o.DrugiPredmet)}," +
                        $"{EscapeForCSV(o.TreciPredmet ?? "")}");
                }
            }
        }

        private List<Odeljenje> UcitajOdeljenjaIzCSV(string putanja)
        {
            List<Odeljenje> odeljenja = new List<Odeljenje>();
            using (StreamReader reader = new StreamReader(putanja, Encoding.UTF8))
            {
                string? header = reader.ReadLine();
                string? linija;
                while ((linija = reader.ReadLine()) != null)
                {
                    if (string.IsNullOrWhiteSpace(linija)) continue;
                    string[] delovi = ParseCSVLine(linija);
                    if (delovi.Length >= 7)
                    {
                        odeljenja.Add(new Odeljenje
                        {
                            Stepen = delovi[0].Trim(),
                            Broj = delovi[1].Trim(),
                            TipMature = delovi[2].Trim(),
                            JezikMature = delovi[3].Trim(),
                            PrviPredmet = delovi[4].Trim(),
                            DrugiPredmet = delovi[5].Trim(),
                            TreciPredmet = string.IsNullOrEmpty(delovi[6].Trim()) ? null : delovi[6].Trim()
                        });
                    }
                }
            }
            return odeljenja;
        }

        private void SnimiUcenikeUCSV(string putanja, List<Ucenik> ucenici)
        {
            using (StreamWriter writer = new StreamWriter(putanja, false, Encoding.UTF8))
            {
                writer.WriteLine("Stepen,Broj,Ime i prezime,Tip mature,Jezik mature,Prvi predmet,Drugi predmet,Treći predmet");
                foreach (var u in ucenici)
                {
                    writer.WriteLine($"{EscapeForCSV(u.Stepen)},{EscapeForCSV(u.Broj)}," +
                        $"{EscapeForCSV(u.ImePrezime)},{EscapeForCSV(u.TipMature)}," +
                        $"{EscapeForCSV(u.JezikMature)},{EscapeForCSV(u.PrviPredmet)}," +
                        $"{EscapeForCSV(u.DrugiPredmet)},{EscapeForCSV(u.TreciPredmet ?? "")}");
                }
            }
        }

        private List<Ucenik> UcitajUcenikeIzCSV(string putanja)
        {
            List<Ucenik> ucenici = new List<Ucenik>();
            using (StreamReader reader = new StreamReader(putanja, Encoding.UTF8))
            {
                string? header = reader.ReadLine();
                string? linija;
                while ((linija = reader.ReadLine()) != null)
                {
                    if (string.IsNullOrWhiteSpace(linija)) continue;
                    string[] delovi = ParseCSVLine(linija);
                    if (delovi.Length >= 8)
                    {
                        ucenici.Add(new Ucenik
                        {
                            Stepen = delovi[0].Trim(),
                            Broj = delovi[1].Trim(),
                            ImePrezime = delovi[2].Trim(),
                            TipMature = delovi[3].Trim(),
                            JezikMature = delovi[4].Trim(),
                            PrviPredmet = delovi[5].Trim(),
                            DrugiPredmet = delovi[6].Trim(),
                            TreciPredmet = string.IsNullOrEmpty(delovi[7].Trim()) ? null : delovi[7].Trim()
                        });
                    }
                }
            }
            return ucenici;
        }

        private string EscapeForCSV(string? tekst)
        {
            if (string.IsNullOrEmpty(tekst))
                return "";

            if (tekst.Contains(",") || tekst.Contains("\"") || tekst.Contains("\n") || tekst.Contains("\r"))
            {
                tekst = tekst.Replace("\"", "\"\"");
                return $"\"{tekst}\"";
            }

            return tekst;
        }

        private string[] ParseCSVLine(string linija)
        {
            List<string> rezultat = new List<string>();
            bool uNavodnicima = false;
            StringBuilder trenutni = new StringBuilder();

            for (int i = 0; i < linija.Length; i++)
            {
                char c = linija[i];

                if (c == '"')
                {
                    if (uNavodnicima && i + 1 < linija.Length && linija[i + 1] == '"')
                    {
                        trenutni.Append('"');
                        i++;
                    }
                    else
                    {
                        uNavodnicima = !uNavodnicima;
                    }
                }
                else if (c == ',' && !uNavodnicima)
                {
                    rezultat.Add(trenutni.ToString());
                    trenutni.Clear();
                }
                else
                {
                    trenutni.Append(c);
                }
            }

            rezultat.Add(trenutni.ToString());
            return rezultat.ToArray();
        }
        #endregion
    }
}