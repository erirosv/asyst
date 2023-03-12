namespace GUI_FrameWork
{
    partial class frmHyrpris
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
            this.dghyrpris = new System.Windows.Forms.DataGridView();
            this.button1 = new System.Windows.Forms.Button();
            this.btändra = new System.Windows.Forms.Button();
            this.tbHyrpris = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.dghyrpris)).BeginInit();
            this.SuspendLayout();
            // 
            // dghyrpris
            // 
            this.dghyrpris.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dghyrpris.Location = new System.Drawing.Point(33, 39);
            this.dghyrpris.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.dghyrpris.Name = "dghyrpris";
            this.dghyrpris.RowHeadersWidth = 51;
            this.dghyrpris.RowTemplate.Height = 24;
            this.dghyrpris.Size = new System.Drawing.Size(839, 454);
            this.dghyrpris.TabIndex = 0;
            this.dghyrpris.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dghyrpris_CellClick);
            this.dghyrpris.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(765, 514);
            this.button1.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(107, 34);
            this.button1.TabIndex = 2;
            this.button1.Text = "Tillbaka";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // btändra
            // 
            this.btändra.Location = new System.Drawing.Point(633, 514);
            this.btändra.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btändra.Name = "btändra";
            this.btändra.Size = new System.Drawing.Size(107, 34);
            this.btändra.TabIndex = 3;
            this.btändra.Text = "Ändra";
            this.btändra.UseVisualStyleBackColor = true;
            this.btändra.Click += new System.EventHandler(this.btändra_Click);
            // 
            // tbHyrpris
            // 
            this.tbHyrpris.Location = new System.Drawing.Point(431, 518);
            this.tbHyrpris.Name = "tbHyrpris";
            this.tbHyrpris.Size = new System.Drawing.Size(170, 26);
            this.tbHyrpris.TabIndex = 4;
            this.tbHyrpris.TextChanged += new System.EventHandler(this.tbHyrpris_TextChanged);
            // 
            // frmHyrpris
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(900, 562);
            this.Controls.Add(this.tbHyrpris);
            this.Controls.Add(this.btändra);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.dghyrpris);
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Name = "frmHyrpris";
            this.Text = "frmHyrpris";
            ((System.ComponentModel.ISupportInitialize)(this.dghyrpris)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dghyrpris;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button btändra;
        private System.Windows.Forms.TextBox tbHyrpris;
    }
}