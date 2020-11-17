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
        public Utilisateur GetUtilisateur()
        {
            Utilisateur utilisateur = new Utilisateur("a", "a", "a");

            using (StreamReader reader = new StreamReader(CheminCSV))
            {

                while (!reader.EndOfStream)
                {
                    string ligne = reader.ReadLine();
                    string[] morceaux = ligne.Split(';');

                    string nom = morceaux[0];
                    string role = morceaux[1];
                    string provenance = morceaux[2];

                    utilisateur = new Utilisateur(nom, role, provenance);
                }
            }
            return utilisateur;
        }
        public void Modifier(Utilisateur utilisateurAModifier)
        {
            Utilisateur utilisateur = GetUtilisateur();
            utilisateur = new Utilisateur(utilisateurAModifier);

            File.WriteAllText(CheminCSV, "");

            using (StreamWriter writer = new StreamWriter(CheminCSV, false))
            {
                string ligne = utilisateur.Nom + ";" +
                               utilisateur.Role + ";" +
                               utilisateur.Provenance + ";";

                writer.WriteLine(ligne);
            }
        }
    }
}
