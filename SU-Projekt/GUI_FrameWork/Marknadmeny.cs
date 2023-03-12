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
    public partial class Marknadmeny : Form
    {
        public FacadeBusiness FacadeBusiness { get; set; }
        public MarknadsChef MarknadsChef { get; set; }
        public Anställd Anställd { get; set; }

        public Marknadmeny(MarknadsChef mc)
        {
            InitializeComponent();
            MarknadsChef = mc;
            //frmLogin = login;
            FacadeBusiness = new FacadeBusiness();
            Anställd = null;

        }

        private void Marknadmeny_Load(object sender, EventArgs e)
        {

        }

        private void btndata_Click(object sender, EventArgs e)
        {
            Marknad mc = new Marknad(MarknadsChef);
                this.Hide();
            mc.Show();
        }

        private void btnloggaut_Click(object sender, EventArgs e)
        {
            frmLogin login = new frmLogin();
            this.Hide();
            login.Show();
        }

        private void btnstatistik_Click(object sender, EventArgs e)
        {
            Bestat bs = new Bestat(MarknadsChef);
            this.Hide();
            bs.Show();
        }

        private void mcföretagskund_Click(object sender, EventArgs e)
        {
            //navigera till lägg till ny företagskund
            LäggTillKund ltk = new LäggTillKund(MarknadsChef, Anställd);
            this.Hide();
            ltk.Show();
        }
        private void btnbokning_Click(object sender, EventArgs e)
        {
            Bokningsform bf = new Bokningsform(Anställd, MarknadsChef);
            this.Hide(); 
            bf.Show();
        }

        private void btnbutik_Click(object sender, EventArgs e)
        {
            ButiksForm mc = new ButiksForm(Anställd, MarknadsChef);
            this.Hide();
            mc.Show();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Marknadregister mc = new Marknadregister(MarknadsChef);
            this.Hide();
            mc.Show();
        }
    }
}
