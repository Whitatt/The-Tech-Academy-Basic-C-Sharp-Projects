using System;
using System.Collections.Generic;
using System.Linq;


    class Program
    {
        static void Main(string[] args)
        {

            //Assignment Part 1
            string[] Cars = { "Pontiac", "Dodge", "GMC", "Ford", "Chevrolet" };

           //opening statement providing user instruction that prints to the console
            Console.WriteLine("Name the country that makes the vehicles \n Pontiac, Dodge, GMC, Ford and Cheverolet");
            string response1 = (Console.ReadLine()); //user data entry

            for (int i = 0; i < Cars.Length; i++) // loop iterates array to # of index positions
           {
                Cars[i] = Cars[i] + response1; //statement that concatenates original array strings and user input
                Console.WriteLine("Result = " + Cars[i]); //Updated array of strings that prints to console
           }
            Console.ReadLine(); // holds open program for next section of code to run

            Console.WriteLine();




    }
}

