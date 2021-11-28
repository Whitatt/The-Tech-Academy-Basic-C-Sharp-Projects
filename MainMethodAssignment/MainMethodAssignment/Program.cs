using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MainMethodAssignment
{
    class Program
    {
        static void Main(string[] args)
        {
            // retrieve # from user and call method addition
            Console.WriteLine("Please enter a number to add to 7:");
            int userNumber = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine(Set.Addition(userNumber, 7));

            //retrieve # from user and call method multiply
            Console.WriteLine("Please enter a decimal number to be multiplied by 8:");
            decimal userInput = Convert.ToDecimal(Console.ReadLine());
            Console.WriteLine(Set.Multiply(userInput, 8));

            //retrieve # from user and call method multi
            Console.WriteLine("Please enter a number to be multiplied by 10:");
            String userString = Console.ReadLine();
            int dub = Convert.ToInt32(userString);
            Console.WriteLine(Set.Multi(dub, 10));
            Console.ReadLine();
        }
    }
}
