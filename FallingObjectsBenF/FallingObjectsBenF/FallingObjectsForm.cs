/*
 * Created by: Benjamin Falsetto
 * Created on: 2018/09/25
 * Created for: ICS3U Programming
 * Weekly Assignment #2
 * This program calculates the height an object is off
 * of the ground when given the time since object released.
*/

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
        }

        private void btnCalculate_Click(object sender, EventArgs e)
        {
            //declare local variables
            double time = Double.Parse(txtEnterTime.Text), height;

            //declare constant
            const double MAXTIME = 4.514;

            //textbox numerical error checking

            //looking to see if textbox is empty
            if (txtEnterTime.Text.Trim() == string.Empty)
            {
                //if the textbox is empty, display a message box on screen -
                //telling the user that the textbox is empty
                MessageBox.Show("Please enter something in the textbox");
            }

            //looking to see if the entered time exceeds the time that it takes for the -
            //object to hit the ground
            if (time > MAXTIME)
            {
                //if the time exceeds MAXTIME, display a message box on screen -
                //telling the user that the object has already hit the ground
                MessageBox.Show("The object has already hit the ground");
            }
            //checking to see if the time is outside certain parameters
            if (time <= 0 && time >= 4.514)
            {
                //if the time is outside certain parameters, tell the user to -
                //input a time value within the given parameters
                MessageBox.Show("Error. Please enter a number between 0 and 4.514");
            }
            //looking to see if the time is less than 0
            if (time < 0)
            {
                //if the time is less than 0, tell the user to enter a valid value
                MessageBox.Show("Error. Please enter a number between 0 and 4.514");
            }
            //check to see if the time is 0
            if (time == 0)
            {
                //if true, tell the user that the object hasn't been released yet
                MessageBox.Show("The object hasn't been released yet");
            }
            //checking to see if time is within certain parameters
            if (time >= 0.0000000001 && time <= 4.514)
            {
                //if true, display the answer label
                //otherwise it would display values that don't make sense
                this.lblAns.Show();
            }

                //convert the string from the textbox to a double
                time = Double.Parse(txtEnterTime.Text);
            
            //calculate the height
            height = 100 - (0.5 * 9.81 * Math.Pow(time, 2));

            //insert the answer into it's label and then show the variable
            this.lblAns.Text ="The object has fallen " + Convert.ToString(height) + " meters since you released it " + time + " seconds ago";

        }

        private void mniExit_Click(object sender, EventArgs e)
        {
            //if mniExit is clicked, exit the program
            this.Close();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void txtEnterTime_TextChanged(object sender, EventArgs e)
        {
            //textbox alphabetical error checking

            //checking to see if a letter was inputted
            if (System.Text.RegularExpressions.Regex.IsMatch(txtEnterTime.Text, "[^0-9]"))
            {
                //if a letter was inputted, tell the user that only numbers are accepted
                MessageBox.Show("Please enter only numbers.");
                
                //clear the textbox if a letter was inputted
                txtEnterTime.Text = txtEnterTime.Text.Remove(txtEnterTime.Text.Length - 1);
            }
        }
    }
}
