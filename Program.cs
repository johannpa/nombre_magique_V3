using System;

namespace nombre_magique_V2
{
    class Program
    {

        static int DemanderNombre(int min, int max)
        {


            int nombreUtilisateur = min - 1;

            while (nombreUtilisateur < min || nombreUtilisateur > max)
            {
                Console.Write("Rentrez un nombre :");
                string reponse = Console.ReadLine();

                try
                {
                    nombreUtilisateur = int.Parse(reponse);

                    if (nombreUtilisateur < min || nombreUtilisateur > max)
                    {
                        Console.WriteLine($"ERREUR : vous devez choisir un nombre entre {min} et {max}");
                    }
                }
                catch
                {
                    Console.WriteLine("ERREUR : rentrez un nombre valide !");
                }
            }



            return nombreUtilisateur;
        }

        static void Main(string[] args)
        {

            const int NOMBRE_MIN = 1;
            const int NOMBRE_MAX = 10;
            Random rand = new Random();

            int nombreMagique = rand.Next(NOMBRE_MIN, NOMBRE_MAX + 1);

            int nombre = NOMBRE_MIN - 1;


            for (int nbVies = 4; nbVies > 0; nbVies--)
            {
                Console.WriteLine();
                Console.WriteLine($"Vie restantes : {nbVies}");
                nombre = DemanderNombre(NOMBRE_MIN, NOMBRE_MAX);
                if (nombre > nombreMagique)
                {
                    Console.WriteLine("Le nombre magique est plus petit");

                }
                else if (nombre < nombreMagique)
                {
                    Console.WriteLine("Le nombre magique est plus grand");

                }
                else
                {
                    Console.WriteLine("Bravo, vous avez trouvé le nombre magique");
                    break;
                }

            }

            if (nombre != nombreMagique)
            {
                Console.WriteLine($"Vous avez perdu, le nombre magique était :  {nombreMagique}");
            }



        }
    }
}
