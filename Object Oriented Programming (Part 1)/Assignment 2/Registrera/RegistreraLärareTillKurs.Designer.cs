namespace Lab2Version.Registrera
{
    partial class RegistreraLärareTillKurs
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
            this.buttonUppdateraKursLista = new System.Windows.Forms.Button();
            this.buttonUppdateraLärare = new System.Windows.Forms.Button();
            this.buttonRegistrera = new System.Windows.Forms.Button();
            this.ListaKurser = new System.Windows.Forms.ListBox();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.labelKurs = new System.Windows.Forms.Label();
            this.lärare = new System.Windows.Forms.ListBox();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.labelLärare = new System.Windows.Forms.Label();
            this.buttonTillbaka = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // buttonUppdateraKursLista
            // 
            this.buttonUppdateraKursLista.Location = new System.Drawing.Point(620, 651);
            this.buttonUppdateraKursLista.Name = "buttonUppdateraKursLista";
            this.buttonUppdateraKursLista.Size = new System.Drawing.Size(419, 59);
            this.buttonUppdateraKursLista.TabIndex = 17;
            this.buttonUppdateraKursLista.Text = "Uppdatera Kurs Lista";
            this.buttonUppdateraKursLista.UseVisualStyleBackColor = true;
            this.buttonUppdateraKursLista.Click += new System.EventHandler(this.buttonUppdateraKursLista_Click);
            // 
            // buttonUppdateraLärare
            // 
            this.buttonUppdateraLärare.Location = new System.Drawing.Point(127, 651);
            this.buttonUppdateraLärare.Name = "buttonUppdateraLärare";
            this.buttonUppdateraLärare.Size = new System.Drawing.Size(419, 59);
            this.buttonUppdateraLärare.TabIndex = 16;
            this.buttonUppdateraLärare.Text = "Updatera Lärar Lista";
            this.buttonUppdateraLärare.UseVisualStyleBackColor = true;
            this.buttonUppdateraLärare.Click += new System.EventHandler(this.buttonUppdateraLärare_Click);
            // 
            // buttonRegistrera
            // 
            this.buttonRegistrera.Location = new System.Drawing.Point(127, 716);
            this.buttonRegistrera.Name = "buttonRegistrera";
            this.buttonRegistrera.Size = new System.Drawing.Size(419, 59);
            this.buttonRegistrera.TabIndex = 15;
            this.buttonRegistrera.Text = "Registrera";
            this.buttonRegistrera.UseVisualStyleBackColor = true;
            this.buttonRegistrera.Click += new System.EventHandler(this.buttonRegistrera_Click);
            // 
            // ListaKurser
            // 
            this.ListaKurser.FormattingEnabled = true;
            this.ListaKurser.ItemHeight = 31;
            this.ListaKurser.Location = new System.Drawing.Point(620, 91);
            this.ListaKurser.Name = "ListaKurser";
            this.ListaKurser.Size = new System.Drawing.Size(419, 531);
            this.ListaKurser.TabIndex = 14;
            this.ListaKurser.SelectedIndexChanged += new System.EventHandler(this.ListaKurser_SelectedIndexChanged);
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(787, 34);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(252, 38);
            this.textBox2.TabIndex = 13;
            this.textBox2.TextChanged += new System.EventHandler(this.textBox2_TextChanged);
            // 
            // labelKurs
            // 
            this.labelKurs.AutoSize = true;
            this.labelKurs.Location = new System.Drawing.Point(614, 34);
            this.labelKurs.Name = "labelKurs";
            this.labelKurs.Size = new System.Drawing.Size(151, 32);
            this.labelKurs.TabIndex = 12;
            this.labelKurs.Text = "Kurs namn";
            // 
            // lärare
            // 
            this.lärare.FormattingEnabled = true;
            this.lärare.ItemHeight = 31;
            this.lärare.Location = new System.Drawing.Point(127, 91);
            this.lärare.Name = "lärare";
            this.lärare.Size = new System.Drawing.Size(419, 531);
            this.lärare.TabIndex = 11;
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(294, 34);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(252, 38);
            this.textBox1.TabIndex = 10;
            this.textBox1.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // labelLärare
            // 
            this.labelLärare.AutoSize = true;
            this.labelLärare.Location = new System.Drawing.Point(121, 34);
            this.labelLärare.Name = "labelLärare";
            this.labelLärare.Size = new System.Drawing.Size(115, 32);
            this.labelLärare.TabIndex = 9;
            this.labelLärare.Text = "Lärar ID";
            // 
            // buttonTillbaka
            // 
            this.buttonTillbaka.Location = new System.Drawing.Point(620, 716);
            this.buttonTillbaka.Name = "buttonTillbaka";
            this.buttonTillbaka.Size = new System.Drawing.Size(419, 59);
            this.buttonTillbaka.TabIndex = 18;
            this.buttonTillbaka.Text = "Tillbaka";
            this.buttonTillbaka.UseVisualStyleBackColor = true;
            this.buttonTillbaka.Click += new System.EventHandler(this.buttonTillbaka_Click);
            // 
            // RegistreraLärareTillKurs
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(16F, 31F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1160, 1068);
            this.Controls.Add(this.buttonTillbaka);
            this.Controls.Add(this.buttonUppdateraKursLista);
            this.Controls.Add(this.buttonUppdateraLärare);
            this.Controls.Add(this.buttonRegistrera);
            this.Controls.Add(this.ListaKurser);
            this.Controls.Add(this.textBox2);
            this.Controls.Add(this.labelKurs);
            this.Controls.Add(this.lärare);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.labelLärare);
            this.Name = "RegistreraLärareTillKurs";
            this.Text = "Registrera Lärare Till Kurs";
            this.Load += new System.EventHandler(this.RegistreraLärareTillKurs_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button buttonUppdateraKursLista;
        private System.Windows.Forms.Button buttonUppdateraLärare;
        private System.Windows.Forms.Button buttonRegistrera;
        private System.Windows.Forms.ListBox ListaKurser;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.Label labelKurs;
        private System.Windows.Forms.ListBox lärare;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Label labelLärare;
        private System.Windows.Forms.Button buttonTillbaka;
    }
}