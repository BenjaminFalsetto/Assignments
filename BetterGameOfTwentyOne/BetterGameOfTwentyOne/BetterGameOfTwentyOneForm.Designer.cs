namespace BetterGameOfTwentyOne
{
    partial class frmBetterGameOfTwentyOne
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
            this.lblStart = new System.Windows.Forms.Label();
            this.btnStart = new System.Windows.Forms.Button();
            this.btnHit = new System.Windows.Forms.Button();
            this.grbStart = new System.Windows.Forms.GroupBox();
            this.grbPlayerControls = new System.Windows.Forms.GroupBox();
            this.btnStand = new System.Windows.Forms.Button();
            this.picCard1 = new System.Windows.Forms.PictureBox();
            this.picCard2 = new System.Windows.Forms.PictureBox();
            this.picCard3 = new System.Windows.Forms.PictureBox();
            this.picCard4 = new System.Windows.Forms.PictureBox();
            this.grbStart.SuspendLayout();
            this.grbPlayerControls.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picCard1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picCard2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picCard3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picCard4)).BeginInit();
            this.SuspendLayout();
            // 
            // lblStart
            // 
            this.lblStart.AutoSize = true;
            this.lblStart.Location = new System.Drawing.Point(5, 16);
            this.lblStart.Name = "lblStart";
            this.lblStart.Size = new System.Drawing.Size(112, 26);
            this.lblStart.TabIndex = 0;
            this.lblStart.Text = "Click the button below\r\nto start a new game";
            // 
            // btnStart
            // 
            this.btnStart.Location = new System.Drawing.Point(24, 45);
            this.btnStart.Name = "btnStart";
            this.btnStart.Size = new System.Drawing.Size(75, 23);
            this.btnStart.TabIndex = 1;
            this.btnStart.Text = "Start";
            this.btnStart.UseVisualStyleBackColor = true;
            this.btnStart.Click += new System.EventHandler(this.btnStart_Click);
            // 
            // btnHit
            // 
            this.btnHit.Location = new System.Drawing.Point(5, 13);
            this.btnHit.Name = "btnHit";
            this.btnHit.Size = new System.Drawing.Size(75, 23);
            this.btnHit.TabIndex = 2;
            this.btnHit.Text = "Hit";
            this.btnHit.UseVisualStyleBackColor = true;
            // 
            // grbStart
            // 
            this.grbStart.Controls.Add(this.lblStart);
            this.grbStart.Controls.Add(this.btnStart);
            this.grbStart.Location = new System.Drawing.Point(12, 12);
            this.grbStart.Name = "grbStart";
            this.grbStart.Size = new System.Drawing.Size(122, 75);
            this.grbStart.TabIndex = 3;
            this.grbStart.TabStop = false;
            // 
            // grbPlayerControls
            // 
            this.grbPlayerControls.Controls.Add(this.btnStand);
            this.grbPlayerControls.Controls.Add(this.btnHit);
            this.grbPlayerControls.Location = new System.Drawing.Point(140, 12);
            this.grbPlayerControls.Name = "grbPlayerControls";
            this.grbPlayerControls.Size = new System.Drawing.Size(200, 49);
            this.grbPlayerControls.TabIndex = 4;
            this.grbPlayerControls.TabStop = false;
            // 
            // btnStand
            // 
            this.btnStand.Location = new System.Drawing.Point(119, 13);
            this.btnStand.Name = "btnStand";
            this.btnStand.Size = new System.Drawing.Size(75, 23);
            this.btnStand.TabIndex = 3;
            this.btnStand.Text = "Stand";
            this.btnStand.UseVisualStyleBackColor = true;
            // 
            // picCard1
            // 
            this.picCard1.Location = new System.Drawing.Point(12, 134);
            this.picCard1.Name = "picCard1";
            this.picCard1.Size = new System.Drawing.Size(100, 141);
            this.picCard1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.picCard1.TabIndex = 5;
            this.picCard1.TabStop = false;
            // 
            // picCard2
            // 
            this.picCard2.Location = new System.Drawing.Point(118, 134);
            this.picCard2.Name = "picCard2";
            this.picCard2.Size = new System.Drawing.Size(100, 141);
            this.picCard2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.picCard2.TabIndex = 6;
            this.picCard2.TabStop = false;
            // 
            // picCard3
            // 
            this.picCard3.Location = new System.Drawing.Point(224, 134);
            this.picCard3.Name = "picCard3";
            this.picCard3.Size = new System.Drawing.Size(100, 141);
            this.picCard3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.picCard3.TabIndex = 7;
            this.picCard3.TabStop = false;
            // 
            // picCard4
            // 
            this.picCard4.Location = new System.Drawing.Point(330, 134);
            this.picCard4.Name = "picCard4";
            this.picCard4.Size = new System.Drawing.Size(100, 141);
            this.picCard4.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.picCard4.TabIndex = 8;
            this.picCard4.TabStop = false;
            // 
            // frmBetterGameOfTwentyOne
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(440, 287);
            this.Controls.Add(this.picCard4);
            this.Controls.Add(this.picCard3);
            this.Controls.Add(this.picCard2);
            this.Controls.Add(this.picCard1);
            this.Controls.Add(this.grbPlayerControls);
            this.Controls.Add(this.grbStart);
            this.Name = "frmBetterGameOfTwentyOne";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Better Game Of Twenty One Benjamin Falsetto";
            this.grbStart.ResumeLayout(false);
            this.grbStart.PerformLayout();
            this.grbPlayerControls.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.picCard1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picCard2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picCard3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picCard4)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label lblStart;
        private System.Windows.Forms.Button btnStart;
        private System.Windows.Forms.Button btnHit;
        private System.Windows.Forms.GroupBox grbStart;
        private System.Windows.Forms.GroupBox grbPlayerControls;
        private System.Windows.Forms.Button btnStand;
        private System.Windows.Forms.PictureBox picCard1;
        private System.Windows.Forms.PictureBox picCard2;
        private System.Windows.Forms.PictureBox picCard3;
        private System.Windows.Forms.PictureBox picCard4;
    }
}

