namespace Lab2Version.Registrera
{
    partial class Betygssättning
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
            this.textBoxStudentID = new System.Windows.Forms.TextBox();
            this.labelStudentID = new System.Windows.Forms.Label();
            this.listBoxUppgifter = new System.Windows.Forms.ListBox();
            this.textBoxUpgNamn = new System.Windows.Forms.TextBox();
            this.labelUppgiftNamn = new System.Windows.Forms.Label();
            this.textBoxBetyg = new System.Windows.Forms.TextBox();
            this.labelSättBetyg = new System.Windows.Forms.Label();
            this.buttonSättBetyg = new System.Windows.Forms.Button();
            this.listBoxStudenter = new System.Windows.Forms.ListBox();
            this.buttonUppdatera = new System.Windows.Forms.Button();
            this.buttonExit = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // textBoxStudentID
            // 
            this.textBoxStudentID.Location = new System.Drawing.Point(252, 49);
            this.textBoxStudentID.Name = "textBoxStudentID";
            this.textBoxStudentID.Size = new System.Drawing.Size(317, 38);
            this.textBoxStudentID.TabIndex = 6;
            this.textBoxStudentID.TextChanged += new System.EventHandler(this.textBoxStudentID_TextChanged);
            // 
            // labelStudentID
            // 
            this.labelStudentID.AutoSize = true;
            this.labelStudentID.Location = new System.Drawing.Point(28, 52);
            this.labelStudentID.Name = "labelStudentID";
            this.labelStudentID.Size = new System.Drawing.Size(148, 32);
            this.labelStudentID.TabIndex = 5;
            this.labelStudentID.Text = "Student ID";
            // 
            // listBoxUppgifter
            // 
            this.listBoxUppgifter.FormattingEnabled = true;
            this.listBoxUppgifter.ItemHeight = 31;
            this.listBoxUppgifter.Location = new System.Drawing.Point(1065, 52);
            this.listBoxUppgifter.Name = "listBoxUppgifter";
            this.listBoxUppgifter.Size = new System.Drawing.Size(389, 686);
            this.listBoxUppgifter.TabIndex = 4;
            // 
            // textBoxUpgNamn
            // 
            this.textBoxUpgNamn.Location = new System.Drawing.Point(252, 128);
            this.textBoxUpgNamn.Name = "textBoxUpgNamn";
            this.textBoxUpgNamn.Size = new System.Drawing.Size(317, 38);
            this.textBoxUpgNamn.TabIndex = 8;
            this.textBoxUpgNamn.TextChanged += new System.EventHandler(this.textBoxUpgNamn_TextChanged);
            // 
            // labelUppgiftNamn
            // 
            this.labelUppgiftNamn.AutoSize = true;
            this.labelUppgiftNamn.Location = new System.Drawing.Point(28, 131);
            this.labelUppgiftNamn.Name = "labelUppgiftNamn";
            this.labelUppgiftNamn.Size = new System.Drawing.Size(202, 32);
            this.labelUppgiftNamn.TabIndex = 7;
            this.labelUppgiftNamn.Text = "Uppgifts Namn";
            // 
            // textBoxBetyg
            // 
            this.textBoxBetyg.Location = new System.Drawing.Point(252, 210);
            this.textBoxBetyg.Name = "textBoxBetyg";
            this.textBoxBetyg.Size = new System.Drawing.Size(317, 38);
            this.textBoxBetyg.TabIndex = 10;
            this.textBoxBetyg.TextChanged += new System.EventHandler(this.textBoxBetyg_TextChanged);
            // 
            // labelSättBetyg
            // 
            this.labelSättBetyg.AutoSize = true;
            this.labelSättBetyg.Location = new System.Drawing.Point(28, 213);
            this.labelSättBetyg.Name = "labelSättBetyg";
            this.labelSättBetyg.Size = new System.Drawing.Size(88, 32);
            this.labelSättBetyg.TabIndex = 9;
            this.labelSättBetyg.Text = "Betyg";
            // 
            // buttonSättBetyg
            // 
            this.buttonSättBetyg.Location = new System.Drawing.Point(252, 278);
            this.buttonSättBetyg.Name = "buttonSättBetyg";
            this.buttonSättBetyg.Size = new System.Drawing.Size(255, 75);
            this.buttonSättBetyg.TabIndex = 11;
            this.buttonSättBetyg.Text = "Sätt Betyg";
            this.buttonSättBetyg.UseVisualStyleBackColor = true;
            this.buttonSättBetyg.Click += new System.EventHandler(this.buttonSättBetyg_Click);
            // 
            // listBoxStudenter
            // 
            this.listBoxStudenter.FormattingEnabled = true;
            this.listBoxStudenter.ItemHeight = 31;
            this.listBoxStudenter.Location = new System.Drawing.Point(632, 52);
            this.listBoxStudenter.Name = "listBoxStudenter";
            this.listBoxStudenter.Size = new System.Drawing.Size(389, 686);
            this.listBoxStudenter.TabIndex = 12;
            this.listBoxStudenter.SelectedIndexChanged += new System.EventHandler(this.listBoxStudenter_SelectedIndexChanged);
            // 
            // buttonUppdatera
            // 
            this.buttonUppdatera.Location = new System.Drawing.Point(252, 394);
            this.buttonUppdatera.Name = "buttonUppdatera";
            this.buttonUppdatera.Size = new System.Drawing.Size(255, 75);
            this.buttonUppdatera.TabIndex = 13;
            this.buttonUppdatera.Text = "Uppdatera";
            this.buttonUppdatera.UseVisualStyleBackColor = true;
            this.buttonUppdatera.Click += new System.EventHandler(this.buttonUppdatera_Click);
            // 
            // buttonExit
            // 
            this.buttonExit.Location = new System.Drawing.Point(252, 663);
            this.buttonExit.Name = "buttonExit";
            this.buttonExit.Size = new System.Drawing.Size(255, 75);
            this.buttonExit.TabIndex = 14;
            this.buttonExit.Text = "Tillbaka";
            this.buttonExit.UseVisualStyleBackColor = true;
            this.buttonExit.Click += new System.EventHandler(this.buttonExit_Click);
            // 
            // Betygssättning
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(16F, 31F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1787, 994);
            this.Controls.Add(this.buttonExit);
            this.Controls.Add(this.buttonUppdatera);
            this.Controls.Add(this.listBoxStudenter);
            this.Controls.Add(this.buttonSättBetyg);
            this.Controls.Add(this.textBoxBetyg);
            this.Controls.Add(this.labelSättBetyg);
            this.Controls.Add(this.textBoxUpgNamn);
            this.Controls.Add(this.labelUppgiftNamn);
            this.Controls.Add(this.textBoxStudentID);
            this.Controls.Add(this.labelStudentID);
            this.Controls.Add(this.listBoxUppgifter);
            this.Name = "Betygssättning";
            this.Text = "Betygssättning";
            this.Load += new System.EventHandler(this.Betygssättning_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox textBoxStudentID;
        private System.Windows.Forms.Label labelStudentID;
        private System.Windows.Forms.ListBox listBoxUppgifter;
        private System.Windows.Forms.TextBox textBoxUpgNamn;
        private System.Windows.Forms.Label labelUppgiftNamn;
        private System.Windows.Forms.TextBox textBoxBetyg;
        private System.Windows.Forms.Label labelSättBetyg;
        private System.Windows.Forms.Button buttonSättBetyg;
        private System.Windows.Forms.ListBox listBoxStudenter;
        private System.Windows.Forms.Button buttonUppdatera;
        private System.Windows.Forms.Button buttonExit;
    }
}