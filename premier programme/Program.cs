namespace premier_programme;

internal class Program
{
    private const int NUMBER_MIN = 1;
    private const int NUMBER_MAX = 10;
    // On ne peut pas utiliser 'const' pour une valeur calculée à l'exécution (comme Random.Next)
    // On utilise 'static readonly' à la place
    private static readonly int NUMBER_MAGIQUE = new Random().Next(NUMBER_MIN, NUMBER_MAX + 1);

    private static int demanderNombre(int min = NUMBER_MIN, int max = NUMBER_MAX)
    {
        var ramdomNumber = min - 1;
        int vies = 5; // On utilise une variable locale pour pouvoir la modifier

        while (vies > 0)
        {
            Console.WriteLine($"Veuillez saisir un nombre entre {min} et {max} (Vies restantes : {vies})");
            try
            {
                ramdomNumber = int.Parse(Console.ReadLine());

                // Vérification si le nombre est dans les bornes
                if (ramdomNumber < min || ramdomNumber > max)
                {
                    Console.WriteLine($"Erreur : Le nombre doit être compris entre {min} et {max}.");
                    continue; // On recommence sans perdre de vie
                }

                if (ramdomNumber == NUMBER_MAGIQUE)
                {
                    Console.WriteLine("Bravo, vous avez trouvé le nombre magique !");
                    return ramdomNumber;
                }

                if (ramdomNumber < NUMBER_MAGIQUE)
                {
                    Console.WriteLine("Le nombre magique est plus grand.");
                }
                else
                {
                    Console.WriteLine("Le nombre magique est plus petit.");
                }

                vies--; // On décrémente le nombre de vies
            }
            catch
            {
                Console.WriteLine("Erreur : Vous devez entrer un nombre valide.");
            }
        }

        Console.WriteLine($"Perdu ! Le nombre magique était {NUMBER_MAGIQUE}.");
        return 0;
    }

    private static void afficherNombre(int ramdomNumber)
    {
        if (ramdomNumber > 0)
            Console.WriteLine("Vous avez saisi " + ramdomNumber);
    }

    private static void Main(string[] args)
    {
        var ramdomNumber = demanderNombre();
        afficherNombre(ramdomNumber);
    }
}