using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Travail.Donnees;

namespace Travail
{
	public class Panier
	{
		public IList<Produit> _cart { get; set; }
		public Panier(IList<Produit> cart)
		{
			_cart = cart;
		}

		public List<string> AfficherPanier()
		{
			return ToString(_cart);
		}

		public double GetPrixTotal(Utilisateur utilisateur)
		{
			return CalculTotal(utilisateur);
		}

		public double GetPrixProduit(Produit item)
		{
			return Convert.ToDouble(item.Prix) * item.Quantite;
		}



		private double CalculTotal(Utilisateur utilisateur)
		{
			double taxe;
			if (utilisateur.Provenance == "Canada")
			{
				taxe = 0.15;
			}
			else
			{
				taxe = 0.07;
			}
			double Resultat = 0;
			foreach (Produit item in _cart)
			{

				Resultat = Resultat + (Convert.ToDouble(item.Prix) * Convert.ToDouble(item.Quantite));
			}
			return Math.Round(Resultat, 2) * taxe;
		}


		private List<string> ToString(IList<Produit> Cart)
		{
			List<string> Resultat = new List<string>();
			foreach (Produit item in Cart)
			{
				Resultat.Add(item.Numero + " " + item.Nom + " " + item.Prix + " $");
			}
			return Resultat;
		}
		private string ToString(Produit item)
		{
			return item.Numero + " " + item.Nom + " " + item.Prix + " $";

		}


	}
}
