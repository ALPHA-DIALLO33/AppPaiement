using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.Metadata;
using System.Text;
using System.Threading.Tasks;

namespace AppPaiement
{
    internal class CarteCredit : Paiement
    {
        public int NumeroCarte { get; set; }

        public CarteCredit(double montant, string description, int numcarte) : base(montant, description)
        {
            NumeroCarte = numcarte;
        }

        
        public virtual void AfficherDetails()
        {
            Console.WriteLine($"PAIEMENT PAR C.CREDIT : {Montant} , DESCRIPTION : {Description}, NUMERO CARTE : {NumeroCarte}");
        }

    }
}
