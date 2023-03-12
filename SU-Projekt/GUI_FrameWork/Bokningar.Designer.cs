namespace GUI_FrameWork
{
    partial class Bokningar
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.btnskrivutb = new System.Windows.Forms.Button();
            this.btnsökb = new System.Windows.Forms.Button();
            this.tbSökBokningar = new System.Windows.Forms.TextBox();
            this.gvBokningar = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.gvBokningar)).BeginInit();
            this.SuspendLayout();
            // 
            // btnskrivutb
            // 
            this.btnskrivutb.Location = new System.Drawing.Point(871, 422);
            this.btnskrivutb.Margin = new System.Windows.Forms.Padding(2);
            this.btnskrivutb.Name = "btnskrivutb";
            this.btnskrivutb.Size = new System.Drawing.Size(155, 48);
            this.btnskrivutb.TabIndex = 7;
            this.btnskrivutb.Text = "Skriv ut alla bokningar";
            this.btnskrivutb.UseVisualStyleBackColor = true;
            this.btnskrivutb.Click += new System.EventHandler(this.btnskrivutb_Click);
            // 
            // btnsökb
            // 
            this.btnsökb.Location = new System.Drawing.Point(204, 30);
            this.btnsökb.Margin = new System.Windows.Forms.Padding(2);
            this.btnsökb.Name = "btnsökb";
            this.btnsökb.Size = new System.Drawing.Size(69, 25);
            this.btnsökb.TabIndex = 6;
            this.btnsökb.Text = "Sök";
            this.btnsökb.UseVisualStyleBackColor = true;
            this.btnsökb.Click += new System.EventHandler(this.btnsökb_Click);
            // 
            // tbSökBokningar
            // 
            this.tbSökBokningar.Location = new System.Drawing.Point(6, 32);
            this.tbSökBokningar.Margin = new System.Windows.Forms.Padding(2);
            this.tbSökBokningar.Name = "tbSökBokningar";
            this.tbSökBokningar.Size = new System.Drawing.Size(195, 22);
            this.tbSökBokningar.TabIndex = 5;
            this.tbSökBokningar.TextChanged += new System.EventHandler(this.tbSökBokningar_TextChanged);
            // 
            // gvBokningar
            // 
            this.gvBokningar.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.gvBokningar.Location = new System.Drawing.Point(6, 56);
            this.gvBokningar.Margin = new System.Windows.Forms.Padding(2);
            this.gvBokningar.Name = "gvBokningar";
            this.gvBokningar.RowHeadersWidth = 62;
            this.gvBokningar.RowTemplate.Height = 28;
            this.gvBokningar.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.gvBokningar.Size = new System.Drawing.Size(1021, 349);
            this.gvBokningar.TabIndex = 4;
            this.gvBokningar.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.gvBokningar_CellContentClick);
            // 
            // Bokningar
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.btnskrivutb);
            this.Controls.Add(this.btnsökb);
            this.Controls.Add(this.tbSökBokningar);
            this.Controls.Add(this.gvBokningar);
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "Bokningar";
            this.Size = new System.Drawing.Size(1028, 479);
            this.Load += new System.EventHandler(this.Bokningar_Load);
            ((System.ComponentModel.ISupportInitialize)(this.gvBokningar)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnskrivutb;
        private System.Windows.Forms.Button btnsökb;
        private System.Windows.Forms.TextBox tbSökBokningar;
        private System.Windows.Forms.DataGridView gvBokningar;
    }
}
