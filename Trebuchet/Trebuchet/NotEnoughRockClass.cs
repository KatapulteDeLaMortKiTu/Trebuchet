*using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Trebuchet
{
    // Pour la beauté on ajoute un dynamic pour regarder s'il y a assez de cailloux en réserve
    class NotEnoughRockClass
    {
        dynamic prop { get; set; }
        public dynamic NotEnoughRock(dynamic d)
        {
            dynamic test = "C'est bon general !";
            if (d is Rock)
            {
                return test;
            }
            if (d is float)
            {
                return 10;
            }
            else
            {
                return 1;
            }
        }
    }
}
