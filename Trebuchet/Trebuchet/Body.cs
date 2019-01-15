using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Trebuchet
{
    class Body : Part
    {
        public Body()
        {
            this.Name = "body";
            Connect connect = new Connect();
            PdV = connect.GetLifeAsync(Name);
        }

        public override void Build()
        {
            Console.WriteLine("Le corps est construit");
        }

        public void Maintain(Body body) { }
    }
}