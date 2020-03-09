using System;
using System.Collections.Generic;

namespace classes
{
    class Company
    {

        // Some readonly properties (let's talk about gets, baby)
        public string Name { get; set; }
        public DateTime CreatedOn { get; }

        // Create a public property for holding a list of current employees

        public List<Employee> Employees = new List<Employee>();

        /*
            Create a constructor method that accepts two arguments:
                1. The name of the company
                2. The date it was created

            The constructor will set the value of the public properties
        */

        public Company(string _name, DateTime _dateCreated)
        {
            _name = Name;
            _dateCreated = CreatedOn;
        }

        public void ListEmployees()
        {
            foreach (Employee employee in Employees)
            {
                Console.WriteLine($"{employee.firstName} {employee.lastName} works for since {employee.startDate}");
            }
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            // Create an instance of a company. Name it whatever you like.

            Company C37Thugs = new Company("C37Thugs", DateTime.Today);

            // Create three employees

            Employee Bubba = new Employee()
            {
                firstName = "Bubba",
                lastName = "Buddha",
                title = "Religious Prophet",
                startDate = DateTime.Now
            };


            Employee Waldo = new Employee()
            {
                firstName = "Wherez",
                lastName = "Waldo",
                title = "Hide and Seek Expert",
                startDate = DateTime.Now
            };


            Employee Billy = new Employee()
            {
                firstName = "Billy",
                lastName = "The Kid",
                title = "Outlaw",
                startDate = DateTime.Now
            };

            // Assign the employees to the company

            C37Thugs.Employees.Add(Bubba);
            C37Thugs.Employees.Add(Waldo);
            C37Thugs.Employees.Add(Billy);

            /*
                Iterate the company's employee list and generate the
                simple report shown above
            */

            C37Thugs.ListEmployees();


        }
    }
}
