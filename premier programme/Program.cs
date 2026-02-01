namespace premier_programme;

internal class Program
{
    private static string DemanderNom(int numeroPersonn)
    {
        var nom = "";
        while (string.IsNullOrWhiteSpace(nom))
        {
            Console.Write($"Quel est ton nom {numeroPersonn} ? ");
            nom = Console.ReadLine()?.Trim() ?? "";
            if (string.IsNullOrWhiteSpace(nom)) Console.WriteLine($"Veuillez entrer un nom valide {numeroPersonn}");
        }

        return nom;
    }

    private static int DemanderAge(int numeroPersonn)
    {
        var ageNumber = 0;
        while (ageNumber <= 0)
        {
            Console.Write($"Quel est ton âge {numeroPersonn}? ");
            var input = Console.ReadLine();

            if (int.TryParse(input, out var parsedAge) && parsedAge > 0)
                ageNumber = parsedAge;
            else
                Console.WriteLine($"Tu n'as pas entré un nombre valide.{numeroPersonn}");
        }

        return ageNumber;
    }

    private static void DemanderInformation(string nom, int age)
    {
        try
        {
            Console.WriteLine($"Bonjour je m'appelle {nom} et j'ai {age} ans");
            Console.WriteLine($"{nom}, c'est bien mon nom");
            Console.WriteLine($"{age + 1} est bien mon age que j'aurais prochainement");
            switch (age)
            {
                case 17:
                    Console.WriteLine($"{nom}, tu es presque majeur");
                    break;
                case 18:
                    Console.WriteLine($"{nom}, tu es tout juste majeur");
                    break;
                case int a when a >= 19:
                    Console.WriteLine($"{nom}, tu es presque majeur");
                    break;
                case int a when a >= 60:
                    Console.WriteLine($"{nom}, tu es très agée");
                    break;
                case int a when a <= 10:
                    Console.WriteLine($"{nom}, tu es encore un petit enfant");
                    break;
                default:
                    Console.WriteLine($"{nom}, tu es mineur");
                    break;
            }
        }
        catch (Exception e)
        {
            Console.WriteLine($"Une erreur est survenue : {e.Message}");
        }

        Console.WriteLine("Fin du programme");
    }

    private static void Main(string[] args)
    {
        var nom = DemanderNom(1);
        var age = DemanderAge(1);
        DemanderInformation(nom, age);
    }
}