using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

/*TODO
 * Trouver une logique à ce programme
 * 
 * Set les PdV de chaque objet en fonction de l'API
 */

namespace Trebuchet
{
    class Program
    {
        static int Main()
        {
            Console.WriteLine("Bienvenue ! Quel est votre nom ?");
            //Type anonyme
            var commander = new { Rang = "general ", Nom = Console.ReadLine() };

            Console.WriteLine("Enchanté " + commander.Rang + commander.Nom + ", la bataille peut commencer !");

            Connect connect = new Connect();

            //Nouvelle catapulte
            Catapulte catapulte = new Catapulte();

            //check life
            while (!catapulte.CheckIfBroken())
            {
                try
                {
                    //Méthode d'extension
                    float Width = 0.RandTo20();
                    float Weight = 0.RandTo20();

                    //Test reflection
                    System.Type type = Weight.GetType();
                    System.Console.WriteLine(type);
                    // On remarque alors que le type du poids est Single (correspond à un float)
                    // On peut alors essayer de regarder le nom complet de l'assembly chargée pour un type Single
                    System.Reflection.Assembly info = typeof(System.Single).Assembly;
                    System.Console.WriteLine(info);



                    //Cast explicite des floats de RandTo20() en int pour Rock(int, int)
                    Rock Objetatirer = new Rock((int)Width, (int)Weight);
                    dynamic check = new NotEnoughRockClass();
                    Console.WriteLine(check.NotEnoughRock(Objetatirer));
                    catapulte.ProcessTir(Objetatirer);
                    catapulte.CheckLifeThenHeal();
                }
                catch (Exception e)
                {
                    Console.WriteLine(e.Message);
                }
            }

            Console.WriteLine("La catapulte est en miettes !");

            Console.WriteLine("Nous avons perdu général, replions nous !");
            return 0;

        }
    }
}
