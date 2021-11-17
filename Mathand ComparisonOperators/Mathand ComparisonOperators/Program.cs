using System;

namespace Mathand_ComparisonOperators
{
    class Program
    {
        static void Main(string[] args)
        {
            //int total = 5 + 10;  THIS IS ADDITION
            //int otherTotal = 12 + 22;
            //int combined = total + otherTotal;
            //Console.WriteLine(combined);
            //Console.ReadLine();

            //int difference = 10 - 5; THIS IS SUBTRACTION
            //Console.WriteLine("Ten minus Five = " + difference.ToString());
            //Console.ReadLine();

            //int product = 10 * 5;   THIS IS MULTIPLICATION
            //Console.WriteLine(product);
            //Console.ReadLine();

            //double quotient = 100.0 / 17.0;   THIS IS DIVISION
            //Console.WriteLine(quotient);
            //Console.ReadLine();

            //int remainder = 11 % 2;  THIS PROVIDES A REMAINDER, SO IF WE DIVIDIE 11 by 2, there will be 1 number left.
            //Console.WriteLine(remainder);
            //Console.ReadLine();

            //bool trueOrFalse = 12 < 5;
            //Console.WriteLine(trueOrFalse.ToString());
            //Console.ReadLine();

            //int roomTemperature = 70;
            //int currentTemperature = 70;
            ////bool isWarm = currentTemperature <= roomTemperature;
            //bool isWarm = currentTemperature != roomTemperature;

            //Console.WriteLine(isWarm);
            //Console.ReadLine();

            Console.WriteLine("Anonymous Income Comparison Program");
            Console.ReadLine();

            Console.WriteLine("Person1");
            Console.ReadLine();
            Console.WriteLine("Hourly Rate");
            int hourlyRate = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Hours worked per week?");
            int hoursWorked = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Person2");
            Console.ReadLine();
            Console.WriteLine("Hourly Rate");
            Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Hours worked per week?");
            Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Annual salary of Person1:");
            Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Annual salary of Person2:");
            Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Does Person 1 make more money than Person 2?");
            bool trueOrFalse = 31200 < 41600;
            Console.WriteLine(trueOrFalse.ToString());
            Console.ReadLine();















        }
    }
}
