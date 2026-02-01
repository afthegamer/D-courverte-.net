namespace premier_programme;

internal class Program
{
    private const int NUMBER_MIN = 1;
    private const int NUMBER_MAX = 10;

    private static int demanderNombre(int min = NUMBER_MIN, int max = NUMBER_MAX)
    {
        var ramdomNumber = 0;
        // On boucle tant que le nombre n'est pas valide (soit pas un nombre, soit hors limites)
        while (ramdomNumber < min || ramdomNumber > max)
        {
            Console.WriteLine($"Veuillez saisir un nombre entre {min} et {max}");
            try
            {
                ramdomNumber = int.Parse(Console.ReadLine());

                if (ramdomNumber < min || ramdomNumber > max)
                {
                    Console.WriteLine($"Erreur : Le nombre doit être compris entre {min} et {max}.");
                }
            }
            catch
            {
                Console.WriteLine("Erreur : Vous devez entrer un nombre valide.");
            }
        }

        return ramdomNumber;
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