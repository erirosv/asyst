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
    public partial class RegistreraLärareTillKurs : Form
    {
        public string lärarId;
        public string kursNamn;

        public DataStore Data { get; set; }

        public RegistreraLärareTillKurs(DataStore data)
        {
            InitializeComponent();
            Data = data;
        }

        private void buttonTillbaka_Click(object sender, EventArgs e)
        {
            LärareForm lm = new LärareForm(Data);
            lm.Show();
            this.Hide();
        }

        private void buttonRegistrera_Click(object sender, EventArgs e)
        {
            Lärare l = Data.LärarLista.SingleOrDefault(x => x.LärarID == lärarId);
            Kurs k = Data.KursLista.Single(x => x.KursNamn == kursNamn);

            k.LäggTillLärare(l);
            l.lKurs.Add(k);

            textBox1.Clear();
            textBox2.Clear();
        }

        private void buttonUppdateraLärare_Click(object sender, EventArgs e)
        {
            bool isEmpty = !Data.LärarLista.Any();
            // Resar listan efter varje ny uppladdning
            lärare.Items.Clear();

            if (isEmpty)
            {
                MessageBox.Show("No teachers in list", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else
            {
                foreach (Lärare l in Data.LärarLista)
                {
                    lärare.Items.Add(l.Name + " | " + l.LärarID);
                }
            }
        }

        private void buttonUppdateraKursLista_Click(object sender, EventArgs e)
        {
            bool isEmpty = !Data.KursLista.Any();
            // Resar listan efter varje ny uppladdning
            ListaKurser.Items.Clear();

            if (isEmpty)
            {
                MessageBox.Show("No courses in list", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else
            {
                foreach (Kurs k in Data.KursLista)
                {
                    ListaKurser.Items.Add(k.KursNamn + " | " + k.KursID);
                }
            }
        }

        private void ListaKurser_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void RegistreraLärareTillKurs_Load(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            lärarId = textBox1.Text;
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {
            kursNamn = textBox2.Text;
        }
    }
}
