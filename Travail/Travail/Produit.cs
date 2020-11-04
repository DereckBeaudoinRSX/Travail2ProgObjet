using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Travail
{
    class Produit
    {
        public string _nom { get; }
        public string _description { get; }
        public decimal _prix { get; }

        public Produit(string nom, string description, decimal prix)
        {
            _nom = nom;
            _description = description;
            _prix = prix;
        }
    }
}
