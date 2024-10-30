using System;
using System.Text.RegularExpressions;
using System.Windows.Forms;

namespace C_sharp_rente
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        // Deze functie verkomt nutteloze invoeren
        private bool IsValidName(string name)
        {
            // Check dat de naam niet leeg is en alleen letters bevat
            return !string.IsNullOrWhiteSpace(name) && Regex.IsMatch(name, @"^[a-zA-Z]+$");
        }

        private void btnStart_Click(object sender, EventArgs e)
        {
            // Wow de gegevens die ik invul
            string voornaam = inputFirstName.Text;
            string achternaam = inputLastName.Text;
            decimal spaarbedrag;

            // START FUnctie
            if (!IsValidName(voornaam) || !IsValidName(achternaam))
            {
                MessageBox.Show("Vul een geldige voor- en achternaam in. Alleen letters zijn toegestaan.", "Ongeldige invoer", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            // Bro is deze wel een bedraf ofnie
            if (decimal.TryParse(inputMoneyAmount.Text, out spaarbedrag))
            {
                // Juw hvl rente is deze
                decimal rente = 0;

                if (spaarbedrag <= 10000)
                {
                    rente = spaarbedrag * 0.015m;
                }
                else
                {
                    rente = spaarbedrag * 0.02m; 
                }

                // Laat rslt zien
                lblOutput.Text = $"Klantgegevens: {voornaam} {achternaam}\n" +
                                 $"U ontvangt voor een spaarbedrag van €{spaarbedrag:0.00} aan rente: €{rente:0.00}";
            }
            else
            {
                // BRO DEZE IS NIE JUISTE GEEF ME GETAL
                MessageBox.Show("Vul een geldig spaarbedrag in.", "Ongeldige invoer", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnStop_Click(object sender, EventArgs e)
        {
            // BOOM
            Application.Exit();
        }
    }
}
