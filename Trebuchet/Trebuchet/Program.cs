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
            Arm arm = new Arm
            {
                PdV = Connect.GetLifeAsync("arm")
            };

            Spoon kouillaire = new Spoon
            {
                PdV = Connect.GetLifeAsync("spoon")
            };

            Rope corde = new Rope
            {
                //PdV = Connect.GetLifeAsync("rope")
            };

            Console.WriteLine(arm.PdV);
            //Console.WriteLine(corde.PdV);
            Console.ReadKey();
        }
    }
}
