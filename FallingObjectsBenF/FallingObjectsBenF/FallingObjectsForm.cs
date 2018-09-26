using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FallingObjectsBenF
{
    public partial class frmFallingObjects : Form
    {
        public frmFallingObjects()
        {
            InitializeComponent();
            this.lblAns.Hide();
            this.lblError.Hide();
        }

        private void btnCalculate_Click(object sender, EventArgs e)
        {
            //declare local variables
            double time = 5.14, height;

            //declare constant
            const double MAXTIME = 4.514;

            if (txtEnterTime.Text.Trim() == string.Empty)
            {
                MessageBox.Show("Please enter something in the textbox");
            }
            /*else if (txtEnterTime < MAXTIME)
                //convert the string from the text box to a double
                time = Double.Parse(txtEnterTime.Text);

                //calculate the height
                height = 100 - (0.5 * 9.81 * Math.Pow(time, 2));

                //insert the answer into it's label
                this.lblAns.Text = Convert.ToString(height) + " meters";
            */
            if(time < 0)
                MessageBox.Show("The object hasn't been re")

            //convert the string from the text box to a double
            time = Double.Parse(txtEnterTime.Text);
            
            //calculate the height
            height = 100 - (0.5 * 9.81 * Math.Pow(time, 2));

            //insert the answer into it's label
            this.lblAns.Text = Convert.ToString(height) + " meters";
            this.lblAns.Show();
            
        }

        private void mniExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
    }
}
