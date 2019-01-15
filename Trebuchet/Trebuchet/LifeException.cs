using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Trebuchet
{
    class LifeException : Exception
    {
        public LifeException() { }


        public LifeException(string nom) : base("Cet élément est cassé : " + nom)
        {
        }
    }
}
