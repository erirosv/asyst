﻿
namespace GUI_Framework_v2
{
    partial class frmKonferensPris_2
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
            this.tbkonferenspris = new System.Windows.Forms.TextBox();
            this.btnändra = new System.Windows.Forms.Button();
            this.btntillbaka = new System.Windows.Forms.Button();
            this.gvkonferenspris = new System.Windows.Forms.DataGridView();
            this.label1 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.gvkonferenspris)).BeginInit();
            this.SuspendLayout();
            // 
            // tbkonferenspris
            // 
            this.tbkonferenspris.Location = new System.Drawing.Point(546, 425);
            this.tbkonferenspris.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.tbkonferenspris.Name = "tbkonferenspris";
            this.tbkonferenspris.Size = new System.Drawing.Size(104, 22);
            this.tbkonferenspris.TabIndex = 9;
            this.tbkonferenspris.TextChanged += new System.EventHandler(this.tbkonferenspris_TextChanged);
            // 
            // btnändra
            // 
            this.btnändra.Location = new System.Drawing.Point(667, 420);
            this.btnändra.Name = "btnändra";
            this.btnändra.Size = new System.Drawing.Size(95, 27);
            this.btnändra.TabIndex = 8;
            this.btnändra.Text = "Ändra";
            this.btnändra.UseVisualStyleBackColor = true;
            this.btnändra.Click += new System.EventHandler(this.btnändra_Click);
            // 
            // btntillbaka
            // 
            this.btntillbaka.Location = new System.Drawing.Point(12, 428);
            this.btntillbaka.Name = "btntillbaka";
            this.btntillbaka.Size = new System.Drawing.Size(103, 27);
            this.btntillbaka.TabIndex = 7;
            this.btntillbaka.Text = "Tillbaka";
            this.btntillbaka.UseVisualStyleBackColor = true;
            this.btntillbaka.Click += new System.EventHandler(this.btntillbaka_Click);
            // 
            // gvkonferenspris
            // 
            this.gvkonferenspris.AllowUserToOrderColumns = true;
            this.gvkonferenspris.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.gvkonferenspris.Location = new System.Drawing.Point(12, 41);
            this.gvkonferenspris.Name = "gvkonferenspris";
            this.gvkonferenspris.ReadOnly = true;
            this.gvkonferenspris.RowHeadersWidth = 51;
            this.gvkonferenspris.RowTemplate.Height = 24;
            this.gvkonferenspris.Size = new System.Drawing.Size(750, 373);
            this.gvkonferenspris.TabIndex = 6;
            this.gvkonferenspris.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgkonferenspris_CellContentClick);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(472, 428);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(68, 17);
            this.label1.TabIndex = 10;
            this.label1.Text = "Nytt pris: ";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(11, 9);
            this.label3.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(127, 29);
            this.label3.TabIndex = 21;
            this.label3.Text = "Ski-Center";
            // 
            // frmKonferensPris_2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(798, 478);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.tbkonferenspris);
            this.Controls.Add(this.btnändra);
            this.Controls.Add(this.btntillbaka);
            this.Controls.Add(this.gvkonferenspris);
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "frmKonferensPris_2";
            this.Text = "frmKonferensPris_2";
            ((System.ComponentModel.ISupportInitialize)(this.gvkonferenspris)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox tbkonferenspris;
        private System.Windows.Forms.Button btnändra;
        private System.Windows.Forms.Button btntillbaka;
        private System.Windows.Forms.DataGridView gvkonferenspris;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label3;
    }
}