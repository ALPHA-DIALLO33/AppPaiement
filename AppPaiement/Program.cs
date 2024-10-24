using AppPaiement;

internal class Program
{
    private static void Main(string[] args)
    {
        Console.WriteLine("Hello, World!");


        //CREATION INSTANCE
        CarteCredit numcarte1 = new CarteCredit(10, "Achat de cahier", 54332458);
        CarteCredit numcarte2 = new CarteCredit(50, "Achat de vêtements", 565654321);
        CarteCredit numcarte3 = new CarteCredit(29, "Achat Cmputer", 567890);

        // AFFICHAGE
        numcarte1.AfficherDetails();
        numcarte2.AfficherDetails();
        numcarte3.AfficherDetails();

    }
}