﻿namespace GUI.Personal
{
    partial class EditEvent
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(EditEvent));
            this.buttonRegistrera = new System.Windows.Forms.Button();
            this.buttonTillbaka = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.buttonSök = new System.Windows.Forms.Button();
            this.textBoxSearch = new System.Windows.Forms.TextBox();
            this.pictureBox3 = new System.Windows.Forms.PictureBox();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // buttonRegistrera
            // 
            this.buttonRegistrera.BackColor = System.Drawing.SystemColors.Menu;
            this.buttonRegistrera.Location = new System.Drawing.Point(1289, 718);
            this.buttonRegistrera.Margin = new System.Windows.Forms.Padding(5);
            this.buttonRegistrera.Name = "buttonRegistrera";
            this.buttonRegistrera.Size = new System.Drawing.Size(164, 54);
            this.buttonRegistrera.TabIndex = 113;
            this.buttonRegistrera.Text = "Registrera";
            this.buttonRegistrera.UseVisualStyleBackColor = false;
            // 
            // buttonTillbaka
            // 
            this.buttonTillbaka.BackColor = System.Drawing.SystemColors.Menu;
            this.buttonTillbaka.Location = new System.Drawing.Point(1083, 718);
            this.buttonTillbaka.Margin = new System.Windows.Forms.Padding(5);
            this.buttonTillbaka.Name = "buttonTillbaka";
            this.buttonTillbaka.Size = new System.Drawing.Size(164, 54);
            this.buttonTillbaka.TabIndex = 112;
            this.buttonTillbaka.Text = "Tillbaka";
            this.buttonTillbaka.UseVisualStyleBackColor = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Mongolian Baiti", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(543, 203);
            this.label1.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(513, 64);
            this.label1.TabIndex = 111;
            this.label1.Text = "Registrera till event";
            // 
            // buttonSök
            // 
            this.buttonSök.BackColor = System.Drawing.SystemColors.Menu;
            this.buttonSök.Location = new System.Drawing.Point(365, 341);
            this.buttonSök.Margin = new System.Windows.Forms.Padding(5);
            this.buttonSök.Name = "buttonSök";
            this.buttonSök.Size = new System.Drawing.Size(164, 54);
            this.buttonSök.TabIndex = 110;
            this.buttonSök.Text = "Sök";
            this.buttonSök.UseVisualStyleBackColor = false;
            // 
            // textBoxSearch
            // 
            this.textBoxSearch.Location = new System.Drawing.Point(121, 347);
            this.textBoxSearch.Margin = new System.Windows.Forms.Padding(5);
            this.textBoxSearch.Name = "textBoxSearch";
            this.textBoxSearch.Size = new System.Drawing.Size(230, 38);
            this.textBoxSearch.TabIndex = 109;
            // 
            // pictureBox3
            // 
            this.pictureBox3.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("pictureBox3.BackgroundImage")));
            this.pictureBox3.Location = new System.Drawing.Point(-5, 0);
            this.pictureBox3.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.pictureBox3.Name = "pictureBox3";
            this.pictureBox3.Size = new System.Drawing.Size(1637, 183);
            this.pictureBox3.TabIndex = 108;
            this.pictureBox3.TabStop = false;
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(121, 432);
            this.dataGridView1.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 102;
            this.dataGridView1.RowTemplate.Height = 40;
            this.dataGridView1.Size = new System.Drawing.Size(1332, 254);
            this.dataGridView1.TabIndex = 107;
            // 
            // EditEvent
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(16F, 31F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1632, 1032);
            this.Controls.Add(this.buttonRegistrera);
            this.Controls.Add(this.buttonTillbaka);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.buttonSök);
            this.Controls.Add(this.textBoxSearch);
            this.Controls.Add(this.pictureBox3);
            this.Controls.Add(this.dataGridView1);
            this.Name = "EditEvent";
            this.Text = "EditEvent";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button buttonRegistrera;
        private System.Windows.Forms.Button buttonTillbaka;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button buttonSök;
        private System.Windows.Forms.TextBox textBoxSearch;
        private System.Windows.Forms.PictureBox pictureBox3;
        private System.Windows.Forms.DataGridView dataGridView1;
    }
}