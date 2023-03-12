namespace Lab2Version.Registrera
{
    partial class LäggTillNyKurs
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
            this.textBoxKursID = new System.Windows.Forms.TextBox();
            this.labelKursID = new System.Windows.Forms.Label();
            this.textBoxNamn = new System.Windows.Forms.TextBox();
            this.labelKursNamn = new System.Windows.Forms.Label();
            this.listboxkurser = new System.Windows.Forms.ListBox();
            this.buttonUppdateraKurs = new System.Windows.Forms.Button();
            this.buttonLäggTIll = new System.Windows.Forms.Button();
            this.buttonTillbaka = new System.Windows.Forms.Button();
            this.buttonRegistreraUppgiftTillKurs = new System.Windows.Forms.Button();
            this.buttonTaBort = new System.Windows.Forms.Button();
            this.labelTaBort = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // textBoxKursID
            // 
            this.textBoxKursID.Location = new System.Drawing.Point(231, 105);
            this.textBoxKursID.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.textBoxKursID.Name = "textBoxKursID";
            this.textBoxKursID.Size = new System.Drawing.Size(253, 38);
            this.textBoxKursID.TabIndex = 16;
            this.textBoxKursID.TextChanged += new System.EventHandler(this.textBoxKursID_TextChanged);
            // 
            // labelKursID
            // 
            this.labelKursID.AutoSize = true;
            this.labelKursID.Location = new System.Drawing.Point(28, 112);
            this.labelKursID.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labelKursID.Name = "labelKursID";
            this.labelKursID.Size = new System.Drawing.Size(107, 32);
            this.labelKursID.TabIndex = 15;
            this.labelKursID.Text = "Kurs ID";
            // 
            // textBoxNamn
            // 
            this.textBoxNamn.Location = new System.Drawing.Point(231, 46);
            this.textBoxNamn.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.textBoxNamn.Name = "textBoxNamn";
            this.textBoxNamn.Size = new System.Drawing.Size(253, 38);
            this.textBoxNamn.TabIndex = 14;
            this.textBoxNamn.TextChanged += new System.EventHandler(this.textBoxNamn_TextChanged);
            // 
            // labelKursNamn
            // 
            this.labelKursNamn.AutoSize = true;
            this.labelKursNamn.Location = new System.Drawing.Point(28, 50);
            this.labelKursNamn.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labelKursNamn.Name = "labelKursNamn";
            this.labelKursNamn.Size = new System.Drawing.Size(148, 32);
            this.labelKursNamn.TabIndex = 13;
            this.labelKursNamn.Text = "KursNamn";
            // 
            // listboxkurser
            // 
            this.listboxkurser.FormattingEnabled = true;
            this.listboxkurser.ItemHeight = 31;
            this.listboxkurser.Location = new System.Drawing.Point(528, 50);
            this.listboxkurser.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.listboxkurser.Name = "listboxkurser";
            this.listboxkurser.Size = new System.Drawing.Size(418, 531);
            this.listboxkurser.TabIndex = 17;
            // 
            // buttonUppdateraKurs
            // 
            this.buttonUppdateraKurs.Location = new System.Drawing.Point(36, 271);
            this.buttonUppdateraKurs.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.buttonUppdateraKurs.Name = "buttonUppdateraKurs";
            this.buttonUppdateraKurs.Size = new System.Drawing.Size(420, 59);
            this.buttonUppdateraKurs.TabIndex = 19;
            this.buttonUppdateraKurs.Text = "Updatera Kurs Lista";
            this.buttonUppdateraKurs.UseVisualStyleBackColor = true;
            this.buttonUppdateraKurs.Click += new System.EventHandler(this.buttonUppdateraKurs_Click);
            // 
            // buttonLäggTIll
            // 
            this.buttonLäggTIll.Location = new System.Drawing.Point(36, 189);
            this.buttonLäggTIll.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.buttonLäggTIll.Name = "buttonLäggTIll";
            this.buttonLäggTIll.Size = new System.Drawing.Size(420, 59);
            this.buttonLäggTIll.TabIndex = 18;
            this.buttonLäggTIll.Text = "Lägg till ";
            this.buttonLäggTIll.UseVisualStyleBackColor = true;
            this.buttonLäggTIll.Click += new System.EventHandler(this.buttonLäggTIll_Click);
            // 
            // buttonTillbaka
            // 
            this.buttonTillbaka.Location = new System.Drawing.Point(36, 522);
            this.buttonTillbaka.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.buttonTillbaka.Name = "buttonTillbaka";
            this.buttonTillbaka.Size = new System.Drawing.Size(420, 59);
            this.buttonTillbaka.TabIndex = 20;
            this.buttonTillbaka.Text = "Tillbaka";
            this.buttonTillbaka.UseVisualStyleBackColor = true;
            this.buttonTillbaka.Click += new System.EventHandler(this.buttonTillbaka_Click);
            // 
            // buttonRegistreraUppgiftTillKurs
            // 
            this.buttonRegistreraUppgiftTillKurs.Location = new System.Drawing.Point(36, 353);
            this.buttonRegistreraUppgiftTillKurs.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.buttonRegistreraUppgiftTillKurs.Name = "buttonRegistreraUppgiftTillKurs";
            this.buttonRegistreraUppgiftTillKurs.Size = new System.Drawing.Size(420, 59);
            this.buttonRegistreraUppgiftTillKurs.TabIndex = 21;
            this.buttonRegistreraUppgiftTillKurs.Text = "Registrera Uppgift";
            this.buttonRegistreraUppgiftTillKurs.UseVisualStyleBackColor = true;
            this.buttonRegistreraUppgiftTillKurs.Click += new System.EventHandler(this.buttonRegistreraUppgiftTillKurs_Click);
            // 
            // buttonTaBort
            // 
            this.buttonTaBort.Location = new System.Drawing.Point(528, 709);
            this.buttonTaBort.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.buttonTaBort.Name = "buttonTaBort";
            this.buttonTaBort.Size = new System.Drawing.Size(251, 59);
            this.buttonTaBort.TabIndex = 23;
            this.buttonTaBort.Text = "Ta Bort";
            this.buttonTaBort.UseVisualStyleBackColor = true;
            this.buttonTaBort.Click += new System.EventHandler(this.buttonTaBort_Click);
            // 
            // labelTaBort
            // 
            this.labelTaBort.AutoSize = true;
            this.labelTaBort.Location = new System.Drawing.Point(523, 635);
            this.labelTaBort.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labelTaBort.Name = "labelTaBort";
            this.labelTaBort.Size = new System.Drawing.Size(421, 32);
            this.labelTaBort.TabIndex = 22;
            this.labelTaBort.Text = "Markera kurs och tryck på knapp";
            // 
            // LäggTillNyKurs
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(16F, 31F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(969, 835);
            this.Controls.Add(this.buttonTaBort);
            this.Controls.Add(this.labelTaBort);
            this.Controls.Add(this.buttonRegistreraUppgiftTillKurs);
            this.Controls.Add(this.buttonTillbaka);
            this.Controls.Add(this.buttonUppdateraKurs);
            this.Controls.Add(this.buttonLäggTIll);
            this.Controls.Add(this.listboxkurser);
            this.Controls.Add(this.textBoxKursID);
            this.Controls.Add(this.labelKursID);
            this.Controls.Add(this.textBoxNamn);
            this.Controls.Add(this.labelKursNamn);
            this.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.Name = "LäggTillNyKurs";
            this.Text = "LäggTillNyKurs";
            this.Load += new System.EventHandler(this.LäggTillNyKurs_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox textBoxKursID;
        private System.Windows.Forms.Label labelKursID;
        private System.Windows.Forms.TextBox textBoxNamn;
        private System.Windows.Forms.Label labelKursNamn;
        private System.Windows.Forms.ListBox listboxkurser;
        private System.Windows.Forms.Button buttonUppdateraKurs;
        private System.Windows.Forms.Button buttonLäggTIll;
        private System.Windows.Forms.Button buttonTillbaka;
        private System.Windows.Forms.Button buttonRegistreraUppgiftTillKurs;
        private System.Windows.Forms.Button buttonTaBort;
        private System.Windows.Forms.Label labelTaBort;
    }
}