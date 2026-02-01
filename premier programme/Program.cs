using premier_programme;

namespace premier_programme;

internal class Program
{

    private static void Main(string[] args)
    {
        int longueur = outils.DemanderNombreEntre("De quelle longueur doit être le mot de passe ?", 1, 50);
        
        // Utilisation de la nouvelle fonction
        int nombreDeMotsDePasse = outils.DemanderNombrePositifNonNull("Combien de mots de passe voulez-vous générer ?");

        Console.WriteLine($"\nRécapitulatif :");
        Console.WriteLine($"- Longueur des mots de passe : {longueur}");
        Console.WriteLine($"- Nombre de mots de passe : {nombreDeMotsDePasse}");
    }
}