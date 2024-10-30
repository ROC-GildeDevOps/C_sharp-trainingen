using System;
using System.Windows.Forms;

namespace C_sharp_berekenen
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            // IDK EXIT
            Application.Exit();
        }

        private void btnStart_Click(object sender, EventArgs e)
        {
            // BRO HERE I DEFINE WHAT I WANT FORM THE FUNCTION
            PerformOperation(input_1.Text, input_2.Text, label10, "addition", (a, b) => a + b);
            PerformOperation(input_3.Text, input_4.Text, label11, "subtraction", (a, b) => a - b);
            PerformOperation(input_5.Text, input_6.Text, label12, "multiplication", (a, b) => a * b);
            // andere want ja OEI
            PerformDivision(input_7.Text, input_8.Text, label13);
        }

        // DIT IS EEN REKENMACHINE
        private void PerformOperation(string input1, string input2, Label resultLabel, string operation, Func<int, int, int> operationFunc)
        {
            if (int.TryParse(input1, out int number1) && int.TryParse(input2, out int number2))
            {
                resultLabel.Text = operationFunc(number1, number2).ToString();
            }
            else
            {
                MessageBox.Show($"Please enter valid numbers for {operation}.", "Input Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        // Ja delen door werkt echt **** dus ja doorvoor andere gemaakt
        private void PerformDivision(string input1, string input2, Label resultLabel)
        {
            if (int.TryParse(input1, out int number1) && int.TryParse(input2, out int number2))
            {
                if (number2 != 0)
                {
                    double result = (double)number1 / number2;
                    resultLabel.Text = result.ToString("F2");
                }
                else
                {
                    MessageBox.Show("Division by zero is not allowed.", "Division Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            else
            {
                MessageBox.Show("Please enter valid numbers for division.", "Input Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
