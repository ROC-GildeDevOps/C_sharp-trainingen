using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace C_sharp_factuur
{
    public partial class Form1 : Form
    {
        // Iedereen moet deze weten. Dus prijzen zijn wel echt zwaar static
        private const decimal PriceArticleOne = 13.58m;
        private const decimal PriceArticleTwo = 35.11m;
        private const decimal VATRate = 0.21m;

        public Form1()
        {
            InitializeComponent();

            // Van decimal naar currency
            lblResultArticleOne.Text = PriceArticleOne.ToString("C");
            lblResultArticleTwo.Text = PriceArticleTwo.ToString("C");
        }


        private void inputFirstName_TextChanged(object sender, EventArgs e)
        {

        }

        private void inputLastName_TextChanged(object sender, EventArgs e)
        {

        }

        private void inputArticleOne_TextChanged(object sender, EventArgs e)
        {

        }

        private void inputArticleTwo_TextChanged(object sender, EventArgs e)
        {

        }

        private void inputQuantityArticleOne_TextChanged(object sender, EventArgs e)
        {

        }

        private void inputQuantityArticleTwo_TextChanged(object sender, EventArgs e)
        {

        }

        private void lblResultArticleOne_Click(object sender, EventArgs e)
        {

        }

        private void lblResultArticleTwo_Click(object sender, EventArgs e)
        {

        }

        private void lblOutputCost_Click(object sender, EventArgs e)
        {

        }

        private void btnSubmit_Click(object sender, EventArgs e)
        {
            // Haal de dingen op die jij typt
            string firstName = inputFirstName.Text;
            string lastName = inputLastName.Text;
            string articleOneDescription = inputArticleOne.Text;
            string articleTwoDescription = inputArticleTwo.Text;
            int quantityArticleOne = int.TryParse(inputQuantityArticleOne.Text, out var qty1) ? qty1 : 0;
            int quantityArticleTwo = int.TryParse(inputQuantityArticleTwo.Text, out var qty2) ? qty2 : 0;

            // Berekeningen enzo
            decimal totalArticleOne = PriceArticleOne * quantityArticleOne;
            decimal totalArticleTwo = PriceArticleTwo * quantityArticleTwo;
            decimal subtotal = totalArticleOne + totalArticleTwo;
            decimal vat = subtotal * VATRate;
            decimal totalInvoice = subtotal + vat;

            // Laat zeg maar het eindresultaat zien
            lblOutputCost.Text = $"Klantgegevens: {firstName} {lastName}\n" +
                             $"{articleOneDescription}: {PriceArticleOne:C} x {quantityArticleOne} = {totalArticleOne:C}\n" +
                             $"{articleTwoDescription}: {PriceArticleTwo:C} x {quantityArticleTwo} = {totalArticleTwo:C}\n" +
                             $"Subtotaal: {subtotal:C}\n" +
                             $"BTW (21%): {vat:C}\n" +
                             $"Factuurbedrag: {totalInvoice:C}";
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            // Das peg alles weg!
            inputFirstName.Clear();
            inputLastName.Clear();
            inputArticleOne.Clear();
            inputArticleTwo.Clear();
            inputQuantityArticleOne.Clear();
            inputQuantityArticleTwo.Clear();
            lblOutputCost.Text = string.Empty;
        }
    }
}
