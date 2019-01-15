using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Trebuchet
{
    public class Rope : Part
    {
         public bool Tense { get; set; }

        //Override de la fonction virtuelle Part.Build()
        public override void Build()
        {
            Console.WriteLine("La corde est construite");
        }

        public Rope()
        {
            this.Tense = false;
            this.Name = "rope";
            Connect connect = new Connect();
            PdV = connect.GetLifeAsync(Name);
        }

        public void Lower(Spoon spoon)
        {
            spoon.Lowered = true;

        }

        public void Pull()
        {
            this.Tense = true;
        }

    }
}
