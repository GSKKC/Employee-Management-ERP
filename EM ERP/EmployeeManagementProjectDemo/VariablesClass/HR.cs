using System;
using System.Collections.Generic;
using System.Text;

namespace EmployeeManagementProjectDemo
{
   public  class HR
    {
        public List<EmployeeDetails> EmployeeList { get; set; }
        public List<TL> TLList { get; set; }
        public HR()
        {
            //Contructor to instantiate members
            EmployeeList = new List<EmployeeDetails>();
            TLList = new List<TL>();
        }

    }
}
