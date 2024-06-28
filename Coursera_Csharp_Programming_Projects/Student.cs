using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;

namespace Coursera_Csharp_Programming_Projects
{
    internal class Student
    {
        //Data Members
        private int studentId;
        private string studentName;

        //Member Function
        /*        public void acceptDetails()
                {
                    Console.Write("Enter Sudent Id: ");
                    studentId = int.Parse(Console.ReadLine());
                    Console.Write("Enter Student Name: ");
                    studentName = Console.ReadLine();
                }
        */

        //Default Constructor
        public Student()
        {
            studentId = 101;
            studentName = "Annonymous";
        }

        //Parameterized Constructor
        public Student(int sId, string sName)
        {
            studentId = sId;
            studentName = sName;
        }


        //void displayDetails()
        public void displayDetails() //Public is an  "access modifier"
        {
            Console.WriteLine("Student Id: " + studentId);
            Console.WriteLine("Student Name: " + studentName);
        }

    }
}
