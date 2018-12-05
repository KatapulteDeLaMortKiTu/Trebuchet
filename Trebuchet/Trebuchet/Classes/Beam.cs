using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Trebuchet 
{
    public class Beam : IBreakable // Poutre traversant qui arrete le mouvement du bras
    {
        public int PdV { get; set; }

        public bool Broken
        {
            get
            {
                return PdV <= 0;
            }
        }

        public void Stop(Arm arm)
            {

                arm.Speed = 0;

            }

        }
}
