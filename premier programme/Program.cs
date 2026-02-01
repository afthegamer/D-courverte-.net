namespace premier_programme;

internal class Program
{
    private const int NUMBER_MIN = 0;
    private const int NUMBER_MAX = 10;
    
    // On instancie le Random une seule fois
    private static readonly Random rand = new Random();

    private static void PoserQuestion(int min, int max)
    {
        int bonnesReponses = 0;
        int numeroQuestion = 1;
        
        // On boucle tant qu'on n'a pas atteint 3 bonnes réponses
        while (bonnesReponses < 3) 
        {
            var a = rand.Next(min, max + 1);
            var b = rand.Next(min, max + 1);
            var reponseAttendue = a + b;
            int reponseInt = 0;

            Console.WriteLine($"Question n°{numeroQuestion} (Score actuel: {bonnesReponses}/3)");

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
                bonnesReponses++;
            }
            else
            {
                Console.WriteLine($"Mauvais ! La réponse était {reponseAttendue}");
            }
            
            numeroQuestion++;
            Console.WriteLine(); // Une ligne vide pour aérer
        }
        
        int totalQuestions = numeroQuestion - 1;
        Console.WriteLine($"Félicitations ! Vous avez obtenu 3 bonnes réponses en {totalQuestions} questions.");

        // Affichage du message en fonction de la performance
        if (totalQuestions == 3)
        {
            Console.WriteLine("Excellent ! C'est un sans faute !");
        }
        else if (totalQuestions <= 6)
        {
            Console.WriteLine("Bien joué ! Encore un petit effort pour le sans faute.");
        }
        else
        {
            Console.WriteLine("Tu as réussi, mais tu as besoin de réviser un peu tes maths !");
        }
    }

    private static void Main(string[] args)
    {
        PoserQuestion(NUMBER_MIN, NUMBER_MAX);
    }
}