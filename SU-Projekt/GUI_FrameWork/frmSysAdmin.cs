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
using BusinessLayer_FrameWork.Models;

namespace GUI_FrameWork
{
    public partial class frmSysAdmin : Form
    {
        public SysAdmin SystemAdmin { get; set; } 
        public FacadeBusiness FacadeBusiness { get; set; }
        public Logi Logi { get; set; }

        private string _search;
        private int logiID;
        private string LogiTyp;
        private int Dagar;
        private int Vecka;
        private bool Tillgänglighet;

        public string Search
        {
            get { return _search; }
            set { _search = value; }
        }


        public frmSysAdmin(SysAdmin sa)
        {
            InitializeComponent();
            //UpdateDataGrid();
            SystemAdmin = sa;
            FacadeBusiness = new FacadeBusiness();
        }

        // Metoder för gridview
        //private void UpdateDataGrid()
        //{
        //    gvprislistor.DataSource = null;
        //    gvprislistor.DataSource = FacadeBusiness.FacadeSysAdmin.GetAllLogiPrice();


        //}

        private void UpdateGridViewLogi()
        {
            dglogidata.DataSource = null;
            dglogidata.DataSource = FacadeBusiness.FacadeLogi.GetAllLogi();
            dglogidata.AutoSize = false;
            HideColums();
        }

        public void UpdateGridViewKonferens()
        {
            dvkonferensinfo.DataSource = null;
            dvkonferensinfo.DataSource = FacadeBusiness.FacadeKonferens.GetAllKonferens();
            dvkonferensinfo.AutoSize = false;
            HideColums();
        }
        private void HideColums()
        {
            dglogidata.Columns["LogiID"].Visible = false;
        }

        // Methods
        private void Label3_Click(object sender, EventArgs e)
        {

        }

        private void Button13_Click(object sender, EventArgs e)
        {
            if (Search != null)
            {
                if (FacadeBusiness.FacadeLogi.SearchLogi(Search).ToList() != null)
                {
                   dglogidata.DataSource = null;
                    dglogidata.DataSource = FacadeBusiness.FacadeLogi.SearchLogi(Search).ToList();
                }
                else
                    UpdateGridViewLogi();
            }
            else
                MessageBox.Show("Det finns ingen sökterm");
        }

        private void tbsökpris_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnsökprislistor_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
         
            frmLogipris lp = new frmLogipris(SystemAdmin);
            this.Hide();
            lp.Show();

        }

        private void gvprislistor_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            
        }

        private void btnuppdaterapris_Click(object sender, EventArgs e)
            {

            }



            private void bttillbaka_Click(object sender, EventArgs e)
            {
                Systemadministrarör sa = new Systemadministrarör(SystemAdmin);
                this.Hide();
                sa.Show();
            }

        private void dglogidata_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            dglogidata.Columns["LogiID"].Visible = false;
            dglogidata.Columns["LogiTyp"].Visible = true;
            dglogidata.Columns["Dagar"].Visible = true;
            dglogidata.Columns["Vecka"].Visible = false;
            dglogidata.Columns["Tillgänglighet"].Visible = false;
            dglogidata.Columns["Totalt antal lägenheter"].Visible = false;

        }
        

        private void button2_Click(object sender, EventArgs e)
        {
            frmHyrpris lp = new frmHyrpris(SystemAdmin);
            this.Hide();
            lp.Show();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            frmkonferenspris lp = new frmkonferenspris(SystemAdmin);
            this.Hide();
            lp.Show();
        }

        private void dvkonferensinfo_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void tabPage1_Click(object sender, EventArgs e)
        {

        }

        private void dvhyrdata_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
        public void UpdateLogi()
        {
            dglogidata.DataSource = null;
            dglogidata.DataSource = FacadeBusiness.FacadeLogi.GetAllLogi();
        }

        private void btntabortlogiinfo_Click(object sender, EventArgs e)
        {
            if (dglogidata.CurrentRow != null)
            {
                Logi = (Logi)dglogidata.CurrentRow.DataBoundItem;
                FacadeBusiness.FacadeLogi.RemoveLogidata(Logi);
            }
            UpdateLogi();
        }

        private void btnsökkonferens_Click(object sender, EventArgs e)
        {
            if (Search != null)
            {
                if (FacadeBusiness.FacadeKonferens.SearchKonferens(Search).ToList() != null)
                {
                    dvkonferensinfo.DataSource = null;
                    dvkonferensinfo.DataSource = FacadeBusiness.FacadeKonferens.SearchKonferens(Search).ToList();
                }
                else
                    UpdateGridViewKonferens();
            }
            else
                MessageBox.Show("Det finns ingen sökterm");
        }

        private void btnsparakonf_Click(object sender, EventArgs e)
        {

        }

        private void btnsparalogiinfo_Click(object sender, EventArgs e)
        {

        }

        private void tbsökkonferens_TextChanged(object sender, EventArgs e)
        {

        }

        private void btntabort_Click(object sender, EventArgs e)
        {

        }

        private void btntabortalldata_Click(object sender, EventArgs e)
        {

        }

        private void btntabortlogidata_Click(object sender, EventArgs e)
        {

        }

        private void tblogiinfo_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnsökhyr_Click(object sender, EventArgs e)
        {

        }
    }      
}


    

