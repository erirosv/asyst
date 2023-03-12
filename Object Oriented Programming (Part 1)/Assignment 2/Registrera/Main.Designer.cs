namespace Lab2Version
{
    partial class Main
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
            this.buttonStudent = new System.Windows.Forms.Button();
            this.buttonLärare = new System.Windows.Forms.Button();
            this.buttonKurs = new System.Windows.Forms.Button();
            this.buttonUppgiftBetyg = new System.Windows.Forms.Button();
            this.buttonExit = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // buttonStudent
            // 
            this.buttonStudent.Location = new System.Drawing.Point(144, 183);
            this.buttonStudent.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.buttonStudent.Name = "buttonStudent";
            this.buttonStudent.Size = new System.Drawing.Size(284, 74);
            this.buttonStudent.TabIndex = 0;
            this.buttonStudent.Text = "Hantera Student";
            this.buttonStudent.UseVisualStyleBackColor = true;
            this.buttonStudent.Click += new System.EventHandler(this.buttonStudent_Click);
            // 
            // buttonLärare
            // 
            this.buttonLärare.Location = new System.Drawing.Point(144, 282);
            this.buttonLärare.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.buttonLärare.Name = "buttonLärare";
            this.buttonLärare.Size = new System.Drawing.Size(284, 74);
            this.buttonLärare.TabIndex = 1;
            this.buttonLärare.Text = "Hantera Lärare";
            this.buttonLärare.UseVisualStyleBackColor = true;
            this.buttonLärare.Click += new System.EventHandler(this.buttonLärare_Click);
            // 
            // buttonKurs
            // 
            this.buttonKurs.Location = new System.Drawing.Point(144, 84);
            this.buttonKurs.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.buttonKurs.Name = "buttonKurs";
            this.buttonKurs.Size = new System.Drawing.Size(284, 74);
            this.buttonKurs.TabIndex = 2;
            this.buttonKurs.Text = "Hantera Kurs";
            this.buttonKurs.UseVisualStyleBackColor = true;
            this.buttonKurs.Click += new System.EventHandler(this.buttonKurs_Click);
            // 
            // buttonUppgiftBetyg
            // 
            this.buttonUppgiftBetyg.Location = new System.Drawing.Point(144, 397);
            this.buttonUppgiftBetyg.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.buttonUppgiftBetyg.Name = "buttonUppgiftBetyg";
            this.buttonUppgiftBetyg.Size = new System.Drawing.Size(284, 74);
            this.buttonUppgiftBetyg.TabIndex = 3;
            this.buttonUppgiftBetyg.Text = "Uppgift / Betyg";
            this.buttonUppgiftBetyg.UseVisualStyleBackColor = true;
            this.buttonUppgiftBetyg.Click += new System.EventHandler(this.buttonUppgiftBetyg_Click);
            // 
            // buttonExit
            // 
            this.buttonExit.Location = new System.Drawing.Point(144, 510);
            this.buttonExit.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.buttonExit.Name = "buttonExit";
            this.buttonExit.Size = new System.Drawing.Size(283, 71);
            this.buttonExit.TabIndex = 4;
            this.buttonExit.Text = "Avsluta Program";
            this.buttonExit.UseVisualStyleBackColor = true;
            this.buttonExit.Click += new System.EventHandler(this.buttonExit_Click);
            // 
            // Main
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(16F, 31F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(624, 649);
            this.Controls.Add(this.buttonExit);
            this.Controls.Add(this.buttonUppgiftBetyg);
            this.Controls.Add(this.buttonKurs);
            this.Controls.Add(this.buttonLärare);
            this.Controls.Add(this.buttonStudent);
            this.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.Name = "Main";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Main";
            this.Load += new System.EventHandler(this.Main_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button buttonStudent;
        private System.Windows.Forms.Button buttonLärare;
        private System.Windows.Forms.Button buttonKurs;
        private System.Windows.Forms.Button buttonUppgiftBetyg;
        private System.Windows.Forms.Button buttonExit;
    }
}