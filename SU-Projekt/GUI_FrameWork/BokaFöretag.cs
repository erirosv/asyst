using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using BusinessEntities_FrameWork.Models;
using BusinessLayer_FrameWork;

namespace GUI_FrameWork
{
    public partial class BokaFöretag : UserControl
    {
        // Variabler
        private string _search;

        // Properties
        public Anställd Anställd { get; set; }
        public FacadeBusiness FacadeBusiness { get; set; }
        public List<PrivatKund> TestPrivat { get; set; }
        public MarknadsChef MarknadsChef { get; set; }


        public string Search
        {
            get { return _search; }
            set { _search = value; }
        }

        public BokaFöretag(MarknadsChef mc, Anställd a_s)
        {
            InitializeComponent();

            FacadeBusiness = new FacadeBusiness();
            MarknadsChef = mc;
            Anställd = a_s;
            UpdateFöretagKund();
            PreSetComboBox();
        }

        public BokaFöretag()
        {
        }

        private void UpdateFöretagKund()
        {
            gvFöretagKund.DataSource = null;
            gvFöretagKund.DataSource = FacadeBusiness.FacadeFöretagsKund.GetAllFöretagKunder();
            HideFöretagKundColums();
        }

        private void HideFöretagKundColums()
        {

        }

        private void PreSetComboBox()
        {
            comboBoxLägenhet.Items.Add("Liten");
            comboBoxLägenhet.Items.Add("Stor");
        }

        private void button4_Click(object sender, EventArgs e)
        {

        }

        private void btnläggtill_Click(object sender, EventArgs e)
        {

        }
    }
}
