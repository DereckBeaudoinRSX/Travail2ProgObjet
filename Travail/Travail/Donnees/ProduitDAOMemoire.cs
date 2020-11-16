using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Travail.Donnees
{
    class ProduitDAOMemoire : IProduitDAO
    {
        private List<Produit> produits;

        public ProduitDAOMemoire()
        {
            produits = new List<Produit>();
        }

        public void Ajouter(Produit produitAAjouter)
        {
            Produit copieProduit = new Produit(produitAAjouter);
            produits.Add(copieProduit);
        }

        public IList<Produit> GetAll()
        {
            List<Produit> copiesProduits = new List<Produit>();

            foreach(var produit in produits)
            {
                Produit copieProduit = new Produit(produit);
                copiesProduits.Add(copieProduit);
            }

            return copiesProduits;
        }

        public Produit Obtenir(int numero)
        {
            IList<Produit> produits = GetAll();

            foreach(var produit in produits)
            {
                if(numero == produit.Numero)
                {
                    return produit;
                }
            }

            throw new Exception();
        }
    }
}
