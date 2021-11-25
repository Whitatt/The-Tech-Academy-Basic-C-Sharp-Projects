using System;
using System.Collections.Generic;

namespace ConsoleAppAssignment
{
    class Program
    {
        static void Main(string[] args)
        {   //Assignment Part 1
            string[] Cars = { "Porsche", "Cadillac", "Toyota", "Ford", "Chevrolet" };

            //opening statement providing user instruction that prints to the console
            Console.WriteLine("Name one country that makes the vehicles above listed?");
            string response1 = (Console.ReadLine()); //user data entry

            for (int i = 0; < Cars.Length; i++) // loop iterates array to # of index positions
            {
                Cars[i] = Cars[i] + response1; //statement that concatenates original array strings and user input
                Console.WriteLine("Result = " + Cars[i]); //Updated array of strings that prints to console
            }
            Console.ReadLine(); // holds open program for next section of code to run

            Console.WriteLine();



            
        }
    }
}
