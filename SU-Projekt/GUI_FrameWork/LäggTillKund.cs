using BusinessEntities_FrameWork.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using BusinessEntities_FrameWork;
using System.Windows.Forms.VisualStyles;
using BusinessLayer_FrameWork;

namespace GUI_FrameWork
{
    public partial class LäggTillKund : Form
    {
        // Properties
        public FacadeBusiness FacadeBusiness { get; set; }

        public MarknadsChef MarknadsChef { get; set; }

        public Anställd Anställd { get; set; }

        // Privete variabler för Getters & Setters
        private string _namn;
        private string _efternamn;
        private string _epost;
        private string _telefon;
        private string _adress;
        private string _postNummer;
        private string _postOrt;
        private string _fakturaAdress;
        private string _refPerson;
        private double _rabatt;
        private string _orgNummer;
        private string _företagfaktureringPostort;
        private string _företagfaktureringPostnummer;

        // Constructor
        public LäggTillKund(MarknadsChef mc, Anställd a_s)
        {
            FacadeBusiness = new FacadeBusiness();
            MarknadsChef = mc;
            Anställd = a_s;
            InitializeComponent();
            
        }

        // -----------------------------------------------------------
        // |********************* Methods ***************************|
        // -----------------------------------------------------------
        // För privatkund
        private void btnLäggTillpKund_Click(object sender, EventArgs e)
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
                        MessageBox.Show("Privatkund tillagd");
                    }
                    else
                        MessageBox.Show("Varning! Saknar 'Adress' eller 'PostNummer' eller 'Postort' ");
                }
                else
                    MessageBox.Show("Varning! Saknar 'E-post' eller 'Telefon'");
            }
            else
                MessageBox.Show("Varning! Saknar 'förnamn' eller 'eftername'");
        }

        // För Företagskund
        private void btnläggtillfkund_Click(object sender, EventArgs e)
        {
            if (Namn != null && OrgNummer != null)
            {
                if (Epost != null && Telefon != null)
                {
                    if (Adress != null && PostNummer != null && PostOrt != null)
                    {
                        if (FöretagFaktureringPostnummer != null && FöretagFaktureringPostort != null)
                        {
                            if (FakturaAdress != null && RefPerson != null && Rabatt.Equals(null))
                            {
                                FacadeBusiness.FacadeFöretagsKund.LäggTillKund(new FöretagsKund()
                                {
                                    Företagsnamn = Namn,
                                    OrgNummer = OrgNummer,
                                    FöretagEpostadress = Epost,
                                    FöretagTelefonNummer = Telefon,
                                    Gatuadress = Adress,
                                    FöretagPostnummer = PostNummer,
                                    FöretagPostort = PostOrt,
                                    Faktureringsadress = FakturaAdress,
                                    FöretagFaktureringPostort = FöretagFaktureringPostort,
                                    FöretagFaktureringPostnummer = FöretagFaktureringPostnummer,
                                    RefPerson = RefPerson,
                                    FöretagRabatt = Rabatt,
                                });
                                MessageBox.Show("Företagskund tillagd");
                            }
                            else
                                MessageBox.Show("Varning! Saknar 'Fakturaadress' eller 'Ref. Person' eller 'Post Ort' ");
                        }
                        else
                            MessageBox.Show("Varning! Saknar företags- postnummer och postort!");
                    }
                    else
                        MessageBox.Show("Varning! Saknar 'Adress' eller 'PostNummer' eller 'Postort' ");
                }
                else
                    MessageBox.Show("Varning! Saknar 'E-post' eller 'Telefon'");
          }
            else
                MessageBox.Show("Varning! Saknar 'förnamn' eller 'eftername'");
            
        }

        // Input från textboxar 
        // Privat Kund
        private void tbnamnp_TextChanged(object sender, EventArgs e)
        {
            Namn = tbnamnp.Text;
        }

        private void tbenamnp_TextChanged(object sender, EventArgs e)
        {
            Efternamn = tbenamnp.Text;
        }

        private void tbepost_TextChanged(object sender, EventArgs e)
        {
            Epost = tbepost.Text;
        }

        private void tbtelefon_TextChanged(object sender, EventArgs e)
        {
            Telefon = tbtelefon.Text;
        }

        private void tbadress_TextChanged(object sender, EventArgs e)
        {
            Adress = tbadress.Text;
        }

        private void tbpostnr_TextChanged(object sender, EventArgs e)
        {
            PostNummer = tbpostnr.Text;
        }

        private void tbpostort_TextChanged(object sender, EventArgs e)
        {
            PostOrt = tbpostort.Text;
        }

        // Input från textboxar 
        // Privat Kund
        private void tbnamnf_TextChanged(object sender, EventArgs e)
        {
            Namn = tbnamnf.Text;
        }

        private void tborgnr_TextChanged(object sender, EventArgs e)
        {
            OrgNummer = tborgnr.Text;
        }

        private void tbepostf_TextChanged(object sender, EventArgs e)
        {
            Epost = tbepostf.Text;
        }

        private void tbtelefonf_TextChanged(object sender, EventArgs e)
        {
            Telefon = tbtelefonf.Text;
        }

        private void tbadressf_TextChanged(object sender, EventArgs e)
        {
            Adress = tbadressf.Text;
        }

        private void tbpostnrf_TextChanged(object sender, EventArgs e)
        {
            PostNummer = tbpostnrf.Text;
        }

        private void tbpostortf_TextChanged(object sender, EventArgs e)
        {
            PostOrt = tbpostnrf.Text;
        }

        private void tbfakturaf_TextChanged(object sender, EventArgs e)
        {
            FakturaAdress = tbfakturaf.Text;
        }

        private void tbreperson_TextChanged(object sender, EventArgs e)
        {
            RefPerson = tbreperson.Text;
        }

        private void tbrabatt_TextChanged(object sender, EventArgs e)
        {
            string temp = tbrabatt.Text;
            Rabatt = double.Parse(temp);
        }

        // Tillbaka till föregående form
        private void btnTillbaka_Click(object sender, EventArgs e)
        {
            if (Anställd == null) 
            {
                Marknadmeny mm = new Marknadmeny(MarknadsChef);
                this.Hide();
                mm.Show();
            }
            else 
                {
             //   Bokningsform a_s = new Bokningsform(Anställd);
                //this.Hide();
                //a_s.Show();

            }
        }

        // Getters & Setters för båda 
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

        // Specifika Getters & Setters för företagskund
        public double Rabatt
        {
            get { return _rabatt; }
            set { _rabatt = value; }
        }

        public string RefPerson
        {
            get { return _refPerson; }
            set { _refPerson = value; }
        }

        public string FakturaAdress
        {
            get { return _fakturaAdress; }
            set { _fakturaAdress = value; }
        }

        public string OrgNummer
        {
            get { return _orgNummer; }
            set { _orgNummer = value; }
        }             

        public string FöretagFaktureringPostnummer
        {
            get { return _företagfaktureringPostnummer; }
            set { _företagfaktureringPostnummer = value; }
        }

        public string FöretagFaktureringPostort
        {
            get { return _företagfaktureringPostort; }
            set { _företagfaktureringPostort = value; }
        }
    }
}
