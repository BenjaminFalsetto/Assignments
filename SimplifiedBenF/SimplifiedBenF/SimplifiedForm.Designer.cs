namespace SimplifiedBenF
{
    partial class frmSimplified
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.btnNewGame = new System.Windows.Forms.Button();
            this.lstPlayerCards = new System.Windows.Forms.ListBox();
            this.lblPlayerCards = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btnNewGame
            // 
            this.btnNewGame.Location = new System.Drawing.Point(69, 55);
            this.btnNewGame.Name = "btnNewGame";
            this.btnNewGame.Size = new System.Drawing.Size(75, 23);
            this.btnNewGame.TabIndex = 0;
            this.btnNewGame.Text = "New Game";
            this.btnNewGame.UseVisualStyleBackColor = true;
            this.btnNewGame.Click += new System.EventHandler(this.btnNewGame_Click);
            // 
            // lstPlayerCards
            // 
            this.lstPlayerCards.FormattingEnabled = true;
            this.lstPlayerCards.Location = new System.Drawing.Point(114, 160);
            this.lstPlayerCards.Name = "lstPlayerCards";
            this.lstPlayerCards.Size = new System.Drawing.Size(120, 95);
            this.lstPlayerCards.TabIndex = 1;
            // 
            // lblPlayerCards
            // 
            this.lblPlayerCards.AutoSize = true;
            this.lblPlayerCards.Location = new System.Drawing.Point(114, 141);
            this.lblPlayerCards.Name = "lblPlayerCards";
            this.lblPlayerCards.Size = new System.Drawing.Size(66, 13);
            this.lblPlayerCards.TabIndex = 2;
            this.lblPlayerCards.Text = "Player Cards";
            // 
            // frmSimplified
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.lblPlayerCards);
            this.Controls.Add(this.lstPlayerCards);
            this.Controls.Add(this.btnNewGame);
            this.Name = "frmSimplified";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnNewGame;
        private System.Windows.Forms.ListBox lstPlayerCards;
        private System.Windows.Forms.Label lblPlayerCards;
    }
}

