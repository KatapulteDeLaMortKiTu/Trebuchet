﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Trebuchet
{
    public class Rope
    {
        public bool Tense { get; set; }
        public int PdV { get; set; }

        public Rope()
        {
            this.Tense = false;
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