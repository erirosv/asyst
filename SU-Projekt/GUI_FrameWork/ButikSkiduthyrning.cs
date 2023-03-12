using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using BusinessLayer_FrameWork;
using BusinessEntities_FrameWork.Models;
using System.Drawing.Text;
using System.Windows.Forms.DataVisualization.Charting;

namespace GUI_FrameWork
{
    public partial class ButikSkiduthyrning : UserControl
    {
        private string _namn;
        private string _efternamn;
        private string _epost;
        private string _telefon;
        private string _adress;
        private string _postNummer;
        private string _postOrt;
        private string _fakturaAdress;
        private string _orgNr;
        private string _refPerson;
        private string _search;
        private double _pris;
        private string antal;

        public FacadeBusiness FacadeBusiness { get; set; }
        public Utrustning Utrustning { get; set; }
        public List<Utrustning> TillUtrustning { get; set; }
        public List<Uthyrning> UthyrningarList { get; set; }
        public Faktura TempFaktura { get; set; }
        public Uthyrning Uthyrning { get; set; }
        public List<Uthyrning> PaketUthyrning { get; set; }
        public Utrustning Utrustning1 { get; set; }
        public Utrustning Utrustning2 { get; set; }
        public Utrustning Utrustning3 { get; set; }

        private DateTime start { get; set; }
        private DateTime slut { get; set; }
        public List<double> Priser { get; set; }

        public ButikSkiduthyrning()
        {
            InitializeComponent();
            FacadeBusiness = new FacadeBusiness();
            TillUtrustning = new List<Utrustning>();
            TempFaktura = new Faktura();
            Uthyrning = new Uthyrning();
            Utrustning = new Utrustning();
            Utrustning1 = new Utrustning();
            Utrustning2 = new Utrustning();
            Utrustning3 = new Utrustning();

            PaketUthyrning = new List<Uthyrning>();

            Priser = new List<double>();

            UpdatePrivatKunder();
            PreSetEnskildaTillbehör();
            HideColumsPrivatKund();
            UpdateBokningar();
            HideColumsBokningar();
            StartCombobox();
        }

        // Form startup inputdata
        private void UpdatePrivatKunder()
        {
            gvExisterandeKunder.DataSource = null;
            gvExisterandeKunder.DataSource = FacadeBusiness.FacadePrivatKund.GetAllPKunder().ToList();
            
        }

        private void StartCombobox()
        {
            cbSkidor.Text = "Inget";
            comboBoxPjäxor.Text = "Inget";
            comboBoxSkor.Text = "Inget";
            comboBoxSkoter.Text = "Inget";
            comboBoxSnowboard.Text = "Inget";
            comboBoxStavar.Text = "Inget";
            
        }

        private void HideColumsPrivatKund()
        {
            gvExisterandeKunder.Columns["PrivatKundID"].Visible = false;
            gvExisterandeKunder.Columns["PrivatGatuadress"].Visible = false;
            gvExisterandeKunder.Columns["PrivatPostnummer"].Visible = false;
            gvExisterandeKunder.Columns["PrivatPostOrt"].Visible = false;
            gvExisterandeKunder.Columns["PrivatTelefonnummer"].Visible = false;
            gvExisterandeKunder.Columns["PrivatEpostadress"].Visible = false;
            gvExisterandeKunder.Columns["Bokningar"].Visible = false;
            gvExisterandeKunder.Columns["Uthyrningar"].Visible = false;
        }

        private void UpdateBokningar()
        {
            gvBokning.DataSource = null;
            gvBokning.DataSource = UthyrningarList;
            
        }

        private void HideColumsBokningar()
        {
            //gvBokning.Columns["BokningsID"].Visible = false;
            //gvBokning.Columns["BokningsTyp"].Visible = false;
            //gvBokning.Columns["Fakturor"].Visible = false;
            //gvBokning.Columns["Moms"].Visible = false;
            //gvBokning.Columns["BruttoPris"].Visible = false;
            //gvBokning.Columns["NettoPris"].Visible = false;
            //gvBokning.Columns["Status"].Visible = false;
            //gvBokning.Columns["Anställd"].Visible = false;
            //gvBokning.Columns["PrivatKund"].Visible = false;
            //gvBokning.Columns["FöretagsKund"].Visible = false;
            //gvBokning.Columns["LogiBokningar"].Visible = false;
            //gvBokning.Columns["TempKund"].Visible = false;
            //gvBokning.Columns["BokaSkidLektioner"].Visible = false;
            //gvBokning.Columns["PreBokningar"].Visible = false;
            //gvBokning.Columns["Konferenser"].Visible = false;


            //gvBokning.Columns[""].Visible = false;
        }

        private void UpdateListaTillbehör()
        {
            gvListaTillbehör.DataSource = null;
            gvListaTillbehör.DataSource = TillUtrustning;
        }

        private void PreSetEnskildaTillbehör()
        {
            // Skidor
            cbSkidor.Items.Add("Inget");
            cbSkidor.Items.Add("Alpint");
            cbSkidor.Items.Add("Längd");

            // Pjäxor
            comboBoxPjäxor.Items.Add("Inget");
            comboBoxPjäxor.Items.Add("Alpint");
            comboBoxPjäxor.Items.Add("Längd");

            // Stavar
            comboBoxStavar.Items.Add("Inget");
            comboBoxStavar.Items.Add("Alpint");
            comboBoxStavar.Items.Add("Längd");

            // Snowboard
            comboBoxSnowboard.Items.Add("Inget");
            comboBoxSnowboard.Items.Add("Snowboard");


            // Snowboardskor
            comboBoxSkor.Items.Add("Inget");
            comboBoxSkor.Items.Add("Skor");

            // Skoter
            comboBoxSkoter.Items.Add("Ingen");
            comboBoxSkoter.Items.Add("Lynx 50");
            comboBoxSkoter.Items.Add("Yamaha Viking");
            comboBoxSkoter.Items.Add("Nilapulka");

            // Dagar
            comboBoxDagar.Items.Add("1");
            comboBoxDagar.Items.Add("2");
            comboBoxDagar.Items.Add("3");
            comboBoxDagar.Items.Add("4");
            comboBoxDagar.Items.Add("5");
            comboBoxDagar.Items.Add("6");
            comboBoxDagar.Items.Add("7");
            //AlpPaket Antal
            comboBoxAlpPaket.Items.Add("1");
            comboBoxAlpPaket.Items.Add("2");
            comboBoxAlpPaket.Items.Add("3");
            comboBoxAlpPaket.Items.Add("4");
            comboBoxAlpPaket.Items.Add("5");
            comboBoxAlpPaket.Items.Add("6");
            comboBoxAlpPaket.Items.Add("7");
            //LängdPaket Antal
            comboBoxLängdPaket.Items.Add("1");
            comboBoxLängdPaket.Items.Add("2");
            comboBoxLängdPaket.Items.Add("3");
            comboBoxLängdPaket.Items.Add("4");
            comboBoxLängdPaket.Items.Add("5");
            comboBoxLängdPaket.Items.Add("6");
            comboBoxLängdPaket.Items.Add("7");
            //Snowboardpaket Antal
            comboBoxSnowPaket.Items.Add("1");
            comboBoxSnowPaket.Items.Add("2");
            comboBoxSnowPaket.Items.Add("3");
            comboBoxSnowPaket.Items.Add("4");
            comboBoxSnowPaket.Items.Add("5");
            comboBoxSnowPaket.Items.Add("6");
            comboBoxSnowPaket.Items.Add("7");
        }

        // Allt om kunderna
        private void btnNyKund_Click(object sender, EventArgs e)
        {
            if (FakturaAdress != null && RefPerson != null)
            {
                SkapaNyFöretagsKund();
            }
            else if (FakturaAdress == null && RefPerson == null)
            {
                SkapaNyPrivatKund();
            }
            else
                MessageBox.Show("Du har missat att fylla i all data!");
        }

        private void SkapaNyPrivatKund()
        {
            if (Namn != null && Efternamn != null)
            {
                if (Epost != null && Telefon != null)
                {
                    if (Adress != null && PostNummer != null && PostOrt != null)
                    {
                        FacadeBusiness.FacadePrivatKund.LäggTillKund(new PrivatKund()
                        {
                            PrivatFörnamn = Namn,
                            PrivatEfternamn = Efternamn,
                            PrivatEpostadress = Epost,
                            PrivatTelefonnummer = Telefon,
                            PrivatGatuadress = Adress,
                            PrivatPostnummer = PostNummer,
                            PrivatPostort = PostOrt
                        });
                    }
                    else
                        MessageBox.Show("Varning! Sakna 'Adress' eller 'PostNummer' eller 'Postort' ");
                }
                else
                    MessageBox.Show("Varning! Sakan 'E-post' eller 'Telefon'");
            }
            else
                MessageBox.Show("Varning! Saknar 'förnamn' eller 'eftername'");
        }

        private void SkapaNyFöretagsKund()
        {
            if (Namn != null && Efternamn != null)
            {
                if (Epost != null && Telefon != null)
                {
                    if (Adress != null && PostNummer != null && PostOrt != null)
                    {
                        FacadeBusiness.FacadeFöretagsKund.LäggTillKund(new FöretagsKund()
                        {
                            Företagsnamn = Namn,
                            OrgNummer = OrgNr,
                            FöretagEpostadress = Epost,
                            FöretagTelefonNummer = Telefon,
                            Gatuadress = Adress,
                            FöretagPostnummer = PostNummer,
                            FöretagPostort = PostOrt,
                            Faktureringsadress = FakturaAdress
                        });
                    }
                    else
                        MessageBox.Show("Varning! Sakna 'Adress' eller 'PostNummer' eller 'Postort' ");
                }
                else
                    MessageBox.Show("Varning! Sakan 'E-post' eller 'Telefon'");
            }
            else
                MessageBox.Show("Varning! Saknar 'förnamn' eller 'eftername'");
        }

        private void btLäggtillTempKund_Click(object sender, EventArgs e)
        {
            if (Namn != null && Efternamn != null && Telefon != null)
            {
                FacadeBusiness.FacadeTempKund.LäggTillTempKund(new TempKund()
                {
                    TempKundFörnamn = Namn,
                    TempKundEfternamn = Efternamn,
                    TempKundTelefonNummer = Telefon
                });
            }
        }

        // Söka på kund
        private void btnSökKund_Click(object sender, EventArgs e)
        {
            if (Search != null)
            {
                if (FacadeBusiness.FacadePrivatKund.SearchPrivatKund(Search).ToList() != null)
                {
                    gvExisterandeKunder.DataSource = null;
                    gvExisterandeKunder.DataSource = FacadeBusiness.FacadePrivatKund.SearchPrivatKund(Search).ToList();
                }
            }
            else
                MessageBox.Show("Det finns ingen sökterm");
        }

        // Uthyrning
        private void btnTaBortBokning_Click(object sender, EventArgs e)
        {
            if (gvBokning.CurrentRow != null)
            {
                int id = Convert.ToInt32(((Uthyrning)gvBokning.CurrentRow.DataBoundItem).UthyrningsID);
                foreach (Uthyrning item in UthyrningarList)
                {
                    if (item.UthyrningsID == id)
                    {
                        UthyrningarList.Remove(item);
                    }
                }
                MessageBox.Show($"Uthyrning {Uthyrning.UthyrningsID} är borttagen");
            }
            UpdateBokningar();
            HideColumsBokningar();
        }

        private void btnTaBortTillbehör_Click(object sender, EventArgs e)
        {
            Utrustning item = new Utrustning();

            if (gvListaTillbehör.CurrentRow != null)
            {
                int id = Convert.ToInt32(((Utrustning)gvListaTillbehör.CurrentRow.DataBoundItem).ArtikelID);
                item = HittaUtrustning(id);

                //---- Fungerar endas för inviduella produkter
                Priser.RemoveAt(gvListaTillbehör.CurrentCell.RowIndex);
                Pris = 0;
                foreach (double d in Priser)
                {
                    Pris = Pris + d;
                }
                TotalPris();
                // ---

                if (item != null)
                {
                    TillUtrustning.Remove(item);
                }
                UpdateListaTillbehör();
            }
        }

        private Utrustning HittaUtrustning(int id)
        {
            foreach (Utrustning item in TillUtrustning)
            {
                if (item.ArtikelID == id)
                {
                    return item;
                }
            }
            return null;
        }

        private void btnSökBokning_Click(object sender, EventArgs e)
        {
            if (gvBokning.CurrentRow != null)
            {
                Uthyrning = (Uthyrning)gvBokning.CurrentRow.DataBoundItem;
                UthyrningarList.Add(FacadeBusiness.FacadeUthyrning.SearchUthyrning(Search));
                gvBokning.DataSource = UthyrningarList;
            }
        }

        // Utskrift
        private void btnUtskrift_Click(object sender, EventArgs e)
        {
            if (gvBokning.CurrentRow != null)
            {
                Uthyrning = (Uthyrning)gvBokning.CurrentRow.DataBoundItem;
                FacadeBusiness.FacadeUthyrning.UthyrningTillUtskrift(Uthyrning);
            }
            HideColumsBokningar();
        }

        // Tillbehör
        private void btnLäggTillTillbehör_Click(object sender, EventArgs e)
        {
              if (cbSkidor.Text != "Inget" || cbSkidor.Text == null)
            {
                if (gvExisterandeKunder.CurrentRow != null)
                {
                    HämtaSkidor();
                    if (Utrustning == null)
                    {
                        MessageBox.Show("Finns inga tillgängliga skidor");
                    }
                    else
                    {
                        TillUtrustning.Add(Utrustning);
                        gvListaTillbehör.DataSource = null;
                        gvListaTillbehör.DataSource = TillUtrustning;
                        Uthyrning.UtrustningsTillUthyrning.Add(Utrustning);
                        UpdateBokningar();
                        HämtaPrisUthyrning(comboBoxDagar.Text, "Skidor", cbSkidor.Text);
                        TotalPris();
                        cbSkidor.Text = "Inget";
                    }
                }
                else
                    MessageBox.Show("Du har inte valt någon kund");

            }
            else if (comboBoxPjäxor.Text != "Inget" || comboBoxPjäxor.Text == null)
            {
                if (gvExisterandeKunder.CurrentRow != null)
                {
                    HämtaPjäxa();
                    if (Utrustning == null)
                    {
                        MessageBox.Show("Finns inga tillgängliga pjäxor");
                    }
                    else
                    {
                        TillUtrustning.Add(Utrustning);
                        gvListaTillbehör.DataSource = null;
                        gvListaTillbehör.DataSource = TillUtrustning;
                        Uthyrning.UtrustningsTillUthyrning.Add(Utrustning);
                        UpdateBokningar();
                        HämtaPrisUthyrning(comboBoxDagar.Text, "Pjäxor", comboBoxPjäxor.Text);
                        TotalPris();
                        comboBoxPjäxor.Text = "Inget";
                    }
                }
                else
                    MessageBox.Show("Du har inte valt någon kund");
            }
            else if (comboBoxStavar.Text != "Inget" || comboBoxStavar.Text == null)
            {
                if (gvExisterandeKunder.CurrentRow != null)
                {
                    HämtaStavar();
                    if (Utrustning == null)
                    {
                        MessageBox.Show("Finns inga tillgängliga stavar");
                    }
                    else
                    {
                        TillUtrustning.Add(Utrustning);
                        gvListaTillbehör.DataSource = null;
                        gvListaTillbehör.DataSource = TillUtrustning;
                        Uthyrning.UtrustningsTillUthyrning.Add(Utrustning);
                        UpdateBokningar();
                        HämtaPrisUthyrning(comboBoxDagar.Text, "Stavar", comboBoxStavar.Text);
                        TotalPris();
                        comboBoxStavar.Text = "Inget";
                    }
                }
                else
                    MessageBox.Show("Du har inte valt någon kund");
            }
            else if (comboBoxSkoter.Text != "Inget" || comboBoxSkoter.Text == null)
            {
                if (gvExisterandeKunder.CurrentRow != null)
                {
                    HämtaSkoter();
                    if (Utrustning == null)
                    {
                        MessageBox.Show("Finns inga tillgängliga skotrar");
                    }
                    else
                    {
                        TillUtrustning.Add(Utrustning);
                        gvListaTillbehör.DataSource = null;
                        gvListaTillbehör.DataSource = TillUtrustning;
                        Uthyrning.UtrustningsTillUthyrning.Add(Utrustning);
                        UpdateBokningar();
                        HämtaPrisUthyrning(comboBoxDagar.Text, "Skoter", comboBoxSkoter.Text);
                        TotalPris();
                        comboBoxSkoter.Text = "Inget";
                    }
                }
                else
                    MessageBox.Show("Du har inte valt någon kund");
            }
            else if (comboBoxSnowboard.Text != "Inget" || comboBoxSnowboard.Text == null)
            {
                if (gvExisterandeKunder.CurrentRow != null)
                {
                    HämtaSnowboard();
                    if (Utrustning == null)
                    {
                        MessageBox.Show("Finns inga tillgängliga skotrar");
                    }
                    else
                    {
                        TillUtrustning.Add(Utrustning);
                        gvListaTillbehör.DataSource = null;
                        gvListaTillbehör.DataSource = TillUtrustning;
                        Uthyrning.UtrustningsTillUthyrning.Add(Utrustning);
                        UpdateBokningar();
                        HämtaPrisUthyrning(comboBoxDagar.Text, "Snowboard", comboBoxSnowboard.Text);
                        TotalPris();
                        comboBoxSnowboard.Text = "Inget";
                    }
                }
                else
                    MessageBox.Show("Du har inte valt någon kund");
            }
            else if (comboBoxSkor.Text != "Inget" || comboBoxSkor.Text == null)
            {
                if (gvExisterandeKunder.CurrentRow != null)
                {
                    HämtaSkor();
                    if (Utrustning == null)
                    {
                        MessageBox.Show("Finns inga tillgängliga skor");
                    }
                    else
                    {
                        TillUtrustning.Add(Utrustning);
                        gvListaTillbehör.DataSource = null;
                        gvListaTillbehör.DataSource = TillUtrustning;
                        Uthyrning.UtrustningsTillUthyrning.Add(Utrustning);//
                        UpdateBokningar();
                        HämtaPrisUthyrning(comboBoxDagar.Text, "Skor", comboBoxSkor.Text);
                        TotalPris();
                        comboBoxSkor.Text = "Inget";
                    }
                }
                else
                    MessageBox.Show("Du har inte valt någon kund");
            }
            if (checkBoxAlpPaket.Checked)
            {
                antal = comboBoxAlpPaket.Text;

                for (int i = 0; i < int.Parse(antal); i++)
                { 
                    HämtaAlpPaket();
                    gvListaTillbehör.DataSource = null;
                    gvListaTillbehör.DataSource = TillUtrustning;
                    UpdateBokningar();

                    HämtaPrisUthyrning(comboBoxDagar.Text, "Paket", "Alpint");
                    TotalPris();
                    
                }
                comboBoxAlpPaket.Text = null;
                checkBoxAlpPaket.Checked = false;
            }
            if (checkBoxLängdPaket.Checked)
            { 
                antal = comboBoxLängdPaket.Text;
                for (int i = 0; i < int.Parse(antal); i++)
                {
                    
                        HämtaLängdPaket();
                        gvListaTillbehör.DataSource = null;
                        gvListaTillbehör.DataSource = TillUtrustning;
                        UpdateBokningar();
                        HämtaPrisUthyrning(comboBoxDagar.Text, "Paket", "Längd");
                        TotalPris();
                    
                }
                comboBoxSnowPaket.Text = null;
                checkBoxLängdPaket.Checked = false;

            }
            if (checkBoxSnowPaket.Checked)
            {
                    antal = comboBoxSnowPaket.Text;
                    for (int i = 0; i < int.Parse(antal); i++)
                    {
                        antal = comboBoxSnowPaket.Text;

                        HämtaSnowPaket();
                        gvListaTillbehör.DataSource = null;
                        gvListaTillbehör.DataSource = TillUtrustning;
                        UpdateBokningar();
                        HämtaPrisUthyrning(comboBoxDagar.Text, "Paket", "Snowboard");
                        TotalPris();

                    }
                checkBoxSnowPaket.Checked = false;
                comboBoxSnowPaket.Text = null;
            }
        }

        private void HämtaSkidor()
        {
            Utrustning = FacadeBusiness.FacadeUtrustning.GetSkida(cbSkidor.Text);
        }

        private void HämtaSnowPaket()
        {
            Utrustning1 = FacadeBusiness.FacadeUtrustning.GetSnowboard("Snowboard");
            TillUtrustning.Add(Utrustning1);
            Uthyrning.UtrustningsTillUthyrning.Add(Utrustning1);

            Utrustning2 = FacadeBusiness.FacadeUtrustning.GetSkor("Skor");
            TillUtrustning.Add(Utrustning2);
            Uthyrning.UtrustningsTillUthyrning.Add(Utrustning2);
        }
        private void HämtaLängdPaket()
        { 
            Utrustning1 = FacadeBusiness.FacadeUtrustning.GetPjäxa("Längd");
            TillUtrustning.Add(Utrustning1);
            Uthyrning.UtrustningsTillUthyrning.Add(Utrustning1);

            Utrustning2 = FacadeBusiness.FacadeUtrustning.GetSkida("Längd");
            TillUtrustning.Add(Utrustning2);
            Uthyrning.UtrustningsTillUthyrning.Add(Utrustning2);

            Utrustning3 = FacadeBusiness.FacadeUtrustning.GetStavar("Längd");
            TillUtrustning.Add(Utrustning3);
            Uthyrning.UtrustningsTillUthyrning.Add(Utrustning3);
        }
        
        private void HämtaAlpPaket()
        {
            Utrustning1 = FacadeBusiness.FacadeUtrustning.GetPjäxa("Alpint");
            TillUtrustning.Add(Utrustning1);
            Uthyrning.UtrustningsTillUthyrning.Add(Utrustning1);

            Utrustning2 = FacadeBusiness.FacadeUtrustning.GetSkida("Alpint");
            TillUtrustning.Add(Utrustning2);
            Uthyrning.UtrustningsTillUthyrning.Add(Utrustning2);

            Utrustning3 = FacadeBusiness.FacadeUtrustning.GetStavar("Alpint");
            TillUtrustning.Add(Utrustning3);
            Uthyrning.UtrustningsTillUthyrning.Add(Utrustning3);
        }
        private void HämtaStavar()
        {
            Utrustning = FacadeBusiness.FacadeUtrustning.GetStavar(comboBoxStavar.Text);
        }
        private void HämtaPjäxa()
        {
            Utrustning = FacadeBusiness.FacadeUtrustning.GetPjäxa(comboBoxPjäxor.Text);
        }
        private void HämtaSkoter()
        {
            Utrustning = FacadeBusiness.FacadeUtrustning.GetSkoter(comboBoxSkoter.Text);
        }
        private void HämtaSnowboard()
        {
            Utrustning = FacadeBusiness.FacadeUtrustning.GetSnowboard(comboBoxSnowboard.Text);
        }
        private void HämtaSkor()
        {
            Utrustning = FacadeBusiness.FacadeUtrustning.GetSkor(comboBoxSkor.Text);
        }

        private void HämtaPrisUthyrning(string dagar, string sort, string typ)
        {
            Pris = Pris + FacadeBusiness.FacadeHyrpris.GetUtrustningsHyrpris(dagar, sort, typ);
            Uthyrning.UthyrningsPris = Pris;
            Priser.Add(Pris);
        }

        private void TotalPris()
        {
            textBoxPrisExklMoms.Text = Pris.ToString();
            textBoxMoms.Text = "12%";
            tbPrisInkMoms.Text = (Pris * 1.12).ToString();
        }

        // Spara Bokning 
        private void btnSparaBokning_Click(object sender, EventArgs e)
        {
            if (gvExisterandeKunder.CurrentRow != null)
            {
                TotalPris();

                if (!checkBoxKontant.Checked && !checkBoxFaktura.Checked)
                {
                    MessageBox.Show("Betalsätt saknas");
                }
                else if (checkBoxKontant.Checked && checkBoxFaktura.Checked)
                {
                    MessageBox.Show("Du kan endast välja ett betalsätt");
                }
                else if (checkBoxKontant.Checked && !checkBoxFaktura.Checked)
                {
                    MessageBox.Show($"Betalining kontant: {tbPrisInkMoms.Text} inkuderat moms");
                }
                else if (!checkBoxKontant.Checked && checkBoxFaktura.Checked)
                {
                    FakturaTillUthyrning();
                    start = DateTime.Now;
                    slut = start.AddMonths(1);
                    RäknaUtSumma();
                    PrivatKund pk = (PrivatKund)gvExisterandeKunder.CurrentRow.DataBoundItem;
                    FacadeBusiness.FacadeFaktura.UthyrningsFakturaPrivat(Pris, "Uthyrning", Uthyrning, pk, start, slut);
                    MessageBox.Show("Bokning skapad");
                } 
            }

            // Resetar alla värden
            Uthyrning.UthyrningsPris = 0;
            Pris = 0;
        }

        private void FakturaTillUthyrning()
        {
            Uthyrning.UthyrningsDatum = DateTime.Now;
            Uthyrning.AntalDagar = int.Parse(comboBoxDagar.Text);
        }

        private void RäknaUtSumma()
        {
            Pris = 0;
            foreach (double d in Priser)
            {
                Pris = Pris + d;
            }
        }

        // Lägga till personal getters & setters
        public double Pris
        {
            get { return _pris; }
            set { _pris = value; }
        }

        public string Search
        {
            get { return _search; }
            set { _search = value; }
        }

        public string PostOrt
        {
            get { return _postOrt; }
            set { _postOrt = value; }
        }

        public string PostNummer
        {
            get { return _postNummer; }
            set { _postNummer = value; }
        }

        public string Adress
        {
            get { return _adress; }
            set { _adress = value; }
        }

        public string Telefon
        {
            get { return _telefon; }
            set { _telefon = value; }
        }

        public string Epost
        {
            get { return _epost; }
            set { _epost = value; }
        }

        public string Efternamn
        {
            get { return _efternamn; }
            set { _efternamn = value; }
        }

        public string Namn
        {
            get { return _namn; }
            set { _namn = value; }
        }

        public string FakturaAdress
        {
            get { return _fakturaAdress; }
            set { _fakturaAdress = value; }
        }

        public string OrgNr
        {
            get { return _orgNr; }
            set { _orgNr = value; }
        }

        public string RefPerson
        {
            get { return _refPerson; }
            set { _refPerson = value; }
        }

        private void textBoxSökBokning_TextChanged(object sender, EventArgs e)
        {

        }

        private void cbSkidor_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void groupBox13_Enter(object sender, EventArgs e)
        {

        }

        private void gvListaTillbehör_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
