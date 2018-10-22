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
        //declare variables and constants
        const double PROV_TAX_ON = 1.13, PROV_TAX_QC = 1.14975, PROV_TAX_NB = 1.15;
        const double PROV_TAX_NS = 1.15, PROV_TAX_NL = 15, PROV_TAX_MB = 13;
        double size, provTax, toppingsPrice, pizzaSizeCost, numPizzas;

        public frmPizzaOrder()
        {
            InitializeComponent();
            grbStep2.Enabled = false;
            grbStep3.Enabled = false;
        }

        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //close the form when clicked
            this.Close();
        }

        private void btnNext1_Click(object sender, EventArgs e)
        {
            //disable the groupbox

            //check which province the user is in
            if (radOn.Checked == true)
            {
                provTax = PROV_TAX_ON;
                grbStep1.Enabled = false;
                grbStep2.Enabled = true;
            }
            else if (radQc.Checked == true)
            {
                provTax = PROV_TAX_QC;
                grbStep1.Enabled = false;
                grbStep2.Enabled = true;
            }
            else if (radNB.Checked == true)
            {
                provTax = PROV_TAX_NB;
                grbStep1.Enabled = false;
                grbStep2.Enabled = true;
            }
            else if (radNS.Checked == true)
            {
                provTax = PROV_TAX_NS;
                grbStep1.Enabled = false;
                grbStep2.Enabled = true;
            }
            else if (radNl.Checked == true)
            {
                provTax = PROV_TAX_NL;
                grbStep1.Enabled = false;
                grbStep2.Enabled = true;
            }
            else if (radMb.Checked == true)
            {
                provTax = PROV_TAX_MB;
                grbStep1.Enabled = false;
                grbStep2.Enabled = true;
            }
            else
            {
                MessageBox.Show("Please state your province of residance");
            }
        }
        private void btnNext2_Click(object sender, EventArgs e)
        {
            //numPizzas = nudS2NumPizzas.Value;

            if (radS2SizeL.Checked == true)
            {
                pizzaSizeCost = 9.99;
            }
            else if (radS2SizeXL.Checked == true)
            {
                pizzaSizeCost = 12.99;

            }
            else
            {
                MessageBox.Show("Please select a size");
            }
        }
    }
}
