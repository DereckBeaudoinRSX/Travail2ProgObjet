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

namespace Travail
{
    public partial class frmVoirProfile : Form
    {
        private IUtilisateurDAO utilisateurdao;
        public frmVoirProfile(IUtilisateurDAO utilisateurDAO)
        {
            InitializeComponent();
            utilisateurdao = utilisateurDAO;
        }

        private void btnClient_Click(object sender, EventArgs e)
        {
            Utilisateur utilisateur = utilisateurdao.GetUtilisateur();
            string provenance = utilisateur.Provenance;
            string role = "Client";
            Utilisateur nouveauUtilisateur = new Utilisateur("JeanNezPleinlCasque", role, provenance);
            utilisateurdao.Modifier(nouveauUtilisateur);
        }

        private void btnAdministrateur_Click(object sender, EventArgs e)
        {
            Utilisateur utilisateur = utilisateurdao.GetUtilisateur();
            string provenance = utilisateur.Provenance;
            string role = "Administrateur";
            Utilisateur nouveauUtilisateur = new Utilisateur("JeanNezPleinlCasque", role, provenance);
            utilisateurdao.Modifier(nouveauUtilisateur);
        }

        private void btnCanada_Click(object sender, EventArgs e)
        {
            Utilisateur utilisateur = utilisateurdao.GetUtilisateur();
            string provenance = "Canada";
            string role = utilisateur.Role;
            Utilisateur nouveauUtilisateur = new Utilisateur("JeanNezPleinlCasque", role, provenance);
            utilisateurdao.Modifier(nouveauUtilisateur);
        }

        private void btnUSA_Click(object sender, EventArgs e)
        {
            Utilisateur utilisateur = utilisateurdao.GetUtilisateur();
            string provenance = "USA";
            string role = utilisateur.Role;
            Utilisateur nouveauUtilisateur = new Utilisateur("JeanNezPleinlCasque", role, provenance);
            utilisateurdao.Modifier(nouveauUtilisateur);
        }

        private void frmVoirProfile_Load(object sender, EventArgs e)
        {
            Utilisateur utilisateur = utilisateurdao.GetUtilisateur();
            lblUserName.Text = utilisateur.Nom;
        }
    }
}
