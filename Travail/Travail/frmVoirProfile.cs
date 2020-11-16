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
            IList<Utilisateur> utilisateurs = utilisateurdao.GetAll();
            string provenance = utilisateurs[0].Provenance;
            string role = "Client";
            Utilisateur utilisateur = new Utilisateur("JeanNezPleinlCasque", role, provenance);
            utilisateurdao.Modifier(utilisateur);
        }

        private void btnAdministrateur_Click(object sender, EventArgs e)
        {
            IList<Utilisateur> utilisateurs = utilisateurdao.GetAll();
            string provenance = utilisateurs[0].Provenance;
            string role = "Administrateur";
            Utilisateur utilisateur = new Utilisateur("JeanNezPleinlCasque", role, provenance);
            utilisateurdao.Modifier(utilisateur);
        }

        private void btnCanada_Click(object sender, EventArgs e)
        {
            IList<Utilisateur> utilisateurs = utilisateurdao.GetAll();
            string provenance = "Canada";
            string role = utilisateurs[0].Role;
            Utilisateur utilisateur = new Utilisateur("JeanNezPleinlCasque", role, provenance);
            utilisateurdao.Modifier(utilisateur);
        }

        private void btnUSA_Click(object sender, EventArgs e)
        {
            IList<Utilisateur> utilisateurs = utilisateurdao.GetAll();
            string provenance = "USA";
            string role = utilisateurs[0].Role;
            Utilisateur utilisateur = new Utilisateur("JeanNezPleinlCasque", role, provenance);
            utilisateurdao.Modifier(utilisateur);
        }

        private void frmVoirProfile_Load(object sender, EventArgs e)
        {
            IList<Utilisateur> utilisateurs = utilisateurdao.GetAll();
            lblUserName.Text = utilisateurs[0].Nom;
        }
    }
}
