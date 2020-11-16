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

namespace Travail
{
    public partial class controleProduit : UserControl
    {
        public controleProduit(Produit produit)
        {
            InitializeComponent();
            lblDescription.Text = produit.Description;
            lblPrix.Text = produit.Prix.ToString();
            lblProduit.Text = produit.Nom;

            string filePath = @"..\..\Images\" + produit.Numero.ToString() + ".jpg";
            pctProduit.Image = Image.FromFile(filePath);
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
    }
}
