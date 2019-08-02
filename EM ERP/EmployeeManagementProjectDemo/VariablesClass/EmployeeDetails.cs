using System;
using System.Collections.Generic;
using System.Text;

namespace EmployeeManagementProjectDemo
{
    public class EmployeeDetails
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public int Age { get; set; }
        public string Address { get; set; }
        public double Salary { get; set; }
        public string Designation { get; set; }
        public bool UnderTrainingStatus { get; set; }
        public EmployeeDetails()
        {
            //By default me it true 
            Designation = "Software Engineer";
            UnderTrainingStatus = true;
        }
    }

}
