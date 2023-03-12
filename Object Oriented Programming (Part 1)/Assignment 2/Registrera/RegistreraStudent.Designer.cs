namespace Lab2Version
{
    partial class RegistreraStudent
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
            this.labelStudentNamn = new System.Windows.Forms.Label();
            this.textBoxNamn = new System.Windows.Forms.TextBox();
            this.buttonRegistrera = new System.Windows.Forms.Button();
            this.buttonUppdateraStudent = new System.Windows.Forms.Button();
            this.labelStudentID = new System.Windows.Forms.Label();
            this.textBoxStudentID = new System.Windows.Forms.TextBox();
            this.buttonTaBort = new System.Windows.Forms.Button();
            this.buttonTillbaka = new System.Windows.Forms.Button();
            this.textBoxPersonNummer = new System.Windows.Forms.TextBox();
            this.labelPersNr = new System.Windows.Forms.Label();
            this.buttonRegistreraStudentTillKurs = new System.Windows.Forms.Button();
            this.labelText = new System.Windows.Forms.Label();
            this.studenter = new System.Windows.Forms.ListBox();
            this.SuspendLayout();
            // 
            // labelStudentNamn
            // 
            this.labelStudentNamn.AutoSize = true;
            this.labelStudentNamn.Location = new System.Drawing.Point(21, 65);
            this.labelStudentNamn.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labelStudentNamn.Name = "labelStudentNamn";
            this.labelStudentNamn.Size = new System.Drawing.Size(196, 32);
            this.labelStudentNamn.TabIndex = 0;
            this.labelStudentNamn.Text = "Student Namn";
            // 
            // textBoxNamn
            // 
            this.textBoxNamn.Location = new System.Drawing.Point(224, 62);
            this.textBoxNamn.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.textBoxNamn.Name = "textBoxNamn";
            this.textBoxNamn.Size = new System.Drawing.Size(253, 38);
            this.textBoxNamn.TabIndex = 1;
            this.textBoxNamn.TextChanged += new System.EventHandler(this.textBoxNamn_TextChanged);
            // 
            // buttonRegistrera
            // 
            this.buttonRegistrera.Location = new System.Drawing.Point(57, 263);
            this.buttonRegistrera.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.buttonRegistrera.Name = "buttonRegistrera";
            this.buttonRegistrera.Size = new System.Drawing.Size(420, 59);
            this.buttonRegistrera.TabIndex = 6;
            this.buttonRegistrera.Text = "Lägg till ";
            this.buttonRegistrera.UseVisualStyleBackColor = true;
            this.buttonRegistrera.Click += new System.EventHandler(this.buttonRegistrera_Click);
            // 
            // buttonUppdateraStudent
            // 
            this.buttonUppdateraStudent.Location = new System.Drawing.Point(57, 346);
            this.buttonUppdateraStudent.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.buttonUppdateraStudent.Name = "buttonUppdateraStudent";
            this.buttonUppdateraStudent.Size = new System.Drawing.Size(420, 59);
            this.buttonUppdateraStudent.TabIndex = 7;
            this.buttonUppdateraStudent.Text = "Updatera Student Lista";
            this.buttonUppdateraStudent.UseVisualStyleBackColor = true;
            this.buttonUppdateraStudent.Click += new System.EventHandler(this.buttonUppdateraStudent_Click);
            // 
            // labelStudentID
            // 
            this.labelStudentID.AutoSize = true;
            this.labelStudentID.Location = new System.Drawing.Point(21, 127);
            this.labelStudentID.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labelStudentID.Name = "labelStudentID";
            this.labelStudentID.Size = new System.Drawing.Size(148, 32);
            this.labelStudentID.TabIndex = 9;
            this.labelStudentID.Text = "Student ID";
            // 
            // textBoxStudentID
            // 
            this.textBoxStudentID.Location = new System.Drawing.Point(224, 121);
            this.textBoxStudentID.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.textBoxStudentID.Name = "textBoxStudentID";
            this.textBoxStudentID.Size = new System.Drawing.Size(253, 38);
            this.textBoxStudentID.TabIndex = 12;
            this.textBoxStudentID.TextChanged += new System.EventHandler(this.textBoxStudentID_TextChanged);
            // 
            // buttonTaBort
            // 
            this.buttonTaBort.Location = new System.Drawing.Point(540, 742);
            this.buttonTaBort.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.buttonTaBort.Name = "buttonTaBort";
            this.buttonTaBort.Size = new System.Drawing.Size(420, 59);
            this.buttonTaBort.TabIndex = 13;
            this.buttonTaBort.Text = "Ta Bort";
            this.buttonTaBort.UseVisualStyleBackColor = true;
            this.buttonTaBort.Click += new System.EventHandler(this.buttonTaBort_Click);
            // 
            // buttonTillbaka
            // 
            this.buttonTillbaka.Location = new System.Drawing.Point(57, 742);
            this.buttonTillbaka.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.buttonTillbaka.Name = "buttonTillbaka";
            this.buttonTillbaka.Size = new System.Drawing.Size(420, 59);
            this.buttonTillbaka.TabIndex = 14;
            this.buttonTillbaka.Text = "Tillbaka";
            this.buttonTillbaka.UseVisualStyleBackColor = true;
            this.buttonTillbaka.Click += new System.EventHandler(this.buttonTillbaka_Click);
            // 
            // textBoxPersonNummer
            // 
            this.textBoxPersonNummer.Location = new System.Drawing.Point(224, 183);
            this.textBoxPersonNummer.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.textBoxPersonNummer.Name = "textBoxPersonNummer";
            this.textBoxPersonNummer.Size = new System.Drawing.Size(253, 38);
            this.textBoxPersonNummer.TabIndex = 15;
            this.textBoxPersonNummer.TextChanged += new System.EventHandler(this.textBoxPersonNummer_TextChanged);
            // 
            // labelPersNr
            // 
            this.labelPersNr.AutoSize = true;
            this.labelPersNr.Location = new System.Drawing.Point(21, 183);
            this.labelPersNr.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labelPersNr.Name = "labelPersNr";
            this.labelPersNr.Size = new System.Drawing.Size(171, 32);
            this.labelPersNr.TabIndex = 16;
            this.labelPersNr.Text = "Per-nummer";
            // 
            // buttonRegistreraStudentTillKurs
            // 
            this.buttonRegistreraStudentTillKurs.Location = new System.Drawing.Point(57, 429);
            this.buttonRegistreraStudentTillKurs.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.buttonRegistreraStudentTillKurs.Name = "buttonRegistreraStudentTillKurs";
            this.buttonRegistreraStudentTillKurs.Size = new System.Drawing.Size(420, 59);
            this.buttonRegistreraStudentTillKurs.TabIndex = 18;
            this.buttonRegistreraStudentTillKurs.Text = "Registrera Kurs";
            this.buttonRegistreraStudentTillKurs.UseVisualStyleBackColor = true;
            this.buttonRegistreraStudentTillKurs.Click += new System.EventHandler(this.buttonRegistreraStudentTillKurs_Click);
            // 
            // labelText
            // 
            this.labelText.AutoSize = true;
            this.labelText.Location = new System.Drawing.Point(533, 687);
            this.labelText.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labelText.Name = "labelText";
            this.labelText.Size = new System.Drawing.Size(464, 32);
            this.labelText.TabIndex = 34;
            this.labelText.Text = "Markera student och tryck på ta bort";
            // 
            // studenter
            // 
            this.studenter.FormattingEnabled = true;
            this.studenter.ItemHeight = 31;
            this.studenter.Location = new System.Drawing.Point(540, 62);
            this.studenter.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.studenter.Name = "studenter";
            this.studenter.Size = new System.Drawing.Size(418, 593);
            this.studenter.TabIndex = 2;
            this.studenter.SelectedIndexChanged += new System.EventHandler(this.studenter_SelectedIndexChanged);
            // 
            // RegistreraStudent
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(16F, 31F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1117, 883);
            this.Controls.Add(this.labelText);
            this.Controls.Add(this.buttonRegistreraStudentTillKurs);
            this.Controls.Add(this.labelPersNr);
            this.Controls.Add(this.textBoxPersonNummer);
            this.Controls.Add(this.buttonTillbaka);
            this.Controls.Add(this.buttonTaBort);
            this.Controls.Add(this.textBoxStudentID);
            this.Controls.Add(this.labelStudentID);
            this.Controls.Add(this.buttonUppdateraStudent);
            this.Controls.Add(this.buttonRegistrera);
            this.Controls.Add(this.studenter);
            this.Controls.Add(this.textBoxNamn);
            this.Controls.Add(this.labelStudentNamn);
            this.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.Name = "RegistreraStudent";
            this.Text = "Registrera Student";
            this.Load += new System.EventHandler(this.RegistreraStudent_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label labelStudentNamn;
        private System.Windows.Forms.TextBox textBoxNamn;
        private System.Windows.Forms.Button buttonRegistrera;
        private System.Windows.Forms.Button buttonUppdateraStudent;
        private System.Windows.Forms.Label labelStudentID;
        private System.Windows.Forms.TextBox textBoxStudentID;
        private System.Windows.Forms.Button buttonTaBort;
        private System.Windows.Forms.Button buttonTillbaka;
        private System.Windows.Forms.TextBox textBoxPersonNummer;
        private System.Windows.Forms.Label labelPersNr;
        private System.Windows.Forms.Button buttonRegistreraStudentTillKurs;
        private System.Windows.Forms.Label labelText;
        private System.Windows.Forms.ListBox studenter;
    }
}