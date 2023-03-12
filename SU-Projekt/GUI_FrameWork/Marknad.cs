using System;
using System.CodeDom;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using BusinessEntities_FrameWork.Models;
using BusinessLayer_FrameWork;
using BusinessLayer_FrameWork.Models;
//using ceTe.DynamicPDF;
using DataLayer_FrameWork.Context;
using DataLayer_FrameWork.UnitOfWork;
//using iTextSharp.text;
//using iTextSharp.text.pdf;

namespace GUI_FrameWork
{
    public partial class Marknad : Form
    {
        public string search;
        public string PreBokning;
        public string prebokning;
        public string AnställdEfternamn;

        public Bokning bk = new Bokning();

        public FacadeBusiness FacadeBusiness = new FacadeBusiness();

        public List<PreBokning> Prebokningar = new List<PreBokning>();

        public List<Bokning> Bokningar = new List<Bokning>();

        public PreBokning pre = new PreBokning();

        public PrivatKund pk { get; set; }

        public List<Anställd> AnställdaEfternamn = new List<Anställd>();

        public Anställd Anställda = new Anställd();

        public Faktura Faktura = new Faktura();
        public MarknadsChef MarknadsChef { get; set; }
        public Anställd Anställd { get; set; }

        public Marknad(MarknadsChef mc)
        {
            InitializeComponent();
            MarknadsChef = mc;
            PreBokning = prebokning;
            pk = new PrivatKund();
            gvpbokning.DataSource = FacadeBusiness.FacadePreBokning.GetAllPreBokning();
            gvfldata.DataSource = FacadeBusiness.FacadeFaktura.GetAllFakturaLogi();
            gvfdata.DataSource = FacadeBusiness.FacadeFaktura.GetAllFakturaShop();
            dvpersonaldata.DataSource = FacadeBusiness.FacadeAnställd.GetAllAnställd();

            FacadeBusiness = new FacadeBusiness();
            dateTimePicker1.Value = DateTime.Now;
            dateTimePicker2.Value = DateTime.Now;

            /*--- Test med att skicka med privatkund ---*/
            pk = new PrivatKund();
            /*--- Slut på test ---*/
          
            UpdatePersonal();
        }



        private void Button4_Click(object sender, EventArgs e)
        {
            if (gvfdata.CurrentRow != null)
            {
                Faktura = (Faktura)gvfdata.CurrentRow.DataBoundItem;
                FacadeBusiness.FacadeFaktura.FakturaShopTillUtskrift(Faktura);
            }
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {
            search = textBox2.Text;
            //Ta bort sökfunktionen i prebokningar
        }

        private void btnsökpb_Click(object sender, EventArgs e)
        {
            if (search != null)
            {
                PreBokning = textBox2.Text;
                UpdateDataGrid();

                FacadeBusiness.FacadePreBokning.SearchPreBokning(search);
            }
            else
                MessageBox.Show("Det finns ingen sökterm!");
        }

        private void UpdateDataGrid()
        {
            gvpbokning.DataSource = null;
            gvpbokning.DataSource = FacadeBusiness.FacadePreBokning.GetAllPreBokning();
            gvpbokning.AutoSize = true;
        }

        private void UpdateFakturaShop()
        {
            gvfdata.DataSource = null;
            gvfdata.DataSource = FacadeBusiness.FacadeFaktura.GetAllFakturaShop();
            gvfdata.AutoSize = true;
        }

        private void btnavböjb_Click(object sender, EventArgs e)
        {
            if (gvpbokning.CurrentRow != null)
            {
                pre = (PreBokning)gvpbokning.CurrentRow.DataBoundItem;
                FacadeBusiness.FacadePreBokning.RemovePreBokning(pre);
            }
            UpdateDataGrid();
        }

        private void btngodkändb_Click(object sender, EventArgs e)
        {
            if (gvpbokning.CurrentRow != null)
            {
               
                pre = (PreBokning)gvpbokning.CurrentRow.DataBoundItem;
                //pk = FacadeBusiness.FacadePreBokning.HittaKund(pre.BokningsID);
                pk = FacadeBusiness.FacadePreBokning.HittaPrivatKundTillPreBokning(pre);
                FacadeBusiness.FacadePreBokning.PreBokningTillBokning(bk, pre, pk.PrivatKundID);
            }

            gvpbokning.DataSource = null;
            gvpbokning.DataSource = FacadeBusiness.FacadePreBokning.GetAllPreBokning();

        }



        private void UpdateFakturaLogi()
        {
            gvfldata.DataSource = null;
            gvfldata.DataSource = FacadeBusiness.FacadeFaktura.GetAllFakturaLogi();
        }

        private void dateTimePicker1_ValueChanged(object sender, EventArgs e)
        {

        }

        private void button10_Click(object sender, EventArgs e)
        {
            search = dateTimePicker1.Value.ToString();

            if (dateTimePicker1 != null)
            {

            }
            UpdateFakturaLogi();
        }

        private void gvfldata_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            gvfldata.Columns["FakturaID"].Visible = false;
            gvfldata.Columns["Pris"].Visible = false;
            gvfldata.Columns["Faktureringsdatum"].Visible = false;
            gvfldata.Columns["Förfallodatum"].Visible = false;
        }

        private void button11_Click(object sender, EventArgs e)
        {
            search = dateTimePicker1.Value.ToString();
            UpdateFakturaShop();
        }

        private void btnskrivutf_Click(object sender, EventArgs e)
        {

        //    if (gvfldata.Rows.Count > 0)
        //    {
        //        SaveFileDialog sfd = new SaveFileDialog();
        //        sfd.Filter = "PDF (*.pdf)|*.pdf";
        //        sfd.FileName = "Output.pdf";
        //        bool fileError = false;
        //        if (sfd.ShowDialog() == DialogResult.OK)
        //        {
        //            if (File.Exists(sfd.FileName))
        //            {
        //                try
        //                {
        //                    File.Delete(sfd.FileName);
        //                }
        //                catch (IOException ex)
        //                {
        //                    fileError = true;
        //                    MessageBox.Show("Det var inte möjligt att spara ner datan." + ex.Message);
        //                }
        //            }
        //            if (!fileError)
        //            {
        //                try
        //                {
        //                    PdfPTable pdfTable = new PdfPTable(gvfldata.Columns.Count);
        //                    pdfTable.DefaultCell.Padding = 3;
        //                    pdfTable.WidthPercentage = 100;
        //                    pdfTable.HorizontalAlignment = Element.ALIGN_LEFT;

        //                    foreach (DataGridViewColumn column in gvfldata.Columns)
        //                    {
        //                        PdfPCell cell = new PdfPCell(new Phrase(column.HeaderText));
        //                        pdfTable.AddCell(cell);
        //                    }

        //                    foreach (DataGridViewRow row in gvfldata.Rows)
        //                    {
        //                        foreach (DataGridViewCell cell in row.Cells)
        //                        {
        //                            pdfTable.AddCell(cell.Value.ToString());
        //                        }
        //                    }

        //                    using (FileStream stream = new FileStream(sfd.FileName, FileMode.Create))
        //                    {
        //                        Document pdfDoc = new Document(PageSize.A4, 10f, 20f, 20f, 10f);
        //                        PdfWriter.GetInstance(pdfDoc, stream);
        //                        pdfDoc.Open();
        //                        pdfDoc.Add(pdfTable);
        //                        pdfDoc.Close();
        //                        stream.Close();
        //                    }

        //                    MessageBox.Show("Data exporterades!!!", "Info");
        //                }
        //                catch (Exception ex)
        //                {
        //                    MessageBox.Show("Error :" + ex.Message);
        //                }
        //            }
        //        }
        //    }
        //    else
        //    {
        //        MessageBox.Show("No Record To Export !!!", "Info");
        //    }
        }

        private void btnsökp_Click(object sender, EventArgs e)
        {
            if (Search != null)
            {
                if (FacadeBusiness.FacadeAnställd.SearchAnställdEfternamn(Search).ToList() != null)
                {
                    dvpersonaldata.DataSource = null;
                    dvpersonaldata.DataSource = FacadeBusiness.FacadeAnställd.SearchAnställdEfternamn(Search).ToList();
                }
                else
                    UpdatePersonal();
            }
            else
                MessageBox.Show("Det finns ingen sökterm!");        
        }

        public string Search
        {
            get { return search; }
            set { search = value; }
        }

        public void UpdatePersonal()
        {
            dvpersonaldata.DataSource = null;
            dvpersonaldata.DataSource = FacadeBusiness.FacadeAnställd.GetAllAnställd();
        }

        private void btntillbaka_Click(object sender, EventArgs e)
        {
            Marknadmeny mc = new Marknadmeny(MarknadsChef);
            this.Hide();
            mc.Show();
        }

        private void btntabortp_Click(object sender, EventArgs e)
        {
            if (dvpersonaldata.CurrentRow != null)
            {
                Anställda = (Anställd)dvpersonaldata.CurrentRow.DataBoundItem;
                FacadeBusiness.FacadeAnställd.RemovePersonal(Anställda);
            }
            UpdatePersonal();
        }

        private void button9_Click(object sender, EventArgs e)
        {

        }

        private void gvpbokning_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void dvpersonaldata_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            Search = textBox1.Text;
        }

        private void textBox2_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyValue == (char)Keys.Enter)
            {
                btnsökpb_Click(null, null);
            }
        }

        private void Marknad_Load(object sender, EventArgs e)
        {
            var allafakturor = FacadeBusiness.FacadeFaktura.GetAllFakturor();
            


        }
    }
}
