using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Method
{
    class Class
    {
        // Method math operation. If no user input for second #, the default value is 3
        public static int Method(int x, int y = 3)
        {
            int result = x * y;

            return result;
        }
    }
}