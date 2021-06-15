using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EmployeeRec.Hr
{
    public class Employee // Declaration of class Employee
    {
        private readonly int _staffId;
        private string _jobTitle;
        private readonly string _fullName;
        private readonly string _employeeDate;
        private string _department;


        // Contructing a Contructor Employee
        public Employee(int staffId, string jobTitle, string fullName, string employeeDate, string department)

        {
            _staffId = staffId;
            _jobTitle = jobTitle;
            _fullName = fullName;
            _employeeDate = employeeDate;
            _department = department;

        }

        public int StaffId
        {
            get => _staffId; // Getting a value readonly
        }

        public string JobTitle
        {
            get => _jobTitle;
        
       
             set 
            {
                _jobTitle = value;
            }
        }
        public string Name
        {
            get => _fullName; // Getting a value readonly
        }

        public string EmployeeDate

        // This get accessor users the explicit syntyax, rather than a short form
        {
            get => _employeeDate;   
        }

        public string Department
        {
            get => _department;

            set
            {
                _department = value;
            }


        }


        public void ClockIn() 
        {
            Console.WriteLine("Employee ClockIn Time is : '8:00AM'");
            
        }
        
         
        
        public void ClockOut() 
        {
            Console.WriteLine("Employee ClockOut Time is : '5:00PM'");
        }

        public void Work() 
        {
            Console.WriteLine("Employee work for a Full Day ! '");
        }
        
        
          
       
     
        
    }
}
