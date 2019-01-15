using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Trebuchet 
{
    public class Beam : Part
    {
        public int PdV { get; set; }


        public void Stop(Arm arm)
            {

                arm.Speed = 0;
            }

        public override void Build()
        {
            Console.WriteLine("Le mât est construit");
        }

    }
}
