using System;

namespace BooleanLogic
{
    class Program
    {
        static void Main(string[] args)
        {
            //Console.WriteLine(true && false); AND OPERATOR
            //Console.WriteLine(true && true);
            //Console.WriteLine(false && false);

            //Console.WriteLine(true || true); OR OPERATOR
            //Console.WriteLine(true || false);
            //Console.WriteLine(false || false);

            //Console.WriteLine(true == true); EQUAL OPERATOR
            //Console.WriteLine(true == false);
            //Console.WriteLine(false == false);

            //Console.WriteLine(true != true); DOES NOT EQUAL OPERATOR
            //Console.WriteLine(true != false);
            //Console.WriteLine(false != false);

            //Console.WriteLine(true ^ true); X OR OPERATOR The result of x ^ y is true if x evaluates to true and y evaluates to false, or x evaluates to false and y evaluates to true.
            //Console.WriteLine(true ^ false);
            //Console.WriteLine(false ^ false);

            Console.WriteLine("What is your age?");
            int ageNumber = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Have you ever had a DUI? Please answer \"true\" or \"false\"");
            bool DUI = Convert.ToBoolean(Console.ReadLine());
            Console.WriteLine("How many speeding tickets do you have?");
            int speedingTickets = Convert.ToInt32(Console.ReadLine());
            bool mustQualify = (ageNumber > 15 && DUI == false && speedingTickets <= 3);//this will determine the age number is greater than 15 and they no dui's and their speeding tickets is less than or qual to 3
            Console.WriteLine("Qualified?");
            Console.WriteLine(mustQualify);//they will qualify if they meet the above stats
            Console.ReadLine(); 
            
            





        }
    }
}
