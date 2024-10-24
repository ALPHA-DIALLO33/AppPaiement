using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AppPaiement
{
    internal class Utilsateur
    {

        public string Nom { get; set; }
        public List<Paiement> Paiements { get; set; }

        public Utilsateur(string nom)
        {
            Nom = nom;
            Paiements = new List<Paiement>();
        }

        
        public void AfficherInfos()
        {
            Console.WriteLine($"Nom de l'utilisateur : {Nom}");
            Console.WriteLine("Paiements effectués :");
            foreach (var paiement in Paiements)
            {
                paiement.AfficherDetails();
            }
        }

        //  ajouter un paiement à la liste
        public void AjouterPaiement(Paiement paiement)
        {
            Paiements.Add(paiement);
        }
    }
}
