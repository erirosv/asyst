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
    public partial class RegistreraStudentTillKurs : Form
    {
        public string stud_val;
        public string kurs_val;

        public DataStore Data { get; set; }

        public RegistreraStudentTillKurs(DataStore data)
        {
            InitializeComponent();
            Data = data;
            
        }

        private void buttonTillbaka_Click(object sender, EventArgs e)
        {
            this.Hide();
            Main main = new Main(Data);
            main.Show();
        }

        private void buttonRegistrera_Click(object sender, EventArgs e)
        {
            Student s = Data.StudentLista.SingleOrDefault(x => x.StudentId.Equals(stud_val));
            Kurs k = Data.KursLista.SingleOrDefault(x => x.KursNamn == kurs_val);

            s.KursLista.Add(k);
            k.kStudent.Add(s);


            textBoxKursNamn.Clear();
            textBoxStudentID.Clear();
        }

        private void textBoxKursNamn_TextChanged(object sender, EventArgs e)
        {
            kurs_val = textBoxKursNamn.Text;
        }

        private void textBoxStudentID_TextChanged(object sender, EventArgs e)
        {
            stud_val = textBoxStudentID.Text;
        }

        private void buttonUppdateraListor_Click(object sender, EventArgs e)
        {
            bool isEmpty = !Data.StudentLista.Any();
            // Resar listan efter varje ny uppladdning
            studenter.Items.Clear();


            if (isEmpty)
            {
                MessageBox.Show("No students in list", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else
            {
                foreach (Student p in Data.StudentLista)
                {
                    studenter.Items.Add(p.Name + " | " + p.KursName);
                }
            }
        }

        private void buttonVisaStudenter_Click(object sender, EventArgs e)
        {
            bool isEmpty = !Data.StudentLista.Any();
            // Resar listan efter varje ny uppladdning
            studenter.Items.Clear();


            if (isEmpty)
            {
                MessageBox.Show("No students in list", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else
            {
                foreach (Student p in Data.StudentLista)
                {
                    studenter.Items.Add(p.Name + " | " + p.StudentId);
                }
            }
        }

        private void kurser_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void buttonVisaKurser_Click(object sender, EventArgs e)
        {
            bool isEmpty = !Data.KursLista.Any();
            // Resar listan efter varje ny uppladdning
            kurser.Items.Clear();

            if (isEmpty)
            {
                MessageBox.Show("No course in list", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else
            {
                foreach (Kurs k in Data.KursLista)
                {
                    kurser.Items.Add(k.KursNamn + " | " + k.KursID);
                }
            }
        }

        private void RegistreraStudentTillKurs_Load(object sender, EventArgs e)
        {

        }

        private void studenter_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
