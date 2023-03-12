namespace Lab2Version.Registrera
{
    partial class LärareForm
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
            this.buttonRegistreraLärareTillKurs = new System.Windows.Forms.Button();
            this.labelPersNr = new System.Windows.Forms.Label();
            this.textBoxPersonNummer = new System.Windows.Forms.TextBox();
            this.buttonTillbaka = new System.Windows.Forms.Button();
            this.buttonTaBort = new System.Windows.Forms.Button();
            this.textBoxLärarID = new System.Windows.Forms.TextBox();
            this.labelLärarID = new System.Windows.Forms.Label();
            this.buttonUppdateraLärare = new System.Windows.Forms.Button();
            this.buttonRegistrera = new System.Windows.Forms.Button();
            this.lärarlistbox = new System.Windows.Forms.ListBox();
            this.textBoxNamn = new System.Windows.Forms.TextBox();
            this.labelLärarNamn = new System.Windows.Forms.Label();
            this.labelText = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // buttonRegistreraLärareTillKurs
            // 
            this.buttonRegistreraLärareTillKurs.Location = new System.Drawing.Point(22, 457);
            this.buttonRegistreraLärareTillKurs.Name = "buttonRegistreraLärareTillKurs";
            this.buttonRegistreraLärareTillKurs.Size = new System.Drawing.Size(419, 59);
            this.buttonRegistreraLärareTillKurs.TabIndex = 32;
            this.buttonRegistreraLärareTillKurs.Text = "Registrera Kurs";
            this.buttonRegistreraLärareTillKurs.UseVisualStyleBackColor = true;
            this.buttonRegistreraLärareTillKurs.Click += new System.EventHandler(this.buttonRegistreraLärareTillKurs_Click);
            // 
            // labelPersNr
            // 
            this.labelPersNr.AutoSize = true;
            this.labelPersNr.Location = new System.Drawing.Point(16, 198);
            this.labelPersNr.Name = "labelPersNr";
            this.labelPersNr.Size = new System.Drawing.Size(171, 32);
            this.labelPersNr.TabIndex = 30;
            this.labelPersNr.Text = "Per-nummer";
            // 
            // textBoxPersonNummer
            // 
            this.textBoxPersonNummer.Location = new System.Drawing.Point(218, 198);
            this.textBoxPersonNummer.Name = "textBoxPersonNummer";
            this.textBoxPersonNummer.Size = new System.Drawing.Size(252, 38);
            this.textBoxPersonNummer.TabIndex = 29;
            this.textBoxPersonNummer.TextChanged += new System.EventHandler(this.textBoxPersonNummer_TextChanged);
            // 
            // buttonTillbaka
            // 
            this.buttonTillbaka.Location = new System.Drawing.Point(22, 638);
            this.buttonTillbaka.Name = "buttonTillbaka";
            this.buttonTillbaka.Size = new System.Drawing.Size(419, 59);
            this.buttonTillbaka.TabIndex = 28;
            this.buttonTillbaka.Text = "Tillbaka";
            this.buttonTillbaka.UseVisualStyleBackColor = true;
            this.buttonTillbaka.Click += new System.EventHandler(this.buttonTillbaka_Click);
            // 
            // buttonTaBort
            // 
            this.buttonTaBort.Location = new System.Drawing.Point(519, 785);
            this.buttonTaBort.Name = "buttonTaBort";
            this.buttonTaBort.Size = new System.Drawing.Size(419, 59);
            this.buttonTaBort.TabIndex = 27;
            this.buttonTaBort.Text = "Ta Bort";
            this.buttonTaBort.UseVisualStyleBackColor = true;
            this.buttonTaBort.Click += new System.EventHandler(this.buttonTaBort_Click);
            // 
            // textBoxLärarID
            // 
            this.textBoxLärarID.Location = new System.Drawing.Point(218, 136);
            this.textBoxLärarID.Name = "textBoxLärarID";
            this.textBoxLärarID.Size = new System.Drawing.Size(252, 38);
            this.textBoxLärarID.TabIndex = 26;
            this.textBoxLärarID.TextChanged += new System.EventHandler(this.textBoxLärarID_TextChanged);
            // 
            // labelLärarID
            // 
            this.labelLärarID.AutoSize = true;
            this.labelLärarID.Location = new System.Drawing.Point(16, 142);
            this.labelLärarID.Name = "labelLärarID";
            this.labelLärarID.Size = new System.Drawing.Size(115, 32);
            this.labelLärarID.TabIndex = 24;
            this.labelLärarID.Text = "Lärar ID";
            // 
            // buttonUppdateraLärare
            // 
            this.buttonUppdateraLärare.Location = new System.Drawing.Point(22, 373);
            this.buttonUppdateraLärare.Name = "buttonUppdateraLärare";
            this.buttonUppdateraLärare.Size = new System.Drawing.Size(419, 59);
            this.buttonUppdateraLärare.TabIndex = 23;
            this.buttonUppdateraLärare.Text = "Updatera Lärare Lista";
            this.buttonUppdateraLärare.UseVisualStyleBackColor = true;
            this.buttonUppdateraLärare.Click += new System.EventHandler(this.buttonUppdateraLärare_Click);
            // 
            // buttonRegistrera
            // 
            this.buttonRegistrera.Location = new System.Drawing.Point(22, 290);
            this.buttonRegistrera.Name = "buttonRegistrera";
            this.buttonRegistrera.Size = new System.Drawing.Size(419, 59);
            this.buttonRegistrera.TabIndex = 22;
            this.buttonRegistrera.Text = "Lägg till ";
            this.buttonRegistrera.UseVisualStyleBackColor = true;
            this.buttonRegistrera.Click += new System.EventHandler(this.buttonRegistrera_Click);
            // 
            // lärarlistbox
            // 
            this.lärarlistbox.FormattingEnabled = true;
            this.lärarlistbox.ItemHeight = 31;
            this.lärarlistbox.Location = new System.Drawing.Point(519, 74);
            this.lärarlistbox.Name = "lärarlistbox";
            this.lärarlistbox.Size = new System.Drawing.Size(419, 624);
            this.lärarlistbox.TabIndex = 21;
            // 
            // textBoxNamn
            // 
            this.textBoxNamn.Location = new System.Drawing.Point(218, 77);
            this.textBoxNamn.Name = "textBoxNamn";
            this.textBoxNamn.Size = new System.Drawing.Size(252, 38);
            this.textBoxNamn.TabIndex = 20;
            this.textBoxNamn.TextChanged += new System.EventHandler(this.textBoxNamn_TextChanged);
            // 
            // labelLärarNamn
            // 
            this.labelLärarNamn.AutoSize = true;
            this.labelLärarNamn.Location = new System.Drawing.Point(16, 80);
            this.labelLärarNamn.Name = "labelLärarNamn";
            this.labelLärarNamn.Size = new System.Drawing.Size(163, 32);
            this.labelLärarNamn.TabIndex = 19;
            this.labelLärarNamn.Text = "Lärar Namn";
            // 
            // labelText
            // 
            this.labelText.AutoSize = true;
            this.labelText.Location = new System.Drawing.Point(513, 716);
            this.labelText.Name = "labelText";
            this.labelText.Size = new System.Drawing.Size(443, 32);
            this.labelText.TabIndex = 33;
            this.labelText.Text = "Markera lärare och tryck på ta bort";
            // 
            // LärareForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(16F, 31F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1077, 923);
            this.Controls.Add(this.labelText);
            this.Controls.Add(this.buttonRegistreraLärareTillKurs);
            this.Controls.Add(this.labelPersNr);
            this.Controls.Add(this.textBoxPersonNummer);
            this.Controls.Add(this.buttonTillbaka);
            this.Controls.Add(this.buttonTaBort);
            this.Controls.Add(this.textBoxLärarID);
            this.Controls.Add(this.labelLärarID);
            this.Controls.Add(this.buttonUppdateraLärare);
            this.Controls.Add(this.buttonRegistrera);
            this.Controls.Add(this.lärarlistbox);
            this.Controls.Add(this.textBoxNamn);
            this.Controls.Add(this.labelLärarNamn);
            this.Name = "LärareForm";
            this.Text = "Lärare";
            this.Load += new System.EventHandler(this.LärareForm_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button buttonRegistreraLärareTillKurs;
        private System.Windows.Forms.Label labelPersNr;
        private System.Windows.Forms.TextBox textBoxPersonNummer;
        private System.Windows.Forms.Button buttonTillbaka;
        private System.Windows.Forms.Button buttonTaBort;
        private System.Windows.Forms.TextBox textBoxLärarID;
        private System.Windows.Forms.Label labelLärarID;
        private System.Windows.Forms.Button buttonUppdateraLärare;
        private System.Windows.Forms.Button buttonRegistrera;
        private System.Windows.Forms.ListBox lärarlistbox;
        private System.Windows.Forms.TextBox textBoxNamn;
        private System.Windows.Forms.Label labelLärarNamn;
        private System.Windows.Forms.Label labelText;
    }
}