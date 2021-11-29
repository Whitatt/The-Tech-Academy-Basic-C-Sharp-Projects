using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassSubmissionAssignment
{
    class Program
    {
        static void Main(string[] args)
        {
            // Instantiate class
            Math math = new Math();

            // Get number from user
            Console.WriteLine("Please enter a number:");
            int num = Convert.ToInt32(Console.ReadLine());

            // Create integer variable to display method output
            int a;
            math.MyMethod(num, out a);
            Console.WriteLine(num + " / 2 = " + a);
            Console.WriteLine();


            // Create variable for method with output parameters
            int z;
            int y;
            math.MetOut(out z, out y);
            Console.WriteLine("Method with output parameters: " + z + " & " + y);
            Console.WriteLine();


            // Call and display overloaded method
            int overload1 = math.MetOverload(8, 12);
            int overload2 = math.MetOverload(6, 13, 17);
            Console.WriteLine("First overload method:\n8 + 12 = " + overload1);
            Console.WriteLine();
            Console.WriteLine("Second overload method:\n8 + 13 + 17 = " + overload2);
            Console.WriteLine();


            // Call static class
            Console.WriteLine("This is a static class:\n7 * 7 = " + Static.Product(7, 7));

            Console.ReadLine();
        }
    }
}