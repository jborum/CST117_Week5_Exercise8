/*
 * Form1 Designer
 * This program was written by Jason Borum
 * Date April 8, 2018
 * Course: CST117
 * Instructor: Dr. Brandon Bass
 */

namespace Exercise8
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.txtFatGrams = new System.Windows.Forms.TextBox();
            this.txtCarbGrams = new System.Windows.Forms.TextBox();
            this.btnCalcFat = new System.Windows.Forms.Button();
            this.btnCalcCarbs = new System.Windows.Forms.Button();
            this.btnClose = new System.Windows.Forms.Button();
            this.txtFatCalories = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txtCarbCalories = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(55, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Fat Grams";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 63);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(67, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Carbs Grams";
            // 
            // txtFatGrams
            // 
            this.txtFatGrams.Location = new System.Drawing.Point(128, 9);
            this.txtFatGrams.Name = "txtFatGrams";
            this.txtFatGrams.Size = new System.Drawing.Size(100, 20);
            this.txtFatGrams.TabIndex = 2;
            // 
            // txtCarbGrams
            // 
            this.txtCarbGrams.Location = new System.Drawing.Point(128, 63);
            this.txtCarbGrams.Name = "txtCarbGrams";
            this.txtCarbGrams.Size = new System.Drawing.Size(100, 20);
            this.txtCarbGrams.TabIndex = 3;
            // 
            // btnCalcFat
            // 
            this.btnCalcFat.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.btnCalcFat.Location = new System.Drawing.Point(234, 9);
            this.btnCalcFat.Name = "btnCalcFat";
            this.btnCalcFat.Size = new System.Drawing.Size(119, 23);
            this.btnCalcFat.TabIndex = 4;
            this.btnCalcFat.Text = "Calculate";
            this.btnCalcFat.UseVisualStyleBackColor = false;
            this.btnCalcFat.Click += new System.EventHandler(this.btnCalcFat_Click);
            // 
            // btnCalcCarbs
            // 
            this.btnCalcCarbs.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.btnCalcCarbs.Location = new System.Drawing.Point(234, 61);
            this.btnCalcCarbs.Name = "btnCalcCarbs";
            this.btnCalcCarbs.Size = new System.Drawing.Size(119, 23);
            this.btnCalcCarbs.TabIndex = 5;
            this.btnCalcCarbs.Text = "Calculate";
            this.btnCalcCarbs.UseVisualStyleBackColor = false;
            this.btnCalcCarbs.Click += new System.EventHandler(this.btnCalcCarbs_Click);
            // 
            // btnClose
            // 
            this.btnClose.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.btnClose.Location = new System.Drawing.Point(12, 123);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(341, 23);
            this.btnClose.TabIndex = 6;
            this.btnClose.Text = "Close";
            this.btnClose.UseVisualStyleBackColor = false;
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
            // 
            // txtFatCalories
            // 
            this.txtFatCalories.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.txtFatCalories.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtFatCalories.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtFatCalories.ForeColor = System.Drawing.Color.Blue;
            this.txtFatCalories.Location = new System.Drawing.Point(128, 35);
            this.txtFatCalories.Name = "txtFatCalories";
            this.txtFatCalories.Size = new System.Drawing.Size(100, 15);
            this.txtFatCalories.TabIndex = 8;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(12, 35);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(88, 13);
            this.label3.TabIndex = 7;
            this.label3.Text = "Calories From Fat";
            // 
            // txtCarbCalories
            // 
            this.txtCarbCalories.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.txtCarbCalories.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtCarbCalories.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtCarbCalories.ForeColor = System.Drawing.Color.Blue;
            this.txtCarbCalories.Location = new System.Drawing.Point(128, 89);
            this.txtCarbCalories.Name = "txtCarbCalories";
            this.txtCarbCalories.Size = new System.Drawing.Size(100, 15);
            this.txtCarbCalories.TabIndex = 10;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(12, 89);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(100, 13);
            this.label4.TabIndex = 9;
            this.label4.Text = "Calories From Carbs";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(365, 158);
            this.Controls.Add(this.txtCarbCalories);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.txtFatCalories);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.btnClose);
            this.Controls.Add(this.btnCalcCarbs);
            this.Controls.Add(this.btnCalcFat);
            this.Controls.Add(this.txtCarbGrams);
            this.Controls.Add(this.txtFatGrams);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "Calories from Fat and Carbohydrates";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtFatGrams;
        private System.Windows.Forms.TextBox txtCarbGrams;
        private System.Windows.Forms.Button btnCalcFat;
        private System.Windows.Forms.Button btnCalcCarbs;
        private System.Windows.Forms.Button btnClose;
        private System.Windows.Forms.TextBox txtFatCalories;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtCarbCalories;
        private System.Windows.Forms.Label label4;
    }
}

