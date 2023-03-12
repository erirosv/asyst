namespace GUI_FrameWork
{
    partial class Marknadregister
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
            this.registertab = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.button5 = new System.Windows.Forms.Button();
            this.bokningsregistergrid = new System.Windows.Forms.DataGridView();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.button6 = new System.Windows.Forms.Button();
            this.butiksregistergrid = new System.Windows.Forms.DataGridView();
            this.tabPage3 = new System.Windows.Forms.TabPage();
            this.button7 = new System.Windows.Forms.Button();
            this.fakturaregistergrid = new System.Windows.Forms.DataGridView();
            this.tabPage4 = new System.Windows.Forms.TabPage();
            this.button11 = new System.Windows.Forms.Button();
            this.företagskundregistergrid = new System.Windows.Forms.DataGridView();
            this.button8 = new System.Windows.Forms.Button();
            this.privatkundregistergrid = new System.Windows.Forms.DataGridView();
            this.tabPage5 = new System.Windows.Forms.TabPage();
            this.button9 = new System.Windows.Forms.Button();
            this.uthyrningsregistergrid = new System.Windows.Forms.DataGridView();
            this.button10 = new System.Windows.Forms.Button();
            this.registertab.SuspendLayout();
            this.tabPage1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.bokningsregistergrid)).BeginInit();
            this.tabPage2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.butiksregistergrid)).BeginInit();
            this.tabPage3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.fakturaregistergrid)).BeginInit();
            this.tabPage4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.företagskundregistergrid)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.privatkundregistergrid)).BeginInit();
            this.tabPage5.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.uthyrningsregistergrid)).BeginInit();
            this.SuspendLayout();
            // 
            // registertab
            // 
            this.registertab.Controls.Add(this.tabPage1);
            this.registertab.Controls.Add(this.tabPage2);
            this.registertab.Controls.Add(this.tabPage3);
            this.registertab.Controls.Add(this.tabPage4);
            this.registertab.Controls.Add(this.tabPage5);
            this.registertab.Location = new System.Drawing.Point(12, 12);
            this.registertab.Name = "registertab";
            this.registertab.SelectedIndex = 0;
            this.registertab.Size = new System.Drawing.Size(988, 646);
            this.registertab.TabIndex = 0;
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.button5);
            this.tabPage1.Controls.Add(this.bokningsregistergrid);
            this.tabPage1.Location = new System.Drawing.Point(8, 39);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(972, 599);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Bokningsregister";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // button5
            // 
            this.button5.Location = new System.Drawing.Point(692, 522);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(220, 51);
            this.button5.TabIndex = 3;
            this.button5.Text = "Skriv ut register";
            this.button5.UseVisualStyleBackColor = true;
            this.button5.Click += new System.EventHandler(this.button5_Click);
            // 
            // bokningsregistergrid
            // 
            this.bokningsregistergrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.bokningsregistergrid.Location = new System.Drawing.Point(6, 6);
            this.bokningsregistergrid.Name = "bokningsregistergrid";
            this.bokningsregistergrid.RowHeadersWidth = 82;
            this.bokningsregistergrid.RowTemplate.Height = 33;
            this.bokningsregistergrid.Size = new System.Drawing.Size(960, 479);
            this.bokningsregistergrid.TabIndex = 0;
            this.bokningsregistergrid.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.bokningsregistergrid_CellContentClick);
            // 
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.button6);
            this.tabPage2.Controls.Add(this.butiksregistergrid);
            this.tabPage2.Location = new System.Drawing.Point(8, 39);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(972, 599);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Butiksregister";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // button6
            // 
            this.button6.Location = new System.Drawing.Point(692, 522);
            this.button6.Name = "button6";
            this.button6.Size = new System.Drawing.Size(220, 51);
            this.button6.TabIndex = 3;
            this.button6.Text = "Skriv ut register";
            this.button6.UseVisualStyleBackColor = true;
            this.button6.Click += new System.EventHandler(this.button6_Click);
            // 
            // butiksregistergrid
            // 
            this.butiksregistergrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.butiksregistergrid.Location = new System.Drawing.Point(6, 6);
            this.butiksregistergrid.Name = "butiksregistergrid";
            this.butiksregistergrid.RowHeadersWidth = 82;
            this.butiksregistergrid.RowTemplate.Height = 33;
            this.butiksregistergrid.Size = new System.Drawing.Size(960, 479);
            this.butiksregistergrid.TabIndex = 0;
            this.butiksregistergrid.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.butiksregistergrid_CellContentClick);
            // 
            // tabPage3
            // 
            this.tabPage3.Controls.Add(this.button7);
            this.tabPage3.Controls.Add(this.fakturaregistergrid);
            this.tabPage3.Location = new System.Drawing.Point(8, 39);
            this.tabPage3.Name = "tabPage3";
            this.tabPage3.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage3.Size = new System.Drawing.Size(972, 599);
            this.tabPage3.TabIndex = 2;
            this.tabPage3.Text = "Fakturaregister";
            this.tabPage3.UseVisualStyleBackColor = true;
            // 
            // button7
            // 
            this.button7.Location = new System.Drawing.Point(692, 522);
            this.button7.Name = "button7";
            this.button7.Size = new System.Drawing.Size(220, 51);
            this.button7.TabIndex = 3;
            this.button7.Text = "Skriv ut register";
            this.button7.UseVisualStyleBackColor = true;
            this.button7.Click += new System.EventHandler(this.button7_Click);
            // 
            // fakturaregistergrid
            // 
            this.fakturaregistergrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.fakturaregistergrid.Location = new System.Drawing.Point(6, 6);
            this.fakturaregistergrid.Name = "fakturaregistergrid";
            this.fakturaregistergrid.RowHeadersWidth = 82;
            this.fakturaregistergrid.RowTemplate.Height = 33;
            this.fakturaregistergrid.Size = new System.Drawing.Size(960, 479);
            this.fakturaregistergrid.TabIndex = 0;
            this.fakturaregistergrid.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.fakturaregistergrid_CellContentClick);
            // 
            // tabPage4
            // 
            this.tabPage4.Controls.Add(this.button11);
            this.tabPage4.Controls.Add(this.företagskundregistergrid);
            this.tabPage4.Controls.Add(this.button8);
            this.tabPage4.Controls.Add(this.privatkundregistergrid);
            this.tabPage4.Location = new System.Drawing.Point(8, 39);
            this.tabPage4.Name = "tabPage4";
            this.tabPage4.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage4.Size = new System.Drawing.Size(972, 599);
            this.tabPage4.TabIndex = 3;
            this.tabPage4.Text = "Kundregister";
            this.tabPage4.UseVisualStyleBackColor = true;
            // 
            // button11
            // 
            this.button11.Location = new System.Drawing.Point(715, 491);
            this.button11.Name = "button11";
            this.button11.Size = new System.Drawing.Size(233, 102);
            this.button11.TabIndex = 5;
            this.button11.Text = "Skriv ut register (Företagskund)";
            this.button11.UseVisualStyleBackColor = true;
            this.button11.Click += new System.EventHandler(this.button11_Click);
            // 
            // företagskundregistergrid
            // 
            this.företagskundregistergrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.företagskundregistergrid.Location = new System.Drawing.Point(479, 6);
            this.företagskundregistergrid.Name = "företagskundregistergrid";
            this.företagskundregistergrid.RowHeadersWidth = 82;
            this.företagskundregistergrid.RowTemplate.Height = 33;
            this.företagskundregistergrid.Size = new System.Drawing.Size(469, 479);
            this.företagskundregistergrid.TabIndex = 4;
            // 
            // button8
            // 
            this.button8.Location = new System.Drawing.Point(6, 491);
            this.button8.Name = "button8";
            this.button8.Size = new System.Drawing.Size(233, 102);
            this.button8.TabIndex = 3;
            this.button8.Text = "Skriv ut register (Privakund)";
            this.button8.UseVisualStyleBackColor = true;
            this.button8.Click += new System.EventHandler(this.button8_Click);
            // 
            // privatkundregistergrid
            // 
            this.privatkundregistergrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.privatkundregistergrid.Location = new System.Drawing.Point(6, 6);
            this.privatkundregistergrid.Name = "privatkundregistergrid";
            this.privatkundregistergrid.RowHeadersWidth = 82;
            this.privatkundregistergrid.RowTemplate.Height = 33;
            this.privatkundregistergrid.Size = new System.Drawing.Size(467, 479);
            this.privatkundregistergrid.TabIndex = 0;
            this.privatkundregistergrid.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.kundregistergrid_CellContentClick);
            // 
            // tabPage5
            // 
            this.tabPage5.Controls.Add(this.button9);
            this.tabPage5.Controls.Add(this.uthyrningsregistergrid);
            this.tabPage5.Location = new System.Drawing.Point(8, 39);
            this.tabPage5.Name = "tabPage5";
            this.tabPage5.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage5.Size = new System.Drawing.Size(972, 599);
            this.tabPage5.TabIndex = 4;
            this.tabPage5.Text = "Uthyrningsregister";
            this.tabPage5.UseVisualStyleBackColor = true;
            // 
            // button9
            // 
            this.button9.Location = new System.Drawing.Point(692, 522);
            this.button9.Name = "button9";
            this.button9.Size = new System.Drawing.Size(220, 51);
            this.button9.TabIndex = 3;
            this.button9.Text = "Skriv ut register";
            this.button9.UseVisualStyleBackColor = true;
            this.button9.Click += new System.EventHandler(this.button9_Click);
            // 
            // uthyrningsregistergrid
            // 
            this.uthyrningsregistergrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.uthyrningsregistergrid.Location = new System.Drawing.Point(6, 6);
            this.uthyrningsregistergrid.Name = "uthyrningsregistergrid";
            this.uthyrningsregistergrid.RowHeadersWidth = 82;
            this.uthyrningsregistergrid.RowTemplate.Height = 33;
            this.uthyrningsregistergrid.Size = new System.Drawing.Size(960, 479);
            this.uthyrningsregistergrid.TabIndex = 0;
            this.uthyrningsregistergrid.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.uthyrningsregistergrid_CellContentClick);
            // 
            // button10
            // 
            this.button10.Location = new System.Drawing.Point(13, 665);
            this.button10.Name = "button10";
            this.button10.Size = new System.Drawing.Size(206, 53);
            this.button10.TabIndex = 1;
            this.button10.Text = "Tillbaka";
            this.button10.UseVisualStyleBackColor = true;
            this.button10.Click += new System.EventHandler(this.button10_Click);
            // 
            // Marknadregister
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1053, 742);
            this.Controls.Add(this.button10);
            this.Controls.Add(this.registertab);
            this.Name = "Marknadregister";
            this.Text = "Marknadregister";
            this.registertab.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.bokningsregistergrid)).EndInit();
            this.tabPage2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.butiksregistergrid)).EndInit();
            this.tabPage3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.fakturaregistergrid)).EndInit();
            this.tabPage4.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.företagskundregistergrid)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.privatkundregistergrid)).EndInit();
            this.tabPage5.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.uthyrningsregistergrid)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl registertab;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.DataGridView bokningsregistergrid;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.DataGridView butiksregistergrid;
        private System.Windows.Forms.TabPage tabPage3;
        private System.Windows.Forms.DataGridView fakturaregistergrid;
        private System.Windows.Forms.TabPage tabPage4;
        private System.Windows.Forms.TabPage tabPage5;
        private System.Windows.Forms.Button button5;
        private System.Windows.Forms.Button button6;
        private System.Windows.Forms.Button button7;
        private System.Windows.Forms.Button button8;
        private System.Windows.Forms.DataGridView privatkundregistergrid;
        private System.Windows.Forms.Button button9;
        private System.Windows.Forms.DataGridView uthyrningsregistergrid;
        private System.Windows.Forms.Button button10;
        private System.Windows.Forms.Button button11;
        private System.Windows.Forms.DataGridView företagskundregistergrid;
    }
}