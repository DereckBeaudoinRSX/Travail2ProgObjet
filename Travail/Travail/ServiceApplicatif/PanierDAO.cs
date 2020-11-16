using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Travail.ServiceApplicatif
{
    public class PanierDAO : IPanierDAO
    {
        frmMenu menu = new frmMenu();

        public void Ajouter(Produit produit)
        {
            menu.panier._cart.Add(produit);
        }

        public IList<Produit> GetAll()
        {
            IList<Produit> produits = new List<Produit>();

            for (int i = 0; i < menu.panier._cart.Count; i++)
            {
                produits.Add(menu.panier._cart[i]);
            }

            return produits;
        }
    }

}
