
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Method_Class
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Please enter an integer: ");
            // Get first # from user
            int intOne = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Please enter a second integer: ");
            // Get second # from user
            int intTwo = Convert.ToInt32(Console.ReadLine());

            // Call method "MyMethod" to display results of user input
            Class.MyMethod(intOne: intOne, intTwo: intTwo);

            Console.ReadLine();
        }
    }
}