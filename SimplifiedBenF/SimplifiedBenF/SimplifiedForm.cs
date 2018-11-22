/*
 * Created by: Benjamin Falsetto
 * Created on: 2018/11/05
 * Created for: ICS3U Programming
 * Assignment 6b - Simplified 21
 * This program allows a user to play a simplified version of blackjack
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

namespace SimplifiedBenF
{
    public partial class frmSimplified : Form
    {
        //declare variables
        int playerTotal, dealerTotal, playerNextCard, dealerNextCard;
        string returnToPlayer, returnToComputer;
        Random randomCardGenerator;

        public frmSimplified()
        {
            InitializeComponent();
            randomCardGenerator = new Random();
        }

        private void mniNewGame_Click(object sender, EventArgs e)
        {
            NewGame();
        }

        private void frmSimplified_Load(object sender, EventArgs e)
        {
            btnHit.Visible = false;
            btnStand.Visible = false;
            lblPlayerCards.Visible = false;
            lstPlayerCards.Visible = false;
            lstPlayerCards.Items.Clear();
            lblPlayerTotal.Visible = false;
        }

        //declare local functions
        private void mniExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        
        private void NewGame()
        {
            lstPlayerCards.Items.Clear();
            btnNewGame.Visible = false;
            btnHit.Visible = true;
            btnHit.Enabled = true;
            btnStand.Visible = true;
            btnStand.Enabled = true;
            lblPlayerCards.Visible = true;
            lstPlayerCards.Visible = true;
            lblPlayerTotal.Text = ("Player total");
            lblPlayerTotal.Visible = true;
            PlayerHit();
            PlayerHit();
            UpdatePlayerTotal();
            DealerHit();
            DealerHit();
        }

        private void btnHit_Click(object sender, EventArgs e)
        {
            PlayerHit();
            UpdatePlayerTotal();
        }

        private void PlayerHit()
        {
            playerNextCard = randomCardGenerator.Next(1, 10 + 1);
            lstPlayerCards.Items.Add(playerNextCard);
            playerTotal = playerTotal + playerNextCard;
            //CheckPlayerTotal();
        }

        private void btnStand_Click(object sender, EventArgs e)
        {
            btnHit.Enabled = false;
            btnStand.Enabled = false;
            CheckDealerHit();
            CheckPlayerTotal();
            CheckDealerTotal();
            DealerFinished();
        }

        private void btnNewGame_Click(object sender, EventArgs e)
        {
            NewGame();
        }

        private void UpdatePlayerTotal()
        {
            lblPlayerTotal.Text = ("Player total" + playerTotal);
        }

        private void CheckPlayerTotal()
        {
            if (playerTotal == 21)
            {
                MessageBox.Show("Blackjack!");
                btnHit.Visible = false;
                btnStand.Visible = false;
                lstPlayerCards.Visible = false;
                lblPlayerCards.Visible = false;
                lblPlayerTotal.Visible = false;
                lstPlayerCards.Items.Clear();
                playerTotal = 0;
                dealerTotal = 0;
                btnNewGame.Visible = true;
            }
            else if (playerTotal > 21)
            {
                PlayerBust();
            }
        }
        private void PlayerBust()
        {
            MessageBox.Show("Player Bust");
            btnHit.Visible = false;
            btnStand.Visible = false;
            lstPlayerCards.Visible = false;
            lblPlayerCards.Visible = false;
            lblPlayerTotal.Visible = false;
            lstPlayerCards.Items.Clear();
            playerTotal = 0;
            dealerTotal = 0;
            btnNewGame.Visible = true;
        }

        private void CheckDealerHit()
        {
            if (dealerTotal <= 16)
            {
                DealerHit();
            }
            else
            {
                DealerFinished();
            }
        }

        private void DealerHit()
        {
            dealerNextCard = randomCardGenerator.Next(1, 10 + 1);
            dealerTotal = dealerTotal + dealerNextCard;
            //CheckDealerTotal();
            //CheckDealerHit();
        }
        
        private void DealerBust()
        {
            MessageBox.Show("Dealer Bust");
            btnHit.Visible = false;
            btnStand.Visible = false;
            lstPlayerCards.Visible = false;
            lblPlayerCards.Visible = false;
            lblPlayerTotal.Visible = false;
            lstPlayerCards.Items.Clear();
            playerTotal = 0;
            dealerTotal = 0;
            btnNewGame.Visible = true;
        }
        private void CheckDealerTotal()
        {
            if (dealerTotal > 21)
            {
                DealerBust();
            }
            else
            {
                CheckDealerHit();
            }
        }

        private void DealerFinished()
        {
            if (playerTotal > dealerTotal)
            {
                MessageBox.Show("Player wins");
                btnHit.Visible = false;
                btnStand.Visible = false;
                lstPlayerCards.Visible = false;
                lblPlayerCards.Visible = false;
                lblPlayerTotal.Visible = false;
                lstPlayerCards.Items.Clear();
                playerTotal = 0;
                dealerTotal = 0;
                btnNewGame.Visible = true;
            }
            else if (dealerTotal > playerTotal)
            {
                MessageBox.Show("Dealer wins");
                btnHit.Visible = false;
                btnStand.Visible = false;
                lstPlayerCards.Visible = false;
                lblPlayerCards.Visible = false;
                lblPlayerTotal.Visible = false;
                lstPlayerCards.Items.Clear();
                playerTotal = 0;
                dealerTotal = 0;
                btnNewGame.Visible = true;
            }
        }
    }
}