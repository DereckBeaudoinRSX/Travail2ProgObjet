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
        private PanierDAO panierDAO { get; }
        public frmVoirPanier(PanierDAO panierDAO)
        {
            InitializeComponent();
            this.panierDAO = panierDAO;
        }

        private void frmVoirPanier_Load(object sender, EventArgs e)
        {

        }

        private void frmVoirPanier_Load(object sender, EventArgs e)
        {
            IList<Produit> items = panierDAO.GetAll();
            Panier panier = new Panier(items); 
            
            foreach (Produit item in items)
            {
                lstProduits.Items.Add(items.ToString(item)); 
            }
        }
    }
}
