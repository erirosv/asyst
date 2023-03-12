using Affärslager.controller;
using Affärslager.models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GUI_WinForm
{
    public partial class BokninngsApp : Form
    {
        int medlemmsnummer;
        string hittaSpecifikBokning;

        Bibliotek Bibliotek { get; set; }
        List<Bok> utvaldaBöcker = new List<Bok>();
        List<Bok> TillgängligaBöcker = new List<Bok>();

        public BokninngsApp(Bibliotek b)
        {
            InitializeComponent();
            this.WindowState = FormWindowState.Maximized;
            Bibliotek = b;

            TillgängligaBöcker = Bibliotek.TillgängligaBöcker();
            UpdateBokningsView();
        }

        private void UpdateBokningsView()
        {
            TillGängligaBöckerView.DataSource = null;
            UtvaldaBöckerView.DataSource = null;

            TillGängligaBöckerView.DataSource = TillgängligaBöcker;
            UtvaldaBöckerView.DataSource = utvaldaBöcker;

        }

        private void UpdateÅterlämningView()
        {
            BokningView.DataSource = null;
            BokningView.DataSource = Bibliotek.AllaBokningar();

            FakturaKontroll();
        }

        private void FakturaKontroll()
        {
            dataGridView4.DataSource = null;

            if (BokningView.CurrentRow != null)
            {
                Bokning b = ((Bokning)BokningView.CurrentRow.DataBoundItem);

                dataGridView4.DataSource = b.Böcker;

                if (b.Faktura != null)
                {
                    FakturaBox.Text = b.Faktura.ToString();
                }
                else
                {
                    FakturaBox.Text = "Ingen faktura existerar";
                }
            }
            else
            {
                FakturaBox.Text = "Ingen faktura existerar";
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            int bokningsnummer = Bibliotek.BokaBok(utvaldaBöcker, medlemmsnummer, dateTimePicker1.Value, dateTimePicker2.Value);

            if (bokningsnummer == -1)
            {
                MessageBox.Show("Någon av de valda böckerna är inte tillgänglig för utlåning", "Invalid");
            }
            else
            {
                MessageBox.Show($"Bokning genomförd. Bokningsnummer: { bokningsnummer}");
                UtvaldaBöckerView.DataSource = null;
                utvaldaBöcker.Clear();
            }

            UpdateÅterlämningView();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            string temp = textBox1.Text;
            if (!int.TryParse(temp, out medlemmsnummer))
            {

            }
            else
            {
                medlemmsnummer = int.Parse(textBox1.Text);
            }
            
        }

        private void TillGängligaBöckerView_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            Bok temp = (Bok)TillGängligaBöckerView.CurrentRow.DataBoundItem;

            utvaldaBöcker.Add(temp);
            TillgängligaBöcker.Remove(temp);

            UpdateBokningsView();
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {
            hittaSpecifikBokning = textBox2.Text;
        }

        private void button4_Click(object sender, EventArgs e)
        {
            Bokning b = null;

            // Kontrollera så att det är en integer
            if (int.TryParse(hittaSpecifikBokning, out int bokningsnummer))
            {
                b = Bibliotek.SpecifikBokning(bokningsnummer);
            }

            if (b == null)
            {
                MessageBox.Show("Bokningsnummret existerar inte");
            }
            else
            {
                BokningView.ClearSelection();

                for (int index = 0; index < BokningView.Rows.Count; index++)
                {
                    DataGridViewRow row = BokningView.Rows[index];

                    if ((Bokning)row.DataBoundItem == b)
                    {
                        BokningView.CurrentCell = BokningView.Rows[index].Cells[0];
                        break;
                    }
                }

                UpdateÅterlämningView();
            }
        }

        private void BokningView_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            UpdateÅterlämningView();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Bibliotek.UtlämningAvBok((Bokning)BokningView.CurrentRow.DataBoundItem);
            UpdateÅterlämningView();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Faktura f = Bibliotek.ÅterlämningAvBok(((Bokning)BokningView.CurrentRow.DataBoundItem).BokningsNummer);
            MessageBox.Show(f.ToString());

            utvaldaBöcker.Clear();

            UpdateÅterlämningView();
            UpdateBokningsView();

            TillGängligaBöckerView.DataSource = Bibliotek.TillgängligaBöcker();

        }

        private void btnVäljBok_Click(object sender, EventArgs e)
        {
            Bok temp = (Bok)TillGängligaBöckerView.CurrentRow.DataBoundItem;

            if (BokningView.SelectedRows != null)
            {
                utvaldaBöcker.Add(temp);
                TillgängligaBöcker.Remove(temp);

                UpdateBokningsView();
            }
        }

        private void button5_Click(object sender, EventArgs e)
        {
            Bibliotek.TaBortBokning(((Bokning)BokningView.CurrentRow.DataBoundItem).BokningsNummer);
            MessageBox.Show("Bokningen är borttagen");

            UpdateÅterlämningView();
            //UpdateBokningsView();

            TillGängligaBöckerView.DataSource = null;
            TillGängligaBöckerView.DataSource = Bibliotek.TillgängligaBöcker();
        }
    }
}
