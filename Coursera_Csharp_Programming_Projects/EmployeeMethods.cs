using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Coursera_Csharp_Programming_Projects
{
    internal partial class Employee
    {
        public partial void DisplayDetails()
        {
            Console.WriteLine("Employee Id:" + this.EmpId);
            Console.WriteLine("Employee Name:" + this.EmpName);
        }
    }
}
