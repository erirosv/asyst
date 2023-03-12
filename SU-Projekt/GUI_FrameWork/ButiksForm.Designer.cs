namespace GUI_FrameWork
{
    partial class ButiksForm
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
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.butikSkiduthyrning1 = new GUI_FrameWork.ButikSkiduthyrning();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.butikÅterlämning1 = new GUI_FrameWork.ButikÅterlämning();
            this.tabPage3 = new System.Windows.Forms.TabPage();
            this.butikSkidskola1 = new GUI_FrameWork.ButikSkidskola(Anställd);
            this.tabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.tabPage2.SuspendLayout();
            this.tabPage3.SuspendLayout();
            this.SuspendLayout();
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Controls.Add(this.tabPage3);
            this.tabControl1.Location = new System.Drawing.Point(20, 20);
            this.tabControl1.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(1734, 1116);
            this.tabControl1.TabIndex = 0;
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.butikSkiduthyrning1);
            this.tabPage1.Location = new System.Drawing.Point(8, 39);
            this.tabPage1.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.tabPage1.Size = new System.Drawing.Size(1718, 1069);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Skiduthyrning";
            this.tabPage1.UseVisualStyleBackColor = true;
            this.tabPage1.Click += new System.EventHandler(this.tabPage1_Click);
            // 
            // butikSkiduthyrning1
            // 
            //this.butikSkiduthyrning1.Adress = null;
            //this.butikSkiduthyrning1.Efternamn = null;
            //this.butikSkiduthyrning1.Epost = null;
            //this.butikSkiduthyrning1.FacadeBusiness = null;
            //this.butikSkiduthyrning1.FakturaAdress = null;
            this.butikSkiduthyrning1.Location = new System.Drawing.Point(9, 22);
            this.butikSkiduthyrning1.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            //this.butikSkiduthyrning1.Name = "butikSkiduthyrning1";
            //this.butikSkiduthyrning1.Namn = null;
            //this.butikSkiduthyrning1.OrgNr = null;
            //this.butikSkiduthyrning1.PostNummer = null;
            //this.butikSkiduthyrning1.PostOrt = null;
            this.butikSkiduthyrning1.Pris = 0D;
            //this.butikSkiduthyrning1.RefPerson = null;
            //this.butikSkiduthyrning1.Search = null;
            this.butikSkiduthyrning1.Size = new System.Drawing.Size(2036, 1098);
            //this.butikSkiduthyrning1.TabIndex = 0;
            //this.butikSkiduthyrning1.Telefon = null;
            //this.butikSkiduthyrning1.TempFaktura = null;
            //this.butikSkiduthyrning1.TillUtrustning = null;
            //this.butikSkiduthyrning1.Uthyrning = null;
            //this.butikSkiduthyrning1.UthyrningarList = null;
            //this.butikSkiduthyrning1.Utrustning = null;
            //this.butikSkiduthyrning1.Utrustning1 = null;
            //this.butikSkiduthyrning1.Utrustning2 = null;
            //this.butikSkiduthyrning1.Utrustning3 = null; 

            // 
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.butikÅterlämning1);
            this.tabPage2.Location = new System.Drawing.Point(8, 39);
            this.tabPage2.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.tabPage2.Size = new System.Drawing.Size(1718, 1069);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Återlämning";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // butikÅterlämning1
            
            // 
            this.butikÅterlämning1.Location = new System.Drawing.Point(42, 28);
            this.butikÅterlämning1.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.butikÅterlämning1.Name = "butikÅterlämning1";
            this.butikÅterlämning1.Size = new System.Drawing.Size(1140, 773);
            this.butikÅterlämning1.TabIndex = 0;
            this.butikÅterlämning1.Load += new System.EventHandler(this.butikÅterlämning1_Load);
            // 
            // tabPage3
            // 
            this.tabPage3.Controls.Add(this.butikSkidskola1);
            this.tabPage3.Location = new System.Drawing.Point(8, 39);
            this.tabPage3.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.tabPage3.Name = "tabPage3";
            this.tabPage3.Size = new System.Drawing.Size(1718, 1069);
            this.tabPage3.TabIndex = 2;
            this.tabPage3.Text = "Skidskola";
            this.tabPage3.UseVisualStyleBackColor = true;
            // 
            // butikSkidskola1
            // 
            //this.butikSkidskola1.Anställd = null;
         //   this.butikSkidskola1.AntalDagar = 0;
          //  this.butikSkidskola1.DeltagarFörnamn = null;
           // this.butikSkidskola1.LektionsTyp = null;
            this.butikSkidskola1.Location = new System.Drawing.Point(27, 36);
            this.butikSkidskola1.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.butikSkidskola1.Name = "butikSkidskola1";
            this.butikSkidskola1.Size = new System.Drawing.Size(1542, 1031);
            this.butikSkidskola1.TabIndex = 0;
            // 
            // ButiksForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1776, 1162);
            this.Controls.Add(this.tabControl1);
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "ButiksForm";
            this.Text = "ButiksForm";
            this.tabControl1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tabPage2.ResumeLayout(false);
            this.tabPage3.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.TabPage tabPage3;
        private ButikSkidskola butikSkidskola1;
        private ButikÅterlämning butikÅterlämning1;
        private ButikSkiduthyrning butikSkiduthyrning1;
    }
}