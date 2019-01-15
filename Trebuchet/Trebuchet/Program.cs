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
            var commander = new { Rang = "general ", Nom = Console.ReadLine()};

            Console.WriteLine("Enchanté " + commander.Rang + commander.Nom + ", la bataille peut commencer !");

            Connect connect = new Connect();

            //Nouvelle catapulte
            Catapulte catapulte = new Catapulte();

            //check life
            if (!catapulte.CheckIfBroken())
            {
                while (!catapulte.CheckIfBroken())
                {
                    
                    //Méthode d'extension
                    float Width = 0.RandTo20();
                    float Weight = 0.RandTo20();
                    //Cast explicite des floats de RandTo20() en int pour Rock(int, int)
                    Rock Objetatirer = new Rock((int)Width, (int)Weight);
                    catapulte.ProcessTir(Objetatirer);
                    catapulte.CheckLifeThenHeal();
                }
                
                
            }
            else
            {
                Console.WriteLine("La catapulte est en miettes !");

                Console.WriteLine("Nous avons perdu général, replions nous !");
                return 0;
            }

            //int tir = TirPLEINEPUISSANCE(catapulte);
            //Console.WriteLine(tir);
            //connect.Fire(tir, "groupe3");
            Console.ReadKey();
            return 0;
        }


        public static int TirPLEINEPUISSANCE(Catapulte catapulte)
        {

            

            


            
                //s.Load(Objetatirer);
                //if (s.Loaded is true)
                //{
                //    r.Lower(s);
                //    r.Pull();
                //    if (r.Tense is true)
                //    {
                //        t.Start();
                //        if (t.Triggered is true)
                //        {
                //            a.Move();
                //            if (a.Action is true)
                //            {
                //                a.Launch(s);
                //                if (s.Loaded is false)
                //                {
                //                    b.Stop(a);
                //                    if (a.Speed == 0)
                //                    {
                //                        Console.WriteLine("PIERRE FEUILLE CISEAUX");
                //                        return 39; // dégâts qu'on va envoyer
                //                    }
                //                    else
                //                    {
                //                        Console.WriteLine("Arm is not stopped.");
                //                    }
                //                }
                //                else
                //                {
                //                    Console.WriteLine("Rock is thrown.");
                //                }
                //            }
                //            else
                //            {
                //                Console.WriteLine("Arm is not actionned.");
                //            }
                //        }
                //        else
                //        {
                //            Console.WriteLine("Trigger is not triggered.");
                //        }
                //    }
                //    else
                //    {
                //        Console.WriteLine("Rope is not tense.");
                //    }
                //}
                //else
                //{
                //    Console.WriteLine("Spoon is not loaded.");
                //}
            
            
            return 0;
        }
    }
}
