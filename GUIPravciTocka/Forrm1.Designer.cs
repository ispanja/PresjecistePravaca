﻿
namespace VsiteCSharpLinearnaJednadzbaGui
{
    partial class Form1
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
            this.buttonEvaluate = new System.Windows.Forms.Button();
            this.resultDisplay1 = new VsiteCSharpLinearnaJednadzbaGui.ResultDisplay();
            this.SuspendLayout();
            // 
            // buttonEvaluate
            // 
            this.buttonEvaluate.Location = new System.Drawing.Point(344, 420);
            this.buttonEvaluate.Name = "buttonEvaluate";
            this.buttonEvaluate.Size = new System.Drawing.Size(119, 38);
            this.buttonEvaluate.TabIndex = 1;
            this.buttonEvaluate.Text = "&Izračunaj";
            this.buttonEvaluate.UseVisualStyleBackColor = true;
            this.buttonEvaluate.Click += new System.EventHandler(this.buttonEvaluate_Click);
            // 
            // resultDisplay1
            // 
            this.resultDisplay1.Location = new System.Drawing.Point(12, 12);
            this.resultDisplay1.Name = "resultDisplay1";
            this.resultDisplay1.Size = new System.Drawing.Size(407, 507);
            this.resultDisplay1.TabIndex = 0;
            this.resultDisplay1.Load += new System.EventHandler(this.resultDisplay1_Load);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1199, 531);
            this.Controls.Add(this.buttonEvaluate);
            this.Controls.Add(this.resultDisplay1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);

        }

        #endregion

        private ResultDisplay resultDisplay1;
        private System.Windows.Forms.Button buttonEvaluate;
    }
}

