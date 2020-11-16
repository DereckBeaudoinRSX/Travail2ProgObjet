using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Travail.ServiceApplicatif
{
    public class PanierDAO : IPanierDAO
    {
        public void Ajouter(Panier panier, Produit produit)
        {
            panier._cart.Add(produit);
        }

        public IList<Produit> GetAll(Panier panier)
        {
            IList<Produit> produits = new List<Produit>();

            for (int i = 0; i < panier._cart.Count; i++)
            {
                produits.Add(panier._cart[i]);
            }

            return produits;
        }
    }

}
