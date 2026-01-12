namespace premier_programme;

internal class Program
{
    private static void Main(string[] args)
    {
        Console.Write("Quel est ton nom ? ");
        var nama = Console.ReadLine();
        var tryagain = 0;
        try
        {
            int? ageNumber = null;

            while (tryagain < 4 && ageNumber == null)
            {
                Console.Write("Quel est ton âge ? ");
                var input = Console.ReadLine();

                if (int.TryParse(input, out var parsedAge))
                {
                    ageNumber = parsedAge;
                    

                    Console.WriteLine("Bonjour je m'appelle " + nama + " et j'ai " + ageNumber + " ans");
                    Console.WriteLine(nama + ", c'est bien mon nom");
                    Console.WriteLine(ageNumber + " est bien mon age");
                    // break implicite car ageNumber != null
                }
                else
                {
                    Console.WriteLine("Tu n'as pas entré un nombre valide.");
                    tryagain++;
                }
            }
        }
        catch (Exception e)
        {
            Console.WriteLine(e);
            throw;
        }

        Console.WriteLine("Fin du programme");
    }
}