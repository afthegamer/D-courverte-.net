namespace premier_programme;

internal class Program
{
    private static int demanderNombre()
    {
        var ramdomNumber = 0;
        while (ramdomNumber == 0)
        {
            Console.WriteLine("Veuillez saisir un nombre");
            var input = Console.ReadLine();
            // On utilise TryParse pour éviter que le programme plante si l'utilisateur n'entre pas un nombre
            int.TryParse(input, out ramdomNumber);
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