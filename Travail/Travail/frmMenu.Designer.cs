namespace Travail
{
	partial class frmMenu
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

		#region Code généré par le Concepteur Windows Form

		/// <summary>
		/// Méthode requise pour la prise en charge du concepteur - ne modifiez pas
		/// le contenu de cette méthode avec l'éditeur de code.
		/// </summary>
		private void InitializeComponent()
		{
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.menuToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.voirProduitsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.voirPanierToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.voirProfileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.ajouterProduitToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.menuToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(800, 24);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // menuToolStripMenuItem
            // 
            this.menuToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.voirProduitsToolStripMenuItem,
            this.voirPanierToolStripMenuItem,
            this.voirProfileToolStripMenuItem,
            this.ajouterProduitToolStripMenuItem});
            this.menuToolStripMenuItem.Name = "menuToolStripMenuItem";
            this.menuToolStripMenuItem.Size = new System.Drawing.Size(50, 20);
            this.menuToolStripMenuItem.Text = "Menu";
            // 
            // voirProduitsToolStripMenuItem
            // 
            this.voirProduitsToolStripMenuItem.Name = "voirProduitsToolStripMenuItem";
            this.voirProduitsToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.voirProduitsToolStripMenuItem.Text = "Voir produits";
            this.voirProduitsToolStripMenuItem.Click += new System.EventHandler(this.voirProduitsToolStripMenuItem_Click);
            // 
            // voirPanierToolStripMenuItem
            // 
            this.voirPanierToolStripMenuItem.Name = "voirPanierToolStripMenuItem";
            this.voirPanierToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.voirPanierToolStripMenuItem.Text = "Voir panier";
            this.voirPanierToolStripMenuItem.Click += new System.EventHandler(this.voirPanierToolStripMenuItem_Click);
            // 
            // voirProfileToolStripMenuItem
            // 
            this.voirProfileToolStripMenuItem.Name = "voirProfileToolStripMenuItem";
            this.voirProfileToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.voirProfileToolStripMenuItem.Text = "Voir profile";
            this.voirProfileToolStripMenuItem.Click += new System.EventHandler(this.voirProfileToolStripMenuItem_Click);
            // 
            // ajouterProduitToolStripMenuItem
            // 
            this.ajouterProduitToolStripMenuItem.Name = "ajouterProduitToolStripMenuItem";
            this.ajouterProduitToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.ajouterProduitToolStripMenuItem.Text = "Ajouter produit";
            this.ajouterProduitToolStripMenuItem.Click += new System.EventHandler(this.ajouterProduitToolStripMenuItem_Click);
            // 
            // frmMenu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "frmMenu";
            this.Text = "Form1";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

		}

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem menuToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem voirProduitsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem voirPanierToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem voirProfileToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem ajouterProduitToolStripMenuItem;
    }
}

