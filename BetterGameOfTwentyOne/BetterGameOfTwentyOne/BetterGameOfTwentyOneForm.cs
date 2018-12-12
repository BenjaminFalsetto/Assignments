using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BetterGameOfTwentyOne
{
    public partial class frmBetterGameOfTwentyOne : Form
    {
        //declare global variables
        int playerTotal = 0, dealerTotal;
        List<Image> listCardImages = new List<Image>();
        Random rndNumGen;

        public frmBetterGameOfTwentyOne()
        {
            InitializeComponent();

            rndNumGen = new Random();
        }

        private void btnStart_Click(object sender, EventArgs e)
        {
            //make all unnecessary items invisible/visible
            this.grbStart.Visible = false;
            this.grbPlayerControls.Visible = true;

            //deal 2 cards to the player
            playerTotal = DealCard(ref playerTotal, listCardImages);
            playerTotal = DealCard(ref playerTotal, listCardImages);

            //deal 2 cards to the dealer
            dealerTotal = DealCard(ref dealerTotal, listCardImages);
            dealerTotal = DealCard(ref dealerTotal, listCardImages);

            //loop through every index in the list and clear everything
            for (int index = 0; index > listCardImages.Count(); index++)
            {
                listCardImages.RemoveAt(index);
            }

            //populate the list with each card
            listCardImages.Add(Properties.Resources._2C);
            listCardImages.Add(Properties.Resources._2D);
            listCardImages.Add(Properties.Resources._2H);
            listCardImages.Add(Properties.Resources._2S);
            listCardImages.Add(Properties.Resources._3C);
            listCardImages.Add(Properties.Resources._3D);
            listCardImages.Add(Properties.Resources._3H);
            listCardImages.Add(Properties.Resources._3S);
            listCardImages.Add(Properties.Resources._4C);
            listCardImages.Add(Properties.Resources._4D);
            listCardImages.Add(Properties.Resources._4H);
            listCardImages.Add(Properties.Resources._4S);
            listCardImages.Add(Properties.Resources._5C);
            listCardImages.Add(Properties.Resources._5D);
            listCardImages.Add(Properties.Resources._5H);
            listCardImages.Add(Properties.Resources._5S);
            listCardImages.Add(Properties.Resources._6C);
            listCardImages.Add(Properties.Resources._6D);
            listCardImages.Add(Properties.Resources._6H);
            listCardImages.Add(Properties.Resources._6S);
            listCardImages.Add(Properties.Resources._7C);
            listCardImages.Add(Properties.Resources._7D);
            listCardImages.Add(Properties.Resources._7H);
            listCardImages.Add(Properties.Resources._7S);
            listCardImages.Add(Properties.Resources._8C);
            listCardImages.Add(Properties.Resources._8D);
            listCardImages.Add(Properties.Resources._8H);
            listCardImages.Add(Properties.Resources._8S);
            listCardImages.Add(Properties.Resources._9C);
            listCardImages.Add(Properties.Resources._9D);
            listCardImages.Add(Properties.Resources._9H);
            listCardImages.Add(Properties.Resources._9S);
            listCardImages.Add(Properties.Resources._10C);
            listCardImages.Add(Properties.Resources._10D);
            listCardImages.Add(Properties.Resources._10H);
            listCardImages.Add(Properties.Resources._10S);
            listCardImages.Add(Properties.Resources.AC);
            listCardImages.Add(Properties.Resources.AD);
            listCardImages.Add(Properties.Resources.AH);
            listCardImages.Add(Properties.Resources.AS);
            listCardImages.Add(Properties.Resources.JC);
            listCardImages.Add(Properties.Resources.JD);
            listCardImages.Add(Properties.Resources.JH);
            listCardImages.Add(Properties.Resources.JS);
            listCardImages.Add(Properties.Resources.KC);
            listCardImages.Add(Properties.Resources.KD);
            listCardImages.Add(Properties.Resources.KH);
            listCardImages.Add(Properties.Resources.KS);
            listCardImages.Add(Properties.Resources.QC);
            listCardImages.Add(Properties.Resources.QD);
            Console.WriteLine("There are " + (listCardImages.Count() + 1) + " cards in the deck");

            //check to see if the deck has been properly populated
            if (listCardImages.Count() + 1 == 51)
            {
                MessageBox.Show("The deck has been populated correctly", "Deck Population Dialog");
            }
            else
            {
                MessageBox.Show("ERROR. The deck has been improperly populated. Attempting to re-populate.", "Deck Population Error");
            }
        }

        private int DealCard(ref int total, List<Image> listCardImages)
        {
            Console.WriteLine("There are " + listCardImages.Count() + " cards in the deck");
            //declare local variables
            int index, currentTotal = 0;

            //generate a random number between 0 and the length of the list
            index = rndNumGen.Next(0, listCardImages.Count() + 1);
            Console.WriteLine(index);

            //take the random number and get the card from the index
            //corresponding with the random number generated. Then
            //send the image to the correct picture box
            picCard1.Image = listCardImages[index];

            return currentTotal;
        }
    }
}
