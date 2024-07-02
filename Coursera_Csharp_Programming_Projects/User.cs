using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http.Headers;
using System.Text;
using System.Threading.Tasks;

namespace Coursera_Csharp_Programming_Projects
{
    internal class User
    {
        private string name;
        private string companyName;
        private int age;
        private string City {  get; set; }  
        public User()
        {
            companyName = "ABC";
        }
        public string Name 
        {
            get { return name; }
            set {  name = value; }
        }
        public string CompanyName
        {
            get { return companyName; }
        }

        public int Age
        {
            get { return age; }
            //set { age = value; }
            set
            {
                if (value < 18)
                    throw new ArithmeticException("Invalid Age");
                age = value;
            }
        }
    }
}
