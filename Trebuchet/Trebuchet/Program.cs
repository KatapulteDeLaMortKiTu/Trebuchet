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
            int tir = TirPLEINEPUISSANCE(arm, beam, rope, spoon, trigger);
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

            //check life
            if (a.PdV > 0 && b.PdV > 0 && r.PdV > 0 && s.PdV > 0 && t.PdV > 0 && bo.PdV > 0)
            {
                Console.WriteLine("###");
                Console.WriteLine("Arm Checked ;\n Beam Checked ;\n Rope Checked ;\n");
                Console.WriteLine("Spoon Checked ;\n Trigger Checked ;\n Body Checked;\n");
                Console.WriteLine("###");
                Console.WriteLine("Ready to shoot !");
            }
            if (a.PdV <= 0 || b.PdV <= 0 || r.PdV <= 0 || s.PdV <= 0 || t.PdV <= 0 || bo.PdV <= 0)
            {
                Console.WriteLine("One element or more are broken");
                return 404;
            }




            s.Load(Objetatirer);
            r.Lower(s);
            t.Start();
            a.Move();
            a.Launch(s);
            b.Stop(a);

            return 0;
        }
    }
}
