using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Travail;

namespace Travail
{
    public interface IUtilisateurDAO
    {
        void Ajouter();
        Utilisateur GetUtilisateur();
        void Modifier(Utilisateur utilisateur);
    }
}
