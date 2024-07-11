using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InOutParamsTemp
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int myNumber;
            Console.WriteLine("Enter a number");
            if(int.TryParse(Console.ReadLine(), out myNumber))
                //here tryparse is used for conversion of a string represenattion of a number.
                // it is useful if there are more lines of code,it is hectic task to try and solve the  
                //exception everytime,the tryparse method runs everything at once.
                //

                Console.WriteLine("Conversion successful" +myNumber);
            //it does not terminate the execution of the program
            
            else
            {
                //here we have mentioned if anything fails what it will print.

                Console.WriteLine("try again");
                Console.WriteLine("Thank you!");
                
            }
        }
        static bool Addition(in int n1, in int n2, out int sum)
        {
            
            sum = n1 + n2;
            if (sum > 50)
                return true;
            return false;
        }

    }
}
