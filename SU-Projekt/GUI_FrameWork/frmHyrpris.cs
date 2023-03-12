using BusinessEntities_FrameWork.Models;
using BusinessLayer_FrameWork;
using BusinessLayer_FrameWork.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GUI_FrameWork
{
    public partial class frmHyrpris : Form
    {
        public SysAdmin SysAdmin { get; set; }
        public Hyrpris Hyrpris  { get; set; }
        public FacadeBusiness FacadeBusiness { get; set; }
        private double pris;
      
        
        public frmHyrpris(SysAdmin sa)
        {
            SysAdmin = sa;
            InitializeComponent();
            FacadeBusiness = new FacadeBusiness();
            UpdateGrid();
        }

        private void UpdateGrid()
        {
            dghyrpris.DataSource = null;
            dghyrpris.DataSource = FacadeBusiness.FacadeHyrpris.HämtaAllaHyrpris().ToList();
        }
        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
           
            dghyrpris.Columns["HyrprisID"].Visible = true;
            dghyrpris.Columns["UtrustningSort"].Visible = true;
            dghyrpris.Columns["UrustningsTyp"].Visible = true;
            dghyrpris.Columns["AntalDagar"].Visible = true;
            dghyrpris.Columns["Pris"].Visible = true;

        }

        private void button1_Click(object sender, EventArgs e)
        {
            frmSysAdmin fs = new frmSysAdmin(SysAdmin);
            this.Hide();
            fs.Show();
        }

        private void btändra_Click(object sender, EventArgs e)
        {
            Hyrpris.Pris = pris;
            FacadeBusiness.FacadeHyrpris.UppdateraHyrpris(Hyrpris, Hyrpris.HyrPirsID);
            MessageBox.Show("Uppdaterad!");
        }

        private void dghyrpris_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (dghyrpris.SelectedRows.Count > 0)
            {
                Hyrpris = (Hyrpris)dghyrpris.SelectedRows[0].DataBoundItem;
                tbHyrpris.Text = Convert.ToString(Hyrpris.Pris);
            }
        }

        private void tbHyrpris_TextChanged(object sender, EventArgs e)
        {
            pris = Convert.ToDouble(tbHyrpris.Text);

        }
    }
}
