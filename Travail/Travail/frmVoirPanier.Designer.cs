namespace Travail
{
    partial class frmVoirPanier
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
            this.lstProduits = new System.Windows.Forms.ListBox();
            this.label1 = new System.Windows.Forms.Label();
            this.lblSousTotal = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // lstProduits
            // 
            this.lstProduits.FormattingEnabled = true;
            this.lstProduits.Location = new System.Drawing.Point(13, 26);
            this.lstProduits.Name = "lstProduits";
            this.lstProduits.Size = new System.Drawing.Size(331, 303);
            this.lstProduits.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(145, 10);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(37, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Panier";
            // 
            // lblSousTotal
            // 
            this.lblSousTotal.AutoSize = true;
            this.lblSousTotal.Location = new System.Drawing.Point(368, 26);
            this.lblSousTotal.Name = "lblSousTotal";
            this.lblSousTotal.Size = new System.Drawing.Size(57, 13);
            this.lblSousTotal.TabIndex = 2;
            this.lblSousTotal.Text = "Sous total:";
            // 
            // frmVoirPanier
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(447, 335);
            this.Controls.Add(this.lblSousTotal);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.lstProduits);
            this.Name = "frmVoirPanier";
            this.Text = "frmVoirPanier";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListBox lstProduits;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lblSousTotal;
    }
}