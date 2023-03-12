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
    public partial class LäggTillNyKurs : Form
    {
        public string namn;
        public string id;
        public string tabort;

        private Kurs kurs = new Kurs();

        public DataStore Data { get; set; }

        public LäggTillNyKurs(DataStore data)
        {
            InitializeComponent();
            Data = data;
        }

        private void LäggTillNyKurs_Load(object sender, EventArgs e)
        {
            Data.KursLista.Add(new Kurs(namn, id));
            textBoxNamn.Clear();
            textBoxKursID.Clear();
        }



        private void buttonTillbaka_Click(object sender, EventArgs e)
        {
            Main main = new Main(Data);
            main.Show();
            this.Hide();
        }

        private void buttonLäggTIll_Click(object sender, EventArgs e)
        {
            Data.KursLista.Add(new Kurs(namn, id));
            textBoxKursID.Clear();
            textBoxNamn.Clear();
        }

        private void textBoxKursID_TextChanged(object sender, EventArgs e)
        {
            id = textBoxKursID.Text;
        }

        private void textBoxNamn_TextChanged(object sender, EventArgs e)
        {
            namn = textBoxNamn.Text;
        }

        private void buttonUppdateraKurs_Click(object sender, EventArgs e)
        {
            //if (listboxkurser.Name == null)
            //{
            //    listboxkurser.Items.RemoveAt(0);
            //}

            bool isEmpty = !Data.KursLista.Any();
            // Resar listan efter varje ny uppladdning
            listboxkurser.Items.Clear();

            if (isEmpty)
            {
                MessageBox.Show("No No in list", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else
            {
                foreach (Kurs k in Data.KursLista)
                {
                    if (k.KursNamn == null || k.KursID == null)
                    {
                        continue;
                    }
                    else
                    {
                        listboxkurser.Items.Add(k.KursNamn + " | " + k.KursID);
                    }
                   
                }
            }

            
        }

        private void textBoxTaBort_TextChanged(object sender, EventArgs e)
        {
            tabort = textBoxKursID.Text;
        }

        private void buttonTaBort_Click(object sender, EventArgs e)
        {
            ListBox.SelectedObjectCollection selectedItems = new ListBox.SelectedObjectCollection(listboxkurser);
            selectedItems = listboxkurser.SelectedItems;

            // Tar fram index för att ta bort student i listan
            int k = selectedItems.Count - 1;

            if (listboxkurser.SelectedIndex != -1)
            {
                // Är for-loopen nödvändig?
                for (int i = selectedItems.Count - 1; i >= 0; i--)
                {
                    listboxkurser.Items.Remove(selectedItems[i]);
                }

                // Tar bort student från listan
                Data.KursLista.RemoveAt(k);
                
            }
            else
                MessageBox.Show("Invalid. There is nothing to remove", "Error!", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }

        private void buttonRegistreraUppgiftTillKurs_Click(object sender, EventArgs e)
        {
            RegistreraUppgift ru = new RegistreraUppgift(Data);
            ru.Show();
            this.Hide();
        }
    }
}
