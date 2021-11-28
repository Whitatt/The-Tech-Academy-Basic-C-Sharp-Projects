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
        public static int MathMethod(int userNumber)
        {
            int result = userNumber + 7;

            return result;
        }

        // Multiply the user's decimal by an integer and return an integer as the answer
        public static int MathMethod(decimal userInput)
        {
            int result = (int)userInput * 8;

            return result;
        }

        // Multiplies the user's input by an integer
        public static int MathMethod(string userString)
        {
            int result = Convert.ToInt32(userString);

            return result * 10;
        }
    }
}