using premier_programme;

namespace premier_programme;

internal class Program
{
    private static void Main(string[] args)
    {
        const int MIN_LONGUEUR = 1;
        const int MAX_LONGUEUR = 50;
        const string ALPHABET_MINUSCULES = "abcdefghijklmnopqrstuvwxyz";
        const string ALPHABET_MAJUSCULES = "ABCDEFGHIJKLMNOPQRSTUVWXYZ";
        const string CHIFFRES = "0123456789";
        const string CARACTERES_SPECIAUX = "!@#$%^&*()";
        
        const string ALPHABET_COMPLET = ALPHABET_MINUSCULES + ALPHABET_MAJUSCULES + CHIFFRES + CARACTERES_SPECIAUX;

        int longueur = outils.DemanderNombreEntre("De quelle longueur doit être le mot de passe ?", MIN_LONGUEUR, MAX_LONGUEUR);
        
        int nombreDeMotsDePasse = outils.DemanderNombrePositifNonNull("Combien de mots de passe voulez-vous générer ?");

        Console.WriteLine();
        
        Random rand = new Random();

        int choixAlphabet = outils.DemanderNombreEntre("Quel type de caractères voulez-vous ?\n1 - Uniquement des minuscules\n2 - Minuscules et majuscules\n3 - Caractères et chiffres\n4 - Tout (minuscules, majuscules, chiffres, spéciaux)\nVotre choix :", 1, 4);

        string alphabetUtilise = "";
        switch (choixAlphabet)
        {
            case 1:
                alphabetUtilise = ALPHABET_MINUSCULES;
                break;
            case 2:
                alphabetUtilise = ALPHABET_MINUSCULES + ALPHABET_MAJUSCULES;
                break;
            case 3:
                alphabetUtilise = ALPHABET_MINUSCULES + ALPHABET_MAJUSCULES + CHIFFRES;
                break;
            case 4:
                alphabetUtilise = ALPHABET_COMPLET;
                break;
        }

        Console.WriteLine();
        for (int i = 0; i < nombreDeMotsDePasse; i++)
        {
            string motDePasse = "";
            for (int j = 0; j < longueur; j++)
            {
                int index = rand.Next(alphabetUtilise.Length);
                motDePasse += alphabetUtilise[index];
            }
            Console.WriteLine($"Mot de passe {i + 1} : {motDePasse}");
        }
    }
}