﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Travail;
using Travail.ServiceApplicatif;

namespace Travail
{
	public partial class frmMenu : Form
	{
        private IUtilisateurDAO utilisateurdao = new UtilisateurDAOCSV();
        private IProduitDAO produitDAO = new ProduitDAOCSV();
        private IPanierDAO panierDAO = new PanierDAO(); 

        private static IList<Produit> produits = new List<Produit>();
        public Panier panier = new Panier(produits);

        public frmMenu()
		{
			InitializeComponent();
		}
        public void CallForm(Form Forme)
        {
            Forme.ShowDialog();
        }
        private void voirProduitsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            try
            {
                CallForm(new frmVoirProduits(produitDAO));
            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message);
            }
        }

        private void voirPanierToolStripMenuItem_Click(object sender, EventArgs e)
        {
            CallForm(new frmVoirPanier(panierDAO));
        }

        private void voirProfileToolStripMenuItem_Click(object sender, EventArgs e)
        {
            try
            {
                CallForm(new frmVoirProfile(utilisateurdao));
            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message);
            }
        }

        private void ajouterProduitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            try
            {
                CallForm(new frmAjouterProduit(produitDAO));
            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message);
            }
        }

        private void frmMenu_Load(object sender, EventArgs e)
        {
            refresh();
        }

        private void refresh()
        {
            Utilisateur utilisateur = utilisateurdao.GetUtilisateur();
            if (utilisateur.Role == "Client")
            {
                ajouterProduitToolStripMenuItem.Visible = false;
            }
            else if (utilisateur.Role == "Administrateur")
            {
                ajouterProduitToolStripMenuItem.Visible = true;
            }
        }

        private void menuToolStripMenuItem_Click(object sender, EventArgs e)
        {
            refresh();
        }
    }
}
