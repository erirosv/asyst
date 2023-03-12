using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Lab2Version.Registrera
{
    public partial class Betygssättning : Form
    {
        public string id;
        public string uNamn;
        public string betyg;

        public DataStore Data { get; set; }

        public Betygssättning(DataStore data)
        {
            InitializeComponent();
            Data = data;
        }

        private void buttonUppdatera_Click(object sender, EventArgs e)
        {
            listBoxStudenter.Items.Clear();
            listBoxUppgifter.Items.Clear();

            //listBoxStudenter = uppgift.VisaUppgifter();
            bool isEmpty = !Data.StudentLista.Any();
            // Resar listan efter varje ny uppladdning
            listBoxStudenter.Items.Clear();


            if (isEmpty)
            {
                MessageBox.Show("No students in list", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else
            {
                foreach (Student p in Data.StudentLista)
                {
                    listBoxStudenter.Items.Add(p.Name + " | " + p.StudentId);
                }
            }

            bool isEmptyUpg = !Data.UppgiftsLista.Any();
            // Resar listan efter varje ny uppladdning
            listBoxUppgifter.Items.Clear();


            if (isEmptyUpg)
            {
                MessageBox.Show("No no in list", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else
            {
                foreach (Uppgift u in Data.UppgiftsLista)
                {
                    listBoxUppgifter.Items.Add(u.UpgName + " | " + u.UpgBetyg);
                    
                }
            }
        }

        private void buttonExit_Click(object sender, EventArgs e)
        {
            this.Hide();
            Main main = new Main(Data);
            main.Show();
        }

        private void textBoxStudentID_TextChanged(object sender, EventArgs e)
        {
            id = textBoxStudentID.Text;
        }

        private void textBoxUpgNamn_TextChanged(object sender, EventArgs e)
        {
            uNamn = textBoxUpgNamn.Text;
        }

        private void textBoxBetyg_TextChanged(object sender, EventArgs e)
        {
            betyg = textBoxBetyg.Text;
        }

        private void buttonSättBetyg_Click(object sender, EventArgs e)
        {
            Student s = Data.StudentLista.SingleOrDefault(x => x.StudentId == id);
            Uppgift u = Data.UppgiftsLista.SingleOrDefault(x => x.UpgName == uNamn);

            u.UpgBetyg = betyg;
            s.Uppgift.Add(u);
            
            textBoxStudentID.Clear();
            textBoxBetyg.Clear();
            textBoxUpgNamn.Clear();
        }

        private void Betygssättning_Load(object sender, EventArgs e)
        {

        }

        private void listBoxStudenter_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
