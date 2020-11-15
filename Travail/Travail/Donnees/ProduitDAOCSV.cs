using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Travail
{
    class ProduitDAOCSV : IProduitDAO
    {
        private const string CheminCSV = @"..\..\AppData\Produit.csv";

        public void Ajouter(Produit produitAAjouter)
        {
            using (StreamWriter writer = new StreamWriter(CheminCSV, true))
            {
                string ligne = produitAAjouter.Numero + ";" +
                               produitAAjouter.Nom + ";" +
                               produitAAjouter.Description + ";" +
                               produitAAjouter.Prix;
                writer.WriteLine(ligne);
            }
        }

        public IList<Produit> GetAll()
        {
            IList<Produit> produits = new List<Produit>();

            using(StreamReader reader = new StreamReader(CheminCSV))
            {
                while (!reader.EndOfStream)
                {
                    string ligne = reader.ReadLine();
                    string[] morceaux = ligne.Split(';');

                    int numero = int.Parse(morceaux[0]);
                    string nom = morceaux[1];
                    string description = morceaux[2];
                    decimal prix = decimal.Parse(morceaux[3]);

                    Produit produit = new Produit(numero, nom, description, prix);
                    produits.Add(produit);
                }
            }
            return produits;
        }

        public void Modifier(Produit produitAModifier)
        {
            IList<Produit> produits = GetAll();

            for (int i = 0; i < produits.Count; i++)
            {
                if(produitAModifier.Numero == produits[i].Numero)
                {
                    produits[i] = new Produit(produitAModifier);
                }
            }

            File.WriteAllText(CheminCSV, "");

            using(StreamWriter writer = new StreamWriter(CheminCSV, true))
            {
                foreach(Produit produit in produits)
                {
                    string ligne = produit.Numero + ";" +
                                   produit.Nom + ";" +
                                   produit.Description + ";" +
                                   produit.Prix;
                    writer.WriteLine(ligne);
                }
            }
        }

        public Produit Obtenir(int numero)
        {
            IList<Produit> produits = GetAll();

            foreach(Produit produit in produits)
            {
                if(numero == produit.Numero)
                {
                    return produit;
                }
            }

            throw new Exception();
        }
    }
}
