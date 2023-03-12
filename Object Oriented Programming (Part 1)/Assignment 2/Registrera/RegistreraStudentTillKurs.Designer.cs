namespace Lab2Version.Registrera
{
    partial class RegistreraStudentTillKurs
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
            this.buttonRegistrera = new System.Windows.Forms.Button();
            this.textBoxKursNamn = new System.Windows.Forms.TextBox();
            this.labelKursNamn = new System.Windows.Forms.Label();
            this.studenter = new System.Windows.Forms.ListBox();
            this.buttonTillbaka = new System.Windows.Forms.Button();
            this.kurser = new System.Windows.Forms.ListBox();
            this.buttonVisaStudenter = new System.Windows.Forms.Button();
            this.buttonVisaKurser = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // textBoxStudentID
            // 
            this.textBoxStudentID.Location = new System.Drawing.Point(245, 150);
            this.textBoxStudentID.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.textBoxStudentID.Name = "textBoxStudentID";
            this.textBoxStudentID.Size = new System.Drawing.Size(253, 38);
            this.textBoxStudentID.TabIndex = 20;
            this.textBoxStudentID.TextChanged += new System.EventHandler(this.textBoxStudentID_TextChanged);
            // 
            // labelStudentID
            // 
            this.labelStudentID.AutoSize = true;
            this.labelStudentID.Location = new System.Drawing.Point(43, 150);
            this.labelStudentID.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labelStudentID.Name = "labelStudentID";
            this.labelStudentID.Size = new System.Drawing.Size(148, 32);
            this.labelStudentID.TabIndex = 19;
            this.labelStudentID.Text = "Student ID";
            // 
            // buttonRegistrera
            // 
            this.buttonRegistrera.Location = new System.Drawing.Point(517, 108);
            this.buttonRegistrera.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.buttonRegistrera.Name = "buttonRegistrera";
            this.buttonRegistrera.Size = new System.Drawing.Size(448, 59);
            this.buttonRegistrera.TabIndex = 17;
            this.buttonRegistrera.Text = "Registrera";
            this.buttonRegistrera.UseVisualStyleBackColor = true;
            this.buttonRegistrera.Click += new System.EventHandler(this.buttonRegistrera_Click);
            // 
            // textBoxKursNamn
            // 
            this.textBoxKursNamn.Location = new System.Drawing.Point(245, 85);
            this.textBoxKursNamn.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.textBoxKursNamn.Name = "textBoxKursNamn";
            this.textBoxKursNamn.Size = new System.Drawing.Size(253, 38);
            this.textBoxKursNamn.TabIndex = 15;
            this.textBoxKursNamn.TextChanged += new System.EventHandler(this.textBoxKursNamn_TextChanged);
            // 
            // labelKursNamn
            // 
            this.labelKursNamn.AutoSize = true;
            this.labelKursNamn.Location = new System.Drawing.Point(43, 88);
            this.labelKursNamn.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labelKursNamn.Name = "labelKursNamn";
            this.labelKursNamn.Size = new System.Drawing.Size(151, 32);
            this.labelKursNamn.TabIndex = 14;
            this.labelKursNamn.Text = "Kurs namn";
            // 
            // studenter
            // 
            this.studenter.FormattingEnabled = true;
            this.studenter.ItemHeight = 31;
            this.studenter.Location = new System.Drawing.Point(50, 246);
            this.studenter.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.studenter.Name = "studenter";
            this.studenter.Size = new System.Drawing.Size(448, 376);
            this.studenter.TabIndex = 21;
            this.studenter.SelectedIndexChanged += new System.EventHandler(this.studenter_SelectedIndexChanged);
            // 
            // buttonTillbaka
            // 
            this.buttonTillbaka.Location = new System.Drawing.Point(294, 746);
            this.buttonTillbaka.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.buttonTillbaka.Name = "buttonTillbaka";
            this.buttonTillbaka.Size = new System.Drawing.Size(420, 59);
            this.buttonTillbaka.TabIndex = 22;
            this.buttonTillbaka.Text = "Tillbaka";
            this.buttonTillbaka.UseVisualStyleBackColor = true;
            this.buttonTillbaka.Click += new System.EventHandler(this.buttonTillbaka_Click);
            // 
            // kurser
            // 
            this.kurser.FormattingEnabled = true;
            this.kurser.ItemHeight = 31;
            this.kurser.Location = new System.Drawing.Point(517, 246);
            this.kurser.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.kurser.Name = "kurser";
            this.kurser.Size = new System.Drawing.Size(448, 376);
            this.kurser.TabIndex = 23;
            this.kurser.SelectedIndexChanged += new System.EventHandler(this.kurser_SelectedIndexChanged);
            // 
            // buttonVisaStudenter
            // 
            this.buttonVisaStudenter.Location = new System.Drawing.Point(50, 653);
            this.buttonVisaStudenter.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.buttonVisaStudenter.Name = "buttonVisaStudenter";
            this.buttonVisaStudenter.Size = new System.Drawing.Size(448, 59);
            this.buttonVisaStudenter.TabIndex = 24;
            this.buttonVisaStudenter.Text = "Visa studenter";
            this.buttonVisaStudenter.UseVisualStyleBackColor = true;
            this.buttonVisaStudenter.Click += new System.EventHandler(this.buttonVisaStudenter_Click);
            // 
            // buttonVisaKurser
            // 
            this.buttonVisaKurser.Location = new System.Drawing.Point(517, 653);
            this.buttonVisaKurser.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.buttonVisaKurser.Name = "buttonVisaKurser";
            this.buttonVisaKurser.Size = new System.Drawing.Size(448, 59);
            this.buttonVisaKurser.TabIndex = 25;
            this.buttonVisaKurser.Text = "Visa Kurser";
            this.buttonVisaKurser.UseVisualStyleBackColor = true;
            this.buttonVisaKurser.Click += new System.EventHandler(this.buttonVisaKurser_Click);
            // 
            // RegistreraStudentTillKurs
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(16F, 31F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1058, 971);
            this.Controls.Add(this.buttonVisaKurser);
            this.Controls.Add(this.buttonVisaStudenter);
            this.Controls.Add(this.kurser);
            this.Controls.Add(this.buttonTillbaka);
            this.Controls.Add(this.studenter);
            this.Controls.Add(this.textBoxStudentID);
            this.Controls.Add(this.labelStudentID);
            this.Controls.Add(this.buttonRegistrera);
            this.Controls.Add(this.textBoxKursNamn);
            this.Controls.Add(this.labelKursNamn);
            this.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.Name = "RegistreraStudentTillKurs";
            this.Text = "RegistreraKurs";
            this.Load += new System.EventHandler(this.RegistreraStudentTillKurs_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox textBoxStudentID;
        private System.Windows.Forms.Label labelStudentID;
        private System.Windows.Forms.Button buttonRegistrera;
        private System.Windows.Forms.TextBox textBoxKursNamn;
        private System.Windows.Forms.Label labelKursNamn;
        private System.Windows.Forms.ListBox studenter;
        private System.Windows.Forms.Button buttonTillbaka;
        private System.Windows.Forms.ListBox kurser;
        private System.Windows.Forms.Button buttonVisaStudenter;
        private System.Windows.Forms.Button buttonVisaKurser;
    }
}