using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Travail.ServiceApplicatif
{
    public interface IPanierDAO
    {
        void Ajouter(Produit produit);
        IList<Produit> GetAll();
    }
}
