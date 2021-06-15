using EmployeeRec.Hr;
using System;

namespace EmployeeRec
{
    class program
    {


        static void Main(string[] args)

        {


            // Creating 5 employees
            Employee firstEmployee = new Employee(101, "Tunde Badmus", "Accountant", "06/06/2021", "Account Department");
            Employee secondEmployee = new Employee(102, "Phillip Newman", "Account Clerk", "06/06/2021", "Accoun Department");
            Employee thirdEmployee = new Employee(103, "John Doe", "CFO", "01/01/2021", "Account Department,");
            Employee forthEmployee = new Employee(104, "Betty Sandy", "IT Student", "06/05/2021", "Information Technology");
            Employee fifthEmployee = new Employee(105, "Samuel Stone", "IT Admin", "05/02/2021", "Information Technology");


            // Give each employee a different job title.

            firstEmployee.JobTitle = "Accountant";
            secondEmployee.JobTitle = "Account Clerk";
            thirdEmployee.JobTitle = "CFO";
            forthEmployee.JobTitle = "IT Student";
            fifthEmployee.JobTitle = "IT Admin";

            // Assign 3 employee the same department, and the other 2 a differnt department.

            firstEmployee.JobTitle = "Account Department";
            secondEmployee.JobTitle = "Account Department";
            thirdEmployee.JobTitle = "Account Department";
            forthEmployee.JobTitle = "Information Technology";
            fifthEmployee.JobTitle = "Information Technology";

            // Store all 5 employees in an array of type Employee


            Employee[] Employees = new Employee[5]
            {
                new Employee(101, "Tunde Badmus", "Accountant", "06/06/2021", "Account Department"),
                new Employee(102, "Phillip Newman", "Account Clerk", "06/06/2021", "Accoun Department"),
                new Employee(103, "John Doe", "CFO", "01/01/2021", "Account Department,"),
                new Employee(104, "Betty Sandy", "IT Student", "06/05/2021", "Information Technology"),
                new Employee(105, "Samuel Stone", "IT Admin", "05/02/2021", "Information Technology"),

            };

            Console.WriteLine("Employee Record");
            Console.WriteLine("---------------------------");

            foreach (Employee Employee in Employees)
            {

                Console.WriteLine("SaffId: {0}", Employee.StaffId);
                Console.WriteLine("FullName:  {0}", Employee.Name);
                Console.WriteLine("JobTitle:     {0}", Employee.JobTitle);
                Console.WriteLine("EmployeeDate: {0}", Employee.EmployeeDate);
                Console.WriteLine("Department: {0}", Employee.Department);
                Employee.ClockIn();
                Employee.ClockOut();
                Employee.Work();
                Console.WriteLine("---------------------------\n");
               

                
            }



            

        }
    }
}
    

