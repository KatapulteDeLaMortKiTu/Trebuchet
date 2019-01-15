using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Trebuchet
{
    public abstract class Part : IBreakable
    {
        protected string name;
        protected int vie;

        public int GetLife()
        { return vie; }

        public void SetLife(int value)
        { vie = value; }

        public string GetName()
        { return name; }

        public void SetName(string value)
        { name = value; }

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
        }

        public virtual void Build() {
            Console.WriteLine("Construction en cours");
        }

        public virtual bool Checklife() => vie >= 0;
    }
}
