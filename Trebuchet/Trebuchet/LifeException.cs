using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Trebuchet
{
    class LifeException : Exception
    {
        public LifeException(string message) : base(message)
        {
            Console.WriteLine(message);
        }
    }
}
