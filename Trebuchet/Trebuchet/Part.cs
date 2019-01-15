using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Trebuchet
{
    public abstract class Part : IBreakable
    {
        protected string Name;
        public int PdV;


        public int GetLife()
        { return PdV; }

        public int GetLifeLost()
        {
            PdvLost = 99 - PdV;
            return PdvLost;
        }

        public void SetLife(int value)
        { PdV = value; }

        public string GetName()
        { return Name; }

        public void SetName(string value)
        { Name = value; }

        public bool Broken
        {
            get
            {
                if(this.GetLife() < 0)
                {
                    return true;
                }
                else
                {
                    return false;
                }
            }
            set
            {
                Broken = value;
            }
        }

        //Fonction virtuelle
        public virtual void Build() {
            Console.WriteLine("Construction en cours");
        }

        public virtual bool Checklife() => PdV >= 0;
    }
}
