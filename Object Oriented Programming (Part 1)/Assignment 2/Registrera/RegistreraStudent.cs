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
    public partial class RegistreraStudent : Form
    {
        private Student student = new Student();

        public string namn;
        public string id;
        public string pn;

        public DataStore Data { get; set; }

        public RegistreraStudent(DataStore data)
        {
            InitializeComponent();
            Data = data;
        }

        private void buttonRegistrera_Click(object sender, EventArgs e)
        {
            Data.StudentLista.Add(new Student(namn, pn, id));

            textBoxNamn.Clear();
            textBoxStudentID.Clear();
            textBoxPersonNummer.Clear();

        }

        private void buttonUppdateraStudent_Click(object sender, EventArgs e)
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

        private void buttonTillbaka_Click(object sender, EventArgs e)
        {
            Main main = new Main(Data);
            main.Show();
            this.Hide();
        }

        private void textBoxStudentID_TextChanged(object sender, EventArgs e)
        {
            id = textBoxStudentID.Text;
        }

        private void textBoxNamn_TextChanged(object sender, EventArgs e)
        {
            namn = textBoxNamn.Text;
        }

        private void textBoxPersonNummer_TextChanged(object sender, EventArgs e)
        {
            pn = textBoxPersonNummer.Text;
        }

        private void buttonTaBort_Click(object sender, EventArgs e)
        {
            ListBox.SelectedObjectCollection selectedItems = new ListBox.SelectedObjectCollection(studenter);
            selectedItems = studenter.SelectedItems;

            // Tar fram index för att ta bort student i listan
            int k = selectedItems.Count - 1;

            if (studenter.SelectedIndex != -1)
            {
                // Är for-loopen nödvändig?
                for (int i = selectedItems.Count - 1; i >= 0; i--)
                {
                    studenter.Items.Remove(selectedItems[i]);
                }

                // Tar bort student från listan
                Data.StudentLista.RemoveAt(k);
            }
            else
                MessageBox.Show("Invalid. There is nothing to remove", "Error!", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }

        private void buttonRegistreraStudentTillKurs_Click(object sender, EventArgs e)
        {
            RegistreraStudentTillKurs rk = new RegistreraStudentTillKurs(Data);
            rk.Show();
            this.Hide();
        }

        private void RegistreraStudent_Load(object sender, EventArgs e)
        {

        }

        private void studenter_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
