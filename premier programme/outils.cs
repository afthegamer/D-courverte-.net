namespace premier_programme;

public static class outils
{
    
    // Fonction de base : demande un entier (positif, négatif ou zéro)
    public static int DemanderNombre(string question)
    {
        while (true)
        {
            Console.Write(question + " ");
            var response = Console.ReadLine();
            try
            {
                return int.Parse(response);
            }
            catch
            {
                Console.WriteLine("Erreur : Vous devez entrer un nombre valide.");
            }
        }
    }

    // Fonction récursive : demande un nombre > 0
    public static int DemanderNombrePositifNonNull(string question)
    {
        int nombre = DemanderNombre(question);
        
        if (nombre > 0)
        {
            return nombre;
        }

        Console.WriteLine("Erreur : Le nombre doit être positif et non nul.");
        return DemanderNombrePositifNonNull(question);
    }

    // Fonction récursive : demande un nombre entre min et max
    public static int DemanderNombreEntre(string question, int min, int max)
    {
        int nombre = DemanderNombre(question);

        if (nombre >= min && nombre <= max)
        {
            return nombre;
        }

        Console.WriteLine($"Erreur : Le nombre doit être compris entre {min} et {max}.");
        return DemanderNombreEntre(question, min, max);
    }
}