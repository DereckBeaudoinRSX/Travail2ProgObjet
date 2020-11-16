using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace Travail
{
    public interface IUtilisateurDAO
    {
        void Ajouter();
        IList<Utilisateur> GetAll();
        void Modifier(Utilisateur utilisateur);
    }
}
