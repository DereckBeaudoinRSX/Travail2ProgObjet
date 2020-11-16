using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Travail.Donnees
{
    public class Utilisateur
    {
        public string Nom { get; }
        public string Role { get; }
        public string Provenance { get; }

        public Utilisateur(string nom, string role, string provenance)
        {
            Nom = nom;
            Role = role;
            Provenance = provenance;
        }
        public Utilisateur(Utilisateur utilisateur)
        {
            Nom = utilisateur.Nom;
            Role = utilisateur.Role;
            Provenance = utilisateur.Provenance;
        }
    }
}
