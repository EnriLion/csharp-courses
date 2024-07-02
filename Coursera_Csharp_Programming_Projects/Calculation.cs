using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Coursera_Csharp_Programming_Projects
{
    internal class Calculation
    {
        public void calculateAnother()
        {
            /*            int result = num1 / num2;
                        Console.WriteLine(result);
            */
            int num1, num2,result = 0;
            try
            {
                /*                int result = num1 / num2;
                                Console.WriteLine(result);
                */
                Console.Write("Enter Number One:");
                num1 = int.Parse(Console.ReadLine());
                Console.Write("Enter Number Two:");
                num2 = int.Parse(Console.ReadLine());
                result =  num1/num2;
            }
/*            catch(Exception ex)
            {
                Console.Write("Exception Occurred");
                Console.Write(ex.Message);
            }
*/            catch(DivideByZeroException ex)
            {
                Console.Write("Exception Occurred");
                Console.Write(ex.Message);
            }
            catch(FormatException ex)
            {
                Console.Write("Exception Occurred");
                Console.Write(ex.Message);
            }
            catch(Exception ex)
            {
                Console.Write("Exception Occurred");
                Console.Write(ex.Message);
            }
            finally
            {
                Console.Write("I will always executed");
                Console.Write(result);
            }
        }
    }
}
