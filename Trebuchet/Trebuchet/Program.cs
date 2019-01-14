using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Net;
using System.Net.Http;
using System.IO;

/*TODO
 * Trouver une logique à ce programme
 * 
 * 
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
            connect.Fire(30, "groupe7");
            connect.Heal("arm");
           // Console.WriteLine(new MyWebRequest("https://dev18504.service-now.com/api/20557/catapulte/fire", "POST", "power=20&target=groupe10").GetResponse()); connect.Heal("rope");
            Console.ReadKey();
        }
    }
}
