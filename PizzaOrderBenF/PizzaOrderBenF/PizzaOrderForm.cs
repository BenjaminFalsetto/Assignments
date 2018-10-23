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

        private void radS3Reg_CheckedChanged(object sender, EventArgs e)
        {
            grbS3P2Reg.Enabled = true;
            grbS3P1Custom.Enabled = false;
        }

        private void radS3Custom_CheckedChanged(object sender, EventArgs e)
        {
            /* if (radS3Custom.Checked == true)
             {
                 grbS3P1Custom.Enabled = true;
                 grbS3P1Custom.Enabled = false;
                 this.Refresh();
             }
             else
             {
                 grbS3P2Reg.Enabled = true;
                 grbS3P1Custom.Enabled = false;
                 this.Refresh();
             }*/
            grbS3P1Custom.Enabled = true;
            grbS3P2Reg.Enabled = false;
        }

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
            //check which province the user is in then set the province tax
            //disable this grb and enable the next
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
                //ask the user to input their province
                MessageBox.Show("Please state your province of residance");
            }
        }
        private void btnNext2_Click(object sender, EventArgs e)
        {
            //set numPizzas to however many pizzas the user wants
            numPizzas = (double)nudS2NumPizzas.Value;

            //check size and set price
            //disable this grb and enable the next
            if (radS2SizeL.Checked == true)
            {
                pizzaSizeCost = 9.99;
                grbStep2.Enabled = false;
                grbStep3.Enabled = true;
                grbS3P2Reg.Enabled = false;
                grbS3P1Custom.Enabled = false;
            }
            else if (radS2SizeXL.Checked == true)
            {
                pizzaSizeCost = 12.99;
                grbStep2.Enabled = false;
                grbStep3.Enabled = true;
                grbS3P2Reg.Enabled = false;
                grbS3P1Custom.Enabled = false;
            }
            else
            {
                MessageBox.Show("Please select a size");
            }
        }
        private void btnNext3_Click(object sender, EventArgs e)
        {
            //see which kind of order the user wants to make
            if (radS3Custom.Checked == true)
            {
                grbS3P1Custom.Enabled = true;
            }
            else if (radS3Reg.Checked == true)
            {
                grbS3P2Reg.Enabled = true;
                grbStep3.Enabled = false;
            }
            else
            {
                MessageBox.Show("Please enter your order type");
            }
        }
    }
}
