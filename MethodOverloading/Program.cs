using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MethodOverloading
{
    internal class Program
    {
        static int Add(int numOne, int numTwo)
        {
            return numOne + numTwo;
        }

        static decimal Add(decimal numOne, decimal numTwo)
        {
            return numOne + numTwo;
        }

        static string Add(decimal numOne, decimal numTwo, bool isTrue)
        {
            if(isTrue == true && (numOne+numTwo == 1))
            {
                return $"{numOne + numTwo} dollar.";
            }
            else if (isTrue = true && (numOne+numTwo != 1))
            {
                return $"{numOne + numTwo} dollars.";
            }
            else
            {
                return "Sorry, not true!";
            }
        }


        static void Main(string[] args)
        {
            Console.WriteLine(Add(0, 1));
            Console.WriteLine(Add(1, 2));
            Console.WriteLine(Add(2.3m, 3.5m));
            Console.WriteLine(Add(0, 1, true));
            Console.WriteLine(Add(0, 1, false));
        }
    }
}
