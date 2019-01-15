using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Trebuchet
{
    class Body : Part
    {
        public int PdV { get; set; }

        public override void Build()
        {
            Console.WriteLine("Le corps est construit");
        }

        public void Maintain(Body body) { }
    }
}