using System;
using System.Collections.Generic;
using System.Text;

namespace EmployeeManagementProjectDemo
{
   public  class TL
    {
        public string Name { get; set; }
        public List<EmployeeDetails> MyEmployeeList { get; set; }

        public TL()
        {
            MyEmployeeList = new List<EmployeeDetails>();
           
        }
    }
}
