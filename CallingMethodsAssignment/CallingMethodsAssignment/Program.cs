using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CallingMethodsAssignment
{
    class Program
    {
        public static int Data { get; set; }
        static void Main(string[] args)
        {
            //program header
            Console.WriteLine("Add, Subtract, Multiply, Divide");

            //instructions to user to enter # to perform math operations
            Console.WriteLine("Please enter a number!: ");
            String userEntry = Console.ReadLine(); //reads user entry
            Data = Convert.ToInt32(userEntry); //bool to string

            var userObject1 = new Users(); //instatiates new variable userObject1
            var result1 = userObject1.GetAdd(Data); //calls method get add

            var userObject2 = new Users(); //instatiates new variable userObject2
            var result2 = userObject2.GetSubtract(Data); //calls method get subtract

            var userObject3 = new Users(); //instatiates new variable userObject3
            var result3 = userObject3.GetMultiply(Data); //calls method get multiply

            var userObject4 = new Users(); //instatiates new variable userObject4
            var result4 = userObject4.GetDivide(Data); //calls method get divide

            Console.WriteLine("Your number plus 10 equals " + result1);  //Writes result1 to console
            Console.WriteLine("Your number minus 10 equals " + result2);  //Writes result2 to console
            Console.WriteLine("Your number multiplied by 10 equals " + result3);  //Writes result3 to console
            Console.WriteLine("Your number divided by 10 equals " + result4);  //Writes result4 to console

            Console.ReadLine();


        }
    }
}
