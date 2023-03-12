namespace GUI_FrameWork
{
    partial class frmLogipris
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
            this.dglogipris = new System.Windows.Forms.DataGridView();
            this.button1 = new System.Windows.Forms.Button();
            this.btändra = new System.Windows.Forms.Button();
            this.tbLogiPris = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.dglogipris)).BeginInit();
            this.SuspendLayout();
            // 
            // dglogipris
            // 
            this.dglogipris.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dglogipris.Location = new System.Drawing.Point(33, 39);
            this.dglogipris.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.dglogipris.Name = "dglogipris";
            this.dglogipris.RowHeadersWidth = 51;
            this.dglogipris.RowTemplate.Height = 24;
            this.dglogipris.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dglogipris.Size = new System.Drawing.Size(830, 454);
            this.dglogipris.TabIndex = 0;
            this.dglogipris.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dglogipris_CellContentClick);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(738, 514);
            this.button1.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(107, 34);
            this.button1.TabIndex = 1;
            this.button1.Text = "Tillbaka";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // btändra
            // 
            this.btändra.Location = new System.Drawing.Point(596, 514);
            this.btändra.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btändra.Name = "btändra";
            this.btändra.Size = new System.Drawing.Size(107, 34);
            this.btändra.TabIndex = 2;
            this.btändra.Text = "Ändra";
            this.btändra.UseVisualStyleBackColor = true;
            this.btändra.Click += new System.EventHandler(this.btändra_Click);
            // 
            // tbLogiPris
            // 
            this.tbLogiPris.Location = new System.Drawing.Point(385, 518);
            this.tbLogiPris.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.tbLogiPris.Name = "tbLogiPris";
            this.tbLogiPris.Size = new System.Drawing.Size(173, 26);
            this.tbLogiPris.TabIndex = 3;
            // 
            // frmLogipris
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(900, 562);
            this.Controls.Add(this.tbLogiPris);
            this.Controls.Add(this.btändra);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.dglogipris);
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Name = "frmLogipris";
            this.Text = "Logipris";
            ((System.ComponentModel.ISupportInitialize)(this.dglogipris)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dglogipris;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button btändra;
        private System.Windows.Forms.TextBox tbLogiPris;
    }
}