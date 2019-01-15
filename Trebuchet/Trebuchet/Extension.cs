using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Trebuchet
{
    public static class Extension
    {
        //RandTo20 est une fonction permettant de générer un nombre aléatoire entre "min" et 20
        public static float RandTo20(this int min) {
            
            int Max = 20;
            Random rnd = new Random();
            int Value = rnd.Next(min, Max);

            //Cast implicite du int Value en float return
            return Value;

        }

    }
}
