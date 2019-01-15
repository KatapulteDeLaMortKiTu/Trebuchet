using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Trebuchet 
{
    public class Beam : Part
    {

        public Beam()
        {
            this.Name = "beam";
            Connect connect = new Connect();
            PdV = connect.GetLifeAsync(Name);
        }

        public void Stop(Arm arm)
            {

                arm.Speed = 0;
            }

        //Override de la fonction virtuelle Part.Build()

        public override void Build()
        {
            Console.WriteLine("Le mât est construit");
        }

    }
}
