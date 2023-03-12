namespace GUI_FrameWork
{
    partial class Skidlärare
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
            this.label3 = new System.Windows.Forms.Label();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.btnväljlärare = new System.Windows.Forms.Button();
            this.btnskrivutlärare = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.btnsökgrupp = new System.Windows.Forms.Button();
            this.Tbsökgrupp = new System.Windows.Forms.TextBox();
            this.gvskidlärare = new System.Windows.Forms.DataGridView();
            this.btnLoggaUt = new System.Windows.Forms.Button();
            this.tabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gvskidlärare)).BeginInit();
            this.SuspendLayout();
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(99, -48);
            this.label3.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(155, 36);
            this.label3.TabIndex = 14;
            this.label3.Text = "Ski-Center";
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Location = new System.Drawing.Point(23, 26);
            this.tabControl1.Margin = new System.Windows.Forms.Padding(2);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(597, 345);
            this.tabControl1.TabIndex = 13;
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.btnväljlärare);
            this.tabPage1.Controls.Add(this.btnskrivutlärare);
            this.tabPage1.Controls.Add(this.label1);
            this.tabPage1.Controls.Add(this.btnsökgrupp);
            this.tabPage1.Controls.Add(this.Tbsökgrupp);
            this.tabPage1.Controls.Add(this.gvskidlärare);
            this.tabPage1.Location = new System.Drawing.Point(4, 25);
            this.tabPage1.Margin = new System.Windows.Forms.Padding(2);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(2);
            this.tabPage1.Size = new System.Drawing.Size(589, 316);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Skidlärare";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // btnväljlärare
            // 
            this.btnväljlärare.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnväljlärare.Location = new System.Drawing.Point(370, 265);
            this.btnväljlärare.Margin = new System.Windows.Forms.Padding(2);
            this.btnväljlärare.Name = "btnväljlärare";
            this.btnväljlärare.Size = new System.Drawing.Size(91, 34);
            this.btnväljlärare.TabIndex = 5;
            this.btnväljlärare.Text = "Välj";
            this.btnväljlärare.UseVisualStyleBackColor = true;
            // 
            // btnskrivutlärare
            // 
            this.btnskrivutlärare.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnskrivutlärare.Location = new System.Drawing.Point(471, 265);
            this.btnskrivutlärare.Margin = new System.Windows.Forms.Padding(2);
            this.btnskrivutlärare.Name = "btnskrivutlärare";
            this.btnskrivutlärare.Size = new System.Drawing.Size(93, 34);
            this.btnskrivutlärare.TabIndex = 4;
            this.btnskrivutlärare.Text = "Skriv ut";
            this.btnskrivutlärare.UseVisualStyleBackColor = true;
            this.btnskrivutlärare.Click += new System.EventHandler(this.btnskrivutlärare_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(13, 20);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(48, 17);
            this.label1.TabIndex = 3;
            this.label1.Text = "Grupp";
            // 
            // btnsökgrupp
            // 
            this.btnsökgrupp.Location = new System.Drawing.Point(277, 10);
            this.btnsökgrupp.Margin = new System.Windows.Forms.Padding(2);
            this.btnsökgrupp.Name = "btnsökgrupp";
            this.btnsökgrupp.Size = new System.Drawing.Size(76, 36);
            this.btnsökgrupp.TabIndex = 2;
            this.btnsökgrupp.Text = "Sök";
            this.btnsökgrupp.UseVisualStyleBackColor = true;
            this.btnsökgrupp.Click += new System.EventHandler(this.btnsökgrupp_Click);
            // 
            // Tbsökgrupp
            // 
            this.Tbsökgrupp.Location = new System.Drawing.Point(66, 16);
            this.Tbsökgrupp.Margin = new System.Windows.Forms.Padding(2);
            this.Tbsökgrupp.Name = "Tbsökgrupp";
            this.Tbsökgrupp.Size = new System.Drawing.Size(210, 22);
            this.Tbsökgrupp.TabIndex = 1;
            // 
            // gvskidlärare
            // 
            this.gvskidlärare.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.gvskidlärare.Location = new System.Drawing.Point(4, 50);
            this.gvskidlärare.Margin = new System.Windows.Forms.Padding(2);
            this.gvskidlärare.Name = "gvskidlärare";
            this.gvskidlärare.RowHeadersWidth = 62;
            this.gvskidlärare.RowTemplate.Height = 28;
            this.gvskidlärare.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.gvskidlärare.Size = new System.Drawing.Size(558, 212);
            this.gvskidlärare.TabIndex = 0;
            this.gvskidlärare.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.Gvskidlärare_CellContentClick);
            // 
            // btnLoggaUt
            // 
            this.btnLoggaUt.Location = new System.Drawing.Point(25, 374);
            this.btnLoggaUt.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnLoggaUt.Name = "btnLoggaUt";
            this.btnLoggaUt.Size = new System.Drawing.Size(121, 39);
            this.btnLoggaUt.TabIndex = 15;
            this.btnLoggaUt.Text = "Logga ut";
            this.btnLoggaUt.UseVisualStyleBackColor = true;
            this.btnLoggaUt.Click += new System.EventHandler(this.btnLoggaUt_Click);
            // 
            // Skidlärare
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(647, 434);
            this.Controls.Add(this.btnLoggaUt);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.tabControl1);
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Name = "Skidlärare";
            this.Text = "Skidlärare";
            this.Load += new System.EventHandler(this.Skidlärare_Load);
            this.tabControl1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tabPage1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gvskidlärare)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.Button btnväljlärare;
        private System.Windows.Forms.Button btnskrivutlärare;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnsökgrupp;
        private System.Windows.Forms.TextBox Tbsökgrupp;
        private System.Windows.Forms.DataGridView gvskidlärare;
        private System.Windows.Forms.Button btnLoggaUt;
    }
}