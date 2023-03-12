namespace GUI_WinForm
{
    partial class BokninngsApp
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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.btnVäljBok = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            this.dateTimePicker2 = new System.Windows.Forms.DateTimePicker();
            this.label4 = new System.Windows.Forms.Label();
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.label3 = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.UtvaldaBöckerView = new System.Windows.Forms.DataGridView();
            this.TillGängligaBöckerView = new System.Windows.Forms.DataGridView();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.button5 = new System.Windows.Forms.Button();
            this.FakturaBox = new System.Windows.Forms.TextBox();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.dataGridView4 = new System.Windows.Forms.DataGridView();
            this.button4 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.BokningView = new System.Windows.Forms.DataGridView();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.UtvaldaBöckerView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.TillGängligaBöckerView)).BeginInit();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.BokningView)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.btnVäljBok);
            this.groupBox1.Controls.Add(this.button1);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.dateTimePicker2);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.dateTimePicker1);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.textBox1);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.UtvaldaBöckerView);
            this.groupBox1.Controls.Add(this.TillGängligaBöckerView);
            this.groupBox1.Location = new System.Drawing.Point(28, 56);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(1055, 975);
            this.groupBox1.TabIndex = 11;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "groupBox1";
            // 
            // btnVäljBok
            // 
            this.btnVäljBok.Location = new System.Drawing.Point(823, 339);
            this.btnVäljBok.Name = "btnVäljBok";
            this.btnVäljBok.Size = new System.Drawing.Size(168, 51);
            this.btnVäljBok.TabIndex = 22;
            this.btnVäljBok.Text = "Välj bok";
            this.btnVäljBok.UseVisualStyleBackColor = true;
            this.btnVäljBok.Click += new System.EventHandler(this.btnVäljBok_Click);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(823, 898);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(168, 51);
            this.button1.TabIndex = 21;
            this.button1.Text = "Boka";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(389, 832);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(147, 20);
            this.label5.TabIndex = 20;
            this.label5.Text = "Återlämningsdatum";
            // 
            // dateTimePicker2
            // 
            this.dateTimePicker2.Location = new System.Drawing.Point(393, 866);
            this.dateTimePicker2.Name = "dateTimePicker2";
            this.dateTimePicker2.Size = new System.Drawing.Size(229, 26);
            this.dateTimePicker2.TabIndex = 19;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(28, 832);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(89, 20);
            this.label4.TabIndex = 18;
            this.label4.Text = "Startdatum";
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.Location = new System.Drawing.Point(28, 866);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(229, 26);
            this.dateTimePicker1.TabIndex = 17;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(28, 758);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(144, 20);
            this.label3.TabIndex = 16;
            this.label3.Text = "Medlemmsnummer";
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(32, 781);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(100, 26);
            this.textBox1.TabIndex = 15;
            this.textBox1.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(27, 432);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(173, 29);
            this.label2.TabIndex = 14;
            this.label2.Text = "Utvalda böcker";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(47, 18);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(140, 29);
            this.label1.TabIndex = 13;
            this.label1.Text = "Tillgängliga";
            // 
            // UtvaldaBöckerView
            // 
            this.UtvaldaBöckerView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.UtvaldaBöckerView.Location = new System.Drawing.Point(32, 477);
            this.UtvaldaBöckerView.Name = "UtvaldaBöckerView";
            this.UtvaldaBöckerView.RowHeadersWidth = 62;
            this.UtvaldaBöckerView.RowTemplate.Height = 28;
            this.UtvaldaBöckerView.Size = new System.Drawing.Size(959, 251);
            this.UtvaldaBöckerView.TabIndex = 12;
            // 
            // TillGängligaBöckerView
            // 
            this.TillGängligaBöckerView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.TillGängligaBöckerView.Location = new System.Drawing.Point(32, 63);
            this.TillGängligaBöckerView.Name = "TillGängligaBöckerView";
            this.TillGängligaBöckerView.RowHeadersWidth = 62;
            this.TillGängligaBöckerView.RowTemplate.Height = 28;
            this.TillGängligaBöckerView.Size = new System.Drawing.Size(959, 251);
            this.TillGängligaBöckerView.TabIndex = 11;
            this.TillGängligaBöckerView.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.TillGängligaBöckerView_CellContentClick);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.button5);
            this.groupBox2.Controls.Add(this.FakturaBox);
            this.groupBox2.Controls.Add(this.textBox2);
            this.groupBox2.Controls.Add(this.dataGridView4);
            this.groupBox2.Controls.Add(this.button4);
            this.groupBox2.Controls.Add(this.button3);
            this.groupBox2.Controls.Add(this.button2);
            this.groupBox2.Controls.Add(this.BokningView);
            this.groupBox2.Location = new System.Drawing.Point(1171, 56);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(982, 975);
            this.groupBox2.TabIndex = 12;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "groupBox2";
            // 
            // button5
            // 
            this.button5.Location = new System.Drawing.Point(60, 354);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(168, 51);
            this.button5.TabIndex = 28;
            this.button5.Text = "Ta bort bokning";
            this.button5.UseVisualStyleBackColor = true;
            this.button5.Click += new System.EventHandler(this.button5_Click);
            // 
            // FakturaBox
            // 
            this.FakturaBox.Location = new System.Drawing.Point(557, 587);
            this.FakturaBox.Multiline = true;
            this.FakturaBox.Name = "FakturaBox";
            this.FakturaBox.Size = new System.Drawing.Size(358, 134);
            this.FakturaBox.TabIndex = 27;
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(60, 477);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(250, 26);
            this.textBox2.TabIndex = 26;
            this.textBox2.TextChanged += new System.EventHandler(this.textBox2_TextChanged);
            // 
            // dataGridView4
            // 
            this.dataGridView4.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView4.Location = new System.Drawing.Point(40, 571);
            this.dataGridView4.Name = "dataGridView4";
            this.dataGridView4.RowHeadersWidth = 62;
            this.dataGridView4.RowTemplate.Height = 28;
            this.dataGridView4.Size = new System.Drawing.Size(465, 290);
            this.dataGridView4.TabIndex = 25;
            // 
            // button4
            // 
            this.button4.Location = new System.Drawing.Point(60, 509);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(168, 41);
            this.button4.TabIndex = 24;
            this.button4.Text = "Hitta specifik bokning";
            this.button4.UseVisualStyleBackColor = true;
            this.button4.Click += new System.EventHandler(this.button4_Click);
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(432, 354);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(168, 51);
            this.button3.TabIndex = 23;
            this.button3.Text = "Återlämna";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(245, 354);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(168, 51);
            this.button2.TabIndex = 22;
            this.button2.Text = "Utlämning";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // BokningView
            // 
            this.BokningView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.BokningView.Location = new System.Drawing.Point(40, 63);
            this.BokningView.Name = "BokningView";
            this.BokningView.RowHeadersWidth = 62;
            this.BokningView.RowTemplate.Height = 28;
            this.BokningView.Size = new System.Drawing.Size(875, 251);
            this.BokningView.TabIndex = 0;
            this.BokningView.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.BokningView_CellContentClick);
            // 
            // BokninngsApp
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(2157, 1153);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Name = "BokninngsApp";
            this.Text = "BokninngsApp";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.UtvaldaBöckerView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.TillGängligaBöckerView)).EndInit();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.BokningView)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.DateTimePicker dateTimePicker2;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.DateTimePicker dateTimePicker1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView UtvaldaBöckerView;
        private System.Windows.Forms.DataGridView TillGängligaBöckerView;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.DataGridView dataGridView4;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.DataGridView BokningView;
        private System.Windows.Forms.TextBox FakturaBox;
        private System.Windows.Forms.Button btnVäljBok;
        private System.Windows.Forms.Button button5;
    }
}