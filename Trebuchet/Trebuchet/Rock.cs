using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Trebuchet
{
    public struct Rock
    {

        public int width;
        public int weight;

        //Structure utilisée pour déterminer la puissance du tir

        public Rock(int width, int weight)
        {
            this.width = width;
            this.weight = weight;
        }


    }
}
