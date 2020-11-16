namespace Travail
{
    partial class frmVoirProduits
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
            this.LstProduits = new System.Windows.Forms.ListBox();
            this.SuspendLayout();
            // 
            // LstProduits
            // 
            this.LstProduits.FormattingEnabled = true;
            this.LstProduits.Location = new System.Drawing.Point(13, 13);
            this.LstProduits.Name = "LstProduits";
            this.LstProduits.Size = new System.Drawing.Size(214, 420);
            this.LstProduits.TabIndex = 0;
            // 
            // frmVoirProduits
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(241, 450);
            this.Controls.Add(this.LstProduits);
            this.Name = "frmVoirProduits";
            this.Text = "frmVoirProduits";
            this.Load += new System.EventHandler(this.frmVoirProduits_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ListBox LstProduits;
    }
}