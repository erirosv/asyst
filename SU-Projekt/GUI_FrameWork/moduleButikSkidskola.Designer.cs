namespace GUI_FrameWork
{
    partial class moduleButikSkidskola
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
            this.Grupplektion = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.registreradgrupp = new System.Windows.Forms.DataGridView();
            this.label3 = new System.Windows.Forms.Label();
            this.btnLäggTillKundG = new System.Windows.Forms.Button();
            this.label25 = new System.Windows.Forms.Label();
            this.btSkolaSparaBokning = new System.Windows.Forms.Button();
            this.checkBoxSkolaFaktura = new System.Windows.Forms.CheckBox();
            this.label1 = new System.Windows.Forms.Label();
            this.checkBoxSkolaKontant = new System.Windows.Forms.CheckBox();
            this.btnSearch = new System.Windows.Forms.Button();
            this.btnGruppSök = new System.Windows.Forms.TextBox();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.label28 = new System.Windows.Forms.Label();
            this.btRegistrera = new System.Windows.Forms.Button();
            this.cbLektionsTyp = new System.Windows.Forms.ComboBox();
            this.label27 = new System.Windows.Forms.Label();
            this.textBoxDeltagarNamn = new System.Windows.Forms.TextBox();
            this.checkBoxMånFre = new System.Windows.Forms.CheckBox();
            this.checkBoxMånOns = new System.Windows.Forms.CheckBox();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.registreradprivat = new System.Windows.Forms.DataGridView();
            this.label2 = new System.Windows.Forms.Label();
            this.sparabokningprivat = new System.Windows.Forms.Button();
            this.checkBoxkontantprivat = new System.Windows.Forms.CheckBox();
            this.checkboxfakturaprivat = new System.Windows.Forms.CheckBox();
            this.btDeltagareTaBort = new System.Windows.Forms.Button();
            this.label7 = new System.Windows.Forms.Label();
            this.btnLäggTillKund = new System.Windows.Forms.Button();
            this.cbAntal = new System.Windows.Forms.ComboBox();
            this.cbTid = new System.Windows.Forms.ComboBox();
            this.label5 = new System.Windows.Forms.Label();
            this.btSkolaSökBokning = new System.Windows.Forms.Button();
            this.label24 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.btPrivRegistrera = new System.Windows.Forms.Button();
            this.textBoxSkolaSökBokning = new System.Windows.Forms.TextBox();
            this.textBoxPrivDeltagarnamn = new System.Windows.Forms.TextBox();
            this.dataGridViewSkolaBokningar = new System.Windows.Forms.DataGridView();
            this.btnTaBortGDeltagre = new System.Windows.Forms.Button();
            this.Grupplektion.SuspendLayout();
            this.tabPage1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.registreradgrupp)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.tabPage2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.registreradprivat)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewSkolaBokningar)).BeginInit();
            this.SuspendLayout();
            // 
            // Grupplektion
            // 
            this.Grupplektion.Controls.Add(this.tabPage1);
            this.Grupplektion.Controls.Add(this.tabPage2);
            this.Grupplektion.Location = new System.Drawing.Point(2, 2);
            this.Grupplektion.Margin = new System.Windows.Forms.Padding(2);
            this.Grupplektion.Name = "Grupplektion";
            this.Grupplektion.SelectedIndex = 0;
            this.Grupplektion.Size = new System.Drawing.Size(800, 686);
            this.Grupplektion.TabIndex = 22;
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.btnTaBortGDeltagre);
            this.tabPage1.Controls.Add(this.registreradgrupp);
            this.tabPage1.Controls.Add(this.label3);
            this.tabPage1.Controls.Add(this.btnLäggTillKundG);
            this.tabPage1.Controls.Add(this.label25);
            this.tabPage1.Controls.Add(this.btSkolaSparaBokning);
            this.tabPage1.Controls.Add(this.checkBoxSkolaFaktura);
            this.tabPage1.Controls.Add(this.label1);
            this.tabPage1.Controls.Add(this.checkBoxSkolaKontant);
            this.tabPage1.Controls.Add(this.btnSearch);
            this.tabPage1.Controls.Add(this.btnGruppSök);
            this.tabPage1.Controls.Add(this.dataGridView1);
            this.tabPage1.Controls.Add(this.label28);
            this.tabPage1.Controls.Add(this.btRegistrera);
            this.tabPage1.Controls.Add(this.cbLektionsTyp);
            this.tabPage1.Controls.Add(this.label27);
            this.tabPage1.Controls.Add(this.textBoxDeltagarNamn);
            this.tabPage1.Controls.Add(this.checkBoxMånFre);
            this.tabPage1.Controls.Add(this.checkBoxMånOns);
            this.tabPage1.Location = new System.Drawing.Point(4, 29);
            this.tabPage1.Margin = new System.Windows.Forms.Padding(2);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(2);
            this.tabPage1.Size = new System.Drawing.Size(792, 653);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Grupplektion";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // registreradgrupp
            // 
            this.registreradgrupp.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.registreradgrupp.Location = new System.Drawing.Point(6, 389);
            this.registreradgrupp.Margin = new System.Windows.Forms.Padding(2);
            this.registreradgrupp.Name = "registreradgrupp";
            this.registreradgrupp.RowHeadersWidth = 82;
            this.registreradgrupp.RowTemplate.Height = 33;
            this.registreradgrupp.Size = new System.Drawing.Size(490, 258);
            this.registreradgrupp.TabIndex = 21;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(6, 29);
            this.label3.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(91, 20);
            this.label3.TabIndex = 20;
            this.label3.Text = "Antal dagar";
            // 
            // btnLäggTillKundG
            // 
            this.btnLäggTillKundG.Location = new System.Drawing.Point(7, 242);
            this.btnLäggTillKundG.Margin = new System.Windows.Forms.Padding(2);
            this.btnLäggTillKundG.Name = "btnLäggTillKundG";
            this.btnLäggTillKundG.Size = new System.Drawing.Size(122, 68);
            this.btnLäggTillKundG.TabIndex = 17;
            this.btnLäggTillKundG.Text = "Lägg till kund";
            this.btnLäggTillKundG.UseVisualStyleBackColor = true;
            this.btnLäggTillKundG.Click += new System.EventHandler(this.btnLäggTillKundG_Click);
            // 
            // label25
            // 
            this.label25.AutoSize = true;
            this.label25.Location = new System.Drawing.Point(647, 2);
            this.label25.Name = "label25";
            this.label25.Size = new System.Drawing.Size(73, 20);
            this.label25.TabIndex = 16;
            this.label25.Text = "Betalsätt";
            // 
            // btSkolaSparaBokning
            // 
            this.btSkolaSparaBokning.Location = new System.Drawing.Point(650, 88);
            this.btSkolaSparaBokning.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btSkolaSparaBokning.Name = "btSkolaSparaBokning";
            this.btSkolaSparaBokning.Size = new System.Drawing.Size(111, 58);
            this.btSkolaSparaBokning.TabIndex = 19;
            this.btSkolaSparaBokning.Text = "Spara bokning";
            this.btSkolaSparaBokning.UseVisualStyleBackColor = true;
            this.btSkolaSparaBokning.Click += new System.EventHandler(this.btSkolaSparaBokning_Click);
            // 
            // checkBoxSkolaFaktura
            // 
            this.checkBoxSkolaFaktura.AutoSize = true;
            this.checkBoxSkolaFaktura.Location = new System.Drawing.Point(651, 29);
            this.checkBoxSkolaFaktura.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.checkBoxSkolaFaktura.Name = "checkBoxSkolaFaktura";
            this.checkBoxSkolaFaktura.Size = new System.Drawing.Size(90, 24);
            this.checkBoxSkolaFaktura.TabIndex = 18;
            this.checkBoxSkolaFaktura.Text = "Faktura";
            this.checkBoxSkolaFaktura.UseVisualStyleBackColor = true;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(169, 0);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(97, 20);
            this.label1.TabIndex = 16;
            this.label1.Text = "Sök bokning";
            // 
            // checkBoxSkolaKontant
            // 
            this.checkBoxSkolaKontant.AutoSize = true;
            this.checkBoxSkolaKontant.Location = new System.Drawing.Point(650, 59);
            this.checkBoxSkolaKontant.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.checkBoxSkolaKontant.Name = "checkBoxSkolaKontant";
            this.checkBoxSkolaKontant.Size = new System.Drawing.Size(91, 24);
            this.checkBoxSkolaKontant.TabIndex = 17;
            this.checkBoxSkolaKontant.Text = "Kontant";
            this.checkBoxSkolaKontant.UseVisualStyleBackColor = true;
            // 
            // btnSearch
            // 
            this.btnSearch.Location = new System.Drawing.Point(433, 10);
            this.btnSearch.Margin = new System.Windows.Forms.Padding(2);
            this.btnSearch.Name = "btnSearch";
            this.btnSearch.Size = new System.Drawing.Size(134, 39);
            this.btnSearch.TabIndex = 15;
            this.btnSearch.Text = "Sök";
            this.btnSearch.UseVisualStyleBackColor = true;
            this.btnSearch.Click += new System.EventHandler(this.btnSearch_Click);
            // 
            // btnGruppSök
            // 
            this.btnGruppSök.Location = new System.Drawing.Point(172, 25);
            this.btnGruppSök.Margin = new System.Windows.Forms.Padding(2);
            this.btnGruppSök.Name = "btnGruppSök";
            this.btnGruppSök.Size = new System.Drawing.Size(186, 26);
            this.btnGruppSök.TabIndex = 14;
            this.btnGruppSök.TextChanged += new System.EventHandler(this.btnGruppSök_TextChanged);
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(172, 55);
            this.dataGridView1.Margin = new System.Windows.Forms.Padding(2);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 82;
            this.dataGridView1.RowTemplate.Height = 33;
            this.dataGridView1.Size = new System.Drawing.Size(395, 256);
            this.dataGridView1.TabIndex = 13;
            // 
            // label28
            // 
            this.label28.AutoSize = true;
            this.label28.Location = new System.Drawing.Point(3, 335);
            this.label28.Name = "label28";
            this.label28.Size = new System.Drawing.Size(114, 20);
            this.label28.TabIndex = 11;
            this.label28.Text = "Deltagarnamm";
            // 
            // btRegistrera
            // 
            this.btRegistrera.Location = new System.Drawing.Point(237, 348);
            this.btRegistrera.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btRegistrera.Name = "btRegistrera";
            this.btRegistrera.Size = new System.Drawing.Size(111, 35);
            this.btRegistrera.TabIndex = 12;
            this.btRegistrera.Text = "Registrera";
            this.btRegistrera.UseVisualStyleBackColor = true;
            this.btRegistrera.Click += new System.EventHandler(this.btRegistrera_Click);
            // 
            // cbLektionsTyp
            // 
            this.cbLektionsTyp.FormattingEnabled = true;
            this.cbLektionsTyp.Items.AddRange(new object[] {
            "Grön",
            "Röd",
            "Blå"});
            this.cbLektionsTyp.Location = new System.Drawing.Point(6, 182);
            this.cbLektionsTyp.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.cbLektionsTyp.Name = "cbLektionsTyp";
            this.cbLektionsTyp.Size = new System.Drawing.Size(91, 28);
            this.cbLektionsTyp.TabIndex = 6;
            // 
            // label27
            // 
            this.label27.AutoSize = true;
            this.label27.Location = new System.Drawing.Point(1, 159);
            this.label27.Name = "label27";
            this.label27.Size = new System.Drawing.Size(90, 20);
            this.label27.TabIndex = 7;
            this.label27.Text = "Lektionstyp";
            // 
            // textBoxDeltagarNamn
            // 
            this.textBoxDeltagarNamn.Location = new System.Drawing.Point(6, 358);
            this.textBoxDeltagarNamn.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.textBoxDeltagarNamn.Name = "textBoxDeltagarNamn";
            this.textBoxDeltagarNamn.Size = new System.Drawing.Size(217, 26);
            this.textBoxDeltagarNamn.TabIndex = 10;
            this.textBoxDeltagarNamn.TextChanged += new System.EventHandler(this.textBoxDeltagarNamn_TextChanged);
            // 
            // checkBoxMånFre
            // 
            this.checkBoxMånFre.AutoSize = true;
            this.checkBoxMånFre.Location = new System.Drawing.Point(8, 92);
            this.checkBoxMånFre.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.checkBoxMånFre.Name = "checkBoxMånFre";
            this.checkBoxMånFre.Size = new System.Drawing.Size(95, 24);
            this.checkBoxMånFre.TabIndex = 1;
            this.checkBoxMånFre.Text = "Mån-Fre";
            this.checkBoxMånFre.UseVisualStyleBackColor = true;
            // 
            // checkBoxMånOns
            // 
            this.checkBoxMånOns.AutoSize = true;
            this.checkBoxMånOns.Location = new System.Drawing.Point(9, 64);
            this.checkBoxMånOns.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.checkBoxMånOns.Name = "checkBoxMånOns";
            this.checkBoxMånOns.Size = new System.Drawing.Size(100, 24);
            this.checkBoxMånOns.TabIndex = 2;
            this.checkBoxMånOns.Text = "Mån-Ons";
            this.checkBoxMånOns.UseVisualStyleBackColor = true;
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
            this.tabPage2.Controls.Add(this.btnLäggTillKund);
            this.tabPage2.Controls.Add(this.cbAntal);
            this.tabPage2.Controls.Add(this.cbTid);
            this.tabPage2.Controls.Add(this.label5);
            this.tabPage2.Controls.Add(this.btSkolaSökBokning);
            this.tabPage2.Controls.Add(this.label24);
            this.tabPage2.Controls.Add(this.label4);
            this.tabPage2.Controls.Add(this.btPrivRegistrera);
            this.tabPage2.Controls.Add(this.textBoxSkolaSökBokning);
            this.tabPage2.Controls.Add(this.textBoxPrivDeltagarnamn);
            this.tabPage2.Controls.Add(this.dataGridViewSkolaBokningar);
            this.tabPage2.Location = new System.Drawing.Point(4, 29);
            this.tabPage2.Margin = new System.Windows.Forms.Padding(2);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(2);
            this.tabPage2.Size = new System.Drawing.Size(792, 653);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Privatlektion";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // registreradprivat
            // 
            this.registreradprivat.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.registreradprivat.Location = new System.Drawing.Point(2, 344);
            this.registreradprivat.Margin = new System.Windows.Forms.Padding(2);
            this.registreradprivat.Name = "registreradprivat";
            this.registreradprivat.RowHeadersWidth = 82;
            this.registreradprivat.RowTemplate.Height = 33;
            this.registreradprivat.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.registreradprivat.Size = new System.Drawing.Size(540, 300);
            this.registreradprivat.TabIndex = 25;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(668, 2);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(73, 20);
            this.label2.TabIndex = 24;
            this.label2.Text = "Betalsätt";
            // 
            // sparabokningprivat
            // 
            this.sparabokningprivat.Location = new System.Drawing.Point(672, 92);
            this.sparabokningprivat.Margin = new System.Windows.Forms.Padding(2);
            this.sparabokningprivat.Name = "sparabokningprivat";
            this.sparabokningprivat.Size = new System.Drawing.Size(111, 58);
            this.sparabokningprivat.TabIndex = 23;
            this.sparabokningprivat.Text = "Spara bokning";
            this.sparabokningprivat.UseVisualStyleBackColor = true;
            this.sparabokningprivat.Click += new System.EventHandler(this.sparabokningprivat_Click);
            // 
            // checkBoxkontantprivat
            // 
            this.checkBoxkontantprivat.AutoSize = true;
            this.checkBoxkontantprivat.Location = new System.Drawing.Point(672, 64);
            this.checkBoxkontantprivat.Margin = new System.Windows.Forms.Padding(2);
            this.checkBoxkontantprivat.Name = "checkBoxkontantprivat";
            this.checkBoxkontantprivat.Size = new System.Drawing.Size(91, 24);
            this.checkBoxkontantprivat.TabIndex = 22;
            this.checkBoxkontantprivat.Text = "Kontant";
            this.checkBoxkontantprivat.UseVisualStyleBackColor = true;
            // 
            // checkboxfakturaprivat
            // 
            this.checkboxfakturaprivat.AutoSize = true;
            this.checkboxfakturaprivat.Location = new System.Drawing.Point(672, 25);
            this.checkboxfakturaprivat.Margin = new System.Windows.Forms.Padding(2);
            this.checkboxfakturaprivat.Name = "checkboxfakturaprivat";
            this.checkboxfakturaprivat.Size = new System.Drawing.Size(90, 24);
            this.checkboxfakturaprivat.TabIndex = 21;
            this.checkboxfakturaprivat.Text = "Faktura";
            this.checkboxfakturaprivat.UseVisualStyleBackColor = true;
            // 
            // btDeltagareTaBort
            // 
            this.btDeltagareTaBort.Location = new System.Drawing.Point(383, 306);
            this.btDeltagareTaBort.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btDeltagareTaBort.Name = "btDeltagareTaBort";
            this.btDeltagareTaBort.Size = new System.Drawing.Size(159, 29);
            this.btDeltagareTaBort.TabIndex = 15;
            this.btDeltagareTaBort.Text = "Ta bort deltagare";
            this.btDeltagareTaBort.UseVisualStyleBackColor = true;
            this.btDeltagareTaBort.Click += new System.EventHandler(this.btDeltagareTaBort_Click);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(6, 28);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(46, 20);
            this.label7.TabIndex = 19;
            this.label7.Text = "Antal";
            // 
            // btnLäggTillKund
            // 
            this.btnLäggTillKund.Location = new System.Drawing.Point(10, 188);
            this.btnLäggTillKund.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnLäggTillKund.Name = "btnLäggTillKund";
            this.btnLäggTillKund.Size = new System.Drawing.Size(111, 58);
            this.btnLäggTillKund.TabIndex = 20;
            this.btnLäggTillKund.Text = "Lägg till kund";
            this.btnLäggTillKund.UseVisualStyleBackColor = true;
            this.btnLäggTillKund.Click += new System.EventHandler(this.btnLäggTillKund_Click);
            // 
            // cbAntal
            // 
            this.cbAntal.FormattingEnabled = true;
            this.cbAntal.Items.AddRange(new object[] {
            "En deltagare",
            "Två deltagare"});
            this.cbAntal.Location = new System.Drawing.Point(6, 58);
            this.cbAntal.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.cbAntal.Name = "cbAntal";
            this.cbAntal.Size = new System.Drawing.Size(115, 28);
            this.cbAntal.TabIndex = 20;
            // 
            // cbTid
            // 
            this.cbTid.FormattingEnabled = true;
            this.cbTid.Location = new System.Drawing.Point(6, 126);
            this.cbTid.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.cbTid.Name = "cbTid";
            this.cbTid.Size = new System.Drawing.Size(115, 28);
            this.cbTid.TabIndex = 15;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(6, 95);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(30, 20);
            this.label5.TabIndex = 16;
            this.label5.Text = "Tid";
            // 
            // btSkolaSökBokning
            // 
            this.btSkolaSökBokning.Location = new System.Drawing.Point(480, 21);
            this.btSkolaSökBokning.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btSkolaSökBokning.Name = "btSkolaSökBokning";
            this.btSkolaSökBokning.Size = new System.Drawing.Size(87, 31);
            this.btSkolaSökBokning.TabIndex = 13;
            this.btSkolaSökBokning.Text = "Sök";
            this.btSkolaSökBokning.UseVisualStyleBackColor = true;
            this.btSkolaSökBokning.Click += new System.EventHandler(this.btSkolaSökBokning_Click);
            // 
            // label24
            // 
            this.label24.AutoSize = true;
            this.label24.Location = new System.Drawing.Point(174, 0);
            this.label24.Name = "label24";
            this.label24.Size = new System.Drawing.Size(97, 20);
            this.label24.TabIndex = 14;
            this.label24.Text = "Sök bokning";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(-1, 290);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(114, 20);
            this.label4.TabIndex = 13;
            this.label4.Text = "Deltagarnamm";
            // 
            // btPrivRegistrera
            // 
            this.btPrivRegistrera.Location = new System.Drawing.Point(225, 306);
            this.btPrivRegistrera.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btPrivRegistrera.Name = "btPrivRegistrera";
            this.btPrivRegistrera.Size = new System.Drawing.Size(102, 32);
            this.btPrivRegistrera.TabIndex = 14;
            this.btPrivRegistrera.Text = "Registrera";
            this.btPrivRegistrera.UseVisualStyleBackColor = true;
            this.btPrivRegistrera.Click += new System.EventHandler(this.btPrivRegistrera_Click);
            // 
            // textBoxSkolaSökBokning
            // 
            this.textBoxSkolaSökBokning.Location = new System.Drawing.Point(178, 28);
            this.textBoxSkolaSökBokning.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.textBoxSkolaSökBokning.Name = "textBoxSkolaSökBokning";
            this.textBoxSkolaSökBokning.Size = new System.Drawing.Size(196, 26);
            this.textBoxSkolaSökBokning.TabIndex = 11;
            this.textBoxSkolaSökBokning.TextChanged += new System.EventHandler(this.textBoxSkolaSökBokning_TextChanged);
            // 
            // textBoxPrivDeltagarnamn
            // 
            this.textBoxPrivDeltagarnamn.Location = new System.Drawing.Point(3, 314);
            this.textBoxPrivDeltagarnamn.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.textBoxPrivDeltagarnamn.Name = "textBoxPrivDeltagarnamn";
            this.textBoxPrivDeltagarnamn.Size = new System.Drawing.Size(214, 26);
            this.textBoxPrivDeltagarnamn.TabIndex = 12;
            // 
            // dataGridViewSkolaBokningar
            // 
            this.dataGridViewSkolaBokningar.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewSkolaBokningar.Location = new System.Drawing.Point(178, 59);
            this.dataGridViewSkolaBokningar.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.dataGridViewSkolaBokningar.Name = "dataGridViewSkolaBokningar";
            this.dataGridViewSkolaBokningar.RowHeadersWidth = 62;
            this.dataGridViewSkolaBokningar.RowTemplate.Height = 28;
            this.dataGridViewSkolaBokningar.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridViewSkolaBokningar.Size = new System.Drawing.Size(389, 212);
            this.dataGridViewSkolaBokningar.TabIndex = 0;
            // 
            // btnTaBortGDeltagre
            // 
            this.btnTaBortGDeltagre.Location = new System.Drawing.Point(354, 351);
            this.btnTaBortGDeltagre.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnTaBortGDeltagre.Name = "btnTaBortGDeltagre";
            this.btnTaBortGDeltagre.Size = new System.Drawing.Size(142, 29);
            this.btnTaBortGDeltagre.TabIndex = 22;
            this.btnTaBortGDeltagre.Text = "Ta bort deltagare";
            this.btnTaBortGDeltagre.UseVisualStyleBackColor = true;
            this.btnTaBortGDeltagre.Click += new System.EventHandler(this.btnTaBortGDeltagre_Click);
            // 
            // moduleButikSkidskola
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.Grupplektion);
            this.Name = "moduleButikSkidskola";
            this.Size = new System.Drawing.Size(822, 711);
            this.Grupplektion.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tabPage1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.registreradgrupp)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.tabPage2.ResumeLayout(false);
            this.tabPage2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.registreradprivat)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewSkolaBokningar)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl Grupplektion;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.DataGridView registreradgrupp;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button btnLäggTillKundG;
        private System.Windows.Forms.Label label25;
        private System.Windows.Forms.Button btSkolaSparaBokning;
        private System.Windows.Forms.CheckBox checkBoxSkolaFaktura;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.CheckBox checkBoxSkolaKontant;
        private System.Windows.Forms.Button btnSearch;
        private System.Windows.Forms.TextBox btnGruppSök;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Label label28;
        private System.Windows.Forms.Button btRegistrera;
        private System.Windows.Forms.ComboBox cbLektionsTyp;
        private System.Windows.Forms.Label label27;
        private System.Windows.Forms.TextBox textBoxDeltagarNamn;
        private System.Windows.Forms.CheckBox checkBoxMånFre;
        private System.Windows.Forms.CheckBox checkBoxMånOns;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.DataGridView registreradprivat;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button sparabokningprivat;
        private System.Windows.Forms.CheckBox checkBoxkontantprivat;
        private System.Windows.Forms.CheckBox checkboxfakturaprivat;
        private System.Windows.Forms.Button btDeltagareTaBort;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Button btnLäggTillKund;
        private System.Windows.Forms.ComboBox cbAntal;
        private System.Windows.Forms.ComboBox cbTid;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button btSkolaSökBokning;
        private System.Windows.Forms.Label label24;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button btPrivRegistrera;
        private System.Windows.Forms.TextBox textBoxSkolaSökBokning;
        private System.Windows.Forms.TextBox textBoxPrivDeltagarnamn;
        private System.Windows.Forms.DataGridView dataGridViewSkolaBokningar;
        private System.Windows.Forms.Button btnTaBortGDeltagre;
    }
}
