using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MathematicalOperations
{
    class Program
    {
        static void Main(string[] args)
        {
            int result = 25 + 5;
            Console.WriteLine(result);

            Console.WriteLine("Result = " + (20 + 5));
            Console.WriteLine(20 + 5*5); //operator precedence 
            Console.WriteLine((20 + 5)*5); //operator precedence 

            Console.ReadLine();
        }
    }
}
