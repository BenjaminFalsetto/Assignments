using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PizzaOrderBenF
{
    public partial class frmPizzaOrder : Form
    {
        public frmPizzaOrder()
        {
            InitializeComponent();

            //declare variables and constants
            const double PROV_TAX_ON = 1.13, PROV_TAX_QC = 1.14975, PROV_TAX_NB = 1.15;
            const double PROV_TAX_NS = 1.15, PROV_TAX_NL = 15, PROV_TAX_MB = 13, PROV_TAX = 0;
            int numPizzas; 
            double size;
        }

        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //close the form when clicked
            this.Close();
        }

        private void btnNext1_Click(object sender, EventArgs e)
        {

        }
    }
}
