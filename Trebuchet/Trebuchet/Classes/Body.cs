using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Trebuchet
{
    class Body : IBreakable // Maintient l'equipement au sol
    {
        public int PdV { get; set; }

        public bool Broken
        {
            get
            {
                return PdV <= 0;
            }
        }

        public void Maintain(Body body) { }
    }
}
