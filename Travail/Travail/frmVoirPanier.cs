using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Travail.ServiceApplicatif;

namespace Travail
{
    public partial class frmVoirPanier : Form
    {
        private IPanierDAO panierDAO { get; }

        public frmVoirPanier(IPanierDAO panierDAO)
        {
            InitializeComponent();
            this.panierDAO = panierDAO;
        }

        private void frmVoirPanier_Load_1(object sender, EventArgs e)
        {
            frmMenu menu = new frmMenu();
            IList<Produit> items = panierDAO.GetAll(menu.panier);
            Panier panier = new Panier(items);
            List<string> nomProduits = panier.ToString(items);

            for(int i = 0; i < panier._cart.Count; i++)
            {
                lstProduits.Items.Add(nomProduits[i]);
            }

            lblSousTotal.Text += " " + panier.SousTotal() + "$";
        }
    }
}
