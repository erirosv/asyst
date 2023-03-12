using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using BusinessLayer_FrameWork;
using BusinessEntities_FrameWork.Models;
using System.Drawing.Text;

namespace GUI_FrameWork
{
    public partial class ButikÅterlämning : UserControl
    {
        public string search;
        public string uthyrning;

        List<PrivatKund> PrivatKunds = new List<PrivatKund>();

        public FacadeBusiness FacadeBusiness { get; set; }
        public PrivatKund PrivatKund { get; set; }

        public ButikÅterlämning()
        {
            FacadeBusiness = new FacadeBusiness();
            InitializeComponent();
        }

        public void UpdateDataGrid()
        {
            dataGridViewÅterlämning.DataSource = null;
            dataGridViewÅterlämning.DataSource = FacadeBusiness.FacadeUthyrning.GetAllUtnyrningar();
        }

        private void textBoxSökNamn_TextChanged(object sender, EventArgs e)
        {
            search = textBoxSökNamn.Text;
        }

        private void buttonSökNamn_Click(object sender, EventArgs e)
        {
            
            //var result = Context.PrivatKund.Where(data => search.Any(term => data.PrivatKund.Contains(Uthyrning) ||
            //                            search.Any(term => data.PrivatKund.Contains(Uthyrning));

            //if (search != null)
            //{
            //    PrivatKund.All(item => item. == "Uthyrning");
            //}

            //if (search != null)
            //{
            //    uthyrning = textBoxSökNamn.Text;
            //    UpdateDataGrid();

            //    FacadeBusiness.FacadeFöretagsKund.SearchFöretagsKund();
            //    FacadeBusiness.FacadePrivatKund.SearchPrivatKund();
            //}
            //else
            //    MessageBox.Show("Det finns ingen sökterm!");

            //if (search != null)
            //{
            //    PrivatKund = textBoxSökNamn.Text;

            //    if (PrivatKund.Uthyrning == true)
            //    {
            //        FacadeBusiness.FacadePrivatKund.GetAllPKunder();
            //    }
            //}
        }

        private void dataGridViewÅterlämning_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void btnÅterlämna_Click(object sender, EventArgs e)
        {
            //if (dataGridViewÅterlämning.CurrentRow != null)
            //{
            //    uthyrning = (Uthyrning)dataGridViewÅterlämning.CurrentRow.DataBoundItem;
            //    FacadeBusiness.FacadeUthyrning.UthyrningtillÅterlämnad(uthyrning);
            //}

            //dataGridViewÅterlämning.DataSource = null;
            //dataGridViewÅterlämning.DataSource = FacadeBusiness.FacadeUthyrning.GetAllUtnyrningar();
        }
    }
}
