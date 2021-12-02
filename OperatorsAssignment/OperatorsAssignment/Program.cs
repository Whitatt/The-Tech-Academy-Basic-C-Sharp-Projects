using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OperatorsAssignment
{
    class Program
    {
        static void Main(string[] args)
        {
            Employee employee1 = new Employee(); //Creates object for employee1
            employee1.EmployeeID = 0541; //Assigns a value to EmployeeId
            employee1.EmployeeName = "Jack Burton"; //Assigns a value to EmployeeName
            string emp1 = employee1.EmployeeID + " " + employee1.EmployeeName; //Concatenates ID and Name
            Console.WriteLine(emp1); //Writes the above concatenated string to console
            Console.ReadLine();  //Holds open console for next section of code to run

            Employee employee2 = new Employee();  //Creates object for employee2
            employee2.EmployeeID = 9254;  //Assigns a value to EmployeeID
            employee2.EmployeeName = "Snake Plissken"; //Assigns a value to EmployeeName
            string emp2 = employee2.EmployeeID + " " + employee2.EmployeeName; //Concatenates ID and Name
            Console.WriteLine(emp2); //Writes the above concatenated string to console
            Console.ReadLine(); //Holds open console for next section of code to run 

            //QC check #1 to ensure method overloading (True)
            Console.WriteLine(employee1.EmployeeID == employee2.EmployeeID); //Writes comparison result to console 
            Console.ReadLine(); //Holds open console for next section of code to run 

            //QC check #2 to ensure method overloading (False)
            Console.WriteLine(employee1.EmployeeID != employee2.EmployeeID); //Writes comparison result to console 
            Console.ReadLine(); //Holds open console for user to either hit Return or Exit console

        }
    }
}