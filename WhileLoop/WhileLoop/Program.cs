using System;

namespace WhileLoop
{
    class Program
    {
        static void Main(string[] args)
        {
            int count = 1;
            while (count <= 4)
            {
                Console.WriteLine("The value of i is : " + count);
                count = count + 1;
            }
            Console.ReadKey();
        

        }
    }
}
