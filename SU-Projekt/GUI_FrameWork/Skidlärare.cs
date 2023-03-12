using BusinessLayer_FrameWork;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;
using BusinessEntities_FrameWork.Models;
using BusinessLayer_FrameWork.Models;
using System.Data.SqlClient;
using iTextSharp.text.pdf;
using iTextSharp.text;

namespace GUI_FrameWork
{
    public partial class Skidlärare : Form
    {
        private string _grupplektionNamn;

        public string search;
        public FacadeBusiness FacadeBusiness { get; set; }
        public string GrupplektionNamn
        {
            get { return _grupplektionNamn; }
            set { _grupplektionNamn = value; }
        }

        public Anställd Anställd { get; set; }

        public Skidlärare(Anställd a)
        {
            InitializeComponent();
            FacadeBusiness = new FacadeBusiness();
            Anställd = a;

            UpdateGrid();
        }

        private void UpdateGrid()
        {
            gvskidlärare.DataSource = null;
            gvskidlärare.DataSource = FacadeBusiness.FacadeSkidlektion.GetAllSkidLektioner();
        }

        private void TextBox1_TextChanged(object sender, EventArgs e)
        {
            
        }

        private void Button1_Click(object sender, EventArgs e)
        {
            if (Tbsökgrupp.Text != null)
            {
                GrupplektionNamn = Tbsökgrupp.Text;
                //FacadeBusiness.FacadeSkidlektion
            }
            else
            {

            }
        }

        private void Gvskidlärare_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            gvskidlärare.Columns["GruppskidlektionsID"].Visible = false;
            gvskidlärare.Columns["Färg"].Visible = true;
            gvskidlärare.Columns["Antal deltagare"].Visible = true;
            gvskidlärare.Columns["Lärare"].Visible = true;
            gvskidlärare.Columns["Antal dagar"].Visible = true;
            gvskidlärare.Columns["LektionsTyp"].Visible = true;
        }

        private void btnsökgrupp_Click(object sender, EventArgs e)
        {
            search = Tbsökgrupp.Text;
            //UpdateGrid();
            gvskidlärare.DataSource = null;
            gvskidlärare.DataSource = FacadeBusiness.FacadeBokningSkidlektion.Gruppskidlektion(search);
        }

        private void btnLoggaUt_Click(object sender, EventArgs e)
        {
            frmLogin login = new frmLogin();
            this.Hide();
            login.Show();
        }

        private void Tbsökgrupp_TextChanged(object sender, EventArgs e)
        {
            search = Tbsökgrupp.Text;
        }

        private void btnväljlärare_Click(object sender, EventArgs e)
        {
            if (gvskidlärare.CurrentRow != null)
            {
               //GruppSkiSearch = (FacadeGruppskidlektion)gvskidlärare.CurrentRow.DataBoundItem;
            }

        }

        private void btnskrivutlärare_Click(object sender, EventArgs e)
        {
            if (true || gvskidlärare.Rows.Count > 0)
            {
                SaveFileDialog sfd = new SaveFileDialog();
                sfd.Filter = "PDF (*.pdf)|*.pdf";
                sfd.FileName = "Output.pdf";
                bool fileError = false;
                if (sfd.ShowDialog() == DialogResult.OK)
                {
                    if (File.Exists(sfd.FileName))
                    {
                        try
                        {
                            File.Delete(sfd.FileName);
                        }
                        catch (IOException ex)
                        {
                            fileError = true;
                            MessageBox.Show("Fanns inte möjlighet att spara ner datan" + ex.Message);
                        }
                    }
                    if (!fileError)
                    {
                        try
                        {
                            PdfPTable pdfTable = new PdfPTable(gvskidlärare.Columns.Count);
                            pdfTable.DefaultCell.Padding = 3;
                            pdfTable.WidthPercentage = 100;
                            pdfTable.HorizontalAlignment = Element.ALIGN_LEFT;

                            foreach (DataGridViewColumn column in gvskidlärare.Columns)
                            {
                                PdfPCell cell = new PdfPCell(new Phrase(column.HeaderText));
                                pdfTable.AddCell(cell);
                            }

                            foreach (DataGridViewRow row in gvskidlärare.Rows)
                            {
                                foreach (DataGridViewCell cell in row.Cells)
                                {
                                    pdfTable.AddCell(cell.Value.ToString());
                                }
                            }

                            using (FileStream stream = new FileStream(sfd.FileName, FileMode.Create))
                            {
                                Document pdfDoc = new Document(PageSize.A4, 10f, 20f, 20f, 10f);
                                PdfWriter.GetInstance(pdfDoc, stream);
                                pdfDoc.Open();
                                pdfDoc.Add(pdfTable);
                                pdfDoc.Close();
                                stream.Close();
                            }

                            MessageBox.Show("Data Exported Successfully !!!", "Info");
                        }
                        catch (Exception ex)
                        {
                            MessageBox.Show("Error :" + ex.Message);
                        }
                    }
                }
            }
            else
            {
                MessageBox.Show("No Record To Export !!!", "Info");
            }
        }

        private void Skidlärare_Load(object sender, EventArgs e)
        {
            gvskidlärare.DataSource = null;
            gvskidlärare.DataSource = FacadeBusiness.FacadeGruppskidlektion.GetAllGrupplektioner();
            
            
            //SqlConnection sqlCon;
            //string conString = null;
            //string sqlQuery = null;

            //conString = "Data source = sqlutb2-db.hb.se,56077; Database=suht2009; User ID=suht2009; Password=blax77; Initial Catalog = suht2009";
            //sqlCon = new SqlConnection(conString);
            //sqlCon.Open();
            //SqlDataAdapter dscmd = new SqlDataAdapter(sqlQuery, sqlCon);
            //DataTable dtData = new DataTable();
            //dscmd.Fill(dtData);
            //gvskidlärare.DataSource = dtData;
        }
    }
}
