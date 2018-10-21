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
            this.exitToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.languageToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.grbStep1 = new System.Windows.Forms.GroupBox();
            this.lblStep1Part1 = new System.Windows.Forms.Label();
            this.nudNumPizzas = new System.Windows.Forms.NumericUpDown();
            this.btnNext1 = new System.Windows.Forms.Button();
            this.radOn = new System.Windows.Forms.RadioButton();
            this.lblProvStep1 = new System.Windows.Forms.Label();
            this.radQb = new System.Windows.Forms.RadioButton();
            this.radNB = new System.Windows.Forms.RadioButton();
            this.radNS = new System.Windows.Forms.RadioButton();
            this.radNl = new System.Windows.Forms.RadioButton();
            this.radMb = new System.Windows.Forms.RadioButton();
            this.grbStep2 = new System.Windows.Forms.GroupBox();
            this.btnNext2 = new System.Windows.Forms.Button();
            this.lblChooseToppings = new System.Windows.Forms.Label();
            this.chkPepperoni = new System.Windows.Forms.CheckBox();
            this.chkNoCheese = new System.Windows.Forms.CheckBox();
            this.chkPepper = new System.Windows.Forms.CheckBox();
            this.chkMushrooms = new System.Windows.Forms.CheckBox();
            this.chkGreenPepper = new System.Windows.Forms.CheckBox();
            this.chkAnchovies = new System.Windows.Forms.CheckBox();
            this.chkOlives = new System.Windows.Forms.CheckBox();
            this.mniEng = new System.Windows.Forms.ToolStripMenuItem();
            this.mniFr = new System.Windows.Forms.ToolStripMenuItem();
            this.mniIt = new System.Windows.Forms.ToolStripMenuItem();
            this.mniSp = new System.Windows.Forms.ToolStripMenuItem();
            this.mniRu = new System.Windows.Forms.ToolStripMenuItem();
            this.lblOr2 = new System.Windows.Forms.Label();
            this.grbStep2P1 = new System.Windows.Forms.GroupBox();
            this.mnuOptions.SuspendLayout();
            this.grbStep1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nudNumPizzas)).BeginInit();
            this.grbStep2.SuspendLayout();
            this.SuspendLayout();
            // 
            // lblHeader
            // 
            this.lblHeader.AutoSize = true;
            this.lblHeader.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblHeader.Location = new System.Drawing.Point(332, 47);
            this.lblHeader.Name = "lblHeader";
            this.lblHeader.Size = new System.Drawing.Size(320, 25);
            this.lblHeader.TabIndex = 0;
            this.lblHeader.Text = "Generic pizzeria but with an app";
            // 
            // mnuOptions
            // 
            this.mnuOptions.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mniFile,
            this.languageToolStripMenuItem});
            this.mnuOptions.Location = new System.Drawing.Point(0, 0);
            this.mnuOptions.Name = "mnuOptions";
            this.mnuOptions.Size = new System.Drawing.Size(984, 24);
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
            // exitToolStripMenuItem
            // 
            this.exitToolStripMenuItem.Name = "exitToolStripMenuItem";
            this.exitToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.exitToolStripMenuItem.Text = "Exit";
            this.exitToolStripMenuItem.Click += new System.EventHandler(this.exitToolStripMenuItem_Click);
            // 
            // languageToolStripMenuItem
            // 
            this.languageToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mniEng,
            this.mniFr,
            this.mniIt,
            this.mniSp,
            this.mniRu});
            this.languageToolStripMenuItem.Name = "languageToolStripMenuItem";
            this.languageToolStripMenuItem.Size = new System.Drawing.Size(71, 20);
            this.languageToolStripMenuItem.Text = "Language";
            // 
            // grbStep1
            // 
            this.grbStep1.Controls.Add(this.radMb);
            this.grbStep1.Controls.Add(this.radNl);
            this.grbStep1.Controls.Add(this.radNS);
            this.grbStep1.Controls.Add(this.radNB);
            this.grbStep1.Controls.Add(this.radQb);
            this.grbStep1.Controls.Add(this.lblProvStep1);
            this.grbStep1.Controls.Add(this.radOn);
            this.grbStep1.Controls.Add(this.btnNext1);
            this.grbStep1.Location = new System.Drawing.Point(32, 114);
            this.grbStep1.Name = "grbStep1";
            this.grbStep1.Size = new System.Drawing.Size(212, 226);
            this.grbStep1.TabIndex = 2;
            this.grbStep1.TabStop = false;
            this.grbStep1.Text = "Step 1";
            // 
            // lblStep1Part1
            // 
            this.lblStep1Part1.AutoSize = true;
            this.lblStep1Part1.Location = new System.Drawing.Point(6, 16);
            this.lblStep1Part1.Name = "lblStep1Part1";
            this.lblStep1Part1.Size = new System.Drawing.Size(204, 13);
            this.lblStep1Part1.TabIndex = 1;
            this.lblStep1Part1.Text = "How many pizzas would you like to order?";
            // 
            // nudNumPizzas
            // 
            this.nudNumPizzas.Location = new System.Drawing.Point(9, 33);
            this.nudNumPizzas.Maximum = new decimal(new int[] {
            10,
            0,
            0,
            0});
            this.nudNumPizzas.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.nudNumPizzas.Name = "nudNumPizzas";
            this.nudNumPizzas.Size = new System.Drawing.Size(120, 20);
            this.nudNumPizzas.TabIndex = 0;
            this.nudNumPizzas.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // btnNext1
            // 
            this.btnNext1.Location = new System.Drawing.Point(69, 197);
            this.btnNext1.Name = "btnNext1";
            this.btnNext1.Size = new System.Drawing.Size(75, 23);
            this.btnNext1.TabIndex = 2;
            this.btnNext1.Text = "Next";
            this.btnNext1.UseVisualStyleBackColor = true;
            // 
            // radOn
            // 
            this.radOn.AutoSize = true;
            this.radOn.Location = new System.Drawing.Point(6, 33);
            this.radOn.Name = "radOn";
            this.radOn.Size = new System.Drawing.Size(59, 17);
            this.radOn.TabIndex = 3;
            this.radOn.TabStop = true;
            this.radOn.Text = "Ontario";
            this.radOn.UseVisualStyleBackColor = true;
            // 
            // lblProvStep1
            // 
            this.lblProvStep1.AutoSize = true;
            this.lblProvStep1.Location = new System.Drawing.Point(6, 16);
            this.lblProvStep1.Name = "lblProvStep1";
            this.lblProvStep1.Size = new System.Drawing.Size(153, 13);
            this.lblProvStep1.TabIndex = 3;
            this.lblProvStep1.Text = "Which province do you live in?";
            // 
            // radQb
            // 
            this.radQb.AutoSize = true;
            this.radQb.Location = new System.Drawing.Point(6, 56);
            this.radQb.Name = "radQb";
            this.radQb.Size = new System.Drawing.Size(63, 17);
            this.radQb.TabIndex = 4;
            this.radQb.TabStop = true;
            this.radQb.Text = "Quebec";
            this.radQb.UseVisualStyleBackColor = true;
            // 
            // radNB
            // 
            this.radNB.AutoSize = true;
            this.radNB.Location = new System.Drawing.Point(6, 79);
            this.radNB.Name = "radNB";
            this.radNB.Size = new System.Drawing.Size(99, 17);
            this.radNB.TabIndex = 5;
            this.radNB.TabStop = true;
            this.radNB.Text = "New Brunswick";
            this.radNB.UseVisualStyleBackColor = true;
            // 
            // radNS
            // 
            this.radNS.AutoSize = true;
            this.radNS.Location = new System.Drawing.Point(6, 102);
            this.radNS.Name = "radNS";
            this.radNS.Size = new System.Drawing.Size(84, 17);
            this.radNS.TabIndex = 6;
            this.radNS.TabStop = true;
            this.radNS.Text = "Nova Scotia";
            this.radNS.UseVisualStyleBackColor = true;
            // 
            // radNl
            // 
            this.radNl.AutoSize = true;
            this.radNl.Location = new System.Drawing.Point(6, 125);
            this.radNl.Name = "radNl";
            this.radNl.Size = new System.Drawing.Size(94, 17);
            this.radNl.TabIndex = 7;
            this.radNl.TabStop = true;
            this.radNl.Text = "Newfoundland";
            this.radNl.UseVisualStyleBackColor = true;
            // 
            // radMb
            // 
            this.radMb.AutoSize = true;
            this.radMb.Location = new System.Drawing.Point(6, 148);
            this.radMb.Name = "radMb";
            this.radMb.Size = new System.Drawing.Size(69, 17);
            this.radMb.TabIndex = 8;
            this.radMb.TabStop = true;
            this.radMb.Text = "Manitoba";
            this.radMb.UseVisualStyleBackColor = true;
            // 
            // grbStep2
            // 
            this.grbStep2.Controls.Add(this.lblOr2);
            this.grbStep2.Controls.Add(this.chkOlives);
            this.grbStep2.Controls.Add(this.chkAnchovies);
            this.grbStep2.Controls.Add(this.chkGreenPepper);
            this.grbStep2.Controls.Add(this.chkMushrooms);
            this.grbStep2.Controls.Add(this.chkPepper);
            this.grbStep2.Controls.Add(this.chkNoCheese);
            this.grbStep2.Controls.Add(this.chkPepperoni);
            this.grbStep2.Controls.Add(this.lblChooseToppings);
            this.grbStep2.Controls.Add(this.btnNext2);
            this.grbStep2.Controls.Add(this.lblStep1Part1);
            this.grbStep2.Controls.Add(this.nudNumPizzas);
            this.grbStep2.Location = new System.Drawing.Point(268, 114);
            this.grbStep2.Name = "grbStep2";
            this.grbStep2.Size = new System.Drawing.Size(278, 363);
            this.grbStep2.TabIndex = 3;
            this.grbStep2.TabStop = false;
            this.grbStep2.Text = "Step 2";
            // 
            // btnNext2
            // 
            this.btnNext2.Location = new System.Drawing.Point(86, 125);
            this.btnNext2.Name = "btnNext2";
            this.btnNext2.Size = new System.Drawing.Size(75, 23);
            this.btnNext2.TabIndex = 2;
            this.btnNext2.Text = "Next";
            this.btnNext2.UseVisualStyleBackColor = true;
            // 
            // lblChooseToppings
            // 
            this.lblChooseToppings.AutoSize = true;
            this.lblChooseToppings.Location = new System.Drawing.Point(6, 60);
            this.lblChooseToppings.Name = "lblChooseToppings";
            this.lblChooseToppings.Size = new System.Drawing.Size(152, 26);
            this.lblChooseToppings.TabIndex = 3;
            this.lblChooseToppings.Text = "What toppings would you like?\r\n($0.50 each)";
            // 
            // chkPepperoni
            // 
            this.chkPepperoni.AutoSize = true;
            this.chkPepperoni.Location = new System.Drawing.Point(6, 112);
            this.chkPepperoni.Name = "chkPepperoni";
            this.chkPepperoni.Size = new System.Drawing.Size(74, 17);
            this.chkPepperoni.TabIndex = 4;
            this.chkPepperoni.Text = "Pepperoni";
            this.chkPepperoni.UseVisualStyleBackColor = true;
            // 
            // chkNoCheese
            // 
            this.chkNoCheese.AutoSize = true;
            this.chkNoCheese.Location = new System.Drawing.Point(6, 89);
            this.chkNoCheese.Name = "chkNoCheese";
            this.chkNoCheese.Size = new System.Drawing.Size(166, 17);
            this.chkNoCheese.TabIndex = 5;
            this.chkNoCheese.Text = "Remove cheese ($.050 extra)";
            this.chkNoCheese.UseVisualStyleBackColor = true;
            // 
            // chkPepper
            // 
            this.chkPepper.AutoSize = true;
            this.chkPepper.Location = new System.Drawing.Point(6, 135);
            this.chkPepper.Name = "chkPepper";
            this.chkPepper.Size = new System.Drawing.Size(65, 17);
            this.chkPepper.TabIndex = 6;
            this.chkPepper.Text = "Peppers";
            this.chkPepper.UseVisualStyleBackColor = true;
            // 
            // chkMushrooms
            // 
            this.chkMushrooms.AutoSize = true;
            this.chkMushrooms.Location = new System.Drawing.Point(6, 158);
            this.chkMushrooms.Name = "chkMushrooms";
            this.chkMushrooms.Size = new System.Drawing.Size(80, 17);
            this.chkMushrooms.TabIndex = 7;
            this.chkMushrooms.Text = "Mushrooms";
            this.chkMushrooms.UseVisualStyleBackColor = true;
            // 
            // chkGreenPepper
            // 
            this.chkGreenPepper.AutoSize = true;
            this.chkGreenPepper.Location = new System.Drawing.Point(178, 89);
            this.chkGreenPepper.Name = "chkGreenPepper";
            this.chkGreenPepper.Size = new System.Drawing.Size(97, 17);
            this.chkGreenPepper.TabIndex = 8;
            this.chkGreenPepper.Text = "Green Peppers";
            this.chkGreenPepper.UseVisualStyleBackColor = true;
            // 
            // chkAnchovies
            // 
            this.chkAnchovies.AutoSize = true;
            this.chkAnchovies.Location = new System.Drawing.Point(178, 112);
            this.chkAnchovies.Name = "chkAnchovies";
            this.chkAnchovies.Size = new System.Drawing.Size(76, 17);
            this.chkAnchovies.TabIndex = 9;
            this.chkAnchovies.Text = "Anchovies";
            this.chkAnchovies.UseVisualStyleBackColor = true;
            // 
            // chkOlives
            // 
            this.chkOlives.AutoSize = true;
            this.chkOlives.Location = new System.Drawing.Point(178, 135);
            this.chkOlives.Name = "chkOlives";
            this.chkOlives.Size = new System.Drawing.Size(55, 17);
            this.chkOlives.TabIndex = 10;
            this.chkOlives.Text = "Olives";
            this.chkOlives.UseVisualStyleBackColor = true;
            // 
            // mniEng
            // 
            this.mniEng.Name = "mniEng";
            this.mniEng.Size = new System.Drawing.Size(180, 22);
            this.mniEng.Text = "English";
            // 
            // mniFr
            // 
            this.mniFr.Name = "mniFr";
            this.mniFr.Size = new System.Drawing.Size(180, 22);
            this.mniFr.Text = "Français";
            // 
            // mniIt
            // 
            this.mniIt.Name = "mniIt";
            this.mniIt.Size = new System.Drawing.Size(180, 22);
            this.mniIt.Text = "Italiano";
            // 
            // mniSp
            // 
            this.mniSp.Name = "mniSp";
            this.mniSp.Size = new System.Drawing.Size(180, 22);
            this.mniSp.Text = "Español";
            // 
            // mniRu
            // 
            this.mniRu.Name = "mniRu";
            this.mniRu.Size = new System.Drawing.Size(180, 22);
            this.mniRu.Text = "Русский";
            // 
            // lblOr2
            // 
            this.lblOr2.AutoSize = true;
            this.lblOr2.Location = new System.Drawing.Point(70, 197);
            this.lblOr2.Name = "lblOr2";
            this.lblOr2.Size = new System.Drawing.Size(123, 13);
            this.lblOr2.TabIndex = 11;
            this.lblOr2.Text = "Or make a custom pizza!";
            // 
            // grbStep2P1
            // 
            this.grbStep2P1.Location = new System.Drawing.Point(681, 203);
            this.grbStep2P1.Name = "grbStep2P1";
            this.grbStep2P1.Size = new System.Drawing.Size(200, 100);
            this.grbStep2P1.TabIndex = 4;
            this.grbStep2P1.TabStop = false;
            this.grbStep2P1.Text = "Custom";
            // 
            // frmPizzaOrder
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(984, 508);
            this.Controls.Add(this.grbStep2P1);
            this.Controls.Add(this.grbStep2);
            this.Controls.Add(this.grbStep1);
            this.Controls.Add(this.lblHeader);
            this.Controls.Add(this.mnuOptions);
            this.MainMenuStrip = this.mnuOptions;
            this.Name = "frmPizzaOrder";
            this.Text = "Generic Pizza Place";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.mnuOptions.ResumeLayout(false);
            this.mnuOptions.PerformLayout();
            this.grbStep1.ResumeLayout(false);
            this.grbStep1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nudNumPizzas)).EndInit();
            this.grbStep2.ResumeLayout(false);
            this.grbStep2.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblHeader;
        private System.Windows.Forms.MenuStrip mnuOptions;
        private System.Windows.Forms.ToolStripMenuItem mniFile;
        private System.Windows.Forms.ToolStripMenuItem languageToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem exitToolStripMenuItem;
        private System.Windows.Forms.GroupBox grbStep1;
        private System.Windows.Forms.Label lblStep1Part1;
        private System.Windows.Forms.NumericUpDown nudNumPizzas;
        private System.Windows.Forms.Label lblProvStep1;
        private System.Windows.Forms.RadioButton radOn;
        private System.Windows.Forms.Button btnNext1;
        private System.Windows.Forms.RadioButton radQb;
        private System.Windows.Forms.RadioButton radMb;
        private System.Windows.Forms.RadioButton radNl;
        private System.Windows.Forms.RadioButton radNS;
        private System.Windows.Forms.RadioButton radNB;
        private System.Windows.Forms.GroupBox grbStep2;
        private System.Windows.Forms.Label lblChooseToppings;
        private System.Windows.Forms.Button btnNext2;
        private System.Windows.Forms.CheckBox chkPepper;
        private System.Windows.Forms.CheckBox chkNoCheese;
        private System.Windows.Forms.CheckBox chkPepperoni;
        private System.Windows.Forms.CheckBox chkOlives;
        private System.Windows.Forms.CheckBox chkAnchovies;
        private System.Windows.Forms.CheckBox chkGreenPepper;
        private System.Windows.Forms.CheckBox chkMushrooms;
        private System.Windows.Forms.ToolStripMenuItem mniEng;
        private System.Windows.Forms.ToolStripMenuItem mniFr;
        private System.Windows.Forms.ToolStripMenuItem mniIt;
        private System.Windows.Forms.ToolStripMenuItem mniSp;
        private System.Windows.Forms.ToolStripMenuItem mniRu;
        private System.Windows.Forms.Label lblOr2;
        private System.Windows.Forms.GroupBox grbStep2P1;
    }
}

