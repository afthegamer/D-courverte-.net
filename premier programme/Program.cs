using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;

namespace programme_collections
{
    class Program
    {
        // Somme (int a, int b, int c)
        static int SommeTableau(int[] t)
        {
            int somme = 0;

            for (int i = 0; i < t.Length; i++)
            {
                somme += t[i];
            }

            return somme;
        }

        static void AfficherTableau(int[] tableau)
        {
            for (int i = 0; i < tableau.Length; i++)
            {
                Console.WriteLine("[" + i + "] " + tableau[i]);
            }
        }

        static void AfficherValeurMaximale(int[] t)
        {
            // La valeur maximale est : xx
            int max = t[0];
            for (int i = 0; i < t.Length; i++)
            {
                if (t[i] > max)
                {
                    max = t[i];
                }
            }
            Console.WriteLine("La valeur maximale est : " + max);
        }

        static void AfficherValeurMinimale(int[] t)
        {
            // La valeur maximale est : xx
            int min = t[0];
            for (int i = 0; i < t.Length; i++)
            {
                if (t[i] < min)
                {
                    min = t[i];
                }
            }
            Console.WriteLine("La valeur minimale est : " + min);
        }

        static void Tableaux()
        {
            //int[] t = { 200, 40, 15, 8, 12 };
            const int TAILLE_TABLEAU = 20;

            // int[] t
            // Initialiser chaque element valeur aléatoire entre 0 et 100

            int[] t = new int[TAILLE_TABLEAU];
            Random r = new Random();
            for (int i = 0; i < t.Length; i++)
            {
                t[i] = r.Next(101);
            }

            AfficherTableau(t);
            AfficherValeurMaximale(t);
            AfficherValeurMinimale(t);


        }

        static void AfficherListe(List<string> liste, bool ordreDescendant = false)
        {
            if (!ordreDescendant)
            {
                for (int i = 0; i < liste.Count; i++)
                {
                    Console.WriteLine(liste[i]);
                }
            }
            else
            {
                // 3 
                // 2 1 0
                for (int i = liste.Count-1; i >= 0; i--)
                {
                    Console.WriteLine(liste[i]);
                }
            }

            // "le nom le plus grand est : "
            string nomLePlusLong = "";
            int longueurMax = 0;
            for (int i = 0; i < liste.Count; i++)
            {
                string nom = liste[i];
                if (nom.Length > longueurMax)
                {
                    longueurMax = nom.Length;
                    nomLePlusLong = nom;
                }
            }

            Console.WriteLine("Le nom le plus long est : " + nomLePlusLong);

            
        }

        static void AfficherElementsCommuns(List<string> liste1, List<string> liste2)
        {
            for (int i = 0; i < liste1.Count; i++)
            {
                string nom1 = liste1[i];
                /*if (liste2.Contains(nom1))
                {
                    Console.WriteLine(nom1);
                }*/
                for (int j = 0; j < liste2.Count; j++)
                {
                    string nom2 = liste2[j];
                    if (nom1 == nom2)
                    {
                        Console.WriteLine(nom1);
                    }
                }
            }
        }

        static void Listes()
        {
            /*List<int> liste = new List<int>();

            liste.Add(5);
            liste.Add(8);
            liste.Add(2);
            liste.Add(2);
            liste.Add(2);

            liste[2]++;
            //liste.Remove(8);
            liste.RemoveAt(1);

            AfficherListe(liste);*/

            /*var noms = new List<string>() { "Jean", "Paul"};
            while(true)
            {
                Console.Write("Rentrez un nom (ENTER pour finir) : ");
                string nom = Console.ReadLine();

                if (nom == "")
                {
                    break;
                }

                if (noms.Contains(nom))
                {
                    Console.WriteLine("Erreur, ce nom est déjà dans la liste");
                    Console.WriteLine();
                }
                else
                {
                    noms.Add(nom);
                }
            }

            //List<string> lesPremiersNoms = noms.GetRange(0, 3);

            // Filtrer : Supprimer tous les noms qui terminent par "e".
            // RemoveAt / longueur de la liste est altérée
            // Bouclez en partant de la fin

            for (int i = noms.Count - 1; i >= 0; i--)
            {
                string nom = noms[i];
                if (nom[nom.Length-1] == 'e')
                {
                    noms.RemoveAt(i);
                }
            }

            AfficherListe(noms, true);*/

            var liste1 = new List<string>() { "paul", "jean", "pierre", "emilie", "martin" };
            var liste2 = new List<string>() { "sophie", "jean", "martin", "toto" };
            // jean, martin

            AfficherElementsCommuns(liste1, liste2);
            // contains

        }

        static void ArrayList()
        {
            ArrayList a = new ArrayList();  // <string>  <int>
            a.Add("Toto"); // nom
            a.Add(49); // age
            a.Add(true); // homme
            

            for (int i = 0; i< a.Count; i++)
            {
                Console.WriteLine(a[i]);
            }

            //object
            var nom = a[0];
            int age = (int)a[1]; // cast
            age++;
            Console.WriteLine("Nom de la personne : " + nom);
            Console.WriteLine("Age de la personne : " + age);

        }

        static void ListesDeListes()
        {
            // France : Paris, Toulouse, Nice, Bordeaux, Lille  <-- List<string>
            // Etats-unis : New-York, Chicago, Los angeles, San Francisco  <-- List<string>
            // Espagne : Madrid, Barcelone, Séville  <-- List<string>
            // Italie : Venise, Florence, Milan, Pise  <-- List<string>

            /*var villes = new List<string>();
            villes.Add("France : Paris, Toulouse, Nice, Bordeaux, Lille");
            villes.Add("Etats-unis : New-York, Chicago, Los angeles, San Francisco");
            villes.Add("Espagne : Madrid, Barcelone, Séville");
            villes.Add("Italie : Venise, Florence, Milan, Pise");*/

            var pays = new List<List<string>>();

            pays.Add(new List<string> { "France", "Paris", "Toulouse", "Nice", "Bordeaux", "Lille" });
            pays.Add(new List<string> { "Etats-unis", "New-York", "Chicago", "Los angeles", "San Francisco" });
            pays.Add(new List<string> { "Italie", "Venise", "Florence", "Milan", "Pise" });

            // France - 5 villes
            //   Paris
            //   Toulouse

            for (int i = 0; i < pays.Count; i++)
            {
                var p = pays[i];
                Console.WriteLine(p[0] + " - " + (p.Count-1) + " villes");
                for (int j = 1; j < p.Count; j++)
                {
                    Console.WriteLine("  " + p[j]);
                }
            }


            //AfficherListe(villes);
        }

        static void Dictionnaire()
        {
            string personneAChercher = "Martin";
            // Dictionary
            // clef -> valeur
            // Nom -> numero de téléphone "+33"
            var d = new Dictionary<string, string>();
            d.Add("Jean", "0622334455");
            d.Add("Marie", "0688334455");
            d["Martin"] = "0678905632";
            d["Toto"] = "0658398472";

            if (d.ContainsKey(personneAChercher))
            {
                Console.WriteLine(d[personneAChercher]);
            }
            else
            {
                Console.WriteLine("Cette personne n'a pas été trouvée");
            }

            //Liste  string [2]nom numero de tel
            var l = new List<string[]>();
            l.Add(new string[] { "Jean", "0622334455" });
            l.Add(new string[] { "Marie", "0688334455" });
            l.Add(new string[] { "Martin", "0678905632" });
            l.Add(new string[] { "Toto", "0658398472" });

            for (int i = 0; i < l.Count; i++)
            {
                if (l[i][0] == personneAChercher)
                {
                    Console.WriteLine(l[i][1]);
                    break;
                }
            }



        }

        static void BoucleForEach()
        {
            //var noms = new string[] { "Toto", "Jean", "Pierre" };
            //var noms = new List<string>() { "Toto", "Jean", "Pierre" };

            /*for (int i = 0; i < noms.Length; i++)
            {
                Console.WriteLine(noms[i]);
            }*/
            /*foreach(var nom in noms)
            {
                Console.WriteLine(nom);
            }*/

            var d = new Dictionary<string, string>();
            d.Add("Jean", "0622334455");
            d.Add("Marie", "0688334455");
            d["Martin"] = "0678905632";
            d["Toto"] = "0658398472";

            foreach(var e in d)
            {
                Console.WriteLine(e.Key + " -> " + e.Value);
            }
        }

        static void TrisEtLinq()
        {
            /*var noms = new List<string> { "Toto", "Jean", "Pierre", "Emilie", "Sophie", "Martin", "Benoit", "Vincent" };

            //noms.Sort();
            //Array.Sort(noms);
            //noms =  noms.OrderBy(nom => nom).ToList(); // trie par ordre alphabetique
            noms = noms.Where(nom => nom[nom.Length-1] != 'e').ToList();


            foreach (var nom in noms)
            {
                Console.WriteLine(nom);
            }
            */

            var notes = new List<int> { 4, 8, 1, 9, 2};
            //notes = notes.OrderByDescending(n => n).ToList();
            notes = notes.Where(n => n >= 5).ToList();
            foreach (var n in notes)
            {
                Console.WriteLine(n);
            }
        }

        static void Main(string[] args)
        {
            //Tableaux();
            //Listes();
            //ArrayList();
            //ListesDeListes();
            //Dictionnaire();
            //BoucleForEach();
            TrisEtLinq();
        }
    }
}
