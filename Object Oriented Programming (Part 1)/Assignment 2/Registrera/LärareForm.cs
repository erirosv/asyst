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
    public partial class LärareForm : Form
    {
        private Lärare lärare = new Lärare();

        public string namn;
        public string id;
        public string personNummer;

        public DataStore Data { get; set; }

        public LärareForm(DataStore data)
        {
            InitializeComponent();
            Data = data;
        }

        private void buttonRegistreraLärareTillKurs_Click(object sender, EventArgs e)
        {
            Form f = Application.OpenForms["RegistreraLärareTillKurs"];
            if (f != null)
            {
                this.Hide();
                f.Focus();
                f.Show();
            }
            else
            {
                RegistreraLärareTillKurs rltk = new RegistreraLärareTillKurs(Data);
                rltk.Show();
                this.Hide();
            }
        }

        private void textBoxNamn_TextChanged(object sender, EventArgs e)
        {
            namn = textBoxNamn.Text;
        }

        private void textBoxLärarID_TextChanged(object sender, EventArgs e)
        {
            id = textBoxLärarID.Text;
        }

        private void textBoxPersonNummer_TextChanged(object sender, EventArgs e)
        {
            personNummer = textBoxPersonNummer.Text;
        }

        private void buttonRegistrera_Click(object sender, EventArgs e)
        {
            Data.LärarLista.Add(new Lärare(namn, personNummer, id));

            textBoxPersonNummer.Clear();
            textBoxNamn.Clear();
            textBoxLärarID.Clear();
        }

        private void buttonUppdateraLärare_Click(object sender, EventArgs e)
        {
            bool isEmpty = !Data.LärarLista.Any();
            // Resar listan efter varje ny uppladdning
            lärarlistbox.Items.Clear();


            if (isEmpty)
            {
                MessageBox.Show("No teachers in list", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else
            {
                foreach (Lärare l in Data.LärarLista)
                {
                    lärarlistbox.Items.Add(l.Name + " | " + l.LärarID);
                }
            }
        }

        private void buttonTillbaka_Click(object sender, EventArgs e)
        {
            Main main = new Main(Data);
            main.Show();
            this.Hide();
        }

        private void buttonTaBort_Click(object sender, EventArgs e)
        {
            ListBox.SelectedObjectCollection selectedItems = new ListBox.SelectedObjectCollection(lärarlistbox);
            selectedItems = lärarlistbox.SelectedItems;

            // Tar fram index för att ta bort student i listan
            int k = selectedItems.Count - 1;

            if (lärarlistbox.SelectedIndex != -1)
            {
                // Är for-loopen nödvändig?
                for (int i = selectedItems.Count - 1; i >= 0; i--)
                {
                    lärarlistbox.Items.Remove(selectedItems[i]);
                }

                // Tar bort student från listan
                Data.LärarLista.RemoveAt(k);
            }
            else
                MessageBox.Show("Invalid. There is nothing to remove", "Error!", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }

        private void LärareForm_Load(object sender, EventArgs e)
        {

        }
    }
}
