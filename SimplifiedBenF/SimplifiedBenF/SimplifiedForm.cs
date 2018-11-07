using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SimplifiedBenF
{
    public partial class frmSimplified : Form
    {
        //declare variables
        int playerTotal, dealerTotal, playerNextCard, dealerNextCard;
        Random randomCardGenerator;

        public frmSimplified()
        {
            InitializeComponent();
            randomCardGenerator = new Random();
        }

        //declare global functions
        private void NewGame()
        {
            btnNewGame.Visible = false;
            lstPlayerCards.Items.Clear();
        }

        private void PlayerHit()
        {
            playerNextCard = randomCardGenerator.Next(1, 10 + 1);
            lstPlayerCards.Items.Add(playerNextCard);
        }



        private void btnNewGame_Click(object sender, EventArgs e)
        {
            NewGame();
        }
    }
}
