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
        const double PROV_TAX_ON = 0.13, PROV_TAX_QC = 0.14975, PROV_TAX_NB = 0.15;
        const double PROV_TAX_NS = 0.15, PROV_TAX_NL = 0.15, PROV_TAX_MB = 0.13;
        double regPizzaCost, provTax, toppingsPrice, pizzaSizeCost, numPizzas, subTotal, total, tax;

        

        private void radS3Reg_CheckedChanged(object sender, EventArgs e)
        {
            grbS3P2Reg.Enabled = true;
            grbS3P1Custom.Enabled = false;
            radS3P1Cheese.Checked = false;
            radS3P1Combination.Checked = false;
            radS3P1MeatLovers.Checked = false;
            radS3P1Hawaiian.Checked = false;
            radS3P1Vegetarian.Checked = false;
        }

        private void radS3Custom_CheckedChanged(object sender, EventArgs e)
        { 
            grbS3P1Custom.Enabled = true;
            grbS3P2Reg.Enabled = false;
            chkS3P2NoCheese.Checked = false;
            chkS3P2Pepperoni.Checked = false;
            chkS3P2GreenPepper.Checked = false;
            chkS3P2Pepper.Checked = false;
            chkS3P2Anchovies.Checked = false;
            chkS3P2Mushrooms.Checked = false;
            chkS3P2Olives.Checked = false;
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
            }
            else if (radS2SizeXL.Checked == true)
            {
                pizzaSizeCost = 12.99;
                grbStep2.Enabled = false;
                grbStep3.Enabled = true;
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
                //do nothing
            }
            else if (radS3Reg.Checked == true)
            {
                //do nothing
            }
            else
            {
                MessageBox.Show("Please enter your order type");
            }
            //get toppings and price
            if (chkS3P2NoCheese.Checked == true)
            {
                toppingsPrice = toppingsPrice + 1;
                grbStep3.Enabled = false;
                regPizzaCost = 0;
            }
            else if (chkS3P2Pepperoni.Checked == true)
            {
                toppingsPrice = toppingsPrice = 0.5;
                grbStep3.Enabled = false;
                regPizzaCost = 0;
            }
            else if (chkS3P2GreenPepper.Checked == true)
            {
                toppingsPrice = toppingsPrice + 0.5;
                grbStep3.Enabled = false;
                regPizzaCost = 0;
            }
            else if (chkS3P2Pepper.Checked == true)
            {
                toppingsPrice = toppingsPrice + 0.5;
                grbStep3.Enabled = false;
                regPizzaCost = 0;
            }
            else if (chkS3P2Anchovies.Checked == true)
            {
                toppingsPrice = toppingsPrice + 0.5;
                grbStep3.Enabled = false;
                regPizzaCost = 0;
            }
            else if (chkS3P2Mushrooms.Checked == true)
            {
                toppingsPrice = toppingsPrice + 0.5;
                grbStep3.Enabled = false;
                regPizzaCost = 0;
            }
            else if (chkS3P2Olives.Checked == true)
            {
                toppingsPrice = toppingsPrice + 0.5;
                grbStep3.Enabled = false;
                regPizzaCost = 0;
            }

            // get the regular pizza cost
            if (radS3P1Cheese.Checked == true)
            {
                regPizzaCost = 0;
                toppingsPrice = 0;
            }
            else if (radS3P1Combination.Checked == true)
            {
                regPizzaCost = 1.5;
                toppingsPrice = 0;
            }
            else if (radS3P1MeatLovers.Checked == true)
            {
                regPizzaCost = 4;
                toppingsPrice = 0;
            }
            if (radS3P1Hawaiian.Checked == true)
            {
                regPizzaCost = 1;
                toppingsPrice = 0;
            }
            if (radS3P1Vegetarian.Checked == true)
            {
                regPizzaCost = 10;
                toppingsPrice = 0;
            }
            grbStep3.Enabled = false;
            btnFinished.Show();
        }
        private void btnFinished_Click(object sender, EventArgs e)
        {
            subTotal = numPizzas * (toppingsPrice + pizzaSizeCost + regPizzaCost);
            tax = provTax * subTotal;
            total = tax + subTotal;
            string[] lines = { "Thanks for ordering!", "Here is your receipt.", "Your subtotal is $" + (subTotal).ToString("#.##"), "Tax is $" + (tax).ToString("#.##"), "Your total is $" + (total).ToString("#.##"), };
            // WriteAllLines creates a file, writes a collection of strings to the file,
            // and then closes the file.  You do NOT need to call Flush() or Close().
            System.IO.File.WriteAllLines(@"PizzaOrderReceipt.txt", lines);
            System.Diagnostics.Process.Start("PizzaOrderReceipt.txt");
        }
    }
}
