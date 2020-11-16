using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Travail
{
	public class Panier
	{
        public List<Produit> Cart;

		public List<string> AfficherPanier()
		{
			return ToString(Cart);
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
			foreach (Produit item in Cart)
			{
				Resultat += (Convert.ToDouble(item.Prix) * item.Quantite);
			}
			return Math.Round(Resultat, 2); 
		}

		private List<string> ToString(List<Produit> Cart)
		{
			List<string> Resultat = new List<string>(); 
			foreach (Produit item in Cart)
			{
				Resultat.Add(item.Nom + " " +  item.Prix + "$ " + " " ); 
			}
			return Resultat;
		} 


	}
}
