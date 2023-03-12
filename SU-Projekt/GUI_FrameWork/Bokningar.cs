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
using System.IO;
using iTextSharp.text.pdf;
using iTextSharp.text;
using System.Data.SqlClient;

namespace GUI_FrameWork
{
    public partial class Bokningar : UserControl
    {
        private string _search;

        public Anställd Anställd { get; set; }
        public FacadeBusiness FacadeBusiness { get; set; }

        public string Search
        {
            get { return _search; }
            set { _search = value; }
        }

        public Bokningar()
        {
            InitializeComponent();

            FacadeBusiness = new FacadeBusiness();
        }

        private void UpdateGridViewBokning()
        {
            gvBokningar.DataSource = null;
            gvBokningar.DataSource = FacadeBusiness.FacadeBokning.GetAllBokningar();
            gvBokningar.AutoSize = false;
            HideColums();
        }

        private void HideColums()
        {
            gvBokningar.Columns["BokningsID"].Visible = false;
        }

        private void btnsökb_Click(object sender, EventArgs e)
        {
            if (Search != null)
            {
                if (FacadeBusiness.FacadeBokning.SearchBokning(Search).ToList() != null)
                {
                    gvBokningar.DataSource = null;
                    gvBokningar.DataSource = FacadeBusiness.FacadeBokning.SearchBokning(Search).ToList();
                }
                else
                    UpdateGridViewBokning();
            }
            else
                MessageBox.Show("Det finns ingen sökterm");
        }

        private void gvBokningar_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void btnskrivutb_Click(object sender, EventArgs e)
        {
            if (gvBokningar.Rows.Count > 0)
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
                            PdfPTable pdfTable = new PdfPTable(gvBokningar.Columns.Count);
                            pdfTable.DefaultCell.Padding = 3;
                            pdfTable.WidthPercentage = 100;
                            pdfTable.HorizontalAlignment = Element.ALIGN_LEFT;

                            foreach (DataGridViewColumn column in gvBokningar.Columns)
                            {
                                PdfPCell cell = new PdfPCell(new Phrase(column.HeaderText));
                                pdfTable.AddCell(cell);
                            }

                            foreach (DataGridViewRow row in gvBokningar.Rows)
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

        private void Bokningar_Load(object sender, EventArgs e)
        {
           var allabokningar =  FacadeBusiness.FacadeBokning.GetAllBokningar();
          var bokningsregister=  FacadeBusiness.FacadeBokningsregister.GetAllBokningar();

          
        }

        private void tbSökBokningar_TextChanged(object sender, EventArgs e)
        {

        }
    }
    }

