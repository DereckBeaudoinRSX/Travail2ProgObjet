using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Travail
{
    public class Produit
    {
        public int Numero { get; }
        public string Nom { get; }
        public string Description { get; }
        public decimal Prix { get; }
        public int Quantite { get; }

        public Produit(int numero, string nom, string description, decimal prix, int quantite)
        {
            Numero = numero;
            Nom = nom;
            Description = description;
            Prix = prix;
            Quantite = quantite; 
        }

        public Produit(Produit produit)
        {
            Numero = produit.Numero;
            Nom = produit.Nom;
            Description = produit.Description;
            Prix = produit.Prix;
            Quantite = produit.Quantite; 
        }
    }
}
