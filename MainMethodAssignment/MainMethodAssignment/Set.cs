using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MainMethodAssignment
{
    class Set
    {
        // Add the user's integer to another integer
        public static int Addition(int userNumber, int y)
        {
            int result = userNumber + y;

            return result;
        }

        // Multiply the user's decimal by an integer and return an integer as the answer
        public static decimal Multiply(decimal userInput, int y)
        {
            int result = (int)userInput * y;

            return result;
        }

        // Multiplies the user's input by an integer
        public static double Multi(int userString, int y)
        {
            int result = userString * y;

            return result;
        }
    }
}