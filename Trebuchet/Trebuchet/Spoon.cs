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
            this.Name = "spoon";
            Connect connect = new Connect();
            PdV = connect.GetLifeAsync(Name);
        }

        public void Load(Rock rock)
        {
            this.Loaded = true;
           
        }

        //Override de la fonction virtuelle Part.Build()

        public override void Build()
        {
            Console.WriteLine("Le receptacle est construit");
        }

    }
}
