namespace C_sharp_factuur
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
            this.lblFirstName = new System.Windows.Forms.Label();
            this.lblLastName = new System.Windows.Forms.Label();
            this.lblArticleOne = new System.Windows.Forms.Label();
            this.lblArticleTwo = new System.Windows.Forms.Label();
            this.inputFirstName = new System.Windows.Forms.TextBox();
            this.inputLastName = new System.Windows.Forms.TextBox();
            this.inputArticleOne = new System.Windows.Forms.TextBox();
            this.inputArticleTwo = new System.Windows.Forms.TextBox();
            this.lblQuantityArticleOne = new System.Windows.Forms.Label();
            this.lblQuantityArticleTwo = new System.Windows.Forms.Label();
            this.inputQuantityArticleOne = new System.Windows.Forms.TextBox();
            this.inputQuantityArticleTwo = new System.Windows.Forms.TextBox();
            this.lblResultArticleOne = new System.Windows.Forms.Label();
            this.lblResultArticleTwo = new System.Windows.Forms.Label();
            this.lblOutputCost = new System.Windows.Forms.Label();
            this.btnSubmit = new System.Windows.Forms.Button();
            this.btnCancel = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lblFirstName
            // 
            this.lblFirstName.AutoSize = true;
            this.lblFirstName.Location = new System.Drawing.Point(50, 50);
            this.lblFirstName.Name = "lblFirstName";
            this.lblFirstName.Size = new System.Drawing.Size(91, 20);
            this.lblFirstName.TabIndex = 0;
            this.lblFirstName.Text = "Voornaam :";
            // 
            // lblLastName
            // 
            this.lblLastName.AutoSize = true;
            this.lblLastName.Location = new System.Drawing.Point(50, 100);
            this.lblLastName.Name = "lblLastName";
            this.lblLastName.Size = new System.Drawing.Size(104, 20);
            this.lblLastName.TabIndex = 1;
            this.lblLastName.Text = "Achternaam :";
            // 
            // lblArticleOne
            // 
            this.lblArticleOne.AutoSize = true;
            this.lblArticleOne.Location = new System.Drawing.Point(50, 150);
            this.lblArticleOne.Name = "lblArticleOne";
            this.lblArticleOne.Size = new System.Drawing.Size(74, 20);
            this.lblArticleOne.TabIndex = 2;
            this.lblArticleOne.Text = "Artikel 1 :";
            // 
            // lblArticleTwo
            // 
            this.lblArticleTwo.AutoSize = true;
            this.lblArticleTwo.Location = new System.Drawing.Point(50, 200);
            this.lblArticleTwo.Name = "lblArticleTwo";
            this.lblArticleTwo.Size = new System.Drawing.Size(74, 20);
            this.lblArticleTwo.TabIndex = 3;
            this.lblArticleTwo.Text = "Artikel 2 :";
            // 
            // inputFirstName
            // 
            this.inputFirstName.Location = new System.Drawing.Point(200, 50);
            this.inputFirstName.Multiline = true;
            this.inputFirstName.Name = "inputFirstName";
            this.inputFirstName.Size = new System.Drawing.Size(200, 25);
            this.inputFirstName.TabIndex = 4;
            this.inputFirstName.TextChanged += new System.EventHandler(this.inputFirstName_TextChanged);
            // 
            // inputLastName
            // 
            this.inputLastName.Location = new System.Drawing.Point(200, 100);
            this.inputLastName.Multiline = true;
            this.inputLastName.Name = "inputLastName";
            this.inputLastName.Size = new System.Drawing.Size(200, 25);
            this.inputLastName.TabIndex = 5;
            this.inputLastName.TextChanged += new System.EventHandler(this.inputLastName_TextChanged);
            // 
            // inputArticleOne
            // 
            this.inputArticleOne.Location = new System.Drawing.Point(200, 150);
            this.inputArticleOne.Multiline = true;
            this.inputArticleOne.Name = "inputArticleOne";
            this.inputArticleOne.Size = new System.Drawing.Size(200, 25);
            this.inputArticleOne.TabIndex = 6;
            this.inputArticleOne.TextChanged += new System.EventHandler(this.inputArticleOne_TextChanged);
            // 
            // inputArticleTwo
            // 
            this.inputArticleTwo.Location = new System.Drawing.Point(200, 200);
            this.inputArticleTwo.Multiline = true;
            this.inputArticleTwo.Name = "inputArticleTwo";
            this.inputArticleTwo.Size = new System.Drawing.Size(200, 25);
            this.inputArticleTwo.TabIndex = 7;
            this.inputArticleTwo.TextChanged += new System.EventHandler(this.inputArticleTwo_TextChanged);
            // 
            // lblQuantityArticleOne
            // 
            this.lblQuantityArticleOne.AutoSize = true;
            this.lblQuantityArticleOne.Location = new System.Drawing.Point(500, 150);
            this.lblQuantityArticleOne.Name = "lblQuantityArticleOne";
            this.lblQuantityArticleOne.Size = new System.Drawing.Size(63, 20);
            this.lblQuantityArticleOne.TabIndex = 8;
            this.lblQuantityArticleOne.Text = "Aantal :";
            // 
            // lblQuantityArticleTwo
            // 
            this.lblQuantityArticleTwo.AutoSize = true;
            this.lblQuantityArticleTwo.Location = new System.Drawing.Point(500, 200);
            this.lblQuantityArticleTwo.Name = "lblQuantityArticleTwo";
            this.lblQuantityArticleTwo.Size = new System.Drawing.Size(63, 20);
            this.lblQuantityArticleTwo.TabIndex = 9;
            this.lblQuantityArticleTwo.Text = "Aantal :";
            // 
            // inputQuantityArticleOne
            // 
            this.inputQuantityArticleOne.Location = new System.Drawing.Point(600, 150);
            this.inputQuantityArticleOne.Multiline = true;
            this.inputQuantityArticleOne.Name = "inputQuantityArticleOne";
            this.inputQuantityArticleOne.Size = new System.Drawing.Size(200, 25);
            this.inputQuantityArticleOne.TabIndex = 10;
            this.inputQuantityArticleOne.TextChanged += new System.EventHandler(this.inputQuantityArticleOne_TextChanged);
            // 
            // inputQuantityArticleTwo
            // 
            this.inputQuantityArticleTwo.Location = new System.Drawing.Point(600, 200);
            this.inputQuantityArticleTwo.Multiline = true;
            this.inputQuantityArticleTwo.Name = "inputQuantityArticleTwo";
            this.inputQuantityArticleTwo.Size = new System.Drawing.Size(200, 25);
            this.inputQuantityArticleTwo.TabIndex = 11;
            this.inputQuantityArticleTwo.TextChanged += new System.EventHandler(this.inputQuantityArticleTwo_TextChanged);
            // 
            // lblResultArticleOne
            // 
            this.lblResultArticleOne.AutoSize = true;
            this.lblResultArticleOne.Location = new System.Drawing.Point(850, 150);
            this.lblResultArticleOne.Name = "lblResultArticleOne";
            this.lblResultArticleOne.Size = new System.Drawing.Size(62, 20);
            this.lblResultArticleOne.TabIndex = 12;
            this.lblResultArticleOne.Text = " €13,58";
            this.lblResultArticleOne.Click += new System.EventHandler(this.lblResultArticleOne_Click);
            // 
            // lblResultArticleTwo
            // 
            this.lblResultArticleTwo.AutoSize = true;
            this.lblResultArticleTwo.Location = new System.Drawing.Point(850, 200);
            this.lblResultArticleTwo.Name = "lblResultArticleTwo";
            this.lblResultArticleTwo.Size = new System.Drawing.Size(58, 20);
            this.lblResultArticleTwo.TabIndex = 13;
            this.lblResultArticleTwo.Text = "€35.11";
            this.lblResultArticleTwo.Click += new System.EventHandler(this.lblResultArticleTwo_Click);
            // 
            // lblOutputCost
            // 
            this.lblOutputCost.BackColor = System.Drawing.SystemColors.AppWorkspace;
            this.lblOutputCost.Location = new System.Drawing.Point(150, 300);
            this.lblOutputCost.Name = "lblOutputCost";
            this.lblOutputCost.Size = new System.Drawing.Size(800, 300);
            this.lblOutputCost.TabIndex = 14;
            this.lblOutputCost.Click += new System.EventHandler(this.lblOutputCost_Click);
            // 
            // btnSubmit
            // 
            this.btnSubmit.Location = new System.Drawing.Point(400, 650);
            this.btnSubmit.Name = "btnSubmit";
            this.btnSubmit.Size = new System.Drawing.Size(100, 50);
            this.btnSubmit.TabIndex = 15;
            this.btnSubmit.Text = "Factuur";
            this.btnSubmit.UseVisualStyleBackColor = true;
            this.btnSubmit.Click += new System.EventHandler(this.btnSubmit_Click);
            // 
            // btnCancel
            // 
            this.btnCancel.Location = new System.Drawing.Point(600, 650);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(100, 50);
            this.btnCancel.TabIndex = 16;
            this.btnCancel.Text = "Back";
            this.btnCancel.UseVisualStyleBackColor = true;
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1096, 751);
            this.Controls.Add(this.btnCancel);
            this.Controls.Add(this.btnSubmit);
            this.Controls.Add(this.lblOutputCost);
            this.Controls.Add(this.lblResultArticleTwo);
            this.Controls.Add(this.lblResultArticleOne);
            this.Controls.Add(this.inputQuantityArticleTwo);
            this.Controls.Add(this.inputQuantityArticleOne);
            this.Controls.Add(this.lblQuantityArticleTwo);
            this.Controls.Add(this.lblQuantityArticleOne);
            this.Controls.Add(this.inputArticleTwo);
            this.Controls.Add(this.inputArticleOne);
            this.Controls.Add(this.inputLastName);
            this.Controls.Add(this.inputFirstName);
            this.Controls.Add(this.lblArticleTwo);
            this.Controls.Add(this.lblArticleOne);
            this.Controls.Add(this.lblLastName);
            this.Controls.Add(this.lblFirstName);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblFirstName;
        private System.Windows.Forms.Label lblLastName;
        private System.Windows.Forms.Label lblArticleOne;
        private System.Windows.Forms.Label lblArticleTwo;
        private System.Windows.Forms.TextBox inputFirstName;
        private System.Windows.Forms.TextBox inputLastName;
        private System.Windows.Forms.TextBox inputArticleOne;
        private System.Windows.Forms.TextBox inputArticleTwo;
        private System.Windows.Forms.Label lblQuantityArticleOne;
        private System.Windows.Forms.Label lblQuantityArticleTwo;
        private System.Windows.Forms.TextBox inputQuantityArticleOne;
        private System.Windows.Forms.TextBox inputQuantityArticleTwo;
        private System.Windows.Forms.Label lblResultArticleOne;
        private System.Windows.Forms.Label lblResultArticleTwo;
        private System.Windows.Forms.Label lblOutputCost;
        private System.Windows.Forms.Button btnSubmit;
        private System.Windows.Forms.Button btnCancel;
    }
}

