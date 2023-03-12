using Lab2Version.Registrera;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Lab2Version
{
    public partial class Main : Form
    {
        public DataStore Data 
        { 
            get; 
            set; 
        }

        public Main(DataStore data)
        {
            InitializeComponent();
            //Data = new DataStore();
            Data = data;
        }

        private void buttonStudent_Click(object sender, EventArgs e)
        {
            Form f1 = Application.OpenForms["RegistreraStudent"];
            
            if (f1 != null)
            {
                this.Hide();
                f1.Focus();
                f1.Show();
            }
            else
            {
                RegistreraStudent rs = new RegistreraStudent(Data);
                rs.Show();
                this.Hide();
            }   
        }

        private void buttonLärare_Click(object sender, EventArgs e)
        {
            Form f = Application.OpenForms["LärareForm"];
            if (f != null)
            {
                this.Hide();
                f.Focus();
                f.Show();
            }
            else
            {
                LärareForm lärare = new LärareForm(Data);
                lärare.Show();
                this.Hide();
            }
            
        }

        private void buttonKurs_Click(object sender, EventArgs e)
        {
            Form f = Application.OpenForms["LäggTillNyKurs"];
            if (f != null)
            {
                this.Hide();
                f.Focus();
                f.Show();
            }
            else
            {
                LäggTillNyKurs ltnk = new LäggTillNyKurs(Data);
                ltnk.Show();
                this.Hide();
            }
        }

        private void buttonUppgiftBetyg_Click(object sender, EventArgs e)
        {
            Form f = Application.OpenForms["RegistreraUppgift"];
            if (f != null)
            {
                this.Hide();
                f.Focus();
                f.Show();
            }
            else
            {
                RegistreraUppgift ru = new RegistreraUppgift(Data);
                ru.Show();
                this.Hide();
            }
            
        }

        private void buttonExit_Click(object sender, EventArgs e)
        {
            this.Close();
            System.Windows.Forms.Application.Exit();
        }

        private void Main_Load(object sender, EventArgs e)
        {

        }
    }
}
