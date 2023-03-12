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
    public partial class Systemadministrarör : Form
    {
        public string användarNamn;
        public string lösenord;
        public FacadeBusiness FacadeBusiness = new FacadeBusiness();
        public SysAdmin SysAdmin = null;
        public frmLogin frmLogin { get; set; }
        public SysAdmin SystemAdmin { get; set; }

        public Systemadministrarör(SysAdmin sa)
        {
            SysAdmin = FacadeBusiness.FacadeSysAdmin.LoginSysAdmin(användarNamn, lösenord);
            SystemAdmin = sa;
            InitializeComponent();
        }

        private void Button3_Click(object sender, EventArgs e)
        {
            frmLogin login = new frmLogin();
            this.Hide();
            login.Show();

        }

        private void btndata_Click(object sender, EventArgs e)
        {
            
                frmSysAdmin sa = new frmSysAdmin(SysAdmin);
                this.Hide();
                sa.Show();
            
        }

        private void btnpersonal_Click(object sender, EventArgs e)
        {
            sysadminpersonal sp = new sysadminpersonal(SystemAdmin);
            this.Hide();
            sp.Show();
        }

        private void btUppdatera_Click(object sender, EventArgs e)
        {
            UppdateraKund sa = new UppdateraKund(SysAdmin);
            this.Hide();
            sa.Show();
        }
    }
}
