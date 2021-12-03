using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LambdaSubmissionAssignment
{
    class Program
    {
        static void Main(string[] args)
        {
            //Here I instantiate a new list of employees.
            List<Employee> employees = new List<Employee>();

            //Here I instantiate employee objects with their properties and add them to the list
            Employee employee1 = new Employee() { FirstName = "Jack", LastName = "Burton", Id = 1 };
            employees.Add(employee1);
            Employee employee2 = new Employee() { FirstName = "Snake", LastName = "Plissken", Id = 2 };
            employees.Add(employee2);
            Employee employee3 = new Employee() { FirstName = "Vincent", LastName = "Vega", Id = 3 };
            employees.Add(employee3);
            Employee employee4 = new Employee() { FirstName = "Jules", LastName = "Winfield", Id = 4 };
            employees.Add(employee4);
            Employee employee5 = new Employee() { FirstName = "Butch", LastName = "Coolidge", Id = 5 };
            employees.Add(employee5);
            Employee employee6 = new Employee() { FirstName = "R.J.", LastName = "Macready", Id = 6 };
            employees.Add(employee6);
            Employee employee7 = new Employee() { FirstName = "Keyser", LastName = "Soze", Id = 7 };
            employees.Add(employee7);
            Employee employee8 = new Employee() { FirstName = "Sarah", LastName = "Conner", Id = 8 };
            employees.Add(employee8);
            Employee employee9 = new Employee() { FirstName = "Imperator", LastName = "Furiosa", Id = 9 };
            employees.Add(employee9);
            Employee employee10 = new Employee() { FirstName = "Clarice", LastName = "Starling", Id = 10 };
            employees.Add(employee10);

            //Here I create a new list for employees named Jack and use a foreach loop to find and add them to the list
            List<Employee> employeesNamedJack1 = new List<Employee>();
            foreach (Employee employee in employees)
            {
                if (employee.FirstName == "Jack")
                {
                    employeesNamedJack1.Add(employee);
                }
            }
            Console.WriteLine("Employees named Jack include:");
            for (int i = 0; i < employeesNamedJack1.Count; i++)
            {
                Console.WriteLine(employeesNamedJack1[i].FirstName + " " + employeesNamedJack1[i].LastName + "\n");
            }

            //Here I create another new list for employees named Jack and use a lambda expression to find and add them to the list
            List<Employee> employeesNamedJack2 = employees.Where(x => x.FirstName == "Jack").ToList();
            Console.WriteLine("Employees named Jack include:");
            for (int j = 0; j < employeesNamedJack2.Count; j++)
            {
                Console.WriteLine(employeesNamedJack2[j].FirstName + " " + employeesNamedJack2[j].LastName + "\n");
            }

            //Here I create a list for newer employees with Ids higher than five and use a lambda epxression to find and add them to the list
            List<Employee> newEmployees = employees.Where(x => x.Id > 5).ToList();
            Console.WriteLine("New employees include: ");
            for (int k = 0; k < newEmployees.Count; k++)
            {
                Console.WriteLine(newEmployees[k].FirstName + " " + newEmployees[k].LastName + "\n");
            }
            Console.ReadLine();
        }
    }
}
