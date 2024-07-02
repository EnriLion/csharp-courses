using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Coursera_Csharp_Programming_Projects
{
    enum WeekDays : byte
    {
        /*     
                Monday, //0
                Tuesday, //1
                Wednesday, //2
                Thursday, //3
                Friday, //4
                Saturday, //5
                Sunday //6

        */
        Monday = 5,
        Tuesday = 10,
        Wednesday = 15,
        Thursday = 25,
        Friday,
        Saturday = 30,
        Sunday

    }
    internal class EnumDemo
    {
        public void display()
        {
            Console.WriteLine(WeekDays.Monday);
            int day = (int)WeekDays.Monday;
            Console.WriteLine(WeekDays.Monday + ": " + day);
            Console.WriteLine(WeekDays.Tuesday);
            day = (int)WeekDays.Tuesday;
            Console.WriteLine(WeekDays.Tuesday + ": " + day);
            Console.WriteLine(WeekDays.Wednesday);
            day = (int)WeekDays.Wednesday;
            Console.WriteLine(WeekDays.Wednesday+ ": " + day);
        }
    }
}
