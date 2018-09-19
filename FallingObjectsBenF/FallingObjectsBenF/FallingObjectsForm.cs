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
        }

        private void btnCalculate_Click(object sender, EventArgs e)
        {
            //declare local variables
            double time, height;

            //convert the string from the text box to a double
            time = double.Parse(txtEnterTime.Text);

            //calculate the height
            height = 100 - (0.5 * 9.81 * Math.Pow(time, 2));

        }
    }
}
