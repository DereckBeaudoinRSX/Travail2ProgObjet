using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Travail;

namespace Travail
{
    public class UtilisateurDAOCSV : IUtilisateurDAO
    {
        private const string CheminCSV = @"..\..\AppData\Utilisateur.csv";
        public void Ajouter()
        {
            using (StreamWriter writer = new StreamWriter(CheminCSV, true))
            {
                string ligne = "JeanNezPleinlCasque" + ";" +
                               "Administrateur" + ";" +
                               "Canada" + ";";
                writer.WriteLine(ligne);
            }
        }
        public IList<Utilisateur> GetAll()
        {
            IList<Utilisateur> utilisateurs = new List<Utilisateur>();

            using (StreamReader reader = new StreamReader(CheminCSV))
            {
                while (!reader.EndOfStream)
                {
                    string ligne = reader.ReadLine();
                    string[] morceaux = ligne.Split(';');

                    string nom = morceaux[0];
                    string role = morceaux[1];
                    string provenance = morceaux[2];

                    Utilisateur utilisateur = new Utilisateur(nom, role, provenance);
                    utilisateurs.Add(utilisateur);
                }
            }
            return utilisateurs;
        }
        public void Modifier(Utilisateur utilisateurAModifier)
        {
            IList<Utilisateur> utilisateurs = GetAll();

            for (int i = 0; i < utilisateurs.Count; i++)
            {
                if (utilisateurAModifier.Nom == utilisateurs[i].Nom)
                {
                    utilisateurs[i] = new Utilisateur(utilisateurAModifier);
                }
            }

            File.WriteAllText(CheminCSV, "");

            using (StreamWriter writer = new StreamWriter(CheminCSV, false))
            {
                foreach (Utilisateur utilisateur in utilisateurs)
                {
                    string ligne = utilisateur.Nom + ";" +
                                   utilisateur.Role + ";" +
                                   utilisateur.Provenance + ";";
                    writer.WriteLine(ligne);
                }
            }
        }
    }
}
