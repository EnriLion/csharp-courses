using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Coursera_Csharp_Programming_Projects
{
    static internal class IntExtensions
    {
        public static bool isGreaterThan(this int i, int value)
        {
            return i > value;
        }
    }
}
