using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using BusinessEntities_FrameWork.Models;
using BusinessLayer_FrameWork;
using System.Drawing.Text;
using Microsoft.Office.Interop.Excel;
using System.Runtime.Remoting.Messaging;

namespace GUI_FrameWork
{
    public partial class BokaPrivat : UserControl
    {
        // Variabler
        private string _search;
        private string _veckonummer;
        private string _antalPersoner;
        private double _pris;
        private string logityp;
        private string vecka;
        private int dagar;

        // Properties
        public FacadeBusiness FacadeBusiness { get; set; }
        public Anställd Anställd { get; set; }
        public Bokning Bokning { get; set; }

        private DateTime start { get; set; }
        private DateTime slut { get; set; }
        private PreBokning PreBokning { get; set; }
        public List<PrivatKund> TestPrivat { get; set; }
        public Logi Logi { get; set; }
        public PrivatKund PrivatKund { get; set; }
        public List<Logi> TillBokning { get; set; }
        public List<double> PriserList { get; set; }

        public BokaPrivat()
        {
            InitializeComponent();
            PreBokning = new PreBokning();
            Bokning = new Bokning();
            FacadeBusiness = new FacadeBusiness();
            TillBokning = new List<Logi>();
            Logi = new Logi();
            //PrivatKund = new PrivatKund();
            PriserList = new List<double>();
            UpdatePrivatKund();
            PreSetComboBox();
        }
        public string Search
        {
            get { return _search; }
            set { _search = value; }
        }

        

        private void UpdatePrivatKund()
        {
            gbPrivatKund.DataSource = null;
            gbPrivatKund.DataSource = FacadeBusiness.FacadePrivatKund.GetAllPKunder();
            gbPrivatKund.AutoSize = false;
            HidePrivatKunfColums();
        }

        private void PreSetComboBox()
        {
            comboBoxLägenhetstyp.Items.Add("Alla");
            comboBoxLägenhetstyp.Items.Add("Liten");
            comboBoxLägenhetstyp.Items.Add("Stor");
            
        }

        private void HidePrivatKunfColums()
        {
            gbPrivatKund.Columns["PrivatKundID"].Visible = false;
            gbPrivatKund.Columns["PrivatGatuadress"].Visible = false;
            gbPrivatKund.Columns["PrivatPostnummer"].Visible = false;
            gbPrivatKund.Columns["PrivatPostOrt"].Visible = false;
        }

       

     


        private void btnSökLgh_Click(object sender, EventArgs e)
        {
            List<Logi> SökLedig = new List<Logi>();
            // Sök
            if (comboBoxLägenhetstyp.SelectedItem.Equals("Alla"))
            {
                dataGridViewLedigaAlt.DataSource = null;
                dataGridViewLedigaAlt.DataSource = FacadeBusiness.FacadeLogi.GetAllLedigaLägenheter(); ;
                
            }
            else if (comboBoxLägenhetstyp.SelectedItem.Equals("Stor"))
            {
                //foreach (Logi item in TillgängligLogi)
                //{
                //    if (item.LogiTyp.Equals("Stor"))
                //    {
                //        SökLedig.Add(item);
                //    }
                //}
                dataGridViewLedigaAlt.DataSource = null;
                dataGridViewLedigaAlt.DataSource = FacadeBusiness.FacadeLogi.GetTillgängligStor();
                
            }
            else if (comboBoxLägenhetstyp.SelectedItem.Equals("Liten"))
            {
                dataGridViewLedigaAlt.DataSource = null;
                dataGridViewLedigaAlt.DataSource = FacadeBusiness.FacadeLogi.GetTillgängligLiten();
            }
            else
            {
                MessageBox.Show("Du har inte valt något alternativ");
            }

        }

       

        private void textBoxVeckoNr_TextChanged(object sender, EventArgs e)
        {
            _veckonummer = textBoxVeckoNr.Text;
        }

        private void textBoxAntalPersoner_TextChanged(object sender, EventArgs e)
        {
            _antalPersoner = textBoxAntalPersoner.Text;
        }

        private void btnBoka_Click(object sender, EventArgs e)
        {
            //TotalPris();
            start = DateTime.Now;
            slut = start.AddMonths(1);
           // RäknaUtSumma();
            PrivatKund pk = (PrivatKund)gbPrivatKund.CurrentRow.DataBoundItem;
            PrivatKund temp = FacadeBusiness.FacadePrivatKund.HämtaPrivatKund(pk.PrivatKundID);

            if (Pris < 12000)
            {
                BokningTillFaktura();
                FacadeBusiness.FacadeFaktura.BokningFakturaPrivat(Pris, "Bokning", Bokning, pk, start, slut);
                MessageBox.Show("Bokning skapad");
            }
            else if(Pris >= 12000)

            {

                skapaPreBokning();
                FacadeBusiness.FacadePreBokning.BokningPrivatPre(Pris, "PreBokning", PreBokning, pk.PrivatKundID, start, slut);
                MessageBox.Show("Bokning för granskning skapad");
            }
        }

       
        private void skapaPreBokning()
        {
            int d = 7;
            int e = 5;
            int f = 2;

            if (checkBoxVecka.Checked == true)
            {
                dagar = d;
            }
            if (checkBoxHelg.Checked == true)
            {
                dagar = e;
            }
            if (checkBoxDagar.Checked == true)
            {
                dagar = f;
            }

            PreBokning.InCheckningsDatum = DateTime.Now;
            PreBokning.UtCheckningsDatum = DateTime.Now.AddDays(dagar);
            PreBokning.BokningsTyp = (string)comboBoxLägenhetstyp.SelectedItem;
            PreBokning.BokningsPris = Pris;
            PreBokning.Moms = 0.2;
            PreBokning.Bruttopris = Pris;
            PreBokning.Nettopris = Pris;
            PreBokning.Status = false;
        }
        private void BokningTillFaktura()
        {
            int d = 7;
            int e = 5;
            int f = 2;

            if (checkBoxVecka.Checked == true)
            {
                dagar = d;
            }
            if (checkBoxHelg.Checked == true)
            {
                dagar = e;
            }
            if (checkBoxDagar.Checked == true)
            {
                dagar = f;
            }
            PrivatKund pk = (PrivatKund)gbPrivatKund.CurrentRow.DataBoundItem;

            Bokning.InCheckningsDatum = DateTime.Now;
            Bokning.UtCheckningsDatum = DateTime.Now.AddDays(dagar);
            Bokning.BokningsTyp = (string)comboBoxLägenhetstyp.SelectedItem;
            Bokning.BokningsPris = Pris;
            Bokning.Moms = 0.2;
            Bokning.Bruttopris = Pris*1.12;
            Bokning.Nettopris = Pris;
            Bokning.Status = false;
            Bokning.PrivatKund = pk;

            
        }


        private void btnVäljKund_Click(object sender, EventArgs e)
        {
            if (gbPrivatKund.CurrentRow != null && dataGridViewLedigaAlt.CurrentRow != null)
            {
                // Dagar
                if (!checkBoxVecka.Checked && !checkBoxDagar.Checked && !checkBoxHelg.Checked)
                {
                    MessageBox.Show("Du har inte valt antal dagar för bokning");
                }
              

                // val av kund
                if (!checkBoxVecka.Checked && !checkBoxDagar.Checked && !checkBoxHelg.Checked)
                {
                    MessageBox.Show("Du har inte valt antal dagar för bokning");
                }
                if (comboBoxLägenhetstyp.SelectedItem != null && textBoxVeckoNr.Text != null && textBoxÅr != null && checkBoxVecka.Checked || checkBoxDagar.Checked || checkBoxHelg.Checked)
                {

                    getlogi();
                    int a = 7;
                    int b = 5;
                    int c = 2;

                    logityp = (string)comboBoxLägenhetstyp.SelectedItem;
                    vecka = textBoxVeckoNr.Text;
                    if (checkBoxVecka.Checked == true)
                    {
                        dagar = a;
                    }
                    if (checkBoxHelg.Checked == true)
                    {
                        dagar = b;
                    }
                    if (checkBoxDagar.Checked == true)
                    {
                        dagar = c;
                    }

                    TillBokning.Add(Logi);
                    dgBokning.DataSource = null;
                    dgBokning.DataSource = TillBokning;
                    Bokning.LogiTillBokning.Add(Logi);
                    HämtaPrisUthyrning(logityp, dagar, Convert.ToInt32(vecka));
                    //HämtaPrisUthyrning(logityp, dagar, Convert.ToInt32(vecka));
                    TotalPris();


                }
            }
        }
        private void getlogi()
        {
            Logi = FacadeBusiness.FacadeLogi.HämtaLogi(comboBoxLägenhetstyp.Text);
        }
        private void buttonNyKund_Click(object sender, EventArgs e)
        {
            LäggTillKund ltk = new LäggTillKund(null, Anställd);
            this.Hide();
            ltk.Show();

        }

        private void HämtaPrisUthyrning(string logityp, int dagar, int vecka)
        {
            Pris = Pris + FacadeBusiness.FacadeLogiPris.GetLogiPris(logityp, dagar, vecka);
            Logi.LogiPris = Pris;
            PriserList.Add(Pris);
        }

        public double Pris
        {
            get { return _pris; }
            set { _pris = value; }
        }

        private void RäknaUtSumma()
        {
            Pris = 0;
            foreach (double d in PriserList)
            {
                Pris = Pris + d;
            }
        }
        private void TotalPris()
        {

            PrivatKund pk = (PrivatKund)gbPrivatKund.CurrentRow.DataBoundItem;
            bool rabatt = FacadeBusiness.FacadePrivatKund.KontrolleraRabatt(pk);
            if (rabatt == true)
            {

                Pris = Pris * 0.92;
                textBoxExklMoms.Text = Pris.ToString();
                textBoxRabatt.Text = Pris.ToString();
                textBoxTotalPris.Text = (Pris * 1.12).ToString();
            }
            else
            {
                textBoxExklMoms.Text = Pris.ToString();
                textBoxMoms.Text = "20%";
                textBoxTotalPris.Text = (Pris * 1.12).ToString();
                textBoxRabatt.Text = "Ingen Rabatt";
            }
        }

        private void buttonTaBort_Click(object sender, EventArgs e)
        {

        }

        private void btnSökKund_Click(object sender, EventArgs e)
        {

        }

        private void tbSökKund_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
