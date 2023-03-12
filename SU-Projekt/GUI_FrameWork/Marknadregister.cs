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
    public partial class Marknadregister : Form
    {
        public FacadeBusiness FacadeBusiness { get; set; }
        public MarknadsChef MarknadsChef { get; set; }
        public List<Bokning> Bokningar = new List<Bokning>();

        public string search;
        private object gridbindingSource;

        public Marknadregister(MarknadsChef mc)
        {
            MarknadsChef = mc;
            FacadeBusiness = new FacadeBusiness();
            InitializeComponent();
            UpdateBokningsregister();
            UpdateButiksregister();
            UpdateFakturaregister();
            UpdateprivatKundregister();
            UpdateföretagsKundregister();
            UpdateUthyrningsregister();
           
        }

        private void button10_Click(object sender, EventArgs e)
        {
            Marknadmeny mc = new Marknadmeny(MarknadsChef);
            this.Hide();
            mc.Show();
        }

        private void bokningsregistergrid_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            
        }

        private void butiksregistergrid_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
           
        }

        private void fakturaregistergrid_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            
        }

        private void kundregistergrid_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
 
        }

        private void uthyrningsregistergrid_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        public void UpdateBokningsregister()
        {
            bokningsregistergrid.DataSource = null;
            bokningsregistergrid.DataSource = FacadeBusiness.FacadeBokning.GetAllBokningar();
        }

        public void UpdateButiksregister()
        {
            butiksregistergrid.DataSource = null;
            butiksregistergrid.DataSource = FacadeBusiness.FacadeUtrustning.GetAllProdukter();
        }

        public void UpdateFakturaregister()
        {
            fakturaregistergrid.DataSource = null;
            fakturaregistergrid.DataSource = FacadeBusiness.FacadeFaktura.GetAllFakturor();
        }

        public void UpdateprivatKundregister()
        {
            privatkundregistergrid.DataSource = null;
            privatkundregistergrid.DataSource = FacadeBusiness.FacadePrivatKund.GetAllPKunder();
            //kundregistergrid.DataSource = null;
            //kundregistergrid.DataSource = DisplayKund();

            //List<DisplayKund> Kunder = new List<DisplayKund>();
            //DisplayKund context = new DisplayKund();
            //object p = context.Connection.Open();
            //int counter = context.Orders.Count();

            //for (int i = 0; i < context.Orders.Count() - 1; i++)
            //{
            //    // AutoMapper library can be used alternatively to perform this mapping.
            //    Kunder item = new Kunder();
            //    item.PrivatKund.PrivatFörnamn = context.Orders.ToList()[i].OrderID;
            //    item.PrivatKund.PrivatEfternamn = context.Orders.ToList()[i].OrderDate;
                
            //    kundregistergrid.Add(item);
            //    item = null;
            //}

            //gridbindingSource.DataSource = kundregistergrid;
            //kundregistergrid.DataSource = null;
            //kundregistergrid.DataSource = gridbindingSource;
            //kundregistergrid.Refresh();
            //statusStrip1.Text = counter + " Item(s)";

            //context.Connection.Close();
            //context.Connection.Dispose();
            //context.Dispose();

        }

        public void UpdateföretagsKundregister()
        {
            företagskundregistergrid.DataSource = null;
            företagskundregistergrid.DataSource = FacadeBusiness.FacadeFöretagsKund.GetAllFöretagKunder();
        }

        public void UpdateUthyrningsregister()
        {
            uthyrningsregistergrid.DataSource = null;
            uthyrningsregistergrid.DataSource = FacadeBusiness.FacadeUthyrning.GetAllUtnyrningar();
        }

        private void textBox5_TextChanged(object sender, EventArgs e)
        {
            //search = textBox5.Text;
        }

        private void button3_Click(object sender, EventArgs e)
        {

        }

        private void button5_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Bokningsregister skrivs nu ut");
        }

        private void button6_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Butiksregister skrivs nu ut");
        }

        private void button7_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Fakturaregister skrivs nu ut");
        }

        private void button8_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Register för privatkund skrivs nu ut");
        }

        private void button11_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Register för företagskund skriv nu ut");
        }

        private void button9_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Uthyrningsregister skrivs nu ut");
        }
    }
}
