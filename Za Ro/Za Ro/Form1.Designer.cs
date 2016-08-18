namespace Za_Ro
{
    partial class Form1
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
            this.lblText1 = new System.Windows.Forms.Label();
            this.btnPrikaziPoruku = new System.Windows.Forms.Button();
            this.lblLjubavnaPoruka = new System.Windows.Forms.Label();
            this.lblSutra = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // lblText1
            // 
            this.lblText1.AutoSize = true;
            this.lblText1.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.lblText1.Location = new System.Drawing.Point(33, 29);
            this.lblText1.Name = "lblText1";
            this.lblText1.Size = new System.Drawing.Size(181, 18);
            this.lblText1.TabIndex = 0;
            this.lblText1.Text = "Današnja ljubavna poruka:";
            // 
            // btnPrikaziPoruku
            // 
            this.btnPrikaziPoruku.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.btnPrikaziPoruku.Location = new System.Drawing.Point(36, 131);
            this.btnPrikaziPoruku.Name = "btnPrikaziPoruku";
            this.btnPrikaziPoruku.Size = new System.Drawing.Size(175, 35);
            this.btnPrikaziPoruku.TabIndex = 1;
            this.btnPrikaziPoruku.Text = "Zatraži ljubavnu poruku";
            this.btnPrikaziPoruku.UseVisualStyleBackColor = true;
            this.btnPrikaziPoruku.Click += new System.EventHandler(this.btnPrikaziPoruku_Click);
            // 
            // lblLjubavnaPoruka
            // 
            this.lblLjubavnaPoruka.AutoSize = true;
            this.lblLjubavnaPoruka.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.lblLjubavnaPoruka.Location = new System.Drawing.Point(33, 78);
            this.lblLjubavnaPoruka.Name = "lblLjubavnaPoruka";
            this.lblLjubavnaPoruka.Size = new System.Drawing.Size(0, 16);
            this.lblLjubavnaPoruka.TabIndex = 2;
            // 
            // lblSutra
            // 
            this.lblSutra.AutoSize = true;
            this.lblSutra.Location = new System.Drawing.Point(33, 184);
            this.lblSutra.Name = "lblSutra";
            this.lblSutra.Size = new System.Drawing.Size(288, 13);
            this.lblSutra.TabIndex = 3;
            this.lblSutra.Text = "Otvori aplikaciju i sutra kako bi dobila novu ljubavnu poruku";
            this.lblSutra.Visible = false;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1131, 216);
            this.Controls.Add(this.lblSutra);
            this.Controls.Add(this.lblLjubavnaPoruka);
            this.Controls.Add(this.btnPrikaziPoruku);
            this.Controls.Add(this.lblText1);
            this.Name = "Form1";
            this.Text = "Za Ro";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblText1;
        private System.Windows.Forms.Button btnPrikaziPoruku;
        private System.Windows.Forms.Label lblLjubavnaPoruka;
        private System.Windows.Forms.Label lblSutra;
    }
}

