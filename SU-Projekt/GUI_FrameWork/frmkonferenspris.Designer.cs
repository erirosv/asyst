namespace GUI_FrameWork
{
    partial class frmkonferenspris
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
            this.dgkonferenspris = new System.Windows.Forms.DataGridView();
            this.button1 = new System.Windows.Forms.Button();
            this.btändra = new System.Windows.Forms.Button();
            this.tbkonferenspris = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.dgkonferenspris)).BeginInit();
            this.SuspendLayout();
            // 
            // dgkonferenspris
            // 
            this.dgkonferenspris.AllowUserToOrderColumns = true;
            this.dgkonferenspris.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgkonferenspris.Location = new System.Drawing.Point(23, 27);
            this.dgkonferenspris.Name = "dgkonferenspris";
            this.dgkonferenspris.ReadOnly = true;
            this.dgkonferenspris.RowHeadersWidth = 51;
            this.dgkonferenspris.RowTemplate.Height = 24;
            this.dgkonferenspris.Size = new System.Drawing.Size(750, 373);
            this.dgkonferenspris.TabIndex = 0;
            this.dgkonferenspris.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgkonferenspris_CellContentClick);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(678, 411);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(95, 27);
            this.button1.TabIndex = 2;
            this.button1.Text = "Tillbaka";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // btändra
            // 
            this.btändra.Location = new System.Drawing.Point(561, 411);
            this.btändra.Name = "btändra";
            this.btändra.Size = new System.Drawing.Size(95, 27);
            this.btändra.TabIndex = 3;
            this.btändra.Text = "Ändra";
            this.btändra.UseVisualStyleBackColor = true;
            this.btändra.Click += new System.EventHandler(this.btändra_Click);
            // 
            // tbkonferenspris
            // 
            this.tbkonferenspris.Location = new System.Drawing.Point(388, 413);
            this.tbkonferenspris.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.tbkonferenspris.Name = "tbkonferenspris";
            this.tbkonferenspris.Size = new System.Drawing.Size(152, 22);
            this.tbkonferenspris.TabIndex = 5;
            this.tbkonferenspris.TextChanged += new System.EventHandler(this.tbkonferenspris_TextChanged_1);
            // 
            // frmkonferenspris
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.tbkonferenspris);
            this.Controls.Add(this.btändra);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.dgkonferenspris);
            this.Name = "frmkonferenspris";
            this.Text = "frmkonferenspris";
            ((System.ComponentModel.ISupportInitialize)(this.dgkonferenspris)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dgkonferenspris;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button btändra;
        private System.Windows.Forms.TextBox tbkonferenspris;
    }
}