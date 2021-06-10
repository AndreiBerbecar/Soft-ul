
namespace soft_educational
{
    partial class Bibiografie
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
            this.lblLinks = new System.Windows.Forms.Label();
            this.lblTitlu = new System.Windows.Forms.Label();
            this.lblLinks2 = new System.Windows.Forms.Label();
            this.lblLinks3 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // lblLinks
            // 
            this.lblLinks.Location = new System.Drawing.Point(60, 121);
            this.lblLinks.Name = "lblLinks";
            this.lblLinks.Size = new System.Drawing.Size(559, 25);
            this.lblLinks.TabIndex = 0;
            this.lblLinks.Text = "https://ro.wikipedia.org/wiki/Europa\r\n";
            this.lblLinks.Click += new System.EventHandler(this.lblLinks_Click);
            // 
            // lblTitlu
            // 
            this.lblTitlu.AutoSize = true;
            this.lblTitlu.Font = new System.Drawing.Font("Times New Roman", 19.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTitlu.Location = new System.Drawing.Point(63, 38);
            this.lblTitlu.Name = "lblTitlu";
            this.lblTitlu.Size = new System.Drawing.Size(175, 37);
            this.lblTitlu.TabIndex = 1;
            this.lblTitlu.Text = "Bibiografie";
            // 
            // lblLinks2
            // 
            this.lblLinks2.AutoSize = true;
            this.lblLinks2.Location = new System.Drawing.Point(63, 182);
            this.lblLinks2.Name = "lblLinks2";
            this.lblLinks2.Size = new System.Drawing.Size(627, 17);
            this.lblLinks2.TabIndex = 2;
            this.lblLinks2.Text = "https://ro.m.wikipedia.org/wiki/Lista_capitalelor_europene_dup%C4%83_suprafa%C8%9" +
    "B%C4%83";
            this.lblLinks2.Click += new System.EventHandler(this.lblLinks2_Click);
            // 
            // lblLinks3
            // 
            this.lblLinks3.AutoSize = true;
            this.lblLinks3.Location = new System.Drawing.Point(63, 249);
            this.lblLinks3.Name = "lblLinks3";
            this.lblLinks3.Size = new System.Drawing.Size(805, 17);
            this.lblLinks3.TabIndex = 3;
            this.lblLinks3.Text = "https://www.plimbaretul.ro/top-3-cele-mai-interesante-si-mai-amuzante-lucruri-des" +
    "pre-fiecare-tara-de-pe-continentul-european/";
            this.lblLinks3.Click += new System.EventHandler(this.lblLinks3_Click);
            // 
            // Bibiografie
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(887, 457);
            this.Controls.Add(this.lblLinks3);
            this.Controls.Add(this.lblLinks2);
            this.Controls.Add(this.lblTitlu);
            this.Controls.Add(this.lblLinks);
            this.Name = "Bibiografie";
            this.Text = "Bibiografie";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblLinks;
        private System.Windows.Forms.Label lblTitlu;
        private System.Windows.Forms.Label lblLinks2;
        private System.Windows.Forms.Label lblLinks3;
    }
}