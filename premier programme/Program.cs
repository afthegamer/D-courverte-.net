namespace premier_programme;

internal class Program
{
    private static string DemanderNom()
    {
        string nom = "";
        while (string.IsNullOrWhiteSpace(nom))
        {
            Console.Write("Quel est ton nom ? ");
            nom = Console.ReadLine()?.Trim() ?? "";
            if (string.IsNullOrWhiteSpace(nom))
            {
                Console.WriteLine("Veuillez entrer un nom valide");
            }
        }
        return nom;
    }

    private static int DemanderAge()
    {
        int ageNumber = 0;
        while (ageNumber <= 0)
        {
            Console.Write("Quel est ton âge ? ");
            string? input = Console.ReadLine();

            if (int.TryParse(input, out int parsedAge) && parsedAge > 0)
            {
                ageNumber = parsedAge;
            }
            else
            {
                Console.WriteLine("Tu n'as pas entré un nombre valide.");
            }
        }
        return ageNumber;
    }

    private static void Main(string[] args)
    {
        try
        {
            string nom = DemanderNom();
            int age = DemanderAge();

            Console.WriteLine($"Bonjour je m'appelle {nom} et j'ai {age} ans");
            Console.WriteLine($"{nom}, c'est bien mon nom");
            Console.WriteLine($"{age} est bien mon age");
        }
        catch (Exception e)
        {
            Console.WriteLine($"Une erreur est survenue : {e.Message}");
        }

        Console.WriteLine("Fin du programme");
    }
}
