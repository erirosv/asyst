using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.Entity.ModelConfiguration.Configuration;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using BusinessEntities_FrameWork.Models;
using BusinessLayer_FrameWork;
using System.Data.SqlClient;
using Excel = Microsoft.Office.Interop.Excel;
using System.Reflection;
using System.IO;
using OfficeOpenXml;

namespace GUI_FrameWork
{
    public partial class Bestat : Form
    {
        public FacadeBusiness FacadeBusiness { get; set; }
        public MarknadsChef MarknadsChef { get; set; }

        public Bokning Bokning { get; set; }
        //public LogiBokning LogiBokning { get; set; }
        public Utrustning Utrustning { get; set; }
        public Uthyrning Uthyrning { get; set; }



        public Bestat(MarknadsChef mc)
        {
            FacadeBusiness = new FacadeBusiness();
            MarknadsChef = mc;
            InitializeComponent();
            UpdateGrid();
        }

        private void UpdateGrid()
        {
            dgBeStatic.DataSource = null;
            dgBeStatic.DataSource = FacadeBusiness.FacadeBokning.GetAllBokningar().ToList();
        }

     
        private void Bestat_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'suht2009DataSet.LogiBokning' table. You can move, or remove it, as needed.
            this.logiBokningTableAdapter.Fill(this.suht2009DataSet.LogiBokning);

        }

        // LogiAlternativ
        private void LogiAlternativComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            cblogialternativ.Items.Add("Typ I Lgh");
            cblogialternativ.Items.Add("Typ II Lgh");
            cblogialternativ.Items.Add("Konferens ");
            cblogialternativ.Items.Add("Camping");



        }

        // Den här används att exportera till excel: Funkar
        private void ExporteraTillExellbt_Click_1(object sender, EventArgs e)
        {
            #region Gamla kode

            //Excel.Application oXL;
            //Excel._Workbook oWB;
            //Excel._Worksheet oSheet;
            //Excel.Range oRng;

            //try
            //{
            //    //Startar excel och får objekt från applikationen. 

            //    oXL = new Excel.Application();
            //    oXL.Visible = true;

            //    //får en ny arbetsbook. 
            //    oWB = (Excel._Workbook)(oXL.Workbooks.Add(Missing.Value));
            //    oSheet = (Excel._Worksheet)oWB.ActiveSheet;

            //    //Lägger till tabellrubriker cell för cell.
            //    oSheet.Cells[1, 1] = "Logi Typ";
            //    oSheet.Cells[1, 2] = "Säsong";
            //    oSheet.Cells[1, 3] = "Vecka";
            //    oSheet.Cells[1, 4] = "Månad";
            //    oSheet.Cells[1, 5] = "Lägenhetstyp";
            //    oSheet.Cells[1, 6] = "Camping";
            //    oSheet.Cells[1, 7] = "Konferens";



            //    // Alla & bokade

            //    //Format A1:D1 som fetstil, vertikal inriktning = mitten
            //    oSheet.get_Range("A1", "G1").Font.Bold = true;
            //    oSheet.get_Range("A1", "G1").VerticalAlignment =
            //    Excel.XlVAlign.xlVAlignCenter;

            //    //Skapar en array för att få flera värden på en gång. 

            //    string[,] saNames = new string[53, 12];

              

            //    //Fyller cellerna A2:B6 med värden från vektorerna
            //    //Fill A2:B6 with an array of values (First and Last Names).
            //    oSheet.get_Range("A2", "B6").Value2 = (saNames);
            //    oRng = oSheet.get_Range("B2", "B7");


            //    //Fill C2:C6 with a relative formula (=A2 & " " & B2).
            //    oRng = oSheet.get_Range("C2", "C6");
            //    oRng.Formula = "=A2 & \" \" & B2";

            //    ////Fill D2:D6 with a formula(=RAND()*100000) and apply format.
            //    //oRng = oSheet.get_Range("D2", "D6");
            //    //oRng.Formula = "=RAND()*100000";
            //    //oRng.NumberFormat = "$0.00";

            //    //AutoFit columns A:D.
            //    oRng = oSheet.get_Range("A1", "D1");
            //    oRng.EntireColumn.AutoFit();

            //    //Ser till att excel är synligt och ger användaren kontroll av excels livsid. 
            //    oXL.Visible = true;
            //    oXL.UserControl = true;
            //}
            //catch (Exception theException)
            //{
            //    String errorMessage;
            //    errorMessage = "Error: ";
            //    errorMessage = String.Concat(errorMessage, theException.Message);
            //    errorMessage = String.Concat(errorMessage, " Line: ");
            //    errorMessage = String.Concat(errorMessage, theException.Source);

            //    MessageBox.Show(errorMessage, "Error");
            //}
            #endregion

            #region Nya kode

            //Microsoft.Office.Interop.Excel._Application app = new Microsoft.Office.Interop.Excel.Application();
            //Microsoft.Office.Interop.Excel._Workbook workbook = app.Workbooks.Add(Type.Missing);
            //Microsoft.Office.Interop.Excel._Worksheet
            //worksheet = null;
            //app.Visible = true;
            //worksheet = workbook.Sheets["Sheet1"];
            //worksheet = workbook.ActiveSheet;
            //worksheet.Name = "Exportera till Excel";
            //for (int i = 1; i < dgBeStatic.Columns.Count + 1; i++)
            //{
            //    worksheet.Cells[1, i] = dgBeStatic.Columns[i - 1].HeaderText;
            //}

            //for (int i = 0; i < dgBeStatic.Rows.Count - 1; i++)
            //{
            //    for (int j = 0; j < dgBeStatic.Columns.Count; j++)
            //    {
            //        worksheet.Cells[i + 2, j + 1] = dgBeStatic.Rows[i].Cells[j].Value.ToString();
            //    }

            //}

            //workbook.SaveAs("c:\\TestExcel.xls", Type.Missing, Type.Missing, Type.Missing, Type.Missing, Type.Missing, Microsoft.Office.Interop.Excel.XlSaveAsAccessMode.xlExclusive, Type.Missing, Type.Missing,

            //Type.Missing, Type.Missing);

            #endregion



        }



        // Returnera till Main
        private void bttillbaka_Click(object sender, EventArgs e)
        {
            Marknadmeny mm = new Marknadmeny(MarknadsChef);
            this.Hide();
            mm.Show();
        }

        private void comboBox2_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

     

        private void dgBeStatic_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            dgBeStatic.Columns["BokningsID"].Visible = false;
            dgBeStatic.Columns["Logi Artiklar"].Visible = false;
            dgBeStatic.Columns["Vecka"].Visible = false;
            dgBeStatic.Columns["Månad"].Visible = false;
            dgBeStatic.Columns["Säsong"].Visible = false;
            dgBeStatic.Columns["Lägenhet"].Visible = false;
            dgBeStatic.Columns["Camping"].Visible = false;
            dgBeStatic.Columns["Konferens"].Visible = false;


        }
    }
    }



        
    


   

