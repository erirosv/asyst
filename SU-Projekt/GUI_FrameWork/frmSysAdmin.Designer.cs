namespace GUI_FrameWork
{
    partial class frmSysAdmin
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
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.label4 = new System.Windows.Forms.Label();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.button3 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.tabPage3 = new System.Windows.Forms.TabPage();
            this.groupBox5 = new System.Windows.Forms.GroupBox();
            this.btntabortlogidata = new System.Windows.Forms.Button();
            this.btntabortlogiinfo = new System.Windows.Forms.Button();
            this.btnsparalogiinfo = new System.Windows.Forms.Button();
            this.btnsökinfo = new System.Windows.Forms.Button();
            this.tblogiinfo = new System.Windows.Forms.TextBox();
            this.dglogidata = new System.Windows.Forms.DataGridView();
            this.tabPage4 = new System.Windows.Forms.TabPage();
            this.groupBox6 = new System.Windows.Forms.GroupBox();
            this.btntabortalldata = new System.Windows.Forms.Button();
            this.btntabort = new System.Windows.Forms.Button();
            this.btnsparakonf = new System.Windows.Forms.Button();
            this.btnsökkonferens = new System.Windows.Forms.Button();
            this.tbsökkonferens = new System.Windows.Forms.TextBox();
            this.dvkonferensinfo = new System.Windows.Forms.DataGridView();
            this.tabPage5 = new System.Windows.Forms.TabPage();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.btnsparahyrinfo = new System.Windows.Forms.Button();
            this.btntaborthyrdata = new System.Windows.Forms.Button();
            this.btnsökhyr = new System.Windows.Forms.Button();
            this.tbhyrinfo = new System.Windows.Forms.TextBox();
            this.dvhyrdata = new System.Windows.Forms.DataGridView();
            this.bttillbaka = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.tabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.tabPage3.SuspendLayout();
            this.groupBox5.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dglogidata)).BeginInit();
            this.tabPage4.SuspendLayout();
            this.groupBox6.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dvkonferensinfo)).BeginInit();
            this.tabPage5.SuspendLayout();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dvhyrdata)).BeginInit();
            this.SuspendLayout();
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Controls.Add(this.tabPage3);
            this.tabControl1.Controls.Add(this.tabPage4);
            this.tabControl1.Controls.Add(this.tabPage5);
            this.tabControl1.Location = new System.Drawing.Point(24, 92);
            this.tabControl1.Margin = new System.Windows.Forms.Padding(3, 1, 3, 1);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(892, 614);
            this.tabControl1.TabIndex = 14;
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.label4);
            this.tabPage1.Controls.Add(this.groupBox3);
            this.tabPage1.Location = new System.Drawing.Point(8, 39);
            this.tabPage1.Margin = new System.Windows.Forms.Padding(3, 1, 3, 1);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3, 1, 3, 1);
            this.tabPage1.Size = new System.Drawing.Size(876, 567);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Prislistor";
            this.tabPage1.UseVisualStyleBackColor = true;
            this.tabPage1.Click += new System.EventHandler(this.tabPage1_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(4, 19);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(140, 37);
            this.label4.TabIndex = 5;
            this.label4.Text = "Prislistor";
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.button3);
            this.groupBox3.Controls.Add(this.button2);
            this.groupBox3.Controls.Add(this.button1);
            this.groupBox3.Location = new System.Drawing.Point(20, 62);
            this.groupBox3.Margin = new System.Windows.Forms.Padding(3, 1, 3, 1);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Padding = new System.Windows.Forms.Padding(3, 1, 3, 1);
            this.groupBox3.Size = new System.Drawing.Size(628, 206);
            this.groupBox3.TabIndex = 2;
            this.groupBox3.TabStop = false;
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(416, 94);
            this.button3.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(188, 51);
            this.button3.TabIndex = 8;
            this.button3.Text = "Konferenspriser";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(227, 94);
            this.button2.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(123, 51);
            this.button2.TabIndex = 7;
            this.button2.Text = "Hyrpriser";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(25, 94);
            this.button1.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(140, 51);
            this.button1.TabIndex = 6;
            this.button1.Text = "Logipriser";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // tabPage3
            // 
            this.tabPage3.Controls.Add(this.groupBox5);
            this.tabPage3.Location = new System.Drawing.Point(8, 39);
            this.tabPage3.Margin = new System.Windows.Forms.Padding(3, 1, 3, 1);
            this.tabPage3.Name = "tabPage3";
            this.tabPage3.Size = new System.Drawing.Size(876, 567);
            this.tabPage3.TabIndex = 2;
            this.tabPage3.Text = "Logilista ";
            this.tabPage3.UseVisualStyleBackColor = true;
            // 
            // groupBox5
            // 
            this.groupBox5.Controls.Add(this.btntabortlogidata);
            this.groupBox5.Controls.Add(this.btntabortlogiinfo);
            this.groupBox5.Controls.Add(this.btnsparalogiinfo);
            this.groupBox5.Controls.Add(this.btnsökinfo);
            this.groupBox5.Controls.Add(this.tblogiinfo);
            this.groupBox5.Controls.Add(this.dglogidata);
            this.groupBox5.Location = new System.Drawing.Point(3, 1);
            this.groupBox5.Margin = new System.Windows.Forms.Padding(3, 1, 3, 1);
            this.groupBox5.Name = "groupBox5";
            this.groupBox5.Padding = new System.Windows.Forms.Padding(3, 1, 3, 1);
            this.groupBox5.Size = new System.Drawing.Size(804, 528);
            this.groupBox5.TabIndex = 0;
            this.groupBox5.TabStop = false;
            this.groupBox5.Text = "Logi information";
            // 
            // btntabortlogidata
            // 
            this.btntabortlogidata.Location = new System.Drawing.Point(176, 375);
            this.btntabortlogidata.Margin = new System.Windows.Forms.Padding(3, 1, 3, 1);
            this.btntabortlogidata.Name = "btntabortlogidata";
            this.btntabortlogidata.Size = new System.Drawing.Size(203, 51);
            this.btntabortlogidata.TabIndex = 10;
            this.btntabortlogidata.Text = "Ta bort all data";
            this.btntabortlogidata.UseVisualStyleBackColor = true;
            this.btntabortlogidata.Click += new System.EventHandler(this.btntabortlogidata_Click);
            // 
            // btntabortlogiinfo
            // 
            this.btntabortlogiinfo.Location = new System.Drawing.Point(0, 375);
            this.btntabortlogiinfo.Margin = new System.Windows.Forms.Padding(3, 1, 3, 1);
            this.btntabortlogiinfo.Name = "btntabortlogiinfo";
            this.btntabortlogiinfo.Size = new System.Drawing.Size(164, 51);
            this.btntabortlogiinfo.TabIndex = 9;
            this.btntabortlogiinfo.Text = "Ta bort";
            this.btntabortlogiinfo.UseVisualStyleBackColor = true;
            this.btntabortlogiinfo.Click += new System.EventHandler(this.btntabortlogiinfo_Click);
            // 
            // btnsparalogiinfo
            // 
            this.btnsparalogiinfo.Location = new System.Drawing.Point(585, 375);
            this.btnsparalogiinfo.Margin = new System.Windows.Forms.Padding(3, 1, 3, 1);
            this.btnsparalogiinfo.Name = "btnsparalogiinfo";
            this.btnsparalogiinfo.Size = new System.Drawing.Size(164, 51);
            this.btnsparalogiinfo.TabIndex = 8;
            this.btnsparalogiinfo.Text = "Spara";
            this.btnsparalogiinfo.UseVisualStyleBackColor = true;
            this.btnsparalogiinfo.Click += new System.EventHandler(this.btnsparalogiinfo_Click);
            // 
            // btnsökinfo
            // 
            this.btnsökinfo.Location = new System.Drawing.Point(207, 39);
            this.btnsökinfo.Margin = new System.Windows.Forms.Padding(3, 1, 3, 1);
            this.btnsökinfo.Name = "btnsökinfo";
            this.btnsökinfo.Size = new System.Drawing.Size(93, 35);
            this.btnsökinfo.TabIndex = 4;
            this.btnsökinfo.Text = "Sök";
            this.btnsökinfo.UseVisualStyleBackColor = true;
            this.btnsökinfo.Click += new System.EventHandler(this.Button13_Click);
            // 
            // tblogiinfo
            // 
            this.tblogiinfo.Location = new System.Drawing.Point(15, 39);
            this.tblogiinfo.Margin = new System.Windows.Forms.Padding(3, 1, 3, 1);
            this.tblogiinfo.Name = "tblogiinfo";
            this.tblogiinfo.Size = new System.Drawing.Size(183, 31);
            this.tblogiinfo.TabIndex = 3;
            this.tblogiinfo.TextChanged += new System.EventHandler(this.tblogiinfo_TextChanged);
            // 
            // dglogidata
            // 
            this.dglogidata.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dglogidata.Location = new System.Drawing.Point(4, 99);
            this.dglogidata.Margin = new System.Windows.Forms.Padding(3, 1, 3, 1);
            this.dglogidata.Name = "dglogidata";
            this.dglogidata.RowHeadersWidth = 62;
            this.dglogidata.RowTemplate.Height = 28;
            this.dglogidata.Size = new System.Drawing.Size(741, 256);
            this.dglogidata.TabIndex = 0;
            this.dglogidata.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dglogidata_CellContentClick);
            // 
            // tabPage4
            // 
            this.tabPage4.Controls.Add(this.groupBox6);
            this.tabPage4.Location = new System.Drawing.Point(8, 39);
            this.tabPage4.Margin = new System.Windows.Forms.Padding(3, 1, 3, 1);
            this.tabPage4.Name = "tabPage4";
            this.tabPage4.Size = new System.Drawing.Size(876, 567);
            this.tabPage4.TabIndex = 3;
            this.tabPage4.Text = "Konferenslista ";
            this.tabPage4.UseVisualStyleBackColor = true;
            // 
            // groupBox6
            // 
            this.groupBox6.Controls.Add(this.btntabortalldata);
            this.groupBox6.Controls.Add(this.btntabort);
            this.groupBox6.Controls.Add(this.btnsparakonf);
            this.groupBox6.Controls.Add(this.btnsökkonferens);
            this.groupBox6.Controls.Add(this.tbsökkonferens);
            this.groupBox6.Controls.Add(this.dvkonferensinfo);
            this.groupBox6.Location = new System.Drawing.Point(3, 12);
            this.groupBox6.Margin = new System.Windows.Forms.Padding(3, 1, 3, 1);
            this.groupBox6.Name = "groupBox6";
            this.groupBox6.Padding = new System.Windows.Forms.Padding(3, 1, 3, 1);
            this.groupBox6.Size = new System.Drawing.Size(804, 528);
            this.groupBox6.TabIndex = 1;
            this.groupBox6.TabStop = false;
            this.groupBox6.Text = "Konferens information";
            // 
            // btntabortalldata
            // 
            this.btntabortalldata.Location = new System.Drawing.Point(188, 381);
            this.btntabortalldata.Margin = new System.Windows.Forms.Padding(3, 1, 3, 1);
            this.btntabortalldata.Name = "btntabortalldata";
            this.btntabortalldata.Size = new System.Drawing.Size(196, 51);
            this.btntabortalldata.TabIndex = 10;
            this.btntabortalldata.Text = "Ta bort all data";
            this.btntabortalldata.UseVisualStyleBackColor = true;
            this.btntabortalldata.Click += new System.EventHandler(this.btntabortalldata_Click);
            // 
            // btntabort
            // 
            this.btntabort.Location = new System.Drawing.Point(4, 381);
            this.btntabort.Margin = new System.Windows.Forms.Padding(3, 1, 3, 1);
            this.btntabort.Name = "btntabort";
            this.btntabort.Size = new System.Drawing.Size(164, 51);
            this.btntabort.TabIndex = 9;
            this.btntabort.Text = "Ta bort";
            this.btntabort.UseVisualStyleBackColor = true;
            this.btntabort.Click += new System.EventHandler(this.btntabort_Click);
            // 
            // btnsparakonf
            // 
            this.btnsparakonf.Location = new System.Drawing.Point(585, 381);
            this.btnsparakonf.Margin = new System.Windows.Forms.Padding(3, 1, 3, 1);
            this.btnsparakonf.Name = "btnsparakonf";
            this.btnsparakonf.Size = new System.Drawing.Size(164, 51);
            this.btnsparakonf.TabIndex = 8;
            this.btnsparakonf.Text = "Spara";
            this.btnsparakonf.UseVisualStyleBackColor = true;
            this.btnsparakonf.Click += new System.EventHandler(this.btnsparakonf_Click);
            // 
            // btnsökkonferens
            // 
            this.btnsökkonferens.Location = new System.Drawing.Point(196, 61);
            this.btnsökkonferens.Margin = new System.Windows.Forms.Padding(3, 1, 3, 1);
            this.btnsökkonferens.Name = "btnsökkonferens";
            this.btnsökkonferens.Size = new System.Drawing.Size(99, 35);
            this.btnsökkonferens.TabIndex = 4;
            this.btnsökkonferens.Text = "Sök";
            this.btnsökkonferens.UseVisualStyleBackColor = true;
            this.btnsökkonferens.Click += new System.EventHandler(this.btnsökkonferens_Click);
            // 
            // tbsökkonferens
            // 
            this.tbsökkonferens.Location = new System.Drawing.Point(4, 61);
            this.tbsökkonferens.Margin = new System.Windows.Forms.Padding(3, 1, 3, 1);
            this.tbsökkonferens.Name = "tbsökkonferens";
            this.tbsökkonferens.Size = new System.Drawing.Size(183, 31);
            this.tbsökkonferens.TabIndex = 3;
            this.tbsökkonferens.TextChanged += new System.EventHandler(this.tbsökkonferens_TextChanged);
            // 
            // dvkonferensinfo
            // 
            this.dvkonferensinfo.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dvkonferensinfo.Location = new System.Drawing.Point(4, 101);
            this.dvkonferensinfo.Margin = new System.Windows.Forms.Padding(3, 1, 3, 1);
            this.dvkonferensinfo.Name = "dvkonferensinfo";
            this.dvkonferensinfo.RowHeadersWidth = 62;
            this.dvkonferensinfo.RowTemplate.Height = 28;
            this.dvkonferensinfo.Size = new System.Drawing.Size(741, 256);
            this.dvkonferensinfo.TabIndex = 0;
            this.dvkonferensinfo.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dvkonferensinfo_CellContentClick);
            // 
            // tabPage5
            // 
            this.tabPage5.Controls.Add(this.groupBox1);
            this.tabPage5.Location = new System.Drawing.Point(8, 39);
            this.tabPage5.Margin = new System.Windows.Forms.Padding(3, 1, 3, 1);
            this.tabPage5.Name = "tabPage5";
            this.tabPage5.Size = new System.Drawing.Size(876, 567);
            this.tabPage5.TabIndex = 4;
            this.tabPage5.Text = "Hyrutrustninglista";
            this.tabPage5.UseVisualStyleBackColor = true;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.btnsparahyrinfo);
            this.groupBox1.Controls.Add(this.btntaborthyrdata);
            this.groupBox1.Controls.Add(this.btnsökhyr);
            this.groupBox1.Controls.Add(this.tbhyrinfo);
            this.groupBox1.Controls.Add(this.dvhyrdata);
            this.groupBox1.Location = new System.Drawing.Point(3, 1);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(3, 1, 3, 1);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(3, 1, 3, 1);
            this.groupBox1.Size = new System.Drawing.Size(875, 472);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Hyr information";
            // 
            // btnsparahyrinfo
            // 
            this.btnsparahyrinfo.Location = new System.Drawing.Point(716, 399);
            this.btnsparahyrinfo.Margin = new System.Windows.Forms.Padding(3, 1, 3, 1);
            this.btnsparahyrinfo.Name = "btnsparahyrinfo";
            this.btnsparahyrinfo.Size = new System.Drawing.Size(147, 51);
            this.btnsparahyrinfo.TabIndex = 5;
            this.btnsparahyrinfo.Text = "Spara";
            this.btnsparahyrinfo.UseVisualStyleBackColor = true;
            // 
            // btntaborthyrdata
            // 
            this.btntaborthyrdata.Location = new System.Drawing.Point(40, 399);
            this.btntaborthyrdata.Margin = new System.Windows.Forms.Padding(3, 1, 3, 1);
            this.btntaborthyrdata.Name = "btntaborthyrdata";
            this.btntaborthyrdata.Size = new System.Drawing.Size(189, 51);
            this.btntaborthyrdata.TabIndex = 3;
            this.btntaborthyrdata.Text = "Ta bort hyr data";
            this.btntaborthyrdata.UseVisualStyleBackColor = true;
            // 
            // btnsökhyr
            // 
            this.btnsökhyr.Location = new System.Drawing.Point(224, 30);
            this.btnsökhyr.Margin = new System.Windows.Forms.Padding(3, 1, 3, 1);
            this.btnsökhyr.Name = "btnsökhyr";
            this.btnsökhyr.Size = new System.Drawing.Size(93, 51);
            this.btnsökhyr.TabIndex = 2;
            this.btnsökhyr.Text = "Sök";
            this.btnsökhyr.UseVisualStyleBackColor = true;
            this.btnsökhyr.Click += new System.EventHandler(this.btnsökhyr_Click);
            // 
            // tbhyrinfo
            // 
            this.tbhyrinfo.Location = new System.Drawing.Point(15, 42);
            this.tbhyrinfo.Margin = new System.Windows.Forms.Padding(3, 1, 3, 1);
            this.tbhyrinfo.Name = "tbhyrinfo";
            this.tbhyrinfo.Size = new System.Drawing.Size(183, 31);
            this.tbhyrinfo.TabIndex = 1;
            // 
            // dvhyrdata
            // 
            this.dvhyrdata.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dvhyrdata.Location = new System.Drawing.Point(4, 92);
            this.dvhyrdata.Margin = new System.Windows.Forms.Padding(3, 1, 3, 1);
            this.dvhyrdata.Name = "dvhyrdata";
            this.dvhyrdata.RowHeadersWidth = 62;
            this.dvhyrdata.RowTemplate.Height = 28;
            this.dvhyrdata.Size = new System.Drawing.Size(853, 280);
            this.dvhyrdata.TabIndex = 0;
            this.dvhyrdata.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dvhyrdata_CellContentClick);
            // 
            // bttillbaka
            // 
            this.bttillbaka.Location = new System.Drawing.Point(549, 710);
            this.bttillbaka.Margin = new System.Windows.Forms.Padding(3, 1, 3, 1);
            this.bttillbaka.Name = "bttillbaka";
            this.bttillbaka.Size = new System.Drawing.Size(188, 70);
            this.bttillbaka.TabIndex = 13;
            this.bttillbaka.Text = "Tillbaka";
            this.bttillbaka.UseVisualStyleBackColor = true;
            this.bttillbaka.Click += new System.EventHandler(this.bttillbaka_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(20, 28);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(251, 55);
            this.label3.TabIndex = 12;
            this.label3.Text = "Ski-Center";
            this.label3.Click += new System.EventHandler(this.Label3_Click);
            // 
            // frmSysAdmin
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(940, 790);
            this.Controls.Add(this.tabControl1);
            this.Controls.Add(this.bttillbaka);
            this.Controls.Add(this.label3);
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "frmSysAdmin";
            this.Text = "Systemadministrator";
            this.tabControl1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tabPage1.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.tabPage3.ResumeLayout(false);
            this.groupBox5.ResumeLayout(false);
            this.groupBox5.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dglogidata)).EndInit();
            this.tabPage4.ResumeLayout(false);
            this.groupBox6.ResumeLayout(false);
            this.groupBox6.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dvkonferensinfo)).EndInit();
            this.tabPage5.ResumeLayout(false);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dvhyrdata)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.TabPage tabPage3;
        private System.Windows.Forms.GroupBox groupBox5;
        private System.Windows.Forms.Button btntabortlogidata;
        private System.Windows.Forms.Button btntabortlogiinfo;
        private System.Windows.Forms.Button btnsparalogiinfo;
        private System.Windows.Forms.Button btnsökinfo;
        private System.Windows.Forms.TextBox tblogiinfo;
        private System.Windows.Forms.DataGridView dglogidata;
        private System.Windows.Forms.TabPage tabPage4;
        private System.Windows.Forms.GroupBox groupBox6;
        private System.Windows.Forms.Button btntabortalldata;
        private System.Windows.Forms.Button btntabort;
        private System.Windows.Forms.Button btnsparakonf;
        private System.Windows.Forms.Button btnsökkonferens;
        private System.Windows.Forms.TextBox tbsökkonferens;
        private System.Windows.Forms.DataGridView dvkonferensinfo;
        private System.Windows.Forms.TabPage tabPage5;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button btnsparahyrinfo;
        private System.Windows.Forms.Button btntaborthyrdata;
        private System.Windows.Forms.Button btnsökhyr;
        private System.Windows.Forms.TextBox tbhyrinfo;
        private System.Windows.Forms.DataGridView dvhyrdata;
        private System.Windows.Forms.Button bttillbaka;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button1;
    }
}