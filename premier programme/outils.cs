namespace premier_programme;

public static class outils
{
    // --- Constantes et Outils pour le Générateur de Mot de Passe ---

    private const string ALPHABET_MINUSCULES = "abcdefghijklmnopqrstuvwxyz";
    private const string ALPHABET_MAJUSCULES = "ABCDEFGHIJKLMNOPQRSTUVWXYZ";
    private const string CHIFFRES = "0123456789";
    private const string CARACTERES_SPECIAUX = "!@#$%^&*()";
    private const string ALPHABET_COMPLET = ALPHABET_MINUSCULES + ALPHABET_MAJUSCULES + CHIFFRES + CARACTERES_SPECIAUX;

    private static readonly Random rand = new Random();

    // --- Point d'entrée unique ---

    public static void LancerGenerateurDeMotDePasse()
    {
        int longueur = DemanderLongueurMotDePasse();
        Console.WriteLine();

        string alphabet = DemanderAlphabet();
        Console.WriteLine();

        int nombre = DemanderNombreDeMotsDePasse();
        Console.WriteLine();

        AfficherMotsDePasse(nombre, longueur, alphabet);
    }

    // --- Étapes du programme (peuvent être privées maintenant) ---

    private static int DemanderLongueurMotDePasse()
    {
        return DemanderNombreEntre("De quelle longueur doit être le mot de passe ?", 1, 50);
    }

    private static string DemanderAlphabet()
    {
        int choix = DemanderNombreEntre("Quel type de caractères voulez-vous ?\n1 - Uniquement des minuscules\n2 - Minuscules et majuscules\n3 - Caractères et chiffres\n4 - Tout (minuscules, majuscules, chiffres, spéciaux)\nVotre choix :", 1, 4);
        
        switch (choix)
        {
            case 1: return ALPHABET_MINUSCULES;
            case 2: return ALPHABET_MINUSCULES + ALPHABET_MAJUSCULES;
            case 3: return ALPHABET_MINUSCULES + ALPHABET_MAJUSCULES + CHIFFRES;
            case 4: return ALPHABET_COMPLET;
            default: return ALPHABET_COMPLET;
        }
    }

    private static int DemanderNombreDeMotsDePasse()
    {
        return DemanderNombrePositifNonNull("Combien de mots de passe voulez-vous générer ?");
    }

    private static void AfficherMotsDePasse(int nombre, int longueur, string alphabet)
    {
        for (int i = 0; i < nombre; i++)
        {
            string motDePasse = GenererMotDePasse(longueur, alphabet);
            Console.WriteLine($"Mot de passe {i + 1} : {motDePasse}");
        }
    }

    private static string GenererMotDePasse(int longueur, string alphabet)
    {
        string motDePasse = "";
        for (int j = 0; j < longueur; j++)
        {
            int index = rand.Next(alphabet.Length);
            motDePasse += alphabet[index];
        }
        return motDePasse;
    }

    // --- Fonctions de saisie génériques (restent publiques si besoin ailleurs) ---

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

    public static int DemanderNombreEntre(string question, int min, int max)
    {
        if (min > max)
        {
            int temp = min;
            min = max;
            max = temp;
        }

        int nombre = DemanderNombre(question);

        if (nombre >= min && nombre <= max)
        {
            return nombre;
        }

        Console.WriteLine($"Erreur : Le nombre doit être compris entre {min} et {max}.");
        return DemanderNombreEntre(question, min, max);
    }
}