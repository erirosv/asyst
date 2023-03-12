using BusinessEntities_FrameWork.Models;
using BusinessLayer_FrameWork;
using BusinessLayer_FrameWork.Models;
using DataLayer_FrameWork.Models;
using DataLayer_FrameWork.UnitOfWork;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml;

namespace GUI_FrameWork
{
    public partial class UppdateraKund : Form
    {
        private string _search;
        public PrivatKund PrivatKund { get; set; }
        public SysAdmin SysAdmin {get;set;}
        public FacadeBusiness FacadeBusiness { get; set; }
        public BindingSource BindingSource { get; set; }
        public FöretagsKund FöretagsKund { get; set; }


        public string fnamn;
        public string enamn;
        public string epost;
        public string telefon;
        public string adress;
        public string postnummer;
        public string postort;

        public string företagsnamn;
        public string organisationsnummer;
        public string företagepost;
        public string företagtelefon;
        public string företagadress;
        public string företagpostnr;
        public string företagpostort;
        public string fakturaadress;
        public string refperson;
        public double rabatt; 
        public int id;

        public UppdateraKund(SysAdmin sa)
        {
            InitializeComponent();
            SysAdmin = sa;
            FacadeBusiness = new FacadeBusiness();
            BindingSource = new BindingSource();
            UppdateraGridView();
            PrivatKund = null ;
            FöretagsKund = null;


        }
        private void UppdateraGridView()
        {
            dvpkund.DataSource = BindingSource.DataSource;
            dvpkund.DataSource = FacadeBusiness.FacadePrivatKund.GetAllPKunder();
            dvfkund.DataSource = BindingSource.DataSource;
            dvfkund.DataSource = FacadeBusiness.FacadeFöretagsKund.GetAllFöretagKunder();
        }
        private void btnsökpkund_Click(object sender, EventArgs e)
        {
            if (Search != null)
            {
                if (FacadeBusiness.FacadePrivatKund.SearchPrivatKund(Search).ToList() != null)
                {
                    dvpkund.DataSource = null;
                    dvpkund.DataSource = FacadeBusiness.FacadePrivatKund.SearchPrivatKund(Search).ToList();
                }
                else
                    UppdateraGridView();
            }
            else
                MessageBox.Show("Det finns ingen sökterm");
        }

        private void Tbsökkund_TextChanged(object sender, EventArgs e)
        {
            Search = Tbsökkund.Text;
        }
        public string Search
        {
            get { return _search; }
            set { _search = value; }
        }

        private void btnuppdatera_Click(object sender, EventArgs e)
        {
            
            if (fnamn != null)
            {
                PrivatKund.PrivatFörnamn = fnamn;

            }
            if (enamn != null)
            {
                PrivatKund.PrivatEfternamn = enamn;
            }
            if (epost != null)
            {
                PrivatKund.PrivatEpostadress = epost;
            }
            if (adress != null)
            {
                PrivatKund.PrivatGatuadress = adress;
            }
            if (postnummer != null)
            {
                PrivatKund.PrivatPostnummer = postnummer;
            }
            if (postort != null)
            {
                PrivatKund.PrivatPostort = postort;
            }
           if (tbtelefon != null)
            {
                PrivatKund.PrivatTelefonnummer = tbtelefon.Text;
            }
        
            FacadeBusiness.FacadePrivatKund.UppdateraPrivatkund(PrivatKund, PrivatKund.PrivatKundID);

            MessageBox.Show("Kunduppgifter uppdaterade");
        }

        private void tbkund_TextChanged(object sender, EventArgs e)
        {
            if (tbkund.Text != null)
            {
                fnamn = tbkund.Text;
            }
        }

        private void tbenamn_TextChanged(object sender, EventArgs e)
        {
            if (tbenamn.Text != null)
            {
                enamn = tbenamn.Text;
            }
        }

        private void tbepost_TextChanged(object sender, EventArgs e)
        {
            if (tbepost.Text != null)
            {
                epost = tbepost.Text;
            }
        }

        private void tbtelefon_TextChanged(object sender, EventArgs e)
        {
            if (tbtelefon.Text != null)
            {
                telefon = tbtelefon.Text;
            }
        }

        private void tbadress_TextChanged(object sender, EventArgs e)
        {
            if (tbadress.Text != null)
            {
                adress = tbadress.Text;
            }
        }

        private void tbpostadress_TextChanged(object sender, EventArgs e)
        {
            if (tbpostadress.Text != null)
            {
                postnummer = tbpostadress.Text;
            }
        }

        private void tbpostort_TextChanged(object sender, EventArgs e)
        {
            if (tbpostort.Text != null)
            {
                postort = tbpostort.Text;
            }
        }

        

        private void dvpkund_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (dvpkund.SelectedRows.Count >0)
            {
                PrivatKund = (PrivatKund)dvpkund.SelectedRows[0].DataBoundItem;
                tbkund.Text = PrivatKund.PrivatFörnamn;
                tbenamn.Text = PrivatKund.PrivatEfternamn;
                tbepost.Text = PrivatKund.PrivatEpostadress;
                tbtelefon.Text = PrivatKund.PrivatTelefonnummer;
                tbadress.Text = PrivatKund.PrivatGatuadress;
                tbpostadress.Text = PrivatKund.PrivatPostnummer;
                tbpostort.Text = PrivatKund.PrivatPostort;
            }
        }

        private void btnsökfkund_Click(object sender, EventArgs e)
        {
            if (Search1 != null)
            {
                if (FacadeBusiness.FacadeFöretagsKund.SearchFöretagsKund(Search1).ToList() != null)
                {
                    dvfkund.DataSource = null;
                    dvfkund.DataSource = FacadeBusiness.FacadeFöretagsKund.SearchFöretagsKund(Search).ToList();
                }
                else
                    UppdateraGridView();
            }
            else
                MessageBox.Show("Det finns ingen säkterm");
        }

        private void Tbsökföretagskund_TextChanged(object sender, EventArgs e)
        {
                Search1 = Tbsökföretagskund.Text;
        }
        public string Search1
        {
            get { return _search; }
            set { _search = value; }
        }

        private void Tbfkund_TextChanged(object sender, EventArgs e)
        {
            if(Tbfkund.Text != null)
            {
                företagsnamn = Tbfkund.Text;
            }
            
        }

        private void textBox13_TextChanged(object sender, EventArgs e)
        {
            if (textBox13.Text != null)
            {
                organisationsnummer = textBox13.Text;
            }
        }

        private void textBox12_TextChanged(object sender, EventArgs e)
        {
            if (textBox12.Text != null)
            {
                företagepost = textBox12.Text;
            }

        }

        private void textBox11_TextChanged(object sender, EventArgs e)
        {
            if (textBox11.Text != null)
            {
                företagtelefon = textBox11.Text;
            }

        }

        private void textBox10_TextChanged(object sender, EventArgs e)
        {
            if (textBox10.Text != null)
            {
                företagadress = textBox10.Text;
            }
        }

        private void textBox9_TextChanged(object sender, EventArgs e)
        {
            if (textBox9.Text != null)
            {
                företagpostnr = textBox9.Text;
            }
        }

        private void textBox8_TextChanged(object sender, EventArgs e)
        {
            if (textBox8.Text != null)
            {
                företagpostort = textBox8.Text;
            }
        }

        private void textBox17_TextChanged(object sender, EventArgs e)
        {
            if(textBox17.Text != null)
            {
                fakturaadress = textBox17.Text;
            }
        }

        private void textBox18_TextChanged(object sender, EventArgs e)
        {
            if (textBox18.Text != null)
            {
                refperson = textBox18.Text;
            }
        }

        private void textBox19_TextChanged(object sender, EventArgs e)
        {
            if (textBox19.Text != null)
            {
                rabatt = Convert.ToDouble(textBox19.Text); 
            }
        }

        private void dvfkund_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (dvfkund.SelectedRows.Count > 0)
            {
                FöretagsKund = (FöretagsKund)dvfkund.SelectedRows[0].DataBoundItem;
                Tbfkund.Text = FöretagsKund.Företagsnamn;
                textBox13.Text = FöretagsKund.OrgNummer;
                textBox12.Text = FöretagsKund.FöretagEpostadress;
                textBox11.Text = FöretagsKund.FöretagTelefonNummer;
                textBox10.Text = FöretagsKund.Gatuadress;
                textBox9.Text = FöretagsKund.FöretagPostnummer;
                textBox8.Text = FöretagsKund.FöretagPostort;
                textBox17.Text = FöretagsKund.Faktureringsadress;
                textBox18.Text = FöretagsKund.RefPerson;
                textBox19.Text = FöretagsKund.FöretagRabatt.ToString();
            }
        }

        private void btnuppdaterafkund_Click(object sender, EventArgs e)
        {
            if (företagsnamn != null)
            {
                FöretagsKund.Företagsnamn = företagsnamn;
            }
            if (organisationsnummer != null)
            {
                FöretagsKund.OrgNummer = organisationsnummer;
            }
            if (företagepost != null)
            {
                FöretagsKund.FöretagEpostadress = företagepost;
            }
            if (företagtelefon != null)
            {
                FöretagsKund.FöretagTelefonNummer = företagtelefon;
            }
            if (företagadress != null)
            {
                FöretagsKund.Gatuadress = företagadress;
            }
            if (företagpostnr != null)
            {
                FöretagsKund.FöretagPostnummer = företagpostnr;
            }
            if (företagpostort != null)
            {
                FöretagsKund.FöretagPostort = företagpostort;
            }
            if (fakturaadress != null)
            {
                FöretagsKund.Faktureringsadress = fakturaadress;
            }
            if (refperson != null)
            {
                FöretagsKund.RefPerson = refperson;
            }
            if (!rabatt.Equals(null))
            {
                FöretagsKund.FöretagRabatt = rabatt;
            }

            FacadeBusiness.FacadeFöretagsKund.UppdateraFöretagsKund(FöretagsKund, FöretagsKund.FöretagKundID);
            MessageBox.Show("Kunduppgifter uppdaterade");
        }

        private void dvpkund_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void btntillbaka_Click(object sender, EventArgs e)
        {
            Systemadministrarör sa = new Systemadministrarör(SysAdmin);
            this.Hide();
            sa.Show();
        }

        private void dvfkund_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
    
}
