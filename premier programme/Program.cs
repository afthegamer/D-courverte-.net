namespace premier_programme;

internal class Program
{
    private const int NUMBER_MIN = 0;
    private const int NUMBER_MAX = 10;
    
    // On instancie le Random une seule fois
    private static readonly Random rand = new Random();

    private static void PoserQuestion(int min, int max)
    {
        while (true) // Boucle infinie pour poser des questions en continu
        {
            var a = rand.Next(min, max + 1);
            var b = rand.Next(min, max + 1);
            var reponseAttendue = a + b;
            int reponseInt = 0;

            while (true) // Boucle pour valider la saisie de l'utilisateur pour la question en cours
            {
                Console.Write($"Combien ça fait {a} + {b} ? ");
                var reponse = Console.ReadLine();

                try
                {
                    reponseInt = int.Parse(reponse);
                    break; // Si la conversion réussit, on sort de la boucle de saisie
                }
                catch
                {
                    Console.WriteLine("Erreur : Vous devez entrer un nombre valide.");
                }
            }

            if (reponseInt == reponseAttendue)
            {
                Console.WriteLine("Bravo !");
            }
            else
            {
                Console.WriteLine($"Mauvais ! La réponse était {reponseAttendue}");
            }
            
            Console.WriteLine(); // Une ligne vide pour aérer
        }
    }

    private static void Main(string[] args)
    {
        PoserQuestion(NUMBER_MIN, NUMBER_MAX);
    }
}