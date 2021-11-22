using System;

namespace Branching
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome to Package Express. Please follow the instructions below");
            Console.ReadLine();
            Console.WriteLine("Please enter the package weight");
            int packWeight = Convert.ToInt32(Console.ReadLine());

            if (packWeight > 50)//Determines packweight less than 50
            {
                Console.WriteLine("Package too heavy to be shipped via Package Express. Have a good day");//displays outcome if weight less than 50 or over 50
            }
            else
            {

                Console.WriteLine("Please enter the package width:");
                int packWidth = Convert.ToInt32(Console.ReadLine());

                Console.WriteLine("Please enter the package height:");
                int packHeight = Convert.ToInt32(Console.ReadLine());

                Console.WriteLine("Please enter the package length");
                int packLength = Convert.ToInt32(Console.ReadLine());

                if (packWidth + packHeight + packLength > 50)//adding variables width height length
                {
                    Console.WriteLine("Package too heavy to be shipped via Package Express. Have a good day");//output if package greater than 50
                }
                else
                {
                    
                    decimal quote = Convert.ToDecimal((packWidth * packHeight * packLength * packWeight) / 100);//multiplies width length height and divides by 100
                    Console.WriteLine($"Your estimated total for shipping this package is ${quote}.00");//curly brackets provide total above multiplication and division
                    Console.WriteLine("Thank you!");
                    Console.ReadLine();
                }

                
            }

           

















            //Console.WriteLine("What is your favorite number?");
            //int favNum = Convert.ToInt32(Console.ReadLine());

            //string result = favNum == 12 ? "You have an awesome favorite number" : "You do not have an awesome favorite number";

            //Console.WriteLine(result);
            //Console.ReadLine();
            //int roomTemperature = 70;

            //Console.WriteLine("Hi, what is your name?");
            //string name = Console.ReadLine();

            //Console.WriteLine("Hi, " + name + ", what is the temperature where you are?");
            //int currentTemperature = Convert.ToInt32(Console.ReadLine());

            //if (currentTemperature == roomTemperature)
            //{
            //    Console.WriteLine("It is exactly room temperature.");
            //}
            //else if (currentTemperature > roomTemperature)
            //{
            //    Console.WriteLine("It is warmer than room temperature.");
            //}
            //else if (roomTemperature > currentTemperature)
            //{
            //    Console.WriteLine("It is colder than room temperature.");
            //}
            //else
            //{
            //    Console.WriteLine("Uhhhhhh.....something went wrong.");
            //}
            //Console.ReadLine();




            //int currentTemperature = 80;
            //int roomTemperature = 70;

            //string comparisonResult = currentTemperature == roomTemperature ? "It is room temp." : "It is not room temp.";

            //Console.WriteLine(comparisonResult);
            //Console.ReadLine();
            
            //if (currentTemperature == roomTemperature)
            //{
            //    Console.WriteLine("It is exactly room Temperature.");
            //}
            //else if (currentTemperature > roomTemperature)
            //{
            //    Console.WriteLine("It is warmer than room temperature.");
            //}
            //else if (roomTemperature > currentTemperature)
            //{
            //    Console.WriteLine("Room Temperature is warmer than current Temperature");
            //}
            //else
            //{
            //    Console.WriteLine("It is not exactly room temperature.");
            //}
            Console.ReadLine();
        }
    }
}
