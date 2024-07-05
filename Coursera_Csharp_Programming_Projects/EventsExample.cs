using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Coursera_Csharp_Programming_Projects
{
    //The Publisher Model
    internal class EventsExample
    {
        //Declare Delegate
        public delegate void delegate_OddNumber();
        //Declare Event 
        public event delegate_OddNumber event_OddNumber;

        public void addition()
        {
            int num1   = 200; int num2 = 100;
            int result = num1 + num2;
            Console.WriteLine(result);
            if (result % 2 != 0 && event_OddNumber != null)
            {
                //Raised Event
                event_OddNumber();
            }
        }
    }
}
