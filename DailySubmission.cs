﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DailyReport
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("The Tech Academy");
            Console.ReadLine();
            Console.WriteLine("Student Daily Report");
            Console.ReadLine();
            Console.WriteLine("What is your name?");
            string yourName = Console.ReadLine();
            Console.WriteLine("What course are you on?");
            string yourCourse = Console.ReadLine();
            Console.WriteLine("What page number?");
            int pageNumber = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Do you need help with anything else?");
            bool needHelpYes = true;
            bool needHelpNo = false;
            Console.WriteLine(needHelpYes);
            Console.WriteLine(needHelpNo);
            Console.ReadLine();
            Console.WriteLine("Is there any other feedback you'd like to Provide? Please be specific.");
            Console.ReadLine();
            Console.WriteLine("How many hours did you study today?");
            int hoursStudied = Convert.ToInt32(Console.ReadLine());


            
        }
    }
}
