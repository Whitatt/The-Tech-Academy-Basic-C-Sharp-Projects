using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Method
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Please enter a number: ");
            // Get the first # from user input
            int userInt = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("(Optional)Please enter another number: ");
            // Get the second optional # from user input
            string userInt2 = Console.ReadLine();

            // if/else statement for whether the user inputs the optional #. If no # is
            // given then the method uses the default value of 5 to multiply the first #.
            // If a second # is given then the product of the user's numbers is displayed
            if (userInt2 != "")
            {
                int x = Convert.ToInt32(userInt2);
                Console.WriteLine(Class.Method(x, userInt));
                Console.ReadLine();
            }
            else
            {
                Console.WriteLine(Class.Method(userInt));
                Console.ReadLine();
            }
        }
    }
}