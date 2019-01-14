<<<<<<< HEAD:Trebuchet/Trebuchet/Spoon.cs
﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Trebuchet
{
    public class Spoon : IBreakable
    {
        public bool Lowered { get; set; }
        public bool Loaded { get; set; }

        public Spoon()
        {
            this.Lowered = false;
            this.Loaded = false;
        }

        public int PdV
        {
            get
            {
                return PdV; //truc URL LALA; 
            }
            set
            {

            }
        }

        public bool Broken
        {
            get
            {
                return PdV <= 0;
            }
        }

        public void Load(Rock rock)
        {
            this.Loaded = true;
           
        }

    }
}
=======
﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Trebuchet
{
    public class Spoon : IBreakable // supporte le rocher
    {
        public int PdV { get; set; }
        public bool Lowered { get; set; }
        public bool Loaded { get; set; }

        public Spoon()
        {
            this.Lowered = false;
            this.Loaded = false;
        }

   /*     public int PdV
        {
            get
            {
                return PdV; //truc URL LALA; 
            }
        }*/
        public bool Broken
        {
            get
            {
                return PdV <= 0;
            }
        }

        public void Load(Rock rock)
        {
            this.Loaded = true;
           
        }

    }
}
>>>>>>> maxime:Trebuchet/Trebuchet/Classes/Spoon.cs
