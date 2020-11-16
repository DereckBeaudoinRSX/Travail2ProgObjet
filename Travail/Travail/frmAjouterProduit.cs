using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Travail
{
    public partial class frmAjouterProduit : Form
    {
        private IProduitDAO produitDAO;
        public frmAjouterProduit(IProduitDAO produitDAO)
        {
            InitializeComponent();
            this.produitDAO = produitDAO;
        }

        private void btnAjouterProduit_Click(object sender, EventArgs e)
        {
            Produit produit = new Produit(int.Parse(txtNumero.Text), txtNom.Text, txtDescription.Text, Convert.ToDecimal(txtPrix.Text), 0);
            produitDAO.Ajouter(produit);
            RefreshAffichage();
        }

        private void frmAjouterProduit_Load(object sender, EventArgs e)
        {
            RefreshAffichage();
        }

        private void RefreshAffichage()
        {
            txtDescription.Text = "";
            txtNom.Text = "";
            txtNumero.Text = "";
            txtPrix.Text = "";
            IList<Produit> produits = produitDAO.GetAll();
            txtNumero.Text = (produits.Count + 1).ToString();
        }
    }
}
