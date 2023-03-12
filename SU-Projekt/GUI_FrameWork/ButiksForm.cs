using BusinessEntities_FrameWork.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GUI_FrameWork
{
    public partial class ButiksForm : Form
    {

        public Anställd Anställd { get; set; }
        public MarknadsChef MarknadsChef { get; set; }

        public ButiksForm(Anställd a, MarknadsChef mc)
        {
            InitializeComponent();
            Anställd = a;
            MarknadsChef = mc;
            
        }
        

        private void butikSkidskola1_Load(object sender, EventArgs e)
        {

        }

        private void tabPage1_Click(object sender, EventArgs e)
        {

        }

        private void butikÅterlämning1_Load(object sender, EventArgs e)
        {
            
        }
    }
}
