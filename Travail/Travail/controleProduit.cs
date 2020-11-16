using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;
using Travail.ServiceApplicatif;

namespace Travail
{
    public partial class controleProduit : UserControl
    {
        private Produit _produit;

        public controleProduit(Produit produit)
        {
            InitializeComponent();
            _produit = produit;
            lblDescription.Text = produit.Description;
            lblPrix.Text = produit.Prix.ToString();
            lblProduit.Text = produit.Nom;

            string filePath = @"..\..\Images\" + produit.Numero.ToString() + ".jpg";
            pctProduit.Image = Image.FromFile(filePath);
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void btnAjouter_Click(object sender, EventArgs e)
        {
            PanierDAO panierDAO = new PanierDAO();
            frmMenu menu = new frmMenu();
            Produit produit = new Produit(_produit.Numero, _produit.Nom, _produit.Description, _produit.Prix, Convert.ToInt32(nudQuantite.Value));
            panierDAO.Ajouter(produit);
        }
    }
}
