using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Trebuchet
{
    public class Trigger : Part
    {

        public bool Triggered { get; set; }

        public Trigger()
        {
            this.Triggered = false;
            this.Name = "trigger";
            Connect connect = new Connect();
            PdV = connect.GetLifeAsync(Name);
        }

        public void Start()
        {
            this.Triggered = true;
        }

        //Override de la fonction virtuelle Part.Build()

        public override void Build()
        {
            Console.WriteLine("Le déclencheur est construit");
        }

    }
}
