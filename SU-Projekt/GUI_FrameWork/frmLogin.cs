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

    public partial class frmLogin : Form
    {
        public string användarNamn;
        public string lösenord;
        public FacadeBusiness FacadeBusiness = new FacadeBusiness();

        public Anställd Anställd = null;
        public SysAdmin SysAdmin = null;
        public MarknadsChef MarknadsChef = null;


        public frmLogin()
        {
            InitializeComponent();
            
        }

        private void Login_Click(object sender, EventArgs e)
        {
            Anställd = FacadeBusiness.FacadeAnställd.LoginAnställd(användarNamn, lösenord);
            SysAdmin = FacadeBusiness.FacadeSysAdmin.LoginSysAdmin(användarNamn, lösenord);
            MarknadsChef = FacadeBusiness.FacadeMarknadsChef.LoginMarknadsChef(användarNamn, lösenord);

             if (Anställd == null && SysAdmin == null && MarknadsChef == null)
             {
                MessageBox.Show(":/ åtkomst nekad ");
             }
             else if (Anställd != null && Anställd.Behörighet == "Reception")
             {
                Bokningsform a_s = new Bokningsform(Anställd, MarknadsChef);
                this.Hide();
                a_s.Show();
            }
             else if (SysAdmin != null)
             {
                Systemadministrarör sa = new Systemadministrarör(SysAdmin);
                this.Hide();
                sa.Show();
             }
             else if (MarknadsChef != null)
             {
                Marknadmeny mc = new Marknadmeny(MarknadsChef);
                this.Hide();
                mc.Show();
             }
             else if(Anställd != null && Anställd.Behörighet == "Butik")
             {
                ButiksForm bk = new ButiksForm(Anställd, MarknadsChef);
                this.Hide();
                bk.Show();
             }
             else if(Anställd != null && Anställd.Behörighet.Equals("Skidlärare"))
             {
                Skidlärare sk = new Skidlärare(Anställd);
                this.Hide();
                sk.Show();
             }
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            användarNamn = textBox1.Text;
        }

        private void Login_Load(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {
            lösenord = textBox2.Text;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void textBox2_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyValue == (char)Keys.Enter)
            {
                Login_Click(null, null);
            }
        }
    }
}
