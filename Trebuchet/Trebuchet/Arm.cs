using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Trebuchet
{
    public class Arm
    {
        public int Angle { get; set; }
        public int Speed { get; set; }
        public int PdV { get; set; }

        public Arm()
        {

        }

        public void Move()
        {
            this.Angle = 0;
        }

        public void Launch(Spoon spoon)
        {
            spoon.loaded = false;
        }
    }
}
