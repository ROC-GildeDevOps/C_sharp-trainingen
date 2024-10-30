using System;
using System.Windows.Forms;

namespace C_sharp_rekenbewerking
{
    public partial class Form1 : Form
    {
        // Moet wel bestaan om aan te passen tuurlijk
        private string currentOperation;

        public Form1()
        {
            InitializeComponent();

            // Haal data van frontend op. Dit geval dus tekst "+"
            currentOperation = btnExpression.Text;
        }

        // Knopje klikken zorgt switchen van (+, -, *, /)
        private void btnExpression_Click(object sender, EventArgs e)
        {
            switch (currentOperation)
            {
                case "+":
                    currentOperation = "-";
                    break;
                case "-":
                    currentOperation = "*";
                    break;
                case "*":
                    currentOperation = "/";
                    break;
                case "/":
                    currentOperation = "+";
                    break;
            }

            // Frontend moet weten
            btnExpression.Text = currentOperation;
        }

        private void btnStart_Click(object sender, EventArgs e)
        {
            try
            {
                // Moeten wel cijfers zijn andere is t gwn aan elkaar plakken
                int first = int.Parse(input_1.Text);
                int second = int.Parse(input_2.Text);
                double result = 0;

                // FF kijken welke formule
                switch (currentOperation)
                {
                    case "+":
                        result = first + second;
                        break;
                    case "-":
                        result = first - second;
                        break;
                    case "*":
                        result = first * second;
                        break;
                    case "/":
                        // Hij mag geen boem doen natuurlijk
                        if (second != 0)
                        {
                            result = (double)first / second;
                        }
                        else
                        {
                            MessageBox.Show("Cannot divide by zero!");
                            return;
                        }
                        break;
                }

                // Front end moet deze ook weten tg
                lblOutput.Text = (currentOperation == "/") ? result.ToString("F2") : result.ToString();
            }
            catch (FormatException)
            {
                // OEI, is geen nummertje ofwel
                MessageBox.Show("Please enter valid integers.");
            }
        }
    }
}
