using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Coursera_Csharp_Programming_Projects
{
    internal class Calculate
    {
        //    static int count = 0;
        public static int count = 0;
        static Calculate()
        {
            count = 0;
        }
        public static int increment() { count++; return count; }
        public static int decrement() { count--; return count; }
    }
}
