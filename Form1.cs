/*
 * Form1
 * This program was written by Jason Borum
 * Date April 8, 2018
 * Course: CST117
 * Instructor: Dr. Brandon Bass
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

namespace Exercise8
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            //close program
            this.Close();
        }

        private void btnCalcFat_Click(object sender, EventArgs e)
        {
            //Test for double
            double tstDbl;
            if (!double.TryParse(txtFatGrams.Text, out tstDbl))
            {
                //display messagebox when double not entered
                MessageBox.Show("Enter Valid Double","Input Error");
                txtFatGrams.Text = "";
                txtFatGrams.Focus();
            }
            else
            {
                //Calculate calories using method
                txtFatCalories.Text = Convert.ToString(FatCalories(tstDbl));
            }
        }

        private void btnCalcCarbs_Click(object sender, EventArgs e)
        {
            //Test for double
            double tstDbl;
            if (!double.TryParse(txtCarbGrams.Text, out tstDbl))
            {
                //display messagebox when double not entered
                MessageBox.Show("Enter Valid Double", "Input Error");
                txtCarbGrams.Text = "";
                txtCarbGrams.Focus();

            }
            else
            {
                //Calculate calories using method
                txtCarbCalories.Text = Convert.ToString(CarbCalories(tstDbl));
            }
        }

        //Method to convert fat grams to calories
        public double FatCalories(double fatGram)
        {
            return fatGram * 9.0;
        }

        //Method to convert carb grams to calories
        public double CarbCalories(double carbGram)
        {
            return carbGram * 4.0;
        }


    } //end of form class
} //end of exercise8 class
