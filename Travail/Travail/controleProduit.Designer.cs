namespace Travail
{
    partial class controleProduit
    {
        /// <summary> 
        /// Variable nécessaire au concepteur.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary> 
        /// Nettoyage des ressources utilisées.
        /// </summary>
        /// <param name="disposing">true si les ressources managées doivent être supprimées ; sinon, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Code généré par le Concepteur de composants

        /// <summary> 
        /// Méthode requise pour la prise en charge du concepteur - ne modifiez pas 
        /// le contenu de cette méthode avec l'éditeur de code.
        /// </summary>
        private void InitializeComponent()
        {
            this.lblProduit = new System.Windows.Forms.Label();
            this.lblDescription = new System.Windows.Forms.Label();
            this.lblPrix = new System.Windows.Forms.Label();
            this.pctProduit = new System.Windows.Forms.PictureBox();
            this.btnAjouter = new System.Windows.Forms.Button();
            this.nudQuantite = new System.Windows.Forms.NumericUpDown();
            ((System.ComponentModel.ISupportInitialize)(this.pctProduit)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudQuantite)).BeginInit();
            this.SuspendLayout();
            // 
            // lblProduit
            // 
            this.lblProduit.AutoSize = true;
            this.lblProduit.Location = new System.Drawing.Point(137, 16);
            this.lblProduit.Name = "lblProduit";
            this.lblProduit.Size = new System.Drawing.Size(40, 13);
            this.lblProduit.TabIndex = 0;
            this.lblProduit.Text = "Produit";
            this.lblProduit.Click += new System.EventHandler(this.label1_Click);
            // 
            // lblDescription
            // 
            this.lblDescription.AutoSize = true;
            this.lblDescription.Location = new System.Drawing.Point(15, 39);
            this.lblDescription.Name = "lblDescription";
            this.lblDescription.Size = new System.Drawing.Size(60, 13);
            this.lblDescription.TabIndex = 1;
            this.lblDescription.Text = "Description";
            // 
            // lblPrix
            // 
            this.lblPrix.AutoSize = true;
            this.lblPrix.Location = new System.Drawing.Point(255, 39);
            this.lblPrix.Name = "lblPrix";
            this.lblPrix.Size = new System.Drawing.Size(24, 13);
            this.lblPrix.TabIndex = 2;
            this.lblPrix.Text = "Prix";
            // 
            // pctProduit
            // 
            this.pctProduit.Location = new System.Drawing.Point(92, 39);
            this.pctProduit.Name = "pctProduit";
            this.pctProduit.Size = new System.Drawing.Size(134, 104);
            this.pctProduit.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pctProduit.TabIndex = 3;
            this.pctProduit.TabStop = false;
            // 
            // btnAjouter
            // 
            this.btnAjouter.Location = new System.Drawing.Point(92, 175);
            this.btnAjouter.Name = "btnAjouter";
            this.btnAjouter.Size = new System.Drawing.Size(134, 23);
            this.btnAjouter.TabIndex = 4;
            this.btnAjouter.Text = "Ajouter au panier";
            this.btnAjouter.UseVisualStyleBackColor = true;
            this.btnAjouter.Click += new System.EventHandler(this.btnAjouter_Click);
            // 
            // nudQuantite
            // 
            this.nudQuantite.Location = new System.Drawing.Point(92, 149);
            this.nudQuantite.Name = "nudQuantite";
            this.nudQuantite.Size = new System.Drawing.Size(134, 20);
            this.nudQuantite.TabIndex = 5;
            // 
            // controleProduit
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoScroll = true;
            this.Controls.Add(this.nudQuantite);
            this.Controls.Add(this.btnAjouter);
            this.Controls.Add(this.pctProduit);
            this.Controls.Add(this.lblPrix);
            this.Controls.Add(this.lblDescription);
            this.Controls.Add(this.lblProduit);
            this.Name = "controleProduit";
            this.Size = new System.Drawing.Size(329, 206);
            ((System.ComponentModel.ISupportInitialize)(this.pctProduit)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudQuantite)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblProduit;
        private System.Windows.Forms.Label lblDescription;
        private System.Windows.Forms.Label lblPrix;
        private System.Windows.Forms.PictureBox pctProduit;
        private System.Windows.Forms.Button btnAjouter;
        private System.Windows.Forms.NumericUpDown nudQuantite;
    }
}
