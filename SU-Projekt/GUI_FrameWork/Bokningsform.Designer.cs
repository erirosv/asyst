namespace GUI_FrameWork
{
    partial class Bokningsform
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
            BusinessLayer_FrameWork.FacadeBusiness facadeBusiness1 = new BusinessLayer_FrameWork.FacadeBusiness();
            DataLayer_FrameWork.Context.DatabaseContext databaseContext1 = new DataLayer_FrameWork.Context.DatabaseContext();
            //BusinessLayer_FrameWork.FacadeBusiness facadeBusiness2 = new BusinessLayer_FrameWork.FacadeBusiness();
            //DataLayer_FrameWork.Context.DatabaseContext databaseContext2 = new DataLayer_FrameWork.Context.DatabaseContext();
            this.bokaPrivat = new GUI_FrameWork.BokaPrivat();
            this.bokaPrivat1 = new GUI_FrameWork.BokaPrivat();
            this.SuspendLayout();
            // 
            // bokaPrivat
            // 
            //this.bokaPrivat.Anställd = null;
            facadeBusiness1.Context = databaseContext1;
            this.bokaPrivat.FacadeBusiness = facadeBusiness1;
            this.bokaPrivat.Location = new System.Drawing.Point(0, 0);
            //this.bokaPrivat.Logi = null;
            this.bokaPrivat.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.bokaPrivat.Name = "bokaPrivat";
            this.bokaPrivat.Pris = 0D;
            //this.bokaPrivat.PriserList = null;
            //this.bokaPrivat.PrivatKund = null;
            //this.bokaPrivat.Search = null;
            this.bokaPrivat.Size = new System.Drawing.Size(1083, 767);
            this.bokaPrivat.TabIndex = 0;
            //this.bokaPrivat.TestPrivat = null;
            // 
            // bokaPrivat1
            // 
           // this.bokaPrivat1.Anställd = null;
           // facadeBusiness2.Context = databaseContext2;
           // this.bokaPrivat1.FacadeBusiness = facadeBusiness2;
            this.bokaPrivat1.Location = new System.Drawing.Point(26, -10);
            //this.bokaPrivat1.Logi = null;
            this.bokaPrivat1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.bokaPrivat1.Name = "bokaPrivat1";
            this.bokaPrivat1.Pris = 0D;
          //  this.bokaPrivat1.PriserList = null;
            //this.bokaPrivat1.PrivatKund = null;
            //this.bokaPrivat1.Search = null;
            this.bokaPrivat1.Size = new System.Drawing.Size(1083, 767);
            this.bokaPrivat1.TabIndex = 0;
           // this.bokaPrivat1.TestPrivat = null;
            //this.bokaPrivat.Load += new System.EventHandler(this.bokaPrivat_Load);//
            // 
            // Bokningsform
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1168, 675);
            this.Controls.Add(this.bokaPrivat1);
            this.Name = "Bokningsform";
            this.Text = "Bokning";
            this.ResumeLayout(false);

        }

        #endregion

        private BokaPrivat bokaPrivat;
        private BokaPrivat bokaPrivat1;
    }
}