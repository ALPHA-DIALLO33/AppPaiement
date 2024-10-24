using AppPaiement;

internal class Program
{
    private static void Main(string[] args)
    {
        Console.WriteLine("Hello, World!");


        //CREATION INSTANCE
        CarteCredit numcarte1 = new CarteCredit(10, "Achat de cahier   ", 54332458);
        CarteCredit numcarte2 = new CarteCredit(50, "Achat de vêtements", 565654321);
        CarteCredit numcarte3 = new CarteCredit(29, "Achat Cmputer     ", 567890);

        // AFFICHAGE
        numcarte1.AfficherDetails();
        numcarte2.AfficherDetails();
        numcarte3.AfficherDetails();


       Console.WriteLine();

        Paypal paiement1 = new Paypal(76, "Achat produit  ", "alphacanada7@gmail.com");
        Paypal paiement2 = new Paypal(41, "Achat materiaux", "alphacanada7@gmail.com");

        
        paiement1.AfficherDetails();
        paiement2.AfficherDetails();
    }
}