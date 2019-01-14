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
            Connect connect = new Connect();

            Arm arm = new Arm
            {
                PdV = connect.GetLifeAsync("arm")
            };

            Spoon kouillaire = new Spoon
            {
                PdV = connect.GetLifeAsync("spoon")
            };

            Rope corde = new Rope
            {
                PdV = connect.GetLifeAsync("rope")
            };

            Console.WriteLine(arm.PdV);
            Console.WriteLine(corde.PdV);
            Console.WriteLine(corde.PdV);
            Console.ReadKey();
        }
    }
}
