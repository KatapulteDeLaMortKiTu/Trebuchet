using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Trebuchet
{
    public class Trigger : IBreakable // manette qui déclenche le tir
    {
        public int PdV { get; set; }
        public bool Triggered { get; set; }

        public bool Broken
        {
            get
            {
                return PdV <= 0;
            }
        }

        public Trigger()
        {
            this.Triggered = false;
        }

        public void Start()
        {
            this.Triggered = true;
        }

    }
}
