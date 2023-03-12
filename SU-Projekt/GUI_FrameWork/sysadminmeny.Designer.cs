namespace GUI_FrameWork
{
    partial class Systemadministrarör
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
            this.btnloggaut = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.btUppdatera = new System.Windows.Forms.Button();
            this.btnpersonal = new System.Windows.Forms.Button();
            this.btndata = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnloggaut
            // 
            this.btnloggaut.Location = new System.Drawing.Point(306, 258);
            this.btnloggaut.Name = "btnloggaut";
            this.btnloggaut.Size = new System.Drawing.Size(156, 52);
            this.btnloggaut.TabIndex = 19;
            this.btnloggaut.Text = "Logga ut";
            this.btnloggaut.UseVisualStyleBackColor = true;
            this.btnloggaut.Click += new System.EventHandler(this.Button3_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.btUppdatera);
            this.groupBox1.Controls.Add(this.btnpersonal);
            this.groupBox1.Controls.Add(this.btndata);
            this.groupBox1.Location = new System.Drawing.Point(27, 94);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(550, 158);
            this.groupBox1.TabIndex = 18;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Meny";
            // 
            // btUppdatera
            // 
            this.btUppdatera.Location = new System.Drawing.Point(330, 41);
            this.btUppdatera.Name = "btUppdatera";
            this.btUppdatera.Size = new System.Drawing.Size(186, 52);
            this.btUppdatera.TabIndex = 17;
            this.btUppdatera.Text = "Uppdatera kund";
            this.btUppdatera.UseVisualStyleBackColor = true;
            this.btUppdatera.Click += new System.EventHandler(this.btUppdatera_Click);
            // 
            // btnpersonal
            // 
            this.btnpersonal.Location = new System.Drawing.Point(168, 41);
            this.btnpersonal.Name = "btnpersonal";
            this.btnpersonal.Size = new System.Drawing.Size(156, 52);
            this.btnpersonal.TabIndex = 16;
            this.btnpersonal.Text = "Personal";
            this.btnpersonal.UseVisualStyleBackColor = true;
            this.btnpersonal.Click += new System.EventHandler(this.btnpersonal_Click);
            // 
            // btndata
            // 
            this.btndata.Location = new System.Drawing.Point(6, 41);
            this.btndata.Name = "btndata";
            this.btndata.Size = new System.Drawing.Size(156, 52);
            this.btndata.TabIndex = 15;
            this.btndata.Text = "Data";
            this.btndata.UseVisualStyleBackColor = true;
            this.btndata.Click += new System.EventHandler(this.btndata_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Matura MT Script Capitals", 18F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(16, 28);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(268, 64);
            this.label3.TabIndex = 17;
            this.label3.Text = "Ski-Center";
            // 
            // Systemadministrarör
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(573, 411);
            this.Controls.Add(this.btnloggaut);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.label3);
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "Systemadministrarör";
            this.Text = "Systemadministrator";
            this.groupBox1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnloggaut;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button btnpersonal;
        private System.Windows.Forms.Button btndata;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button btUppdatera;
    }
}