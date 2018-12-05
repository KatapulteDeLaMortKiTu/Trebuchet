using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Trebuchet
{
    public class Spoon : IBreakable // supporte le rocher
    {

        public bool Lowered { get; set; }
        public bool Loaded { get; set; }

        public Spoon()
        {
            this.Lowered = false;
            this.Loaded = false;
        }

        public int PdV
        {
            get
            {
                return PdV; //truc URL LALA; 
            }
        }
        public bool Broken
        {
            get
            {
                return PdV <= 0;
            }
        }

        public void Load(Rock rock)
        {
            this.Loaded = true;
           
        }

    }
}
