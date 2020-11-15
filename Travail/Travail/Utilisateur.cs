using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Travail
{
    class Utilisateur
    {
        public string Nom { get; }
        public string Role { get; }
        public decimal Provenance { get; }

        public Utilisateur(string nom, string role, decimal provenance)
        {
            Nom = nom;
            Role = role;
            Provenance = provenance;
        }
    }
}
