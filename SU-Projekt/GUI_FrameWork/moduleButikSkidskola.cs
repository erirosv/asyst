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

namespace GUI_FrameWork
{
    public partial class moduleButikSkidskola : UserControl
    {
        public string search;

        public SkidLektion sl = new SkidLektion();
        public Privatskidlektion pl = new Privatskidlektion();
        public FacadeBusiness FacadeBusiness { get; set; }
        public Anställd Anställd { get; set; }
        public MarknadsChef MarknadsChef { get; set; }
        public SkidLektion SkidLektion { get; set; }

        private DateTime start { get; set; }
        private DateTime slut { get; set; }
        public List<double> Priser { get; set; }

        private int _antaldagar;
        private string _lektionstyp;
        private string _deltagargruppnamn;
        private string _antal;
        private int _tid;
        private string _deltagarnamn;
        private double _pris;

        public moduleButikSkidskola()
        {
            InitializeComponent();
        }

        private void btRegistrera_Click(object sender, EventArgs e)
        {
            RegistreraDeltagare();
        }

        private void RegistreraDeltagare()
        {

            if (cbLektionsTyp != null)
            {
                if (textBoxDeltagarNamn != null)
                {
                    if (checkBoxMånFre.Checked == true && !checkBoxMånOns.Checked)
                    {
                        AntalDagar = 5;
                        SkapaDeltagare();
                    }
                    else if (checkBoxMånOns.Checked == true && !checkBoxMånFre.Checked)
                    {
                        AntalDagar = 3;
                        SkapaDeltagare();
                    }
                    else
                        MessageBox.Show("Du kan bara välja ett alternativ");

                    MessageBox.Show("Information registrerad");
                }
            }
        }

        private void SkapaDeltagare()
        {
            //FacadeBusiness.FacadeGruppskidlektion.LäggTillGruppskidlektion(new Gruppskidlektion()
            //{
            //    AntalDagar = AntalDagar,
            //    LektionsTyp = LektionsTyp,
            //    DeltagarNamn = DeltagargruppNamn,
            //});
        }

        public int AntalDagar
        {
            get { return _antaldagar; }
            set { _antaldagar = value; }
        }

        public string LektionsTyp
        {
            get { return _lektionstyp; }
            set { _lektionstyp = value; }
        }

        public string DeltagargruppNamn
        {
            get { return _deltagarnamn; }
            set { _deltagarnamn = value; }
        }

        public string Antal
        {
            get { return _antal; }
            set { _antal = value; }
        }

        public int Tid
        {
            get { return _tid; }
            set { _tid = value; }
        }

        public string Deltagarnamn
        {
            get { return _deltagarnamn; }
            set { _deltagarnamn = value; }
        }

        public double Pris
        {
            get { return _pris; }
            set { _pris = value; }
        }

        private void btSkolaSparaBokning_Click(object sender, EventArgs e)
        {
            if (dataGridView1.CurrentRow != null)
            {
                if (!checkBoxSkolaKontant.Checked && !checkBoxSkolaFaktura.Checked)
                {
                    MessageBox.Show("Du måste välja betalsätt");
                }
                if (checkBoxSkolaKontant.Checked && checkBoxSkolaFaktura.Checked)
                {
                    MessageBox.Show("Du kan endast välja ett betalsätt");
                }
                else if (checkBoxSkolaKontant.Checked && !checkBoxSkolaFaktura.Checked)
                {
                    MessageBox.Show($"Betalning kontant!");
                }
                else if (!checkBoxSkolaKontant.Checked && checkBoxSkolaFaktura.Checked)
                {
                    if (checkBoxMånOns.Checked == true)
                    {
                        start = DateTime.Now;
                        slut = start.AddDays(3);
                        RäknaUtSumma();
                    }
                    else if (checkBoxMånFre.Checked == true)
                    {
                        start = DateTime.Now;
                        slut = start.AddDays(5);
                        RäknaUtSumma();
                    }
                    Deltagare deltagare = (Deltagare)dataGridView1.CurrentRow.DataBoundItem;
                }
            }
        }

        private void RäknaUtSumma()
        {
            Pris = 0;
            foreach (double d in Priser)
            {
                Pris = Pris + d;
            }
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            if (search != null)
            {
                if (FacadeBusiness.FacadeFöretagsKund.SearchFöretagsKund(search).ToList() != null)
                {
                    dataGridView1.DataSource = null;
                    dataGridView1.DataSource = FacadeBusiness.FacadeFöretagsKund.SearchFöretagsKund(search).ToList();
                }
            }
            else
                MessageBox.Show("Det finns ingen sökterm");
        }

        private void textBoxDeltagarNamn_TextChanged(object sender, EventArgs e)
        {
            Deltagarnamn = textBoxDeltagarNamn.Text;
        }

        private void btnGruppSök_TextChanged(object sender, EventArgs e)
        {
            search = btnGruppSök.Text;
        }

        private void textBoxSkolaSökBokning_TextChanged(object sender, EventArgs e)
        {
            search = btnGruppSök.Text;
        }

        private void btSkolaSökBokning_Click(object sender, EventArgs e)
        {
            if (search != null)
            {
                if (FacadeBusiness.FacadePrivatKund.SearchPrivatKund(search).ToList() != null)
                {
                    dataGridViewSkolaBokningar.DataSource = null;
                    dataGridViewSkolaBokningar.DataSource = FacadeBusiness.FacadePrivatKund.SearchPrivatKund(search).ToList();
                }
            }
            else
                MessageBox.Show("Det finns ingen sökterm");
        }

        private void btnLäggTillKund_Click(object sender, EventArgs e)
        {
            LäggTillKund();
        }

        private void btnLäggTillKundG_Click(object sender, EventArgs e)
        {
            LäggTillKund();
        }

        private void LäggTillKund()
        {
            LäggTillKund ltk = new LäggTillKund(MarknadsChef, Anställd);
            this.Hide();
            ltk.Show();
        }

        private void sparabokningprivat_Click(object sender, EventArgs e)
        {
            if (dataGridViewSkolaBokningar.CurrentRow != null)
            {
                if (registreradprivat.CurrentRow != null)
                {
                    if (!checkBoxkontantprivat.Checked && !checkboxfakturaprivat.Checked)
                    {
                        MessageBox.Show("Du måste välja betalsätt");
                    }
                    if (checkBoxkontantprivat.Checked && checkboxfakturaprivat.Checked)
                    {
                        MessageBox.Show("Du kan endast välja ett betalsätt");
                    }
                    else if (checkBoxkontantprivat.Checked && !checkboxfakturaprivat.Checked)
                    {
                        MessageBox.Show($"Betalning kontant!");
                    }
                    else if (!checkBoxkontantprivat.Checked && checkboxfakturaprivat.Checked)
                    {
                        start = DateTime.Now;
                        slut = start.AddDays(30);
                        RäknaUtSumma();
                        Privatskidlektion privatlektion = (Privatskidlektion)dataGridViewSkolaBokningar.CurrentRow.DataBoundItem;
                        PrivatKund pk = (PrivatKund)registreradprivat.CurrentRow.DataBoundItem;
                       // FacadeBusiness.FacadeFaktura.SkidlektionFakturaprivat(start, slut, pk, "Skidlektion", Pris);
                    }
                }
            }
        }

        private void btDeltagareTaBort_Click(object sender, EventArgs e)
        {
            if (registreradprivat.CurrentRow != null)
            {
                Deltagare d = (Deltagare)registreradprivat.CurrentRow.DataBoundItem;
                FacadeBusiness.FacadeDeltagare.Remove(d.DeltagarID);
            }
        }

        private void btPrivRegistrera_Click(object sender, EventArgs e)
        {
            if (cbAntal != null)
            {
                if (cbTid != null)
                {
                    if (textBoxPrivDeltagarnamn != null)
                    {
                        FacadeBusiness.FacadePrivatLektion.LäggTillPrivatLektion(new SkidLektion()
                        {
                            SkidLärare = "Jöns",
                            TypAvLektion = "Privat",
                            Pris = Pris,
                            Antal = Antal,
                            Tid = int.Parse(cbTid.Text),
                            Deltagarnamn = Name
                        });
                    }
                }
            }
        }

        private void btnTaBortGDeltagre_Click(object sender, EventArgs e)
        {
            if (registreradgrupp.CurrentRow != null)
            {
                Deltagare d = (Deltagare)registreradgrupp.CurrentRow.DataBoundItem;
                FacadeBusiness.FacadeDeltagare.Remove(d.DeltagarID);
            }
        }
    }
}

