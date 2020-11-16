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
    public partial class frmVoirProduits : Form
    {
        private IProduitDAO produitDAO;

        public frmVoirProduits(IProduitDAO produitDAO)
        {
            InitializeComponent();
            this.produitDAO = produitDAO;
        }

        private void frmVoirProduits_Load(object sender, EventArgs e)
        {
            IList<Produit> produits = produitDAO.GetAll();

            for(int i = 0; i < produits.Count(); i++)
            {
                Control control = new controleProduit(produits[i]);
                flowLayoutPanelProduit.Controls.Add(control);
            }
        }
    }
}
