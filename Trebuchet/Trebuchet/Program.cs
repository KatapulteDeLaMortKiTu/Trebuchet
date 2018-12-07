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
        static void Main()
        {
            //Nouvelle catapulte
            Arm arm = new Arm();
            Beam beam = new Beam();
            Rope rope = new Rope();
            Spoon spoon = new Spoon();
            Trigger trigger = new Trigger();
            Body body = new Body();
            int tir = TirPLEINEPUISSANCE(arm, beam, rope, spoon, trigger, body);
            Console.WriteLine(tir);
            Console.ReadKey();
        }

        public static int TirPLEINEPUISSANCE(Arm a, Beam b, Rope r, Spoon s, Trigger t, Body bo)
        {
             // valeurs fixes pour tests
            int WidthMin = 0;
            int WidthMax = 20;
            int WeightMin = 0;
            int WeightMax = 20;
            Random rnd = new Random();
            int Width = rnd.Next(WidthMin, WidthMax);
            int Weight = rnd.Next(WeightMin, WeightMax);
            Rock Objetatirer = new Rock(0,0);

            // manual set life to test the following tests :D
            a.PdV = 1;
            b.PdV = 1;
            r.PdV = 1;
            s.PdV = 1;
            t.PdV = 1;
            bo.PdV = 1;

            //check life
            if (a.PdV > 0 && b.PdV > 0 && r.PdV > 0 && s.PdV > 0 && t.PdV > 0 && bo.PdV > 0)
            {
                Console.WriteLine("###");
                Console.WriteLine("Arm Checked ;\nBeam Checked ;\nRope Checked ;\n");
                Console.WriteLine("Spoon Checked ;\nTrigger Checked ;\nBody Checked;\n");
                Console.WriteLine("###");
                Console.WriteLine("Ready to shoot !");
            }
            if (a.PdV <= 0 || b.PdV <= 0 || r.PdV <= 0 || s.PdV <= 0 || t.PdV <= 0 || bo.PdV <= 0)
            {
                Console.WriteLine("One element or more are broken");
                return 404;
            }


            if (Objetatirer != null)
            {
                s.Load(Objetatirer);
                if(s.Loaded is true)
                {
                    r.Lower(s);
                    r.Pull();
                    if (r.Tense is true)
                    {
                        t.Start();
                        if (t.Triggered is true)
                        {
                            a.Move();
                            if(a.Action is true )
                            {
                                a.Launch(s);
                                if(s.Loaded is false)
                                {
                                    b.Stop(a);
                                    if(a.Speed == 0)
                                    {
                                        Console.WriteLine("PIERRE FEUILLE CISEAUX");
                                        return 39; // dégâts qu'on va envoyer
                                    } else
                                    {
                                        Console.WriteLine("Arm is not stopped.");
                                    }
                                } else
                                {
                                    Console.WriteLine("Rock is throwed.");
                                }                               
                            } else
                            {
                                Console.WriteLine("Arm is not actionned.");
                            }                      
                        } else
                        {
                            Console.WriteLine("Trigger is not triggered.");
                        }                        
                    } else
                    {
                        Console.WriteLine("Rope is not tense.");
                    }                 
                } else
                {
                    Console.WriteLine("Spoon is not loaded.");
                }               
            } else
            {
                Console.WriteLine("This fucking rock is missing !");
            }
            return 0;
        }
    }
}
