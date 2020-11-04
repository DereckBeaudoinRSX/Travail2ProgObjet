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
			 return item._prix * 
		}



		private double CalculTotal()
		{
			double Resultat = 0; 
			foreach (Produit item in Cart)
			{
				Resultat = Resultat + (item._prix * );  
			}
			return Math.Round(Resultat, 2); 
		}

		private List<string> ToString(List<Produit> Cart)
		{
			List<string> Resultat = new List<string>(); 
			foreach (Produit item in Cart)
			{
				Resultat.Add(item._nom + " " +  item._prix + "$ " + " " ); 
			}
			return Resultat;
		} 


	}
}
