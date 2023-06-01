using System;

namespace CeUAA11_2023_VictorPholien
{
    class Program
    {
        static void Main(string[] args)
        {
            string phClaire;
            string phClef;
            string MatVigenere;
            int a;
            int b;
            string matAffine;

            methodes MesOutils = new methodes();

            Console.WriteLine("CRYPTAGE");
            Console.WriteLine("========");
            bool continuer = true;

            
            while (continuer) //Boucle pour pouvoir recommencer
            {
                Console.WriteLine("Choisissez parmi les options suivantes");
                Console.WriteLine("1 - Cryptage de Viginère");
                Console.WriteLine("2 - Cryptage avec la methode affine");
                int choix = int.Parse(Console.ReadLine());

                if( choix == 1) //Si l'utilisateur choisi le Cryptage de Viginère
                {
                    Console.WriteLine("Encodez la phrase a crypter");
                    phClaire = Console.ReadLine();
                    Console.WriteLine("Vous avez choisi la methode Viginère");
                    Console.WriteLine("------------------------------------");
                    Console.WriteLine("Encodez la clé a utiliser dans la methode Viginaire");
                    phClef = Console.ReadLine();
                    MesOutils.CryptVigenere( phClaire,  phClef, out MatVigenere);
                    Console.WriteLine("Voici la matrice de Cryptage");
                    Console.WriteLine("----------------------------");
                    Console.WriteLine(MatVigenere);
                }

                else if (choix == 2) //Si l'utilisateur choisi le Cryptage avec la méthode affine
                {
                    Console.WriteLine("Encodez la phrase a crypter");
                    phClaire = Console.ReadLine();
                    Console.WriteLine("Donnez la valeur de a (impaire entre 1 et 25 sauf 13)");
                    a = int.Parse(Console.ReadLine());
                    Console.WriteLine("Donnez la valeur de b");
                    b = int.Parse(Console.ReadLine());
                    MesOutils.CryptAffine(phClaire, a, b, out matAffine);
                    Console.WriteLine("Résultat du cryptage par la methode affine");
                    Console.WriteLine("----------------------------");
                    Console.WriteLine(matAffine);
                }


                Console.WriteLine("\nVoulez-vous continuer ? (O/N)"); //Demande pour relancer le programme
                string reponse = Console.ReadLine().ToUpper();
                continuer = (reponse == "O" || reponse == "YES");
            }
        }
    }
}
