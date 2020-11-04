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
	public partial class frmMenu : Form
	{
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
            CallForm(new frmVoirProduits());
        }

        private void voirPanierToolStripMenuItem_Click(object sender, EventArgs e)
        {
            CallForm(new frmVoirPanier());
        }

        private void voirProfileToolStripMenuItem_Click(object sender, EventArgs e)
        {
            CallForm(new frmVoirProfile());
        }

        private void ajouterProduitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            CallForm(new frmAjouterProduit());
        }
    }
}
