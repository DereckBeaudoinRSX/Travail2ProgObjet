using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Travail.ServiceApplicatif
{
    class PanierDAO : IPanierDAO
    {
        public void Ajouter(Panier panier, Produit produit)
        {
            panier.Cart.Add(produit);
        }

        public IList<Produit> GetAll(Panier panier)
        {
            IList<Produit> produits = new List<Produit>();

            for (int i = 0; i < panier.Cart.Count; i++)
            {
                produits.Add(panier.Cart[i]);
            }

            return produits;
        }
    }
}
