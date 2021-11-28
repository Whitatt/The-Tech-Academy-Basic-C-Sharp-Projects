using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MethodClass
{
    class Class
    {
        // Create method "MyMethod" with two integers as parameters
        public static void MyMethod(int intOne, int intTwo)
        {
            // Multiply first integer by 8
            int result = intOne * 8;
            // Display "result"
            Console.WriteLine($"{intOne} multiplied by 8 = {result}");
            // Display unused integer
            Console.WriteLine("Unused integer: " + intTwo);
            
        }
    }
}