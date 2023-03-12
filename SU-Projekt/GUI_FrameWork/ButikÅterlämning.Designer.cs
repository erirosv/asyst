namespace GUI_FrameWork
{
    partial class ButikÅterlämning
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
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.label12 = new System.Windows.Forms.Label();
            this.buttonSökNamn = new System.Windows.Forms.Button();
            this.textBoxSökNamn = new System.Windows.Forms.TextBox();
            this.btnÅterlämna = new System.Windows.Forms.Button();
            this.dataGridViewÅterlämning = new System.Windows.Forms.DataGridView();
            this.button1 = new System.Windows.Forms.Button();
            this.groupBox4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewÅterlämning)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox4
            // 
            this.groupBox4.Controls.Add(this.button1);
            this.groupBox4.Controls.Add(this.label12);
            this.groupBox4.Controls.Add(this.buttonSökNamn);
            this.groupBox4.Controls.Add(this.textBoxSökNamn);
            this.groupBox4.Controls.Add(this.btnÅterlämna);
            this.groupBox4.Controls.Add(this.dataGridViewÅterlämning);
            this.groupBox4.Location = new System.Drawing.Point(3, 0);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(755, 493);
            this.groupBox4.TabIndex = 11;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "Återlämning";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(19, 27);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(71, 17);
            this.label12.TabIndex = 25;
            this.label12.Text = "Sök namn";
            // 
            // buttonSökNamn
            // 
            this.buttonSökNamn.Location = new System.Drawing.Point(163, 52);
            this.buttonSökNamn.Name = "buttonSökNamn";
            this.buttonSökNamn.Size = new System.Drawing.Size(59, 31);
            this.buttonSökNamn.TabIndex = 24;
            this.buttonSökNamn.Text = "Sök";
            this.buttonSökNamn.UseVisualStyleBackColor = true;
            this.buttonSökNamn.Click += new System.EventHandler(this.buttonSökNamn_Click);
            // 
            // textBoxSökNamn
            // 
            this.textBoxSökNamn.Location = new System.Drawing.Point(21, 55);
            this.textBoxSökNamn.Name = "textBoxSökNamn";
            this.textBoxSökNamn.Size = new System.Drawing.Size(129, 22);
            this.textBoxSökNamn.TabIndex = 23;
            this.textBoxSökNamn.TextChanged += new System.EventHandler(this.textBoxSökNamn_TextChanged);
            // 
            // btnÅterlämna
            // 
            this.btnÅterlämna.Location = new System.Drawing.Point(498, 332);
            this.btnÅterlämna.Name = "btnÅterlämna";
            this.btnÅterlämna.Size = new System.Drawing.Size(125, 46);
            this.btnÅterlämna.TabIndex = 17;
            this.btnÅterlämna.Text = "Återlämna";
            this.btnÅterlämna.UseVisualStyleBackColor = true;
            this.btnÅterlämna.Click += new System.EventHandler(this.btnÅterlämna_Click);
            // 
            // dataGridViewÅterlämning
            // 
            this.dataGridViewÅterlämning.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewÅterlämning.Location = new System.Drawing.Point(21, 86);
            this.dataGridViewÅterlämning.Name = "dataGridViewÅterlämning";
            this.dataGridViewÅterlämning.RowHeadersWidth = 62;
            this.dataGridViewÅterlämning.RowTemplate.Height = 28;
            this.dataGridViewÅterlämning.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridViewÅterlämning.Size = new System.Drawing.Size(603, 233);
            this.dataGridViewÅterlämning.TabIndex = 0;
            this.dataGridViewÅterlämning.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridViewÅterlämning_CellContentClick);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(355, 332);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(126, 46);
            this.button1.TabIndex = 27;
            this.button1.Text = "Tillbaka";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // ButikÅterlämning
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.groupBox4);
            this.Name = "ButikÅterlämning";
            this.Size = new System.Drawing.Size(760, 495);
            this.groupBox4.ResumeLayout(false);
            this.groupBox4.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewÅterlämning)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox4;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Button buttonSökNamn;
        private System.Windows.Forms.TextBox textBoxSökNamn;
        private System.Windows.Forms.Button btnÅterlämna;
        private System.Windows.Forms.DataGridView dataGridViewÅterlämning;
        private System.Windows.Forms.Button button1;
    }
}
