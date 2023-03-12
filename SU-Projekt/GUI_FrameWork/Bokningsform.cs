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
    public partial class Bokningsform : Form
    {
        public Anställd Anställd { get; set; }
        public Bokningsform(Anställd a, MarknadsChef marknadsChef)
        {
            InitializeComponent();
            Anställd = a;
        }

        private void button4_Click(object sender, EventArgs e)
        {

        }

        private void bokningar1_Load(object sender, EventArgs e)
        {

        }

        private void btnBoka_Click(object sender, EventArgs e)
        {
            //lägg till så den skickas till prebokning, därefter går den till bokningar
        }

        private void btnskrivutb_Click(object sender, EventArgs e)
        {

        }
    }
}
