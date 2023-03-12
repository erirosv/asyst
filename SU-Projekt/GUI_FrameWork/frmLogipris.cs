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
    public partial class frmLogipris : Form
    {
        public SysAdmin SysAdmin { get; set; }
        public Logi Logi { get; set; }
        public FacadeBusiness FacadeBusiness { get; set; }

        private int Dagar;
        private int Vecka;
        private double Pris;

        private string LogiTyp;


        public frmLogipris(SysAdmin sa)
        {
            SysAdmin = sa;
            InitializeComponent();
            FacadeBusiness = new FacadeBusiness();
            UpdateGrid();
        }

        private void UpdateGrid()
        {
            dglogipris.DataSource = null;
            dglogipris.DataSource = FacadeBusiness.FacadeLogiPris.HämtaLogiPris().ToList();
        }

        private void dglogipris_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            dglogipris.Columns["LogiprisID"].Visible = true;
            dglogipris.Columns["LogiTyp"].Visible = true;
            dglogipris.Columns["Vecka"].Visible = true;
            dglogipris.Columns["Dagar"].Visible = true;
            dglogipris.Columns["Pris"].Visible =true;

        }

        private void button1_Click(object sender, EventArgs e)
        {
            frmSysAdmin fs = new frmSysAdmin(SysAdmin);
            this.Hide();
            fs.Show();
        }

        private void btändra_Click(object sender, EventArgs e)
        {
            if (LogiTyp != null)
            {
                Logi.LogiTyp = LogiTyp;
            }
            if (Vecka != null)
            {
                Logi.Vecka = Vecka;
            }
            if (Dagar != null)
            {
                Logi.Dagar = Dagar;
            }
            if (Pris != null)
            {
                //Logi.Pris = Pris;
            }

            //FacadeBusiness.FacadeLogiPris.UppdateraLogiPris(Logi.LogiPris, Logi.LogiPris.LogiPrisID);
            MessageBox.Show("Logi pris är  uppdaterad!");

        }
    }
}
