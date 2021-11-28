using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CallingMethodsAssignment
{
    public class Users
    {
        public int GetAdd(int data)  //method 1: adds 10 to user integer data entry
        {
            return data + 10;  //method operation (addition)
        }
        public int GetSubtract(int data)  //method 2: subtracts 10 from user integer data entry
        {
            return data - 10;  //method operation (subtraction)
        }
        public int GetMultiply(int data)  //method 3: multiplies user integer data entry by 10
        {
            return data * 10;  //method operation (multiplication)
        }
        public int GetDivide(int data)  //method 4: divides user integer data entry by 10
        {
            return data / 10;  //method operation (division)
        }
    }
}