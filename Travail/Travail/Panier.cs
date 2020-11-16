using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Travail
{
	public class Panier
	{
		private IList<Produit> _cart { get; set; }
		public Panier(IList<Produit> cart)
		{
			_cart = cart;
		}

		public List<string> AfficherPanier()
		{
			return ToString(_cart);
		}

		public double GetPrixTotal()
		{
			return CalculTotal();
		}

		public double GetPrixProduit(Produit item)
		{
			return Convert.ToDouble(item.Prix) * item.Quantite;
		}



		private double CalculTotal()
		{
			double Resultat = 0;
			foreach (Produit item in _cart)
			{

				Resultat = Resultat + (Convert.ToDouble(item.Prix) * Convert.ToDouble(item.Quantite));
			}
			return Math.Round(Resultat, 2);
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
