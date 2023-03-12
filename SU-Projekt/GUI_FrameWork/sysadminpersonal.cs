using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using BusinessEntities_FrameWork.Models;
using BusinessLayer_FrameWork;

namespace GUI_FrameWork
{
    public partial class sysadminpersonal : Form
    {
        public FacadeBusiness FacadeBusiness { get; set; }
        public Anställd Anställd { get; set; }
        public SysAdmin SystemAdmin { get; set; }

        public string _search;
        private string _användarnamn;
        private string _fnamn;
        private string _enamn;
        private string _lösenord;
        private string _behörighet;
        private string _anställningstyp;

        public sysadminpersonal(SysAdmin sa)
        {
            InitializeComponent();
            SystemAdmin = sa;
            FacadeBusiness = new FacadeBusiness();
            Anställd = null;
            PreSetComboBox();
            UpdatePersonal();
            //dvpersonaldata.DataSource = FacadeBusiness.FacadeAnställd.GetAllAnställd();
        }

        public void UpdatePersonal()
        {
            dvpersonaldata.DataSource = null;
            dvpersonaldata.DataSource = FacadeBusiness.FacadeAnställd.GetAllAnställd();
        }

        private void dvpersonaldata_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            
        }

        private void btntabortpersonal_Click(object sender, EventArgs e)
        {
            if (dvpersonaldata.CurrentRow != null)
            {
                Anställd = (Anställd)dvpersonaldata.CurrentRow.DataBoundItem;
                FacadeBusiness.FacadeAnställd.RemovePersonal(Anställd);
            }
            UpdatePersonal();
        }

        private void tabPage2_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            Systemadministrarör sm = new Systemadministrarör(SystemAdmin);
            this.Hide();
            sm.Show();
        }

        private void button2_Click(object sender, EventArgs e)
        {

        }

        private void tbanamn_TextChanged(object sender, EventArgs e)
        {
            if (tbanamn != null)
            {
                Användarnamn = tbanamn.Text;
            }
        }

        private void PreSetComboBox()
        {

        }

        private void tbfnamn_TextChanged(object sender, EventArgs e)
        {
            if (tbfnamn != null)
            {
                Förnamn = tbfnamn.Text;
            }
        }

        private void tbenamn_TextChanged(object sender, EventArgs e)
        {
            if (tbenamn != null)
            {
                Efternamn = tbenamn.Text;
            }
        }

        private void tblösen_TextChanged(object sender, EventArgs e)
        {
            if (tblösen != null)
            {
                Lösenord = tblösen.Text;
            }
        }

        public string Användarnamn
        {
            get { return _användarnamn; }
            set { _användarnamn = value; }
        }

        public string Förnamn
        {
            get { return _fnamn; }
            set { _fnamn = value; }
        }

        public string Efternamn
        {
            get { return _enamn; }
            set { _enamn = value; }
        }

        public string Lösenord
        {
            get { return _lösenord; }
            set { _lösenord = value; }
        }

        public string Behörighet
        {
            get { return _behörighet; }
            set { _behörighet = value; }
        }

        public string Anställningstyp
        {
            get { return _anställningstyp; }
            set { _anställningstyp = value; }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            sysadminläggtillpersonal sap = new sysadminläggtillpersonal(SystemAdmin);
            this.Hide();
            sap.Show();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            Search = textBox1.Text;
        }

        private void sökupdatepersonal_Click(object sender, EventArgs e)
        {
            if (Search != null)
            {
                if (FacadeBusiness.FacadeAnställd.SearchAnställdEfternamn(Search).ToList() != null)
                {
                    dvpersonaldata.DataSource = null;
                    dvpersonaldata.DataSource = FacadeBusiness.FacadeAnställd.SearchAnställdEfternamn(Search).ToList();
                }
                else
                    UpdatePersonal();
            }
            else
                MessageBox.Show("Det finns ingen sökterm");
        }

        public string Search
        {
            get { return _search; }
            set { _search = value; }
        }

        private void btnuppdateraanställd_Click_1(object sender, EventArgs e)
        {
            if (Användarnamn != null)
            {
                Anställd.AnvändarNamn = Användarnamn;
            }
            if (Förnamn != null)
            {
                Anställd.AnställdFörnamn = Förnamn;
            }
            if (Efternamn != null)
            {
                Anställd.AnställdEfternamn = Efternamn;
            }
            if (Lösenord != null)
            {
                Anställd.Lösenord = Lösenord;
            }
            if (Behörighet != null)
            {
                Anställd.Behörighet = Behörighet;
            }
            if (Anställningstyp != null)
            {
                Anställd.AnställningsTyp = Anställningstyp;
            }
            FacadeBusiness.FacadeAnställd.UppdateraAnställd(Anställd, Anställd.AnställningsID);
            MessageBox.Show("Personal Uppdaterad!");
        }

        private void dvpersonaldata_CellContentClick_1(object sender, DataGridViewCellEventArgs e)
        {
            if (dvpersonaldata.CurrentRow != null)
            {
                if (dvpersonaldata.SelectedRows.Count > 0)
                {
                    Anställd = (Anställd)dvpersonaldata.CurrentRow.DataBoundItem;
                    tbanamn.Text = Anställd.AnvändarNamn;
                    tbfnamn.Text = Anställd.AnställdFörnamn;
                    tbenamn.Text = Anställd.AnställdEfternamn;
                    tblösen.Text = Anställd.Lösenord;
                    cbbehörig.Text = Anställd.Behörighet;
                    cbanställdstyp.Text = Anställd.AnställningsTyp.ToString();
                }
            }
        }

        private void btntabortpersonal_Click_1(object sender, EventArgs e)
        {
            if (dvpersonaldata.CurrentRow != null)
            {
                Anställd = (Anställd)dvpersonaldata.CurrentRow.DataBoundItem;
                FacadeBusiness.FacadeAnställd.RemovePersonal(Anställd);
            }
            UpdatePersonal();
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cbbehörig != null)
            {
                Behörighet = comboBox1.Text;
            }
        }

        private void comboBox2_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cbanställdstyp != null)
            {
                _anställningstyp = comboBox2.Text;
            }
        }
    }
}

