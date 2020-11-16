using System;
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
            try
            {
                CallForm(new frmVoirPanier(panierDAO));
            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message);
            }
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
            IList<Utilisateur> utilisateurs = utilisateurdao.GetAll();
            if (utilisateurs[0].Role == "Client")
            {
                ajouterProduitToolStripMenuItem.Visible = false;
            }
            else if (utilisateurs[0].Role == "Administrateur")
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
