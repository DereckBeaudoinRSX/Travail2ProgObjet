using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Travail
{
    class Produit
    {
        public int Numero { get; }
        public string Nom { get; }
        public string Description { get; }
        public decimal Prix { get; }

        public Produit(int numero, string nom, string description, decimal prix)
        {
            Numero = numero;
            Nom = nom;
            Description = description;
            Prix = prix;
        }

        public Produit(Produit produit)
        {
            Numero = produit.Numero;
            Nom = produit.Nom;
            Description = produit.Description;
            Prix = produit.Prix;
        }
    }
}
