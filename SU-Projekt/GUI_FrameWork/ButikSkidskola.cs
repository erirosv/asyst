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
using NPOI.OpenXmlFormats.Dml;

namespace GUI_FrameWork
{
    public partial class ButikSkidskola : UserControl
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

        public ButikSkidskola(Anställd anställd) 
        {
            FacadeBusiness = new FacadeBusiness();
            Anställd = anställd;
            
            InitializeComponent();

            if (Anställd == null)
            {
                btnBack.Hide();
            }
        }

        private void btSkolaTaBortBokning_Click(object sender, EventArgs e)
        {
            if (dataGridViewSkolaBokningar.CurrentRow != null)
            {
                sl = (SkidLektion)dataGridViewSkolaBokningar.CurrentRow.DataBoundItem;
                FacadeBusiness.FacadeSkidlektion.RemoveSkidLektion(sl);
            }
            //UpdateDataGrid();
        }

        private void ButikSkidskola_Load(object sender, EventArgs e)
        {

        }

        private void dataGridViewSkolaBokningar_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void btRegistrera_Click(object sender, EventArgs e)
        {
            
        }

        private void RegistreraDeltagare()
        {
            //if (checkBoxMånFre.Checked == true)
            //{
            //    AntalDagar = 5;
            //}
            //else if (checkBoxMånOns.Checked == true)
            //{
            //    AntalDagar = 3;
            //}

            //cbLektionsTyp.Text = _lektionstyp;
            //textBoxDeltagarNamn.Text = Deltagarnamn;


            ////Använda någon av dessa?

            //if (cbLektionsTyp != null)
            //{
            //    if (textBoxDeltagarNamn != null)
            //    {
            //        if (checkBoxMånFre.Checked == true)
            //        {
            //            AntalDagar = 5;
            //        }
            //        else if (checkBoxMånOns.Checked == true)
            //        {
            //            AntalDagar = 3;
            //        }
            //        FacadeBusiness.FacadeGruppskidlektion.LäggTillGruppskidlektion(new Gruppskidlektion()
            //        {
            //            AntalDagar = AntalDagar,
            //            LektionsTyp = LektionsTyp,
            //            DeltagarNamn = DeltagargruppNamn,
            //        });
            //        MessageBox.Show("Information registrerad");
            //    }
            //}
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

        private void textBoxSkolaSökBokning_TextChanged(object sender, EventArgs e)
        {
            search = textBoxSkolaSökBokning.Text;
        }


        // GV --> privat
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

        private void button1_Click(object sender, EventArgs e)
        {
            LäggTillKund ltk = new LäggTillKund(MarknadsChef, Anställd);
            this.Hide();
            ltk.Show();
        }

        private void checkBoxSkolaKontant_CheckedChanged(object sender, EventArgs e)
        {

        }

        // GV --> privat
        private void UpdateRegistreradprivat()
        {
            registreradprivat.DataSource = null;
            registreradprivat.DataSource = FacadeBusiness.FacadePrivatLektion.GetAllPrivatLektion();
        }

        private void btPrivRegistrera_Click(object sender, EventArgs e)
        {

            //if (comboBoxTid != null)
            //{
            //    if (comboBox1 != null)
            //    {
            //        if (textBoxPrivDeltagarnamn != null)
            //        {
            //            FacadeBusiness.FacadePrivatLektion.LäggTillPrivatLektion(new SkidLektion()
            //            {
            //                Antal = Antal,
            //                Tid = Tid,
            //                Deltagarnamn = Deltagarnamn,
            //            });
            //            MessageBox.Show("Information registrerad");
            //        }
            //        else
            //            MessageBox.Show("Du har glömt fylla i information");
            //    }
            //    else 
            //        MessageBox.Show("Du har glömt fylla i information");
            //}
            //UpdateRegistreradprivat();
        }


        private void btRegistrera_Click_1(object sender, EventArgs e)
        {
            RegistreraDeltagare();
        }

        public void Updateregistreradgrupp()
        {
            registreradgrupp.DataSource = null;
            registreradgrupp.DataSource = FacadeBusiness.FacadeGruppskidlektion.GetAllGrupplektioner();
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

        private void comboBoxTid_SelectedIndexChanged(object sender, EventArgs e)
        {
            Tid = comboBoxTid.SelectedIndex;
        }

        private void button2_Click(object sender, EventArgs e)
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

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            search = textBox1.Text;
        }

        private void textBoxDeltagarNamn_TextChanged(object sender, EventArgs e)
        {

        }

        private void cbLektionsTyp_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void checkBoxMånOns_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void checkBoxSkolaFaktura_CheckedChanged(object sender, EventArgs e)
        {

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
                        //FacadeBusiness.FacadeFaktura.SkidlektionFakturaprivat(start, slut, pk, "Skidlektion", Pris);
                    }
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

        public void HämtaSkidlektionPrisPrivat(string dagar, string typ, string antal)
        {
            Pris = Pris + FacadeBusiness.FacadeSkidlektion.GetSkidlektionPrisPrivat(dagar, typ, antal);
            SkidLektion.Pris = (int)Pris;
            Priser.Add(Pris);
        }

        private void btDeltagareTaBort_Click(object sender, EventArgs e)
        {
            if (registreradprivat.CurrentRow != null)
            {
                Deltagare d = (Deltagare)registreradgrupp.CurrentRow.DataBoundItem;
                FacadeBusiness.FacadeDeltagare.Remove(d.DeltagarID);
            }
        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            frmLogin frmLogin = new frmLogin();
            this.Hide();
            frmLogin.Show();
        }

        private void button3_Click(object sender, EventArgs e)
        {

        }

        private void btSkolaUtskrift_Click(object sender, EventArgs e)
        {

        }
    }
}
