using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PolymorphismAssignment
{
    public class Employee : Person, IQuittable
    {
        public void Quit()
        {
            Console.WriteLine("An employee is no longer with us");
        }
    }
}