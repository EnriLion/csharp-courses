using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Coursera_Csharp_Programming_Projects
{
    internal class StudentInfo
    {
        private int studentId;
        private string studentName;

        public void acceptDetails()
        {
            Console.Write("Enter Student Id:");
            studentId = int.Parse(Console.ReadLine());
            Console.Write("Enter Student Name: ");
            studentName = Console.ReadLine();
        }

        public void displayDetails()
        {
            Console.WriteLine("Student Id: " + studentId);
            Console.WriteLine("Student Name: " + studentName);
        }
    }
}
