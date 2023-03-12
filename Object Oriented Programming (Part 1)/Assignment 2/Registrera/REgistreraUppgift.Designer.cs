namespace Lab2Version.Registrera
{
    partial class RegistreraUppgift
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
            this.listBoxUppgifter = new System.Windows.Forms.ListBox();
            this.labelKursNamn = new System.Windows.Forms.Label();
            this.buttonRegistreraUppgift = new System.Windows.Forms.Button();
            this.textBoxUppgiftNamn = new System.Windows.Forms.TextBox();
            this.buttonSättBetyg = new System.Windows.Forms.Button();
            this.buttonTaBortUppgift = new System.Windows.Forms.Button();
            this.buttonVisaUppgifter = new System.Windows.Forms.Button();
            this.labelText = new System.Windows.Forms.Label();
            this.buttonTillbaka = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // listBoxUppgifter
            // 
            this.listBoxUppgifter.FormattingEnabled = true;
            this.listBoxUppgifter.ItemHeight = 31;
            this.listBoxUppgifter.Location = new System.Drawing.Point(640, 91);
            this.listBoxUppgifter.Name = "listBoxUppgifter";
            this.listBoxUppgifter.Size = new System.Drawing.Size(389, 686);
            this.listBoxUppgifter.TabIndex = 0;
            // 
            // labelKursNamn
            // 
            this.labelKursNamn.AutoSize = true;
            this.labelKursNamn.Location = new System.Drawing.Point(41, 112);
            this.labelKursNamn.Name = "labelKursNamn";
            this.labelKursNamn.Size = new System.Drawing.Size(202, 32);
            this.labelKursNamn.TabIndex = 1;
            this.labelKursNamn.Text = "Uppgifts Namn";
            // 
            // buttonRegistreraUppgift
            // 
            this.buttonRegistreraUppgift.Location = new System.Drawing.Point(265, 183);
            this.buttonRegistreraUppgift.Name = "buttonRegistreraUppgift";
            this.buttonRegistreraUppgift.Size = new System.Drawing.Size(255, 75);
            this.buttonRegistreraUppgift.TabIndex = 2;
            this.buttonRegistreraUppgift.Text = "Registrera Uppgift";
            this.buttonRegistreraUppgift.UseVisualStyleBackColor = true;
            this.buttonRegistreraUppgift.Click += new System.EventHandler(this.buttonRegistreraUppgift_Click);
            // 
            // textBoxUppgiftNamn
            // 
            this.textBoxUppgiftNamn.Location = new System.Drawing.Point(265, 109);
            this.textBoxUppgiftNamn.Name = "textBoxUppgiftNamn";
            this.textBoxUppgiftNamn.Size = new System.Drawing.Size(317, 38);
            this.textBoxUppgiftNamn.TabIndex = 3;
            this.textBoxUppgiftNamn.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // buttonSättBetyg
            // 
            this.buttonSättBetyg.Location = new System.Drawing.Point(265, 399);
            this.buttonSättBetyg.Name = "buttonSättBetyg";
            this.buttonSättBetyg.Size = new System.Drawing.Size(255, 75);
            this.buttonSättBetyg.TabIndex = 4;
            this.buttonSättBetyg.Text = "Sätt Betyg";
            this.buttonSättBetyg.UseVisualStyleBackColor = true;
            this.buttonSättBetyg.Click += new System.EventHandler(this.buttonSättBetyg_Click);
            // 
            // buttonTaBortUppgift
            // 
            this.buttonTaBortUppgift.Location = new System.Drawing.Point(265, 566);
            this.buttonTaBortUppgift.Name = "buttonTaBortUppgift";
            this.buttonTaBortUppgift.Size = new System.Drawing.Size(255, 75);
            this.buttonTaBortUppgift.TabIndex = 5;
            this.buttonTaBortUppgift.Text = "Ta Bort Uppgift";
            this.buttonTaBortUppgift.UseVisualStyleBackColor = true;
            this.buttonTaBortUppgift.Click += new System.EventHandler(this.buttonTaBortUppgift_Click);
            // 
            // buttonVisaUppgifter
            // 
            this.buttonVisaUppgifter.Location = new System.Drawing.Point(265, 284);
            this.buttonVisaUppgifter.Name = "buttonVisaUppgifter";
            this.buttonVisaUppgifter.Size = new System.Drawing.Size(255, 75);
            this.buttonVisaUppgifter.TabIndex = 6;
            this.buttonVisaUppgifter.Text = "Visa Uppgifter";
            this.buttonVisaUppgifter.UseVisualStyleBackColor = true;
            this.buttonVisaUppgifter.Click += new System.EventHandler(this.buttonVisaUppgifter_Click);
            // 
            // labelText
            // 
            this.labelText.AutoSize = true;
            this.labelText.Location = new System.Drawing.Point(78, 502);
            this.labelText.Name = "labelText";
            this.labelText.Size = new System.Drawing.Size(457, 32);
            this.labelText.TabIndex = 34;
            this.labelText.Text = "Markera uppgift och tryck på ta bort";
            // 
            // buttonTillbaka
            // 
            this.buttonTillbaka.Location = new System.Drawing.Point(265, 702);
            this.buttonTillbaka.Name = "buttonTillbaka";
            this.buttonTillbaka.Size = new System.Drawing.Size(255, 75);
            this.buttonTillbaka.TabIndex = 35;
            this.buttonTillbaka.Text = "Tillbaka";
            this.buttonTillbaka.UseVisualStyleBackColor = true;
            this.buttonTillbaka.Click += new System.EventHandler(this.buttonTillbaka_Click);
            // 
            // RegistreraUppgift
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(16F, 31F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1308, 1041);
            this.Controls.Add(this.buttonTillbaka);
            this.Controls.Add(this.labelText);
            this.Controls.Add(this.buttonVisaUppgifter);
            this.Controls.Add(this.buttonTaBortUppgift);
            this.Controls.Add(this.buttonSättBetyg);
            this.Controls.Add(this.textBoxUppgiftNamn);
            this.Controls.Add(this.buttonRegistreraUppgift);
            this.Controls.Add(this.labelKursNamn);
            this.Controls.Add(this.listBoxUppgifter);
            this.Name = "RegistreraUppgift";
            this.Text = "RegistreraUppgift";
            this.Load += new System.EventHandler(this.RegistreraUppgift_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListBox listBoxUppgifter;
        private System.Windows.Forms.Label labelKursNamn;
        private System.Windows.Forms.Button buttonRegistreraUppgift;
        private System.Windows.Forms.TextBox textBoxUppgiftNamn;
        private System.Windows.Forms.Button buttonSättBetyg;
        private System.Windows.Forms.Button buttonTaBortUppgift;
        private System.Windows.Forms.Button buttonVisaUppgifter;
        private System.Windows.Forms.Label labelText;
        private System.Windows.Forms.Button buttonTillbaka;
    }
}