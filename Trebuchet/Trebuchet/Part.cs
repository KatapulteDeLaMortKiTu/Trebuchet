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
        protected int PdV;


        public int GetLife()
        { return PdV; }

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
                //Si les PV sont en dessous de 0, alors Broken est vrai
                if(this.GetLife() < 0)
                {
                    return true;
                }
                else
                {
                    return false;
                }
               
            }
        }

        //Fonction Virtuelle non utilisée
        public virtual void Build() {
            Console.WriteLine("Construction en cours");
        }

        public virtual bool Checklife() => PdV >= 0;
    }
}
