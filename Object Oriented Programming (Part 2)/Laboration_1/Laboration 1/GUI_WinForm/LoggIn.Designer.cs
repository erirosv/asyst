namespace GUI_WinForm
{
    partial class LoggIn
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
            this.labelAnställningsNummer = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.labelPassword = new System.Windows.Forms.Label();
            this.labelName = new System.Windows.Forms.Label();
            this.buttonLoggIn = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // labelAnställningsNummer
            // 
            this.labelAnställningsNummer.AutoSize = true;
            this.labelAnställningsNummer.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelAnställningsNummer.Location = new System.Drawing.Point(126, 131);
            this.labelAnställningsNummer.Name = "labelAnställningsNummer";
            this.labelAnställningsNummer.Size = new System.Drawing.Size(230, 29);
            this.labelAnställningsNummer.TabIndex = 0;
            this.labelAnställningsNummer.Text = "Anställningsnummer";
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(131, 163);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(225, 26);
            this.textBox1.TabIndex = 1;
            this.textBox1.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.ImageScalingSize = new System.Drawing.Size(24, 24);
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(61, 4);
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(131, 233);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(225, 26);
            this.textBox2.TabIndex = 4;
            this.textBox2.TextChanged += new System.EventHandler(this.textBox2_TextChanged);
            // 
            // labelPassword
            // 
            this.labelPassword.AutoSize = true;
            this.labelPassword.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelPassword.Location = new System.Drawing.Point(196, 201);
            this.labelPassword.Name = "labelPassword";
            this.labelPassword.Size = new System.Drawing.Size(115, 29);
            this.labelPassword.TabIndex = 3;
            this.labelPassword.Text = "Lösenord";
            // 
            // labelName
            // 
            this.labelName.AutoSize = true;
            this.labelName.Font = new System.Drawing.Font("Microsoft Sans Serif", 22F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelName.Location = new System.Drawing.Point(173, 38);
            this.labelName.Name = "labelName";
            this.labelName.Size = new System.Drawing.Size(155, 52);
            this.labelName.TabIndex = 5;
            this.labelName.Text = "LoggIn";
            // 
            // buttonLoggIn
            // 
            this.buttonLoggIn.Location = new System.Drawing.Point(182, 284);
            this.buttonLoggIn.Name = "buttonLoggIn";
            this.buttonLoggIn.Size = new System.Drawing.Size(110, 47);
            this.buttonLoggIn.TabIndex = 6;
            this.buttonLoggIn.Text = "LoggIn";
            this.buttonLoggIn.UseVisualStyleBackColor = true;
            this.buttonLoggIn.Click += new System.EventHandler(this.buttonLoggIn_Click);
            // 
            // LoggIn
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(494, 429);
            this.Controls.Add(this.buttonLoggIn);
            this.Controls.Add(this.labelName);
            this.Controls.Add(this.textBox2);
            this.Controls.Add(this.labelPassword);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.labelAnställningsNummer);
            this.Name = "LoggIn";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label labelAnställningsNummer;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.Label labelPassword;
        private System.Windows.Forms.Label labelName;
        private System.Windows.Forms.Button buttonLoggIn;
    }
}

