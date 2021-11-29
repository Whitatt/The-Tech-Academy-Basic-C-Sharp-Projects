using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassSubmissionAssignment
{
    public class Math
    {
        // Method ouputs an integer
        public void MyMethod(int num, out int result)
        {
            result = num / 2;
        }

        // Method with output parameters
        public void MetOut(out int output1, out int output2)
        {
            output1 = 40;
            output2 = 15;
        }

        // Overloaded method
        public int MetOverload(int a, int b)
        {
            return a + b;
        }
        public int MetOverload(int a, int b, int c)
        {
            return a + b + c;
        }
    }
}
