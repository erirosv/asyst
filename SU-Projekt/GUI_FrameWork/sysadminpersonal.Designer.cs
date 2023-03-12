using System;

namespace GUI_FrameWork
{
    partial class sysadminpersonal
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
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.sökupdatepersonal = new System.Windows.Forms.Button();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.button3 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.btnändrapersonal = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.btntabortpersonal = new System.Windows.Forms.Button();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.comboBox2 = new System.Windows.Forms.ComboBox();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.cbanställdstyp = new System.Windows.Forms.ComboBox();
            this.cbbehörig = new System.Windows.Forms.ComboBox();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.tblösen = new System.Windows.Forms.TextBox();
            this.tbenamn = new System.Windows.Forms.TextBox();
            this.tbfnamn = new System.Windows.Forms.TextBox();
            this.tbanamn = new System.Windows.Forms.TextBox();
            this.dvpersonaldata = new System.Windows.Forms.DataGridView();
            this.btnuppdateraanställd = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.tabControl1.SuspendLayout();
            this.tabPage2.SuspendLayout();
            this.groupBox4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dvpersonaldata)).BeginInit();
            this.SuspendLayout();
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Location = new System.Drawing.Point(0, 31);
            this.tabControl1.Margin = new System.Windows.Forms.Padding(4);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(1322, 552);
            this.tabControl1.TabIndex = 15;
            // 
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.sökupdatepersonal);
            this.tabPage2.Controls.Add(this.textBox1);
            this.tabPage2.Controls.Add(this.button3);
            this.tabPage2.Controls.Add(this.button2);
            this.tabPage2.Controls.Add(this.btnändrapersonal);
            this.tabPage2.Controls.Add(this.label1);
            this.tabPage2.Controls.Add(this.btntabortpersonal);
            this.tabPage2.Controls.Add(this.groupBox4);
            this.tabPage2.Controls.Add(this.dvpersonaldata);
            this.tabPage2.Controls.Add(this.btnuppdateraanställd);
            this.tabPage2.Location = new System.Drawing.Point(8, 39);
            this.tabPage2.Margin = new System.Windows.Forms.Padding(4);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(4);
            this.tabPage2.Size = new System.Drawing.Size(1306, 505);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Anställdslista";
            this.tabPage2.UseVisualStyleBackColor = true;
            this.tabPage2.Click += new System.EventHandler(this.tabPage2_Click);
            // 
            // sökupdatepersonal
            // 
            this.sökupdatepersonal.Location = new System.Drawing.Point(392, 7);
            this.sökupdatepersonal.Name = "sökupdatepersonal";
            this.sökupdatepersonal.Size = new System.Drawing.Size(168, 60);
            this.sökupdatepersonal.TabIndex = 43;
            this.sökupdatepersonal.Text = "Sök";
            this.sökupdatepersonal.UseVisualStyleBackColor = true;
            this.sökupdatepersonal.Click += new System.EventHandler(this.sökupdatepersonal_Click);
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(166, 25);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(220, 31);
            this.textBox1.TabIndex = 42;
            this.textBox1.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(200, 429);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(208, 44);
            this.button3.TabIndex = 41;
            this.button3.Text = "Lägg till personal";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(380, 823);
            this.button2.Margin = new System.Windows.Forms.Padding(6);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(396, 87);
            this.button2.TabIndex = 40;
            this.button2.Text = "Lägg till Personal";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // btnändrapersonal
            // 
            this.btnändrapersonal.Location = new System.Drawing.Point(1566, 823);
            this.btnändrapersonal.Margin = new System.Windows.Forms.Padding(4);
            this.btnändrapersonal.Name = "btnändrapersonal";
            this.btnändrapersonal.Size = new System.Drawing.Size(112, 44);
            this.btnändrapersonal.TabIndex = 39;
            this.btnändrapersonal.Text = "Ändra";
            this.btnändrapersonal.UseVisualStyleBackColor = true;
            this.btnändrapersonal.Click += new System.EventHandler(this.btnändrapersonal_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(16, 19);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(143, 37);
            this.label1.TabIndex = 38;
            this.label1.Text = "Personal";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // btntabortpersonal
            // 
            this.btntabortpersonal.Location = new System.Drawing.Point(24, 429);
            this.btntabortpersonal.Margin = new System.Windows.Forms.Padding(4);
            this.btntabortpersonal.Name = "btntabortpersonal";
            this.btntabortpersonal.Size = new System.Drawing.Size(148, 44);
            this.btntabortpersonal.TabIndex = 37;
            this.btntabortpersonal.Text = "Ta bort personal";
            this.btntabortpersonal.UseVisualStyleBackColor = true;
            this.btntabortpersonal.Click += new System.EventHandler(this.btntabortpersonal_Click_1);
            // 
            // groupBox4
            // 
            this.groupBox4.Controls.Add(this.comboBox2);
            this.groupBox4.Controls.Add(this.comboBox1);
            this.groupBox4.Controls.Add(this.cbanställdstyp);
            this.groupBox4.Controls.Add(this.cbbehörig);
            this.groupBox4.Controls.Add(this.label8);
            this.groupBox4.Controls.Add(this.label9);
            this.groupBox4.Controls.Add(this.label10);
            this.groupBox4.Controls.Add(this.label11);
            this.groupBox4.Controls.Add(this.label12);
            this.groupBox4.Controls.Add(this.label13);
            this.groupBox4.Controls.Add(this.tblösen);
            this.groupBox4.Controls.Add(this.tbenamn);
            this.groupBox4.Controls.Add(this.tbfnamn);
            this.groupBox4.Controls.Add(this.tbanamn);
            this.groupBox4.Location = new System.Drawing.Point(924, 85);
            this.groupBox4.Margin = new System.Windows.Forms.Padding(4);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Padding = new System.Windows.Forms.Padding(4);
            this.groupBox4.Size = new System.Drawing.Size(376, 338);
            this.groupBox4.TabIndex = 36;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "Information";
            // 
            // comboBox2
            // 
            this.comboBox2.FormattingEnabled = true;
            this.comboBox2.Items.AddRange(new object[] {
            "Anställd",
            "Marknadschef",
            "Systemadmin"});
            this.comboBox2.Location = new System.Drawing.Point(202, 258);
            this.comboBox2.Name = "comboBox2";
            this.comboBox2.Size = new System.Drawing.Size(152, 33);
            this.comboBox2.TabIndex = 42;
            this.comboBox2.SelectedIndexChanged += new System.EventHandler(this.comboBox2_SelectedIndexChanged);
            // 
            // comboBox1
            // 
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Items.AddRange(new object[] {
            "Admin",
            "Butik",
            "Chef",
            "Reception",
            "Skidskola"});
            this.comboBox1.Location = new System.Drawing.Point(202, 218);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(152, 33);
            this.comboBox1.TabIndex = 41;
            this.comboBox1.SelectedIndexChanged += new System.EventHandler(this.comboBox1_SelectedIndexChanged);
            // 
            // cbanställdstyp
            // 
            this.cbanställdstyp.FormattingEnabled = true;
            this.cbanställdstyp.Items.AddRange(new object[] {
            "Anställd",
            "Marknadschef",
            "Systemadministratör"});
            this.cbanställdstyp.Location = new System.Drawing.Point(404, 496);
            this.cbanställdstyp.Margin = new System.Windows.Forms.Padding(4);
            this.cbanställdstyp.Name = "cbanställdstyp";
            this.cbanställdstyp.Size = new System.Drawing.Size(152, 33);
            this.cbanställdstyp.TabIndex = 41;
            // 
            // cbbehörig
            // 
            this.cbbehörig.FormattingEnabled = true;
            this.cbbehörig.Items.AddRange(new object[] {
            "Admin",
            "Butik",
            "Marknadschef",
            "Reception",
            "Skidskola"});
            this.cbbehörig.Location = new System.Drawing.Point(404, 417);
            this.cbbehörig.Margin = new System.Windows.Forms.Padding(4);
            this.cbbehörig.Name = "cbbehörig";
            this.cbbehörig.Size = new System.Drawing.Size(152, 33);
            this.cbbehörig.TabIndex = 39;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(6, 258);
            this.label8.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(135, 25);
            this.label8.TabIndex = 40;
            this.label8.Text = "Anställds typ";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(6, 221);
            this.label9.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(116, 25);
            this.label9.TabIndex = 39;
            this.label9.Text = "Behörighet";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(6, 181);
            this.label10.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(102, 25);
            this.label10.TabIndex = 38;
            this.label10.Text = "Lösenord";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(6, 138);
            this.label11.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(110, 25);
            this.label11.TabIndex = 37;
            this.label11.Text = "Efternamn";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(6, 88);
            this.label12.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(97, 25);
            this.label12.TabIndex = 36;
            this.label12.Text = "Förnamn";
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(6, 44);
            this.label13.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(157, 25);
            this.label13.TabIndex = 35;
            this.label13.Text = "Användarnamn";
            // 
            // tblösen
            // 
            this.tblösen.Location = new System.Drawing.Point(202, 175);
            this.tblösen.Margin = new System.Windows.Forms.Padding(4);
            this.tblösen.Name = "tblösen";
            this.tblösen.Size = new System.Drawing.Size(152, 31);
            this.tblösen.TabIndex = 32;
            this.tblösen.TextChanged += new System.EventHandler(this.tblösen_TextChanged);
            // 
            // tbenamn
            // 
            this.tbenamn.Location = new System.Drawing.Point(202, 131);
            this.tbenamn.Margin = new System.Windows.Forms.Padding(4);
            this.tbenamn.Name = "tbenamn";
            this.tbenamn.Size = new System.Drawing.Size(152, 31);
            this.tbenamn.TabIndex = 31;
            this.tbenamn.TextChanged += new System.EventHandler(this.tbenamn_TextChanged);
            // 
            // tbfnamn
            // 
            this.tbfnamn.Location = new System.Drawing.Point(202, 85);
            this.tbfnamn.Margin = new System.Windows.Forms.Padding(4);
            this.tbfnamn.Name = "tbfnamn";
            this.tbfnamn.Size = new System.Drawing.Size(152, 31);
            this.tbfnamn.TabIndex = 30;
            this.tbfnamn.TextChanged += new System.EventHandler(this.tbfnamn_TextChanged);
            // 
            // tbanamn
            // 
            this.tbanamn.Location = new System.Drawing.Point(202, 40);
            this.tbanamn.Margin = new System.Windows.Forms.Padding(4);
            this.tbanamn.Name = "tbanamn";
            this.tbanamn.Size = new System.Drawing.Size(152, 31);
            this.tbanamn.TabIndex = 29;
            this.tbanamn.TextChanged += new System.EventHandler(this.tbanamn_TextChanged);
            // 
            // dvpersonaldata
            // 
            this.dvpersonaldata.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dvpersonaldata.Location = new System.Drawing.Point(24, 71);
            this.dvpersonaldata.Margin = new System.Windows.Forms.Padding(4);
            this.dvpersonaldata.Name = "dvpersonaldata";
            this.dvpersonaldata.RowHeadersWidth = 62;
            this.dvpersonaldata.RowTemplate.Height = 28;
            this.dvpersonaldata.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dvpersonaldata.Size = new System.Drawing.Size(896, 351);
            this.dvpersonaldata.TabIndex = 35;
            this.dvpersonaldata.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dvpersonaldata_CellContentClick_1);
            this.dvpersonaldata.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dvpersonaldata_CellContentClick_1);
            // 
            // btnuppdateraanställd
            // 
            this.btnuppdateraanställd.Location = new System.Drawing.Point(924, 429);
            this.btnuppdateraanställd.Margin = new System.Windows.Forms.Padding(4);
            this.btnuppdateraanställd.Name = "btnuppdateraanställd";
            this.btnuppdateraanställd.Size = new System.Drawing.Size(148, 44);
            this.btnuppdateraanställd.TabIndex = 32;
            this.btnuppdateraanställd.Text = "Uppdatera";
            this.btnuppdateraanställd.UseVisualStyleBackColor = true;
            this.btnuppdateraanställd.Click += new System.EventHandler(this.btnuppdateraanställd_Click_1);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(1080, 598);
            this.button1.Margin = new System.Windows.Forms.Padding(4);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(240, 63);
            this.button1.TabIndex = 16;
            this.button1.Text = "Tillbaka";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // sysadminpersonal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1392, 733);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.tabControl1);
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "sysadminpersonal";
            this.Text = "sysadminpersonal";
            this.tabControl1.ResumeLayout(false);
            this.tabPage2.ResumeLayout(false);
            this.tabPage2.PerformLayout();
            this.groupBox4.ResumeLayout(false);
            this.groupBox4.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dvpersonaldata)).EndInit();
            this.ResumeLayout(false);

        }

        private void btnändrapersonal_Click(object sender, EventArgs e)
        {
            throw new NotImplementedException();
        }

        #endregion

        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.Button btnändrapersonal;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btntabortpersonal;
        private System.Windows.Forms.GroupBox groupBox4;
        private System.Windows.Forms.ComboBox cbanställdstyp;
        private System.Windows.Forms.ComboBox cbbehörig;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.TextBox tblösen;
        private System.Windows.Forms.TextBox tbenamn;
        private System.Windows.Forms.TextBox tbfnamn;
        private System.Windows.Forms.TextBox tbanamn;
        private System.Windows.Forms.DataGridView dvpersonaldata;
        private System.Windows.Forms.Button btnuppdateraanställd;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.ComboBox comboBox2;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.Button sökupdatepersonal;
        private System.Windows.Forms.TextBox textBox1;
    }
}