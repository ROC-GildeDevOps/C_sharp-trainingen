using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace C_sharp_berekeningen
{
    public partial class Form1 : Form
    {
        // nu weten ze allemaal wat wat is enzo
        private int a = 10;
        private double b = 20.50;
        private double c = 50.10;
        private int d = 20;

        public Form1()
        {
            InitializeComponent();
        }

        // These 3 are all the same so not much explain. 
        private void btnPlus_Click(object sender, EventArgs e)
        {
            double result = a + b + c + d;
            lblOutput.Text = "Result: " + result.ToString();
        }

        private void btnMinus_Click(object sender, EventArgs e)
        {
            double result = a - b - c - d;
            lblOutput.Text = "Result: " + result.ToString();
        }

        private void btnFactor_Click(object sender, EventArgs e)
        {
            double result = a * b * c * d;
            lblOutput.Text = "Result: " + result.ToString();
        }

        private void btnDivide_Click(object sender, EventArgs e)
        {
            // 0 kan je zeg maar niet delen enzo!
            if (b != 0)
            {
                double result = (a + c) / b;
                lblOutput.Text = "Result: " + result.ToString();
            }
            else
            {
                lblOutput.Text = "Error: Division by zero";
            }
        }

        private void lblOutput_Click(object sender, EventArgs e)
        {
           // Da ding moet zeg maar niks doen hier!!
        }
    }
}
