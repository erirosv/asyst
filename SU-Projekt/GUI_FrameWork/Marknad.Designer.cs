using System;

namespace GUI_FrameWork
{
    partial class Marknad
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
            this.label3 = new System.Windows.Forms.Label();
            this.tabPage5 = new System.Windows.Forms.TabPage();
            this.label7 = new System.Windows.Forms.Label();
            this.btnsökp = new System.Windows.Forms.Button();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.btntabortp = new System.Windows.Forms.Button();
            this.dvpersonaldata = new System.Windows.Forms.DataGridView();
            this.btntillbaka = new System.Windows.Forms.Button();
            this.tabPage4 = new System.Windows.Forms.TabPage();
            this.groupBox5 = new System.Windows.Forms.GroupBox();
            this.btnskrivutfakturas = new System.Windows.Forms.Button();
            this.gvfdata = new System.Windows.Forms.DataGridView();
            this.groupBox6 = new System.Windows.Forms.GroupBox();
            this.button11 = new System.Windows.Forms.Button();
            this.label6 = new System.Windows.Forms.Label();
            this.dateTimePicker2 = new System.Windows.Forms.DateTimePicker();
            this.tabPage3 = new System.Windows.Forms.TabPage();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.btnskrivutf = new System.Windows.Forms.Button();
            this.gvfldata = new System.Windows.Forms.DataGridView();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.button10 = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.tabPage6 = new System.Windows.Forms.TabPage();
            this.btnavböjb = new System.Windows.Forms.Button();
            this.btngodkändb = new System.Windows.Forms.Button();
            this.btnsökpb = new System.Windows.Forms.Button();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.gvpbokning = new System.Windows.Forms.DataGridView();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage5.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dvpersonaldata)).BeginInit();
            this.tabPage4.SuspendLayout();
            this.groupBox5.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gvfdata)).BeginInit();
            this.groupBox6.SuspendLayout();
            this.tabPage3.SuspendLayout();
            this.groupBox4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gvfldata)).BeginInit();
            this.groupBox3.SuspendLayout();
            this.tabPage6.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gvpbokning)).BeginInit();
            this.tabControl1.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnloggaut
            // 
            this.btnloggaut.Location = new System.Drawing.Point(555, 539);
            this.btnloggaut.Name = "btnloggaut";
            this.btnloggaut.Size = new System.Drawing.Size(103, 40);
            this.btnloggaut.TabIndex = 13;
            this.btnloggaut.Text = "Logga ut";
            this.btnloggaut.UseVisualStyleBackColor = true;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Matura MT Script Capitals", 18F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(19, 24);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(168, 40);
            this.label3.TabIndex = 11;
            this.label3.Text = "Ski-Center";
            // 
            // tabPage5
            // 
            this.tabPage5.Controls.Add(this.label7);
            this.tabPage5.Controls.Add(this.btnsökp);
            this.tabPage5.Controls.Add(this.textBox1);
            this.tabPage5.Controls.Add(this.btntabortp);
            this.tabPage5.Controls.Add(this.dvpersonaldata);
            this.tabPage5.Location = new System.Drawing.Point(4, 25);
            this.tabPage5.Name = "tabPage5";
            this.tabPage5.Size = new System.Drawing.Size(627, 392);
            this.tabPage5.TabIndex = 4;
            this.tabPage5.Text = "Personaldata";
            this.tabPage5.UseVisualStyleBackColor = true;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(18, 8);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(91, 17);
            this.label7.TabIndex = 46;
            this.label7.Text = "Sök personal";
            // 
            // btnsökp
            // 
            this.btnsökp.Location = new System.Drawing.Point(203, 20);
            this.btnsökp.Name = "btnsökp";
            this.btnsökp.Size = new System.Drawing.Size(91, 27);
            this.btnsökp.TabIndex = 45;
            this.btnsökp.Text = "Sök";
            this.btnsökp.UseVisualStyleBackColor = true;
            this.btnsökp.Click += new System.EventHandler(this.btnsökp_Click);
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(19, 26);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(172, 22);
            this.textBox1.TabIndex = 44;
            this.textBox1.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // btntabortp
            // 
            this.btntabortp.Location = new System.Drawing.Point(467, 315);
            this.btntabortp.Name = "btntabortp";
            this.btntabortp.Size = new System.Drawing.Size(142, 28);
            this.btntabortp.TabIndex = 43;
            this.btntabortp.Text = "Ta bort personal";
            this.btntabortp.UseVisualStyleBackColor = true;
            this.btntabortp.Click += new System.EventHandler(this.btntabortp_Click);
            // 
            // dvpersonaldata
            // 
            this.dvpersonaldata.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dvpersonaldata.Location = new System.Drawing.Point(13, 56);
            this.dvpersonaldata.Name = "dvpersonaldata";
            this.dvpersonaldata.RowHeadersWidth = 62;
            this.dvpersonaldata.RowTemplate.Height = 28;
            this.dvpersonaldata.Size = new System.Drawing.Size(595, 248);
            this.dvpersonaldata.TabIndex = 41;
            this.dvpersonaldata.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dvpersonaldata_CellContentClick);
            // 
            // btntillbaka
            // 
            this.btntillbaka.Location = new System.Drawing.Point(211, 24);
            this.btntillbaka.Name = "btntillbaka";
            this.btntillbaka.Size = new System.Drawing.Size(243, 28);
            this.btntillbaka.TabIndex = 40;
            this.btntillbaka.Text = "Tillbaka till Meny";
            this.btntillbaka.UseVisualStyleBackColor = true;
            this.btntillbaka.Click += new System.EventHandler(this.btntillbaka_Click);
            // 
            // tabPage4
            // 
            this.tabPage4.Controls.Add(this.groupBox5);
            this.tabPage4.Controls.Add(this.groupBox6);
            this.tabPage4.Location = new System.Drawing.Point(4, 25);
            this.tabPage4.Name = "tabPage4";
            this.tabPage4.Size = new System.Drawing.Size(627, 392);
            this.tabPage4.TabIndex = 3;
            this.tabPage4.Text = "Faktura för shop";
            this.tabPage4.UseVisualStyleBackColor = true;
            // 
            // groupBox5
            // 
            this.groupBox5.Controls.Add(this.btnskrivutfakturas);
            this.groupBox5.Controls.Add(this.gvfdata);
            this.groupBox5.Location = new System.Drawing.Point(3, 91);
            this.groupBox5.Name = "groupBox5";
            this.groupBox5.Size = new System.Drawing.Size(590, 296);
            this.groupBox5.TabIndex = 6;
            this.groupBox5.TabStop = false;
            this.groupBox5.Text = "Data";
            // 
            // btnskrivutfakturas
            // 
            this.btnskrivutfakturas.Location = new System.Drawing.Point(448, 238);
            this.btnskrivutfakturas.Name = "btnskrivutfakturas";
            this.btnskrivutfakturas.Size = new System.Drawing.Size(125, 37);
            this.btnskrivutfakturas.TabIndex = 3;
            this.btnskrivutfakturas.Text = "Skriv ut faktura";
            this.btnskrivutfakturas.UseVisualStyleBackColor = true;
            this.btnskrivutfakturas.Click += new System.EventHandler(this.Button4_Click);
            // 
            // gvfdata
            // 
            this.gvfdata.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.gvfdata.Location = new System.Drawing.Point(11, 16);
            this.gvfdata.Name = "gvfdata";
            this.gvfdata.RowHeadersWidth = 62;
            this.gvfdata.RowTemplate.Height = 28;
            this.gvfdata.Size = new System.Drawing.Size(563, 218);
            this.gvfdata.TabIndex = 2;
            // 
            // groupBox6
            // 
            this.groupBox6.Controls.Add(this.button11);
            this.groupBox6.Controls.Add(this.label6);
            this.groupBox6.Controls.Add(this.dateTimePicker2);
            this.groupBox6.Location = new System.Drawing.Point(13, 3);
            this.groupBox6.Name = "groupBox6";
            this.groupBox6.Size = new System.Drawing.Size(211, 84);
            this.groupBox6.TabIndex = 5;
            this.groupBox6.TabStop = false;
            this.groupBox6.Text = "Datum";
            // 
            // button11
            // 
            this.button11.Location = new System.Drawing.Point(141, 44);
            this.button11.Name = "button11";
            this.button11.Size = new System.Drawing.Size(67, 26);
            this.button11.TabIndex = 3;
            this.button11.Text = "Sök";
            this.button11.UseVisualStyleBackColor = true;
            this.button11.Click += new System.EventHandler(this.button11_Click);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(3, 26);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(74, 17);
            this.label6.TabIndex = 0;
            this.label6.Text = "Välj datum";
            // 
            // dateTimePicker2
            // 
            this.dateTimePicker2.Location = new System.Drawing.Point(3, 44);
            this.dateTimePicker2.Name = "dateTimePicker2";
            this.dateTimePicker2.Size = new System.Drawing.Size(135, 22);
            this.dateTimePicker2.TabIndex = 1;
            // 
            // tabPage3
            // 
            this.tabPage3.Controls.Add(this.groupBox4);
            this.tabPage3.Controls.Add(this.groupBox3);
            this.tabPage3.Location = new System.Drawing.Point(4, 25);
            this.tabPage3.Name = "tabPage3";
            this.tabPage3.Size = new System.Drawing.Size(627, 392);
            this.tabPage3.TabIndex = 2;
            this.tabPage3.Text = "Faktura  för Logi";
            this.tabPage3.UseVisualStyleBackColor = true;
            // 
            // groupBox4
            // 
            this.groupBox4.Controls.Add(this.btnskrivutf);
            this.groupBox4.Controls.Add(this.gvfldata);
            this.groupBox4.Location = new System.Drawing.Point(3, 91);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(590, 293);
            this.groupBox4.TabIndex = 4;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "Data";
            // 
            // btnskrivutf
            // 
            this.btnskrivutf.Location = new System.Drawing.Point(448, 238);
            this.btnskrivutf.Name = "btnskrivutf";
            this.btnskrivutf.Size = new System.Drawing.Size(125, 36);
            this.btnskrivutf.TabIndex = 3;
            this.btnskrivutf.Text = "Skriv ut faktura";
            this.btnskrivutf.UseVisualStyleBackColor = true;
            this.btnskrivutf.Click += new System.EventHandler(this.btnskrivutf_Click);
            // 
            // gvfldata
            // 
            this.gvfldata.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.gvfldata.ImeMode = System.Windows.Forms.ImeMode.Off;
            this.gvfldata.Location = new System.Drawing.Point(11, 16);
            this.gvfldata.Name = "gvfldata";
            this.gvfldata.RowHeadersWidth = 62;
            this.gvfldata.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            this.gvfldata.RowTemplate.Height = 28;
            this.gvfldata.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.gvfldata.Size = new System.Drawing.Size(563, 218);
            this.gvfldata.TabIndex = 2;
            this.gvfldata.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.gvfldata_CellContentClick);
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.button10);
            this.groupBox3.Controls.Add(this.label5);
            this.groupBox3.Controls.Add(this.dateTimePicker1);
            this.groupBox3.Location = new System.Drawing.Point(13, 3);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(211, 84);
            this.groupBox3.TabIndex = 3;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Datum";
            // 
            // button10
            // 
            this.button10.Location = new System.Drawing.Point(141, 44);
            this.button10.Name = "button10";
            this.button10.Size = new System.Drawing.Size(67, 26);
            this.button10.TabIndex = 2;
            this.button10.Text = "Sök";
            this.button10.UseVisualStyleBackColor = true;
            this.button10.Click += new System.EventHandler(this.button10_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(3, 26);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(74, 17);
            this.label5.TabIndex = 0;
            this.label5.Text = "Välj datum";
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.Location = new System.Drawing.Point(3, 44);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(135, 22);
            this.dateTimePicker1.TabIndex = 1;
            this.dateTimePicker1.ValueChanged += new System.EventHandler(this.dateTimePicker1_ValueChanged);
            // 
            // tabPage6
            // 
            this.tabPage6.Controls.Add(this.btnavböjb);
            this.tabPage6.Controls.Add(this.btngodkändb);
            this.tabPage6.Controls.Add(this.btnsökpb);
            this.tabPage6.Controls.Add(this.textBox2);
            this.tabPage6.Controls.Add(this.gvpbokning);
            this.tabPage6.Location = new System.Drawing.Point(4, 25);
            this.tabPage6.Name = "tabPage6";
            this.tabPage6.Size = new System.Drawing.Size(627, 392);
            this.tabPage6.TabIndex = 5;
            this.tabPage6.Text = "Godkänna preliminärbokningar";
            this.tabPage6.UseVisualStyleBackColor = true;
            // 
            // btnavböjb
            // 
            this.btnavböjb.Location = new System.Drawing.Point(317, 315);
            this.btnavböjb.Name = "btnavböjb";
            this.btnavböjb.Size = new System.Drawing.Size(142, 28);
            this.btnavböjb.TabIndex = 9;
            this.btnavböjb.Text = "Avslå bokning";
            this.btnavböjb.UseVisualStyleBackColor = true;
            this.btnavböjb.Click += new System.EventHandler(this.btnavböjb_Click);
            // 
            // btngodkändb
            // 
            this.btngodkändb.Location = new System.Drawing.Point(467, 315);
            this.btngodkändb.Name = "btngodkändb";
            this.btngodkändb.Size = new System.Drawing.Size(142, 28);
            this.btngodkändb.TabIndex = 8;
            this.btngodkändb.Text = " Godkänd bokning";
            this.btngodkändb.UseVisualStyleBackColor = true;
            this.btngodkändb.Click += new System.EventHandler(this.btngodkändb_Click);
            // 
            // btnsökpb
            // 
            this.btnsökpb.Location = new System.Drawing.Point(203, 20);
            this.btnsökpb.Name = "btnsökpb";
            this.btnsökpb.Size = new System.Drawing.Size(91, 27);
            this.btnsökpb.TabIndex = 7;
            this.btnsökpb.Text = "Sök";
            this.btnsökpb.UseVisualStyleBackColor = true;
            this.btnsökpb.Click += new System.EventHandler(this.btnsökpb_Click);
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(19, 26);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(172, 22);
            this.textBox2.TabIndex = 6;
            this.textBox2.TextChanged += new System.EventHandler(this.textBox2_TextChanged);
            this.textBox2.KeyDown += new System.Windows.Forms.KeyEventHandler(this.textBox2_KeyDown);
            // 
            // gvpbokning
            // 
            this.gvpbokning.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.gvpbokning.Location = new System.Drawing.Point(13, 56);
            this.gvpbokning.Name = "gvpbokning";
            this.gvpbokning.RowHeadersWidth = 62;
            this.gvpbokning.RowTemplate.Height = 28;
            this.gvpbokning.Size = new System.Drawing.Size(595, 248);
            this.gvpbokning.TabIndex = 5;
            this.gvpbokning.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.gvpbokning_CellContentClick);
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPage6);
            this.tabControl1.Controls.Add(this.tabPage3);
            this.tabControl1.Controls.Add(this.tabPage4);
            this.tabControl1.Controls.Add(this.tabPage5);
            this.tabControl1.Location = new System.Drawing.Point(23, 58);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(635, 421);
            this.tabControl1.TabIndex = 12;
            // 
            // Marknad
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(696, 479);
            this.Controls.Add(this.btnloggaut);
            this.Controls.Add(this.tabControl1);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.btntillbaka);
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Name = "Marknad";
            this.Text = "Marknadschef";
            this.Load += new System.EventHandler(this.Marknad_Load);
            this.tabPage5.ResumeLayout(false);
            this.tabPage5.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dvpersonaldata)).EndInit();
            this.tabPage4.ResumeLayout(false);
            this.groupBox5.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.gvfdata)).EndInit();
            this.groupBox6.ResumeLayout(false);
            this.groupBox6.PerformLayout();
            this.tabPage3.ResumeLayout(false);
            this.groupBox4.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.gvfldata)).EndInit();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.tabPage6.ResumeLayout(false);
            this.tabPage6.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gvpbokning)).EndInit();
            this.tabControl1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        private void btnkonvertexcel_Click(object sender, EventArgs e)
        {
            throw new NotImplementedException();
        }

        #endregion

        private System.Windows.Forms.Button btnloggaut;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TabPage tabPage5;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Button btnsökp;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Button btntabortp;
        private System.Windows.Forms.DataGridView dvpersonaldata;
        private System.Windows.Forms.Button btntillbaka;
        private System.Windows.Forms.TabPage tabPage4;
        private System.Windows.Forms.GroupBox groupBox5;
        private System.Windows.Forms.Button btnskrivutfakturas;
        private System.Windows.Forms.DataGridView gvfdata;
        private System.Windows.Forms.GroupBox groupBox6;
        private System.Windows.Forms.Button button11;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.DateTimePicker dateTimePicker2;
        private System.Windows.Forms.TabPage tabPage3;
        private System.Windows.Forms.GroupBox groupBox4;
        private System.Windows.Forms.Button btnskrivutf;
        private System.Windows.Forms.DataGridView gvfldata;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.Button button10;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.DateTimePicker dateTimePicker1;
        private System.Windows.Forms.TabPage tabPage6;
        private System.Windows.Forms.Button btnavböjb;
        private System.Windows.Forms.Button btngodkändb;
        private System.Windows.Forms.Button btnsökpb;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.DataGridView gvpbokning;
        private System.Windows.Forms.TabControl tabControl1;
    }
}