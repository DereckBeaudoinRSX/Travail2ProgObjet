using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Travail
{
    public interface IProduitDAO
    {
        void Ajouter(Produit produit);
        IList<Produit> GetAll();
        Produit Obtenir(int numero);
    }
}
