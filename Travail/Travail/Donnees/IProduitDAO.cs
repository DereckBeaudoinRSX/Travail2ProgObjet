using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Travail
{
    interface IProduitDAO
    {
        void Ajouter(Produit produit);
        IList<Produit> GetAll();
        void Modifier(Produit produit);
        Produit Obtenir(int numero);
    }
}
