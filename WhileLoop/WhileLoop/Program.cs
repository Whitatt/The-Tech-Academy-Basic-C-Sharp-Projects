using System;

namespace WhileLoop
{
    class Program
    {
        static void Main(string[] args)
        {
            {
                int i = 1;
                while (i <= 4)
                {
                    Console.WriteLine("i value: {0}", i);
                    i++;
                }
                Console.WriteLine("Press Enter Key to Exit..");
                Console.ReadLine();
            }   //executing statement within while loop by checking the condition (i <= 4) and
                //increasing the variable i (i++)
                //value to 1 by using the increment operator.


        }
    }
}
