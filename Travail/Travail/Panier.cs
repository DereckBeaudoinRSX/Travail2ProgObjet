using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Travail
{
	public class Panier
	{
<<<<<<< HEAD

		public List<Produit> Cart;
=======
		public IList<Produit> _cart { get; set; }

		public Panier(IList<Produit> cart)
		{
			_cart = cart; 
		}
>>>>>>> Fichier-Random

        public Panier()
        {
            _cart = new List<Produit>();
        }

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
			return 0;
		}



		private double CalculTotal()
		{
			double Resultat = 0; 
			foreach (Produit item in Cart)
			{
				Resultat = Resultat + (0);  
			}
			return Math.Round(Resultat, 2); 
		}

		private List<string> ToString(List<Produit> Cart)
		{
			List<string> Resultat = new List<string>(); 
			foreach (Produit item in Cart)
			{
				Resultat.Add(""); 
			}
			return Resultat;
		} 


	}
}
