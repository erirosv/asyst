using BusinessEntities_FrameWork.Models;
using BusinessLayer_FrameWork;
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
    public partial class frmkonferenspris : Form
    {
       
        public SysAdmin SysAdmin { get; set; }
        public FacadeBusiness FacadeBusiness { get; set; }
        public KonferensPris KonferensPris { get; set; }
        private double Pris;

        public frmkonferenspris(SysAdmin sa)
        {
            SysAdmin = sa;
            InitializeComponent();
            FacadeBusiness = new FacadeBusiness();
            UpdateDataGrid();
        }

        private void dgkonferenspris_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            dgkonferenspris.Columns["KonferensPrisID"].Visible = true;
            dgkonferenspris.Columns["Antal dagar"].Visible = true;
            dgkonferenspris.Columns["Konferens typ"].Visible = true;
            dgkonferenspris.Columns["Vecka"].Visible = true;
            dgkonferenspris.Columns["Timmar"].Visible = true;
            dgkonferenspris.Columns["Pris"].Visible = true;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            frmSysAdmin fs = new frmSysAdmin(SysAdmin);
            this.Hide();
            fs.Show();
        }
        
        private void UpdateDataGrid()
        {
            dgkonferenspris.DataSource = null;
            dgkonferenspris.DataSource = FacadeBusiness.FacadeKonferensPris.HämtaKonferensPris().ToList();
        }

        private void dgkonferenspris_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (dgkonferenspris.SelectedRows.Count > 0)
            {
                KonferensPris = (KonferensPris)dgkonferenspris.SelectedRows[0].DataBoundItem;
                tbkonferenspris.Text = Convert.ToString(KonferensPris.Pris);
            }
        }

        private void btändra_Click(object sender, EventArgs e)
        {
            KonferensPris.Pris = Pris;
            FacadeBusiness.FacadeKonferensPris.UppdateraKonferensPris(KonferensPris, KonferensPris.KonferensPrisID);
            MessageBox.Show("Uppdaterad!");
        }

        private void tbkonferenspris_TextChanged_1(object sender, EventArgs e)
        {
            Pris = Convert.ToDouble(tbkonferenspris.Text);
        }
    }
}
