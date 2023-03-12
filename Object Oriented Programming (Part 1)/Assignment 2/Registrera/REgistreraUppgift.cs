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
    public partial class RegistreraUppgift : Form
    {
        public DataStore Data { get; set; }

        private Uppgift uppfigt = new Uppgift();

        public string namn;

        public RegistreraUppgift(DataStore data)
        {
            InitializeComponent();
            Data = data;
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            namn = textBoxUppgiftNamn.Text;
        }

        private void buttonRegistreraUppgift_Click(object sender, EventArgs e)
        {
            Data.UppgiftsLista.Add(new Uppgift(namn));
            textBoxUppgiftNamn.Clear();
        }

        private void buttonVisaUppgifter_Click(object sender, EventArgs e)
        {
            bool isEmpty = !Data.UppgiftsLista.Any();
            // Resar listan efter varje ny uppladdning
            listBoxUppgifter.Items.Clear();


            if (isEmpty)
            {
                MessageBox.Show("No students in list", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else
            {
                foreach (Uppgift u in Data.UppgiftsLista)
                {
                    listBoxUppgifter.Items.Add(u.UpgName);
                }
            }
        }

        private void buttonSättBetyg_Click(object sender, EventArgs e)
        {
            Betygssättning b = new Betygssättning(Data);
            b.Show();
            this.Hide();
        }

        private void buttonTaBortUppgift_Click(object sender, EventArgs e)
        {
            ListBox.SelectedObjectCollection selectedItems = new ListBox.SelectedObjectCollection(listBoxUppgifter);
            selectedItems = listBoxUppgifter.SelectedItems;

            // Tar fram index för att ta bort student i listan
            int k = selectedItems.Count - 1;

            if (listBoxUppgifter.SelectedIndex != -1)
            {
                // Är for-loopen nödvändig?
                for (int i = selectedItems.Count - 1; i >= 0; i--)
                {
                    listBoxUppgifter.Items.Remove(selectedItems[i]);
                }

                // Tar bort student från listan
                Data.UppgiftsLista.RemoveAt(k);
            }
            else
                MessageBox.Show("Invalid. There is nothing to remove", "Error!", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }

        private void buttonTillbaka_Click(object sender, EventArgs e)
        {
            Main main = new Main(Data);
            main.Show();
            this.Hide();
        }

        private void RegistreraUppgift_Load(object sender, EventArgs e)
        {

        }
    }
}
