using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Trebuchet
{
    public class Spoon : Part
    {
        public bool Lowered { get; set; }
        public bool Loaded { get; set; }

        public Spoon()
        {
            this.Lowered = false;
            this.Loaded = false;
        }

        public int PdV { get; set; }

        public void Load(Rock rock)
        {
            this.Loaded = true;
           
        }

        public override void Build()
        {
            Console.WriteLine("Le receptacle est construit");
        }

    }
}
