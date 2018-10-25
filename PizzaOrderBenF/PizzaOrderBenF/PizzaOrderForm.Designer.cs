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
            this.grbStep1 = new System.Windows.Forms.GroupBox();
            this.radMb = new System.Windows.Forms.RadioButton();
            this.radNl = new System.Windows.Forms.RadioButton();
            this.radNS = new System.Windows.Forms.RadioButton();
            this.radNB = new System.Windows.Forms.RadioButton();
            this.radQc = new System.Windows.Forms.RadioButton();
            this.lblProvStep1 = new System.Windows.Forms.Label();
            this.radOn = new System.Windows.Forms.RadioButton();
            this.btnNext1 = new System.Windows.Forms.Button();
            this.lblS1NumPizzas = new System.Windows.Forms.Label();
            this.nudS2NumPizzas = new System.Windows.Forms.NumericUpDown();
            this.grbStep2 = new System.Windows.Forms.GroupBox();
            this.radS2SizeXL = new System.Windows.Forms.RadioButton();
            this.radS2SizeL = new System.Windows.Forms.RadioButton();
            this.lblS2InputSize = new System.Windows.Forms.Label();
            this.btnNext2 = new System.Windows.Forms.Button();
            this.grbS3P2Reg = new System.Windows.Forms.GroupBox();
            this.radS3P1Hawaiian = new System.Windows.Forms.RadioButton();
            this.radS3P1Combination = new System.Windows.Forms.RadioButton();
            this.radS3P1Vegetarian = new System.Windows.Forms.RadioButton();
            this.radS3P1MeatLovers = new System.Windows.Forms.RadioButton();
            this.radS3P1Cheese = new System.Windows.Forms.RadioButton();
            this.radS3Custom = new System.Windows.Forms.RadioButton();
            this.lblS3RegOrCust = new System.Windows.Forms.Label();
            this.radS3Reg = new System.Windows.Forms.RadioButton();
            this.grbS3P1Custom = new System.Windows.Forms.GroupBox();
            this.chkS3P2NoCheese = new System.Windows.Forms.CheckBox();
            this.chkS3P2Olives = new System.Windows.Forms.CheckBox();
            this.lblS3P2ChooseToppings = new System.Windows.Forms.Label();
            this.chkS3P2Pepperoni = new System.Windows.Forms.CheckBox();
            this.chkS3P2Anchovies = new System.Windows.Forms.CheckBox();
            this.chkS3P2Pepper = new System.Windows.Forms.CheckBox();
            this.chkS3P2GreenPepper = new System.Windows.Forms.CheckBox();
            this.chkS3P2Mushrooms = new System.Windows.Forms.CheckBox();
            this.grbStep3 = new System.Windows.Forms.GroupBox();
            this.btnNext3 = new System.Windows.Forms.Button();
            this.btnFinished = new System.Windows.Forms.Button();
            this.mnuOptions.SuspendLayout();
            this.grbStep1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nudS2NumPizzas)).BeginInit();
            this.grbStep2.SuspendLayout();
            this.grbS3P2Reg.SuspendLayout();
            this.grbS3P1Custom.SuspendLayout();
            this.grbStep3.SuspendLayout();
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
            this.mnuOptions.BackColor = System.Drawing.Color.Transparent;
            this.mnuOptions.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mniFile});
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
            this.exitToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.exitToolStripMenuItem.Text = "Exit";
            this.exitToolStripMenuItem.Click += new System.EventHandler(this.exitToolStripMenuItem_Click);
            // 
            // grbStep1
            // 
            this.grbStep1.Controls.Add(this.radMb);
            this.grbStep1.Controls.Add(this.radNl);
            this.grbStep1.Controls.Add(this.radNS);
            this.grbStep1.Controls.Add(this.radNB);
            this.grbStep1.Controls.Add(this.radQc);
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
            // radQc
            // 
            this.radQc.AutoSize = true;
            this.radQc.Location = new System.Drawing.Point(6, 56);
            this.radQc.Name = "radQc";
            this.radQc.Size = new System.Drawing.Size(63, 17);
            this.radQc.TabIndex = 4;
            this.radQc.TabStop = true;
            this.radQc.Text = "Quebec";
            this.radQc.UseVisualStyleBackColor = true;
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
            // btnNext1
            // 
            this.btnNext1.Location = new System.Drawing.Point(69, 197);
            this.btnNext1.Name = "btnNext1";
            this.btnNext1.Size = new System.Drawing.Size(75, 23);
            this.btnNext1.TabIndex = 2;
            this.btnNext1.Text = "Next";
            this.btnNext1.UseVisualStyleBackColor = true;
            this.btnNext1.Click += new System.EventHandler(this.btnNext1_Click);
            // 
            // lblS1NumPizzas
            // 
            this.lblS1NumPizzas.AutoSize = true;
            this.lblS1NumPizzas.Location = new System.Drawing.Point(6, 16);
            this.lblS1NumPizzas.Name = "lblS1NumPizzas";
            this.lblS1NumPizzas.Size = new System.Drawing.Size(204, 13);
            this.lblS1NumPizzas.TabIndex = 1;
            this.lblS1NumPizzas.Text = "How many pizzas would you like to order?";
            // 
            // nudS2NumPizzas
            // 
            this.nudS2NumPizzas.Location = new System.Drawing.Point(6, 32);
            this.nudS2NumPizzas.Maximum = new decimal(new int[] {
            10,
            0,
            0,
            0});
            this.nudS2NumPizzas.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.nudS2NumPizzas.Name = "nudS2NumPizzas";
            this.nudS2NumPizzas.Size = new System.Drawing.Size(120, 20);
            this.nudS2NumPizzas.TabIndex = 0;
            this.nudS2NumPizzas.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // grbStep2
            // 
            this.grbStep2.Controls.Add(this.radS2SizeXL);
            this.grbStep2.Controls.Add(this.radS2SizeL);
            this.grbStep2.Controls.Add(this.lblS2InputSize);
            this.grbStep2.Controls.Add(this.btnNext2);
            this.grbStep2.Controls.Add(this.lblS1NumPizzas);
            this.grbStep2.Controls.Add(this.nudS2NumPizzas);
            this.grbStep2.Location = new System.Drawing.Point(268, 114);
            this.grbStep2.Name = "grbStep2";
            this.grbStep2.Size = new System.Drawing.Size(278, 153);
            this.grbStep2.TabIndex = 3;
            this.grbStep2.TabStop = false;
            this.grbStep2.Text = "Step 2";
            // 
            // radS2SizeXL
            // 
            this.radS2SizeXL.AutoSize = true;
            this.radS2SizeXL.Location = new System.Drawing.Point(6, 95);
            this.radS2SizeXL.Name = "radS2SizeXL";
            this.radS2SizeXL.Size = new System.Drawing.Size(79, 17);
            this.radS2SizeXL.TabIndex = 5;
            this.radS2SizeXL.TabStop = true;
            this.radS2SizeXL.Text = "Extra Large";
            this.radS2SizeXL.UseVisualStyleBackColor = true;
            // 
            // radS2SizeL
            // 
            this.radS2SizeL.AutoSize = true;
            this.radS2SizeL.Location = new System.Drawing.Point(6, 72);
            this.radS2SizeL.Name = "radS2SizeL";
            this.radS2SizeL.Size = new System.Drawing.Size(52, 17);
            this.radS2SizeL.TabIndex = 4;
            this.radS2SizeL.TabStop = true;
            this.radS2SizeL.Text = "Large";
            this.radS2SizeL.UseVisualStyleBackColor = true;
            // 
            // lblS2InputSize
            // 
            this.lblS2InputSize.AutoSize = true;
            this.lblS2InputSize.Location = new System.Drawing.Point(6, 56);
            this.lblS2InputSize.Name = "lblS2InputSize";
            this.lblS2InputSize.Size = new System.Drawing.Size(104, 13);
            this.lblS2InputSize.TabIndex = 3;
            this.lblS2InputSize.Text = "Large or extra large?";
            // 
            // btnNext2
            // 
            this.btnNext2.Location = new System.Drawing.Point(102, 118);
            this.btnNext2.Name = "btnNext2";
            this.btnNext2.Size = new System.Drawing.Size(75, 23);
            this.btnNext2.TabIndex = 2;
            this.btnNext2.Text = "Next";
            this.btnNext2.UseVisualStyleBackColor = true;
            this.btnNext2.Click += new System.EventHandler(this.btnNext2_Click);
            // 
            // grbS3P2Reg
            // 
            this.grbS3P2Reg.Controls.Add(this.radS3P1Hawaiian);
            this.grbS3P2Reg.Controls.Add(this.radS3P1Combination);
            this.grbS3P2Reg.Controls.Add(this.radS3P1Vegetarian);
            this.grbS3P2Reg.Controls.Add(this.radS3P1MeatLovers);
            this.grbS3P2Reg.Controls.Add(this.radS3P1Cheese);
            this.grbS3P2Reg.Enabled = false;
            this.grbS3P2Reg.Location = new System.Drawing.Point(1, 216);
            this.grbS3P2Reg.Name = "grbS3P2Reg";
            this.grbS3P2Reg.Size = new System.Drawing.Size(249, 100);
            this.grbS3P2Reg.TabIndex = 4;
            this.grbS3P2Reg.TabStop = false;
            this.grbS3P2Reg.Text = "Regular Pizza";
            // 
            // radS3P1Hawaiian
            // 
            this.radS3P1Hawaiian.AutoSize = true;
            this.radS3P1Hawaiian.Location = new System.Drawing.Point(105, 43);
            this.radS3P1Hawaiian.Name = "radS3P1Hawaiian";
            this.radS3P1Hawaiian.Size = new System.Drawing.Size(69, 17);
            this.radS3P1Hawaiian.TabIndex = 7;
            this.radS3P1Hawaiian.TabStop = true;
            this.radS3P1Hawaiian.Text = "Hawaiian";
            this.radS3P1Hawaiian.UseVisualStyleBackColor = true;
            // 
            // radS3P1Combination
            // 
            this.radS3P1Combination.AutoSize = true;
            this.radS3P1Combination.Location = new System.Drawing.Point(105, 20);
            this.radS3P1Combination.Name = "radS3P1Combination";
            this.radS3P1Combination.Size = new System.Drawing.Size(83, 17);
            this.radS3P1Combination.TabIndex = 6;
            this.radS3P1Combination.TabStop = true;
            this.radS3P1Combination.Text = "Combination";
            this.radS3P1Combination.UseVisualStyleBackColor = true;
            // 
            // radS3P1Vegetarian
            // 
            this.radS3P1Vegetarian.AutoSize = true;
            this.radS3P1Vegetarian.Location = new System.Drawing.Point(6, 66);
            this.radS3P1Vegetarian.Name = "radS3P1Vegetarian";
            this.radS3P1Vegetarian.Size = new System.Drawing.Size(76, 17);
            this.radS3P1Vegetarian.TabIndex = 5;
            this.radS3P1Vegetarian.TabStop = true;
            this.radS3P1Vegetarian.Text = "Vegetarian";
            this.radS3P1Vegetarian.UseVisualStyleBackColor = true;
            // 
            // radS3P1MeatLovers
            // 
            this.radS3P1MeatLovers.AutoSize = true;
            this.radS3P1MeatLovers.Location = new System.Drawing.Point(6, 43);
            this.radS3P1MeatLovers.Name = "radS3P1MeatLovers";
            this.radS3P1MeatLovers.Size = new System.Drawing.Size(84, 17);
            this.radS3P1MeatLovers.TabIndex = 1;
            this.radS3P1MeatLovers.TabStop = true;
            this.radS3P1MeatLovers.Text = "Meat Lovers";
            this.radS3P1MeatLovers.UseVisualStyleBackColor = true;
            // 
            // radS3P1Cheese
            // 
            this.radS3P1Cheese.AutoSize = true;
            this.radS3P1Cheese.Location = new System.Drawing.Point(6, 20);
            this.radS3P1Cheese.Name = "radS3P1Cheese";
            this.radS3P1Cheese.Size = new System.Drawing.Size(61, 17);
            this.radS3P1Cheese.TabIndex = 0;
            this.radS3P1Cheese.TabStop = true;
            this.radS3P1Cheese.Text = "Cheese";
            this.radS3P1Cheese.UseVisualStyleBackColor = true;
            // 
            // radS3Custom
            // 
            this.radS3Custom.AutoSize = true;
            this.radS3Custom.Location = new System.Drawing.Point(6, 32);
            this.radS3Custom.Name = "radS3Custom";
            this.radS3Custom.Size = new System.Drawing.Size(60, 17);
            this.radS3Custom.TabIndex = 14;
            this.radS3Custom.TabStop = true;
            this.radS3Custom.Text = "Custom";
            this.radS3Custom.UseVisualStyleBackColor = true;
            this.radS3Custom.CheckedChanged += new System.EventHandler(this.radS3Custom_CheckedChanged);
            // 
            // lblS3RegOrCust
            // 
            this.lblS3RegOrCust.AutoSize = true;
            this.lblS3RegOrCust.Location = new System.Drawing.Point(6, 16);
            this.lblS3RegOrCust.Name = "lblS3RegOrCust";
            this.lblS3RegOrCust.Size = new System.Drawing.Size(244, 13);
            this.lblS3RegOrCust.TabIndex = 13;
            this.lblS3RegOrCust.Text = "Would you like to order regular or custom pizza(s)?";
            // 
            // radS3Reg
            // 
            this.radS3Reg.AutoSize = true;
            this.radS3Reg.Location = new System.Drawing.Point(6, 52);
            this.radS3Reg.Name = "radS3Reg";
            this.radS3Reg.Size = new System.Drawing.Size(62, 17);
            this.radS3Reg.TabIndex = 12;
            this.radS3Reg.TabStop = true;
            this.radS3Reg.Text = "Regular";
            this.radS3Reg.UseVisualStyleBackColor = true;
            this.radS3Reg.CheckedChanged += new System.EventHandler(this.radS3Reg_CheckedChanged);
            // 
            // grbS3P1Custom
            // 
            this.grbS3P1Custom.Controls.Add(this.chkS3P2NoCheese);
            this.grbS3P1Custom.Controls.Add(this.chkS3P2Olives);
            this.grbS3P1Custom.Controls.Add(this.lblS3P2ChooseToppings);
            this.grbS3P1Custom.Controls.Add(this.chkS3P2Pepperoni);
            this.grbS3P1Custom.Controls.Add(this.chkS3P2Anchovies);
            this.grbS3P1Custom.Controls.Add(this.chkS3P2Pepper);
            this.grbS3P1Custom.Controls.Add(this.chkS3P2GreenPepper);
            this.grbS3P1Custom.Controls.Add(this.chkS3P2Mushrooms);
            this.grbS3P1Custom.Enabled = false;
            this.grbS3P1Custom.Location = new System.Drawing.Point(0, 79);
            this.grbS3P1Custom.Name = "grbS3P1Custom";
            this.grbS3P1Custom.Size = new System.Drawing.Size(249, 135);
            this.grbS3P1Custom.TabIndex = 4;
            this.grbS3P1Custom.TabStop = false;
            this.grbS3P1Custom.Text = "Custom Pizza";
            // 
            // chkS3P2NoCheese
            // 
            this.chkS3P2NoCheese.AutoSize = true;
            this.chkS3P2NoCheese.Location = new System.Drawing.Point(6, 45);
            this.chkS3P2NoCheese.Name = "chkS3P2NoCheese";
            this.chkS3P2NoCheese.Size = new System.Drawing.Size(160, 17);
            this.chkS3P2NoCheese.TabIndex = 5;
            this.chkS3P2NoCheese.Text = "Remove cheese ($.50 extra)";
            this.chkS3P2NoCheese.UseVisualStyleBackColor = true;
            // 
            // chkS3P2Olives
            // 
            this.chkS3P2Olives.AutoSize = true;
            this.chkS3P2Olives.Location = new System.Drawing.Point(86, 114);
            this.chkS3P2Olives.Name = "chkS3P2Olives";
            this.chkS3P2Olives.Size = new System.Drawing.Size(55, 17);
            this.chkS3P2Olives.TabIndex = 10;
            this.chkS3P2Olives.Text = "Olives";
            this.chkS3P2Olives.UseVisualStyleBackColor = true;
            // 
            // lblS3P2ChooseToppings
            // 
            this.lblS3P2ChooseToppings.AutoSize = true;
            this.lblS3P2ChooseToppings.Location = new System.Drawing.Point(6, 16);
            this.lblS3P2ChooseToppings.Name = "lblS3P2ChooseToppings";
            this.lblS3P2ChooseToppings.Size = new System.Drawing.Size(152, 26);
            this.lblS3P2ChooseToppings.TabIndex = 3;
            this.lblS3P2ChooseToppings.Text = "What toppings would you like?\r\n($0.50 each)";
            // 
            // chkS3P2Pepperoni
            // 
            this.chkS3P2Pepperoni.AutoSize = true;
            this.chkS3P2Pepperoni.Location = new System.Drawing.Point(6, 68);
            this.chkS3P2Pepperoni.Name = "chkS3P2Pepperoni";
            this.chkS3P2Pepperoni.Size = new System.Drawing.Size(74, 17);
            this.chkS3P2Pepperoni.TabIndex = 4;
            this.chkS3P2Pepperoni.Text = "Pepperoni";
            this.chkS3P2Pepperoni.UseVisualStyleBackColor = true;
            // 
            // chkS3P2Anchovies
            // 
            this.chkS3P2Anchovies.AutoSize = true;
            this.chkS3P2Anchovies.Location = new System.Drawing.Point(86, 91);
            this.chkS3P2Anchovies.Name = "chkS3P2Anchovies";
            this.chkS3P2Anchovies.Size = new System.Drawing.Size(76, 17);
            this.chkS3P2Anchovies.TabIndex = 9;
            this.chkS3P2Anchovies.Text = "Anchovies";
            this.chkS3P2Anchovies.UseVisualStyleBackColor = true;
            // 
            // chkS3P2Pepper
            // 
            this.chkS3P2Pepper.AutoSize = true;
            this.chkS3P2Pepper.Location = new System.Drawing.Point(6, 91);
            this.chkS3P2Pepper.Name = "chkS3P2Pepper";
            this.chkS3P2Pepper.Size = new System.Drawing.Size(65, 17);
            this.chkS3P2Pepper.TabIndex = 6;
            this.chkS3P2Pepper.Text = "Peppers";
            this.chkS3P2Pepper.UseVisualStyleBackColor = true;
            // 
            // chkS3P2GreenPepper
            // 
            this.chkS3P2GreenPepper.AutoSize = true;
            this.chkS3P2GreenPepper.Location = new System.Drawing.Point(86, 68);
            this.chkS3P2GreenPepper.Name = "chkS3P2GreenPepper";
            this.chkS3P2GreenPepper.Size = new System.Drawing.Size(97, 17);
            this.chkS3P2GreenPepper.TabIndex = 8;
            this.chkS3P2GreenPepper.Text = "Green Peppers";
            this.chkS3P2GreenPepper.UseVisualStyleBackColor = true;
            // 
            // chkS3P2Mushrooms
            // 
            this.chkS3P2Mushrooms.AutoSize = true;
            this.chkS3P2Mushrooms.Location = new System.Drawing.Point(6, 114);
            this.chkS3P2Mushrooms.Name = "chkS3P2Mushrooms";
            this.chkS3P2Mushrooms.Size = new System.Drawing.Size(80, 17);
            this.chkS3P2Mushrooms.TabIndex = 7;
            this.chkS3P2Mushrooms.Text = "Mushrooms";
            this.chkS3P2Mushrooms.UseVisualStyleBackColor = true;
            // 
            // grbStep3
            // 
            this.grbStep3.Controls.Add(this.btnNext3);
            this.grbStep3.Controls.Add(this.radS3Reg);
            this.grbStep3.Controls.Add(this.grbS3P2Reg);
            this.grbStep3.Controls.Add(this.grbS3P1Custom);
            this.grbStep3.Controls.Add(this.radS3Custom);
            this.grbStep3.Controls.Add(this.lblS3RegOrCust);
            this.grbStep3.Location = new System.Drawing.Point(572, 114);
            this.grbStep3.Name = "grbStep3";
            this.grbStep3.Size = new System.Drawing.Size(249, 349);
            this.grbStep3.TabIndex = 15;
            this.grbStep3.TabStop = false;
            this.grbStep3.Text = "Step 3";
            // 
            // btnNext3
            // 
            this.btnNext3.Location = new System.Drawing.Point(87, 320);
            this.btnNext3.Name = "btnNext3";
            this.btnNext3.Size = new System.Drawing.Size(75, 23);
            this.btnNext3.TabIndex = 15;
            this.btnNext3.Text = "Next";
            this.btnNext3.UseVisualStyleBackColor = true;
            this.btnNext3.Click += new System.EventHandler(this.btnNext3_Click);
            // 
            // btnFinished
            // 
            this.btnFinished.Location = new System.Drawing.Point(455, 472);
            this.btnFinished.Name = "btnFinished";
            this.btnFinished.Size = new System.Drawing.Size(75, 23);
            this.btnFinished.TabIndex = 16;
            this.btnFinished.Text = "Finished";
            this.btnFinished.UseVisualStyleBackColor = true;
            this.btnFinished.Visible = false;
            this.btnFinished.Click += new System.EventHandler(this.btnFinished_Click);
            // 
            // frmPizzaOrder
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(984, 527);
            this.Controls.Add(this.btnFinished);
            this.Controls.Add(this.grbStep3);
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
            ((System.ComponentModel.ISupportInitialize)(this.nudS2NumPizzas)).EndInit();
            this.grbStep2.ResumeLayout(false);
            this.grbStep2.PerformLayout();
            this.grbS3P2Reg.ResumeLayout(false);
            this.grbS3P2Reg.PerformLayout();
            this.grbS3P1Custom.ResumeLayout(false);
            this.grbS3P1Custom.PerformLayout();
            this.grbStep3.ResumeLayout(false);
            this.grbStep3.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblHeader;
        private System.Windows.Forms.MenuStrip mnuOptions;
        private System.Windows.Forms.ToolStripMenuItem mniFile;
        private System.Windows.Forms.ToolStripMenuItem exitToolStripMenuItem;
        private System.Windows.Forms.GroupBox grbStep1;
        private System.Windows.Forms.Label lblS1NumPizzas;
        private System.Windows.Forms.NumericUpDown nudS2NumPizzas;
        private System.Windows.Forms.Label lblProvStep1;
        private System.Windows.Forms.RadioButton radOn;
        private System.Windows.Forms.Button btnNext1;
        private System.Windows.Forms.RadioButton radQc;
        private System.Windows.Forms.RadioButton radMb;
        private System.Windows.Forms.RadioButton radNl;
        private System.Windows.Forms.RadioButton radNS;
        private System.Windows.Forms.RadioButton radNB;
        private System.Windows.Forms.GroupBox grbStep2;
        private System.Windows.Forms.Label lblS3P2ChooseToppings;
        private System.Windows.Forms.Button btnNext2;
        private System.Windows.Forms.CheckBox chkS3P2Pepper;
        private System.Windows.Forms.CheckBox chkS3P2NoCheese;
        private System.Windows.Forms.CheckBox chkS3P2Pepperoni;
        private System.Windows.Forms.CheckBox chkS3P2Olives;
        private System.Windows.Forms.CheckBox chkS3P2Anchovies;
        private System.Windows.Forms.CheckBox chkS3P2GreenPepper;
        private System.Windows.Forms.CheckBox chkS3P2Mushrooms;
        private System.Windows.Forms.GroupBox grbS3P1Custom;
        private System.Windows.Forms.Label lblS3RegOrCust;
        private System.Windows.Forms.RadioButton radS3Reg;
        private System.Windows.Forms.RadioButton radS3Custom;
        private System.Windows.Forms.GroupBox grbS3P2Reg;
        private System.Windows.Forms.RadioButton radS3P1Cheese;
        private System.Windows.Forms.RadioButton radS3P1Combination;
        private System.Windows.Forms.RadioButton radS3P1Vegetarian;
        private System.Windows.Forms.RadioButton radS3P1MeatLovers;
        private System.Windows.Forms.RadioButton radS3P1Hawaiian;
        private System.Windows.Forms.RadioButton radS2SizeXL;
        private System.Windows.Forms.RadioButton radS2SizeL;
        private System.Windows.Forms.Label lblS2InputSize;
        private System.Windows.Forms.GroupBox grbStep3;
        private System.Windows.Forms.Button btnNext3;
        private System.Windows.Forms.Button btnFinished;
    }
}

