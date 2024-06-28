using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Coursera_Csharp_Programming_Projects
{
    internal class Marks : StudentInfo
    {
        float objectiveMarks;
        float subjectiveMarks;
        public void acceptDetails()
        {
            base.acceptDetails();
            Console.Write("Enter Objective Marks: ");
            objectiveMarks = float.Parse(Console.ReadLine());
            Console.Write("Enter Subjective Marks: ");
            subjectiveMarks= float.Parse(Console.ReadLine());
        }

        public void displayDetails()
        {
            base.displayDetails();
            Console.WriteLine("Objective Marks: " + objectiveMarks);
            Console.WriteLine("Subjective Marks: " + subjectiveMarks);
        }
    }
}
