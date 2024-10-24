using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.Metadata;
using System.Text;
using System.Threading.Tasks;

namespace AppPaiement
{
    internal class Paypal : Paiement
    {
        public string Courriel { get; set; }

        public Paypal(double montant, string description, string email) : base(montant, description)
        {
            Courriel = email;
        }

        // Implémentation de la méthode abstraite
        public virtual void AfficherDetails()
        {
            Console.WriteLine($" PAYPAL : {Montant} , Description : {Description}, Courriel : {Courriel}");
        }


    }


}
