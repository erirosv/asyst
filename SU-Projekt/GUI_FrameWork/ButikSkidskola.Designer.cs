namespace GUI_FrameWork
{
    partial class ButikSkidskola
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
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.label7 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.comboBoxTid = new System.Windows.Forms.ComboBox();
            this.btPrivRegistrera = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.textBoxPrivDeltagarnamn = new System.Windows.Forms.TextBox();
            this.btSkolaUtskrift = new System.Windows.Forms.Button();
            this.checkBoxSkolaFaktura = new System.Windows.Forms.CheckBox();
            this.checkBoxSkolaKontant = new System.Windows.Forms.CheckBox();
            this.label25 = new System.Windows.Forms.Label();
            this.btDeltagareTaBort = new System.Windows.Forms.Button();
            this.label24 = new System.Windows.Forms.Label();
            this.btSkolaSökBokning = new System.Windows.Forms.Button();
            this.textBoxSkolaSökBokning = new System.Windows.Forms.TextBox();
            this.dataGridViewSkolaBokningar = new System.Windows.Forms.DataGridView();
            this.btSkolaSparaBokning = new System.Windows.Forms.Button();
            this.btRegistrera = new System.Windows.Forms.Button();
            this.label28 = new System.Windows.Forms.Label();
            this.textBoxDeltagarNamn = new System.Windows.Forms.TextBox();
            this.label27 = new System.Windows.Forms.Label();
            this.cbLektionsTyp = new System.Windows.Forms.ComboBox();
            this.checkBoxMånOns = new System.Windows.Forms.CheckBox();
            this.checkBoxMånFre = new System.Windows.Forms.CheckBox();
            this.button1 = new System.Windows.Forms.Button();
            this.Grupplektion = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.registreradgrupp = new System.Windows.Forms.DataGridView();
            this.label3 = new System.Windows.Forms.Label();
            this.button3 = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.button2 = new System.Windows.Forms.Button();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.registreradprivat = new System.Windows.Forms.DataGridView();
            this.label2 = new System.Windows.Forms.Label();
            this.sparabokningprivat = new System.Windows.Forms.Button();
            this.checkBoxkontantprivat = new System.Windows.Forms.CheckBox();
            this.checkboxfakturaprivat = new System.Windows.Forms.CheckBox();
            this.btnBack = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewSkolaBokningar)).BeginInit();
            this.Grupplektion.SuspendLayout();
            this.tabPage1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.registreradgrupp)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.tabPage2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.registreradprivat)).BeginInit();
            this.SuspendLayout();
            // 
            // comboBox1
            // 
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Items.AddRange(new object[] {
            "En deltagare",
            "Två deltagare"});
            this.comboBox1.Location = new System.Drawing.Point(8, 72);
            this.comboBox1.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(152, 33);
            this.comboBox1.TabIndex = 20;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(8, 35);
            this.label7.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(61, 25);
            this.label7.TabIndex = 19;
            this.label7.Text = "Antal";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(8, 119);
            this.label5.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(42, 25);
            this.label5.TabIndex = 16;
            this.label5.Text = "Tid";
            // 
            // comboBoxTid
            // 
            this.comboBoxTid.FormattingEnabled = true;
            this.comboBoxTid.Location = new System.Drawing.Point(8, 158);
            this.comboBoxTid.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.comboBoxTid.Name = "comboBoxTid";
            this.comboBoxTid.Size = new System.Drawing.Size(152, 33);
            this.comboBoxTid.TabIndex = 15;
            this.comboBoxTid.SelectedIndexChanged += new System.EventHandler(this.comboBoxTid_SelectedIndexChanged);
            // 
            // btPrivRegistrera
            // 
            this.btPrivRegistrera.Location = new System.Drawing.Point(300, 382);
            this.btPrivRegistrera.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btPrivRegistrera.Name = "btPrivRegistrera";
            this.btPrivRegistrera.Size = new System.Drawing.Size(136, 40);
            this.btPrivRegistrera.TabIndex = 14;
            this.btPrivRegistrera.Text = "Registrera";
            this.btPrivRegistrera.UseVisualStyleBackColor = true;
            this.btPrivRegistrera.Click += new System.EventHandler(this.btPrivRegistrera_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(-1, 362);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(151, 25);
            this.label4.TabIndex = 13;
            this.label4.Text = "Deltagarnamm";
            // 
            // textBoxPrivDeltagarnamn
            // 
            this.textBoxPrivDeltagarnamn.Location = new System.Drawing.Point(4, 392);
            this.textBoxPrivDeltagarnamn.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.textBoxPrivDeltagarnamn.Name = "textBoxPrivDeltagarnamn";
            this.textBoxPrivDeltagarnamn.Size = new System.Drawing.Size(284, 31);
            this.textBoxPrivDeltagarnamn.TabIndex = 12;
            // 
            // btSkolaUtskrift
            // 
            this.btSkolaUtskrift.Location = new System.Drawing.Point(1077, 576);
            this.btSkolaUtskrift.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btSkolaUtskrift.Name = "btSkolaUtskrift";
            this.btSkolaUtskrift.Size = new System.Drawing.Size(148, 50);
            this.btSkolaUtskrift.TabIndex = 7;
            this.btSkolaUtskrift.Text = "Till utskrift";
            this.btSkolaUtskrift.UseVisualStyleBackColor = true;
            this.btSkolaUtskrift.Click += new System.EventHandler(this.btSkolaUtskrift_Click);
            // 
            // checkBoxSkolaFaktura
            // 
            this.checkBoxSkolaFaktura.AutoSize = true;
            this.checkBoxSkolaFaktura.Location = new System.Drawing.Point(868, 36);
            this.checkBoxSkolaFaktura.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.checkBoxSkolaFaktura.Name = "checkBoxSkolaFaktura";
            this.checkBoxSkolaFaktura.Size = new System.Drawing.Size(117, 29);
            this.checkBoxSkolaFaktura.TabIndex = 18;
            this.checkBoxSkolaFaktura.Text = "Faktura";
            this.checkBoxSkolaFaktura.UseVisualStyleBackColor = true;
            this.checkBoxSkolaFaktura.CheckedChanged += new System.EventHandler(this.checkBoxSkolaFaktura_CheckedChanged);
            // 
            // checkBoxSkolaKontant
            // 
            this.checkBoxSkolaKontant.AutoSize = true;
            this.checkBoxSkolaKontant.Location = new System.Drawing.Point(867, 74);
            this.checkBoxSkolaKontant.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.checkBoxSkolaKontant.Name = "checkBoxSkolaKontant";
            this.checkBoxSkolaKontant.Size = new System.Drawing.Size(118, 29);
            this.checkBoxSkolaKontant.TabIndex = 17;
            this.checkBoxSkolaKontant.Text = "Kontant";
            this.checkBoxSkolaKontant.UseVisualStyleBackColor = true;
            this.checkBoxSkolaKontant.CheckedChanged += new System.EventHandler(this.checkBoxSkolaKontant_CheckedChanged);
            // 
            // label25
            // 
            this.label25.AutoSize = true;
            this.label25.Location = new System.Drawing.Point(863, 2);
            this.label25.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label25.Name = "label25";
            this.label25.Size = new System.Drawing.Size(96, 25);
            this.label25.TabIndex = 16;
            this.label25.Text = "Betalsätt";
            // 
            // btDeltagareTaBort
            // 
            this.btDeltagareTaBort.Location = new System.Drawing.Point(511, 382);
            this.btDeltagareTaBort.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btDeltagareTaBort.Name = "btDeltagareTaBort";
            this.btDeltagareTaBort.Size = new System.Drawing.Size(212, 36);
            this.btDeltagareTaBort.TabIndex = 15;
            this.btDeltagareTaBort.Text = "Ta bort deltagare";
            this.btDeltagareTaBort.UseVisualStyleBackColor = true;
            this.btDeltagareTaBort.Click += new System.EventHandler(this.btDeltagareTaBort_Click);
            // 
            // label24
            // 
            this.label24.AutoSize = true;
            this.label24.Location = new System.Drawing.Point(232, 0);
            this.label24.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label24.Name = "label24";
            this.label24.Size = new System.Drawing.Size(131, 25);
            this.label24.TabIndex = 14;
            this.label24.Text = "Sök bokning";
            // 
            // btSkolaSökBokning
            // 
            this.btSkolaSökBokning.Location = new System.Drawing.Point(640, 26);
            this.btSkolaSökBokning.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btSkolaSökBokning.Name = "btSkolaSökBokning";
            this.btSkolaSökBokning.Size = new System.Drawing.Size(116, 39);
            this.btSkolaSökBokning.TabIndex = 13;
            this.btSkolaSökBokning.Text = "Sök";
            this.btSkolaSökBokning.UseVisualStyleBackColor = true;
            this.btSkolaSökBokning.Click += new System.EventHandler(this.btSkolaSökBokning_Click);
            // 
            // textBoxSkolaSökBokning
            // 
            this.textBoxSkolaSökBokning.Location = new System.Drawing.Point(237, 35);
            this.textBoxSkolaSökBokning.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.textBoxSkolaSökBokning.Name = "textBoxSkolaSökBokning";
            this.textBoxSkolaSökBokning.Size = new System.Drawing.Size(260, 31);
            this.textBoxSkolaSökBokning.TabIndex = 11;
            this.textBoxSkolaSökBokning.TextChanged += new System.EventHandler(this.textBoxSkolaSökBokning_TextChanged);
            // 
            // dataGridViewSkolaBokningar
            // 
            this.dataGridViewSkolaBokningar.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewSkolaBokningar.Location = new System.Drawing.Point(237, 74);
            this.dataGridViewSkolaBokningar.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.dataGridViewSkolaBokningar.Name = "dataGridViewSkolaBokningar";
            this.dataGridViewSkolaBokningar.RowHeadersWidth = 62;
            this.dataGridViewSkolaBokningar.RowTemplate.Height = 28;
            this.dataGridViewSkolaBokningar.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridViewSkolaBokningar.Size = new System.Drawing.Size(519, 265);
            this.dataGridViewSkolaBokningar.TabIndex = 0;
            this.dataGridViewSkolaBokningar.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridViewSkolaBokningar_CellContentClick);
            // 
            // btSkolaSparaBokning
            // 
            this.btSkolaSparaBokning.Location = new System.Drawing.Point(867, 110);
            this.btSkolaSparaBokning.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btSkolaSparaBokning.Name = "btSkolaSparaBokning";
            this.btSkolaSparaBokning.Size = new System.Drawing.Size(148, 72);
            this.btSkolaSparaBokning.TabIndex = 19;
            this.btSkolaSparaBokning.Text = "Spara bokning";
            this.btSkolaSparaBokning.UseVisualStyleBackColor = true;
            this.btSkolaSparaBokning.Click += new System.EventHandler(this.btSkolaSparaBokning_Click);
            // 
            // btRegistrera
            // 
            this.btRegistrera.Location = new System.Drawing.Point(316, 435);
            this.btRegistrera.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btRegistrera.Name = "btRegistrera";
            this.btRegistrera.Size = new System.Drawing.Size(148, 44);
            this.btRegistrera.TabIndex = 12;
            this.btRegistrera.Text = "Registrera";
            this.btRegistrera.UseVisualStyleBackColor = true;
            this.btRegistrera.Click += new System.EventHandler(this.btRegistrera_Click_1);
            // 
            // label28
            // 
            this.label28.AutoSize = true;
            this.label28.Location = new System.Drawing.Point(4, 419);
            this.label28.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label28.Name = "label28";
            this.label28.Size = new System.Drawing.Size(151, 25);
            this.label28.TabIndex = 11;
            this.label28.Text = "Deltagarnamm";
            // 
            // textBoxDeltagarNamn
            // 
            this.textBoxDeltagarNamn.Location = new System.Drawing.Point(8, 448);
            this.textBoxDeltagarNamn.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.textBoxDeltagarNamn.Name = "textBoxDeltagarNamn";
            this.textBoxDeltagarNamn.Size = new System.Drawing.Size(288, 31);
            this.textBoxDeltagarNamn.TabIndex = 10;
            this.textBoxDeltagarNamn.TextChanged += new System.EventHandler(this.textBoxDeltagarNamn_TextChanged);
            // 
            // label27
            // 
            this.label27.AutoSize = true;
            this.label27.Location = new System.Drawing.Point(1, 199);
            this.label27.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label27.Name = "label27";
            this.label27.Size = new System.Drawing.Size(122, 25);
            this.label27.TabIndex = 7;
            this.label27.Text = "Lektionstyp";
            // 
            // cbLektionsTyp
            // 
            this.cbLektionsTyp.FormattingEnabled = true;
            this.cbLektionsTyp.Items.AddRange(new object[] {
            "Grön",
            "Röd",
            "Blå"});
            this.cbLektionsTyp.Location = new System.Drawing.Point(8, 228);
            this.cbLektionsTyp.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.cbLektionsTyp.Name = "cbLektionsTyp";
            this.cbLektionsTyp.Size = new System.Drawing.Size(120, 33);
            this.cbLektionsTyp.TabIndex = 6;
            this.cbLektionsTyp.SelectedIndexChanged += new System.EventHandler(this.cbLektionsTyp_SelectedIndexChanged);
            // 
            // checkBoxMånOns
            // 
            this.checkBoxMånOns.AutoSize = true;
            this.checkBoxMånOns.Location = new System.Drawing.Point(12, 80);
            this.checkBoxMånOns.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.checkBoxMånOns.Name = "checkBoxMånOns";
            this.checkBoxMånOns.Size = new System.Drawing.Size(132, 29);
            this.checkBoxMånOns.TabIndex = 2;
            this.checkBoxMånOns.Text = "Mån-Ons";
            this.checkBoxMånOns.UseVisualStyleBackColor = true;
            this.checkBoxMånOns.CheckedChanged += new System.EventHandler(this.checkBoxMånOns_CheckedChanged);
            // 
            // checkBoxMånFre
            // 
            this.checkBoxMånFre.AutoSize = true;
            this.checkBoxMånFre.Location = new System.Drawing.Point(11, 115);
            this.checkBoxMånFre.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.checkBoxMånFre.Name = "checkBoxMånFre";
            this.checkBoxMånFre.Size = new System.Drawing.Size(125, 29);
            this.checkBoxMånFre.TabIndex = 1;
            this.checkBoxMånFre.Text = "Mån-Fre";
            this.checkBoxMånFre.UseVisualStyleBackColor = true;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(4, 240);
            this.button1.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(148, 72);
            this.button1.TabIndex = 20;
            this.button1.Text = "Lägg till kund";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // Grupplektion
            // 
            this.Grupplektion.Controls.Add(this.tabPage1);
            this.Grupplektion.Controls.Add(this.tabPage2);
            this.Grupplektion.Location = new System.Drawing.Point(3, 2);
            this.Grupplektion.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Grupplektion.Name = "Grupplektion";
            this.Grupplektion.SelectedIndex = 0;
            this.Grupplektion.Size = new System.Drawing.Size(1067, 858);
            this.Grupplektion.TabIndex = 21;
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.registreradgrupp);
            this.tabPage1.Controls.Add(this.label3);
            this.tabPage1.Controls.Add(this.button3);
            this.tabPage1.Controls.Add(this.label25);
            this.tabPage1.Controls.Add(this.btSkolaSparaBokning);
            this.tabPage1.Controls.Add(this.checkBoxSkolaFaktura);
            this.tabPage1.Controls.Add(this.label1);
            this.tabPage1.Controls.Add(this.checkBoxSkolaKontant);
            this.tabPage1.Controls.Add(this.button2);
            this.tabPage1.Controls.Add(this.textBox1);
            this.tabPage1.Controls.Add(this.dataGridView1);
            this.tabPage1.Controls.Add(this.label28);
            this.tabPage1.Controls.Add(this.btRegistrera);
            this.tabPage1.Controls.Add(this.cbLektionsTyp);
            this.tabPage1.Controls.Add(this.label27);
            this.tabPage1.Controls.Add(this.textBoxDeltagarNamn);
            this.tabPage1.Controls.Add(this.checkBoxMånFre);
            this.tabPage1.Controls.Add(this.checkBoxMånOns);
            this.tabPage1.Location = new System.Drawing.Point(8, 39);
            this.tabPage1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.tabPage1.Size = new System.Drawing.Size(1051, 811);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Grupplektion";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // registreradgrupp
            // 
            this.registreradgrupp.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.registreradgrupp.Location = new System.Drawing.Point(8, 486);
            this.registreradgrupp.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.registreradgrupp.Name = "registreradgrupp";
            this.registreradgrupp.RowHeadersWidth = 82;
            this.registreradgrupp.RowTemplate.Height = 33;
            this.registreradgrupp.Size = new System.Drawing.Size(653, 322);
            this.registreradgrupp.TabIndex = 21;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(8, 36);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(122, 25);
            this.label3.TabIndex = 20;
            this.label3.Text = "Antal dagar";
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(9, 302);
            this.button3.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(163, 85);
            this.button3.TabIndex = 17;
            this.button3.Text = "Lägg till kund";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(225, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(131, 25);
            this.label1.TabIndex = 16;
            this.label1.Text = "Sök bokning";
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(577, 12);
            this.button2.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(179, 49);
            this.button2.TabIndex = 15;
            this.button2.Text = "Sök";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(229, 31);
            this.textBox1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(247, 31);
            this.textBox1.TabIndex = 14;
            this.textBox1.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(229, 69);
            this.dataGridView1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 82;
            this.dataGridView1.RowTemplate.Height = 33;
            this.dataGridView1.Size = new System.Drawing.Size(527, 320);
            this.dataGridView1.TabIndex = 13;
            // 
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.registreradprivat);
            this.tabPage2.Controls.Add(this.label2);
            this.tabPage2.Controls.Add(this.sparabokningprivat);
            this.tabPage2.Controls.Add(this.checkBoxkontantprivat);
            this.tabPage2.Controls.Add(this.checkboxfakturaprivat);
            this.tabPage2.Controls.Add(this.btDeltagareTaBort);
            this.tabPage2.Controls.Add(this.label7);
            this.tabPage2.Controls.Add(this.button1);
            this.tabPage2.Controls.Add(this.comboBox1);
            this.tabPage2.Controls.Add(this.comboBoxTid);
            this.tabPage2.Controls.Add(this.label5);
            this.tabPage2.Controls.Add(this.btSkolaSökBokning);
            this.tabPage2.Controls.Add(this.label24);
            this.tabPage2.Controls.Add(this.label4);
            this.tabPage2.Controls.Add(this.btPrivRegistrera);
            this.tabPage2.Controls.Add(this.textBoxSkolaSökBokning);
            this.tabPage2.Controls.Add(this.textBoxPrivDeltagarnamn);
            this.tabPage2.Controls.Add(this.dataGridViewSkolaBokningar);
            this.tabPage2.Location = new System.Drawing.Point(8, 39);
            this.tabPage2.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.tabPage2.Size = new System.Drawing.Size(1051, 811);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Privatlektion";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // registreradprivat
            // 
            this.registreradprivat.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.registreradprivat.Location = new System.Drawing.Point(3, 430);
            this.registreradprivat.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.registreradprivat.Name = "registreradprivat";
            this.registreradprivat.RowHeadersWidth = 82;
            this.registreradprivat.RowTemplate.Height = 33;
            this.registreradprivat.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.registreradprivat.Size = new System.Drawing.Size(720, 375);
            this.registreradprivat.TabIndex = 25;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(891, 2);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(96, 25);
            this.label2.TabIndex = 24;
            this.label2.Text = "Betalsätt";
            // 
            // sparabokningprivat
            // 
            this.sparabokningprivat.Location = new System.Drawing.Point(896, 115);
            this.sparabokningprivat.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.sparabokningprivat.Name = "sparabokningprivat";
            this.sparabokningprivat.Size = new System.Drawing.Size(148, 72);
            this.sparabokningprivat.TabIndex = 23;
            this.sparabokningprivat.Text = "Spara bokning";
            this.sparabokningprivat.UseVisualStyleBackColor = true;
            this.sparabokningprivat.Click += new System.EventHandler(this.sparabokningprivat_Click);
            // 
            // checkBoxkontantprivat
            // 
            this.checkBoxkontantprivat.AutoSize = true;
            this.checkBoxkontantprivat.Location = new System.Drawing.Point(896, 80);
            this.checkBoxkontantprivat.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.checkBoxkontantprivat.Name = "checkBoxkontantprivat";
            this.checkBoxkontantprivat.Size = new System.Drawing.Size(118, 29);
            this.checkBoxkontantprivat.TabIndex = 22;
            this.checkBoxkontantprivat.Text = "Kontant";
            this.checkBoxkontantprivat.UseVisualStyleBackColor = true;
            // 
            // checkboxfakturaprivat
            // 
            this.checkboxfakturaprivat.AutoSize = true;
            this.checkboxfakturaprivat.Location = new System.Drawing.Point(896, 31);
            this.checkboxfakturaprivat.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.checkboxfakturaprivat.Name = "checkboxfakturaprivat";
            this.checkboxfakturaprivat.Size = new System.Drawing.Size(117, 29);
            this.checkboxfakturaprivat.TabIndex = 21;
            this.checkboxfakturaprivat.Text = "Faktura";
            this.checkboxfakturaprivat.UseVisualStyleBackColor = true;
            // 
            // btnBack
            // 
            this.btnBack.Location = new System.Drawing.Point(1077, 636);
            this.btnBack.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnBack.Name = "btnBack";
            this.btnBack.Size = new System.Drawing.Size(148, 49);
            this.btnBack.TabIndex = 27;
            this.btnBack.Text = "Tillbaka";
            this.btnBack.UseVisualStyleBackColor = true;
            this.btnBack.Click += new System.EventHandler(this.btnBack_Click);
            // 
            // ButikSkidskola
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.btnBack);
            this.Controls.Add(this.Grupplektion);
            this.Controls.Add(this.btSkolaUtskrift);
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "ButikSkidskola";
            this.Size = new System.Drawing.Size(1325, 1015);
            this.Load += new System.EventHandler(this.ButikSkidskola_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewSkolaBokningar)).EndInit();
            this.Grupplektion.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tabPage1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.registreradgrupp)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.tabPage2.ResumeLayout(false);
            this.tabPage2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.registreradprivat)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.ComboBox comboBoxTid;
        private System.Windows.Forms.Button btPrivRegistrera;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox textBoxPrivDeltagarnamn;
        private System.Windows.Forms.Button btSkolaUtskrift;
        private System.Windows.Forms.Button btSkolaSparaBokning;
        private System.Windows.Forms.CheckBox checkBoxSkolaFaktura;
        private System.Windows.Forms.CheckBox checkBoxSkolaKontant;
        private System.Windows.Forms.Label label25;
        private System.Windows.Forms.Button btDeltagareTaBort;
        private System.Windows.Forms.Label label24;
        private System.Windows.Forms.Button btSkolaSökBokning;
        private System.Windows.Forms.TextBox textBoxSkolaSökBokning;
        private System.Windows.Forms.DataGridView dataGridViewSkolaBokningar;
        private System.Windows.Forms.Button btRegistrera;
        private System.Windows.Forms.Label label28;
        private System.Windows.Forms.TextBox textBoxDeltagarNamn;
        private System.Windows.Forms.Label label27;
        private System.Windows.Forms.ComboBox cbLektionsTyp;
        private System.Windows.Forms.CheckBox checkBoxMånOns;
        private System.Windows.Forms.CheckBox checkBoxMånFre;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.TabControl Grupplektion;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button sparabokningprivat;
        private System.Windows.Forms.CheckBox checkBoxkontantprivat;
        private System.Windows.Forms.CheckBox checkboxfakturaprivat;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.DataGridView registreradgrupp;
        private System.Windows.Forms.DataGridView registreradprivat;
        private System.Windows.Forms.Button btnBack;
    }
}
