﻿namespace FallingObjectsBenF
{
    partial class frmFallingObjects
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
            this.lblEnterTime = new System.Windows.Forms.Label();
            this.txtEnterTime = new System.Windows.Forms.TextBox();
            this.btnCalculate = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lblEnterTime
            // 
            this.lblEnterTime.AutoSize = true;
            this.lblEnterTime.Font = new System.Drawing.Font("Rosewood Std Regular", 21.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblEnterTime.ForeColor = System.Drawing.Color.Red;
            this.lblEnterTime.Location = new System.Drawing.Point(32, 78);
            this.lblEnterTime.Name = "lblEnterTime";
            this.lblEnterTime.Size = new System.Drawing.Size(813, 34);
            this.lblEnterTime.TabIndex = 0;
            this.lblEnterTime.Text = "Enter the time (in seconds) since you released the object";
            // 
            // txtEnterTime
            // 
            this.txtEnterTime.Font = new System.Drawing.Font("ISOCPEUR", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtEnterTime.Location = new System.Drawing.Point(869, 81);
            this.txtEnterTime.Name = "txtEnterTime";
            this.txtEnterTime.Size = new System.Drawing.Size(68, 31);
            this.txtEnterTime.TabIndex = 1;
            // 
            // btnCalculate
            // 
            this.btnCalculate.Location = new System.Drawing.Point(439, 260);
            this.btnCalculate.Name = "btnCalculate";
            this.btnCalculate.Size = new System.Drawing.Size(128, 56);
            this.btnCalculate.TabIndex = 2;
            this.btnCalculate.Text = "button1";
            this.btnCalculate.UseVisualStyleBackColor = true;
            // 
            // frmFallingObjects
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1114, 631);
            this.Controls.Add(this.btnCalculate);
            this.Controls.Add(this.txtEnterTime);
            this.Controls.Add(this.lblEnterTime);
            this.Name = "frmFallingObjects";
            this.Text = "Falling Objects Ben F";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblEnterTime;
        private System.Windows.Forms.TextBox txtEnterTime;
        private System.Windows.Forms.Button btnCalculate;
    }
}

