namespace GUI_FrameWork
{
    partial class Bestat
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
            this.components = new System.ComponentModel.Container();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.dgBeStatic = new System.Windows.Forms.DataGridView();
            this.cbsäsong = new System.Windows.Forms.ComboBox();
            this.cbvecka = new System.Windows.Forms.ComboBox();
            this.ExporteraTillExellbt = new System.Windows.Forms.Button();
            this.cblogialternativ = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.bttillbaka = new System.Windows.Forms.Button();
            this.logiBokningBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.suht2009DataSet = new GUI_FrameWork.suht2009DataSet();
            this.logiBokningTableAdapter = new GUI_FrameWork.suht2009DataSetTableAdapters.LogiBokningTableAdapter();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgBeStatic)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.logiBokningBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.suht2009DataSet)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.dgBeStatic);
            this.groupBox1.Controls.Add(this.cbsäsong);
            this.groupBox1.Controls.Add(this.cbvecka);
            this.groupBox1.Controls.Add(this.ExporteraTillExellbt);
            this.groupBox1.Controls.Add(this.cblogialternativ);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Location = new System.Drawing.Point(44, 65);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(2);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(2);
            this.groupBox1.Size = new System.Drawing.Size(680, 364);
            this.groupBox1.TabIndex = 21;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Beläggningsstatistik";
            // 
            // dgBeStatic
            // 
            this.dgBeStatic.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgBeStatic.Location = new System.Drawing.Point(23, 83);
            this.dgBeStatic.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.dgBeStatic.Name = "dgBeStatic";
            this.dgBeStatic.RowHeadersWidth = 62;
            this.dgBeStatic.RowTemplate.Height = 28;
            this.dgBeStatic.Size = new System.Drawing.Size(638, 224);
            this.dgBeStatic.TabIndex = 25;
            this.dgBeStatic.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgBeStatic_CellContentClick);
            // 
            // cbsäsong
            // 
            this.cbsäsong.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.cbsäsong.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.cbsäsong.FormattingEnabled = true;
            this.cbsäsong.Items.AddRange(new object[] {
            "Säsong: Vinter",
            "Säsong: Sommar",
            "Säsong: Vår",
            "Säsong: Höst"});
            this.cbsäsong.Location = new System.Drawing.Point(263, 38);
            this.cbsäsong.Name = "cbsäsong";
            this.cbsäsong.Size = new System.Drawing.Size(131, 24);
            this.cbsäsong.TabIndex = 22;
            this.cbsäsong.Text = "Säsong: Vinter";
            this.cbsäsong.SelectedIndexChanged += new System.EventHandler(this.comboBox2_SelectedIndexChanged);
            // 
            // cbvecka
            // 
            this.cbvecka.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.cbvecka.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.cbvecka.FormattingEnabled = true;
            this.cbvecka.Items.AddRange(new object[] {
            "Vecka: 1",
            "Vecka: 2",
            "Vecka: 3",
            "Vecka: 4",
            "Vecka: 5",
            "Vecka: 6",
            "Vecka: 7",
            "Vecka: 8",
            "Vecka: 9",
            "Vecka: 10",
            "Vecka: 11",
            "Vecka: 12",
            "Vecka: 13",
            "Vecka: 14",
            "Vecka: 15",
            "Vecka: 16",
            "Vecka: 17",
            "Vecka: 18",
            "Vecka: 19",
            "Vecka: 20",
            "Vecka: 21",
            "Vecka: 22",
            "Vecka: 23",
            "Vecka: 24",
            "Vecka: 25",
            "Vecka: 26",
            "Vecka: 27",
            "Vecka: 28",
            "Vecka: 29",
            "Vecka: 30",
            "Vecka: 31",
            "Vecka: 32",
            "Vecka: 33",
            "Vecka: 34",
            "Vecka: 35",
            "Vecka: 36",
            "Vecka: 37",
            "Vecka: 38",
            "Vecka: 39",
            "Vecka: 40",
            "Vecka: 41",
            "Vecka: 42",
            "Vecka: 43",
            "Vecka: 44",
            "Vecka: 45",
            "Vecka: 46",
            "Vecka: 47",
            "Vecka: 48",
            "Vecka: 49",
            "Vecka: 50",
            "Vecka: 51",
            "Vecka: 52",
            "Vecka: 53"});
            this.cbvecka.Location = new System.Drawing.Point(162, 38);
            this.cbvecka.Name = "cbvecka";
            this.cbvecka.Size = new System.Drawing.Size(95, 24);
            this.cbvecka.TabIndex = 20;
            this.cbvecka.Text = "Vecka: 1";
            // 
            // ExporteraTillExellbt
            // 
            this.ExporteraTillExellbt.Location = new System.Drawing.Point(518, 324);
            this.ExporteraTillExellbt.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.ExporteraTillExellbt.Name = "ExporteraTillExellbt";
            this.ExporteraTillExellbt.Size = new System.Drawing.Size(143, 27);
            this.ExporteraTillExellbt.TabIndex = 18;
            this.ExporteraTillExellbt.Text = "Exportera till excel";
            this.ExporteraTillExellbt.UseVisualStyleBackColor = true;
            this.ExporteraTillExellbt.Click += new System.EventHandler(this.ExporteraTillExellbt_Click_1);
            // 
            // cblogialternativ
            // 
            this.cblogialternativ.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.cblogialternativ.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.cblogialternativ.FormattingEnabled = true;
            this.cblogialternativ.Items.AddRange(new object[] {
            "Typ I Lägenhet ",
            "Typ II Lägenhet ",
            "Camping"});
            this.cblogialternativ.Location = new System.Drawing.Point(23, 38);
            this.cblogialternativ.Name = "cblogialternativ";
            this.cblogialternativ.Size = new System.Drawing.Size(133, 24);
            this.cblogialternativ.TabIndex = 17;
            this.cblogialternativ.Text = "Logi alternativ:";
            this.cblogialternativ.SelectedIndexChanged += new System.EventHandler(this.LogiAlternativComboBox_SelectedIndexChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(57, 38);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(0, 17);
            this.label1.TabIndex = 15;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Matura MT Script Capitals", 18F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(14, 9);
            this.label3.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(168, 40);
            this.label3.TabIndex = 20;
            this.label3.Text = "Ski-Center";
            // 
            // bttillbaka
            // 
            this.bttillbaka.Location = new System.Drawing.Point(44, 444);
            this.bttillbaka.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.bttillbaka.Name = "bttillbaka";
            this.bttillbaka.Size = new System.Drawing.Size(138, 32);
            this.bttillbaka.TabIndex = 23;
            this.bttillbaka.Text = "Tillbaka";
            this.bttillbaka.UseVisualStyleBackColor = true;
            this.bttillbaka.Click += new System.EventHandler(this.bttillbaka_Click);
            // 
            // logiBokningBindingSource
            // 
            this.logiBokningBindingSource.DataMember = "LogiBokning";
            this.logiBokningBindingSource.DataSource = this.suht2009DataSet;
            // 
            // suht2009DataSet
            // 
            this.suht2009DataSet.DataSetName = "suht2009DataSet";
            this.suht2009DataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // logiBokningTableAdapter
            // 
            this.logiBokningTableAdapter.ClearBeforeFill = true;
            // 
            // Bestat
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(760, 566);
            this.Controls.Add(this.bttillbaka);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.label3);
            this.Name = "Bestat";
            this.Text = "Bestat";
            this.Load += new System.EventHandler(this.Bestat_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgBeStatic)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.logiBokningBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.suht2009DataSet)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button ExporteraTillExellbt;
        private System.Windows.Forms.ComboBox cblogialternativ;
        private System.Windows.Forms.Button bttillbaka;
        private System.Windows.Forms.ComboBox cbsäsong;
        private System.Windows.Forms.ComboBox cbvecka;
        private suht2009DataSet suht2009DataSet;
        private System.Windows.Forms.BindingSource logiBokningBindingSource;
        private suht2009DataSetTableAdapters.LogiBokningTableAdapter logiBokningTableAdapter;
        private System.Windows.Forms.DataGridView dgBeStatic;
    }
}