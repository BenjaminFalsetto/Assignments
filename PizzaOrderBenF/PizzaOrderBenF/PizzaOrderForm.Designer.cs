namespace PizzaOrderBenF
{
    partial class frmPizzaOrder
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
            this.lblHeader = new System.Windows.Forms.Label();
            this.mnuOptions = new System.Windows.Forms.MenuStrip();
            this.mniFile = new System.Windows.Forms.ToolStripMenuItem();
            this.provinceToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.languageToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.exitToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.ontarioToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.quebecToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.newBrunswickToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.manitobaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.novaScotiaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.newfoundlandToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.grbStep1 = new System.Windows.Forms.GroupBox();
            this.numericUpDown1 = new System.Windows.Forms.NumericUpDown();
            this.lblStep1Part1 = new System.Windows.Forms.Label();
            this.mnuOptions.SuspendLayout();
            this.grbStep1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown1)).BeginInit();
            this.SuspendLayout();
            // 
            // lblHeader
            // 
            this.lblHeader.AutoSize = true;
            this.lblHeader.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblHeader.Location = new System.Drawing.Point(27, 47);
            this.lblHeader.Name = "lblHeader";
            this.lblHeader.Size = new System.Drawing.Size(320, 25);
            this.lblHeader.TabIndex = 0;
            this.lblHeader.Text = "Generic pizzeria but with an app";
            // 
            // mnuOptions
            // 
            this.mnuOptions.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mniFile,
            this.provinceToolStripMenuItem,
            this.languageToolStripMenuItem});
            this.mnuOptions.Location = new System.Drawing.Point(0, 0);
            this.mnuOptions.Name = "mnuOptions";
            this.mnuOptions.Size = new System.Drawing.Size(941, 24);
            this.mnuOptions.TabIndex = 1;
            this.mnuOptions.Text = "menuStrip1";
            // 
            // mniFile
            // 
            this.mniFile.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.exitToolStripMenuItem});
            this.mniFile.Name = "mniFile";
            this.mniFile.Size = new System.Drawing.Size(37, 20);
            this.mniFile.Text = "File";
            // 
            // provinceToolStripMenuItem
            // 
            this.provinceToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.ontarioToolStripMenuItem,
            this.quebecToolStripMenuItem,
            this.newBrunswickToolStripMenuItem,
            this.manitobaToolStripMenuItem,
            this.novaScotiaToolStripMenuItem,
            this.newfoundlandToolStripMenuItem});
            this.provinceToolStripMenuItem.Name = "provinceToolStripMenuItem";
            this.provinceToolStripMenuItem.Size = new System.Drawing.Size(65, 20);
            this.provinceToolStripMenuItem.Text = "Province";
            // 
            // languageToolStripMenuItem
            // 
            this.languageToolStripMenuItem.Name = "languageToolStripMenuItem";
            this.languageToolStripMenuItem.Size = new System.Drawing.Size(71, 20);
            this.languageToolStripMenuItem.Text = "Language";
            // 
            // exitToolStripMenuItem
            // 
            this.exitToolStripMenuItem.Name = "exitToolStripMenuItem";
            this.exitToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.exitToolStripMenuItem.Text = "Exit";
            this.exitToolStripMenuItem.Click += new System.EventHandler(this.exitToolStripMenuItem_Click);
            // 
            // ontarioToolStripMenuItem
            // 
            this.ontarioToolStripMenuItem.Name = "ontarioToolStripMenuItem";
            this.ontarioToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.ontarioToolStripMenuItem.Text = "Ontario";
            // 
            // quebecToolStripMenuItem
            // 
            this.quebecToolStripMenuItem.Name = "quebecToolStripMenuItem";
            this.quebecToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.quebecToolStripMenuItem.Text = "Quebec";
            // 
            // newBrunswickToolStripMenuItem
            // 
            this.newBrunswickToolStripMenuItem.Name = "newBrunswickToolStripMenuItem";
            this.newBrunswickToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.newBrunswickToolStripMenuItem.Text = "New Brunswick";
            // 
            // manitobaToolStripMenuItem
            // 
            this.manitobaToolStripMenuItem.Name = "manitobaToolStripMenuItem";
            this.manitobaToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.manitobaToolStripMenuItem.Text = "Manitoba";
            // 
            // novaScotiaToolStripMenuItem
            // 
            this.novaScotiaToolStripMenuItem.Name = "novaScotiaToolStripMenuItem";
            this.novaScotiaToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.novaScotiaToolStripMenuItem.Text = "Nova Scotia";
            // 
            // newfoundlandToolStripMenuItem
            // 
            this.newfoundlandToolStripMenuItem.Name = "newfoundlandToolStripMenuItem";
            this.newfoundlandToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.newfoundlandToolStripMenuItem.Text = "Newfoundland";
            // 
            // grbStep1
            // 
            this.grbStep1.Controls.Add(this.lblStep1Part1);
            this.grbStep1.Controls.Add(this.numericUpDown1);
            this.grbStep1.Location = new System.Drawing.Point(32, 114);
            this.grbStep1.Name = "grbStep1";
            this.grbStep1.Size = new System.Drawing.Size(212, 154);
            this.grbStep1.TabIndex = 2;
            this.grbStep1.TabStop = false;
            this.grbStep1.Text = "Step 1";
            // 
            // numericUpDown1
            // 
            this.numericUpDown1.Location = new System.Drawing.Point(10, 36);
            this.numericUpDown1.Maximum = new decimal(new int[] {
            10,
            0,
            0,
            0});
            this.numericUpDown1.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.numericUpDown1.Name = "numericUpDown1";
            this.numericUpDown1.Size = new System.Drawing.Size(120, 20);
            this.numericUpDown1.TabIndex = 0;
            this.numericUpDown1.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // lblStep1Part1
            // 
            this.lblStep1Part1.AutoSize = true;
            this.lblStep1Part1.Location = new System.Drawing.Point(7, 20);
            this.lblStep1Part1.Name = "lblStep1Part1";
            this.lblStep1Part1.Size = new System.Drawing.Size(204, 13);
            this.lblStep1Part1.TabIndex = 1;
            this.lblStep1Part1.Text = "How many pizzas would you like to order?";
            // 
            // frmPizzaOrder
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(941, 497);
            this.Controls.Add(this.grbStep1);
            this.Controls.Add(this.lblHeader);
            this.Controls.Add(this.mnuOptions);
            this.MainMenuStrip = this.mnuOptions;
            this.Name = "frmPizzaOrder";
            this.Text = "Generic Pizza Place";
            this.mnuOptions.ResumeLayout(false);
            this.mnuOptions.PerformLayout();
            this.grbStep1.ResumeLayout(false);
            this.grbStep1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblHeader;
        private System.Windows.Forms.MenuStrip mnuOptions;
        private System.Windows.Forms.ToolStripMenuItem mniFile;
        private System.Windows.Forms.ToolStripMenuItem provinceToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem languageToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem exitToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem ontarioToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem quebecToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem newBrunswickToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem manitobaToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem novaScotiaToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem newfoundlandToolStripMenuItem;
        private System.Windows.Forms.GroupBox grbStep1;
        private System.Windows.Forms.Label lblStep1Part1;
        private System.Windows.Forms.NumericUpDown numericUpDown1;
    }
}

