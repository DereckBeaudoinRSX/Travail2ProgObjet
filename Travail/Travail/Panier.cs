using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace Travail
{
	public class Panier
	{
		public IList<Produit> _cart { get; set; }

		public Panier(IList<Produit> cart)
		{
			_cart = cart;
		}

		public double SousTotal()
		{
			double Resultat = 0;
			foreach (Produit item in _cart)
			{
				Resultat += (Convert.ToDouble(item.Prix) * Convert.ToDouble(item.Quantite));
			}
            return Math.Round(Resultat, 2);
		}

		public double CalculTaxe(Utilisateur utilisateur)
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

			return taxe;
		}

		public List<string> ToString(IList<Produit> Cart)
		{
			List<string> Resultat = new List<string>();
			foreach (Produit item in Cart)
			{
				Resultat.Add(item.Nom + " - " + item.Prix + "$ * " + item.Quantite + " = " + item.Prix * item.Quantite + "$");
			}
			return Resultat;
		}
	}
}
