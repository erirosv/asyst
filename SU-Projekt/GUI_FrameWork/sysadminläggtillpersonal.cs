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
    public partial class sysadminläggtillpersonal : Form
    {
        public FacadeBusiness FacadeBusiness { get; set; }
        public SysAdmin SysAdmin { get; set; }
        public Anställd Anställd { get; set; }

        public sysadminläggtillpersonal(SysAdmin sa)
        {
            SysAdmin = sa;
            FacadeBusiness = new FacadeBusiness();
            InitializeComponent();
        }

        private string _användarnamn;
        private string _fnamn;
        private string _enamn;
        private string _lösenord;
        private string _behörighet;
        private string _anställningstyp;

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            if (textBox1 != null)
            {
                Användarnamn = textBox1.Text;
            }
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {
            if (textBox2 != null)
            {
                Förnamn = textBox2.Text;
            }
        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {
            if (textBox3 != null)
            {
                Efternamn = textBox3.Text;
            }
        }

        private void textBox4_TextChanged(object sender, EventArgs e)
        {
            if (textBox4 != null)
            {
                Lösenord = textBox4.Text;
            }
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (comboBox1 != null)
            {
                Behörighet = comboBox1.Text;
            }
        }

        private void comboBox2_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (comboBox2 != null)
            {
                Anställningstyp = comboBox2.Text;
            }
        }

        private void buttonaddpersonal_Click(object sender, EventArgs e)
        {
            if (Användarnamn != null)
            {
                if (Förnamn != null)
                {
                    if (Efternamn != null)
                    {
                        if (Lösenord != null)
                        {
                            if (Behörighet != null)
                            {
                                if (Anställningstyp != null)
                                {
                                    FacadeBusiness.FacadeAnställd.AddAnställd(new Anställd()
                                    {
                                        AnvändarNamn = Användarnamn,
                                        AnställdFörnamn = Förnamn,
                                        AnställdEfternamn = Efternamn,
                                        Lösenord = Lösenord,
                                        Behörighet = Behörighet,
                                        AnställningsTyp = Anställningstyp,
                                        Bokningar = null,
                                        Uthyrningar = null,
                                    });
                                    MessageBox.Show("Anställd tillagd");
                                }
                                else
                                    MessageBox.Show("Varning! Saknas 'lösenord', 'behörighet' eller 'anställdstyp' ");
                            }
                            else
                                MessageBox.Show("Varning! Saknar förnamn' eller 'efternamn'");
                        }                      
                    }        
                }
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

        private void button1_Click(object sender, EventArgs e)
        {
            sysadminpersonal sa = new sysadminpersonal(SysAdmin);
            this.Hide();
            sa.Show();
        }
    }
}
