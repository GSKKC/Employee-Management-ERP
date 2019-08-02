using System;
using System.Collections.Generic;
using System.Text;

namespace EmployeeManagementProjectDemo
{
     
   
  
    public class DataSetUp 
    {
        
       
        protected void TLData(HR hrc)
    {
        hrc.TLList.Add(new TL
        {
            Name = "Ashwani"
        });
        hrc.TLList.Add(new TL
        {
            Name = "Harshwantu"
        });
    }
        protected void EnployeeData(HR hrc)
        {
            hrc.EmployeeList.Add(new EmployeeDetails
            {
                FirstName = "Krishna",
                LastName = "Gupta",
                Age = 21,
                Address = "Kurla",
                Salary = 19916
            });
            hrc.EmployeeList.Add(new EmployeeDetails
            {
                FirstName = "Giridhar",
                LastName = "Chaitter",
                Age = 22,
                Address = "Dombivali",
                Salary = 19916
            });

            hrc.EmployeeList.Add(new EmployeeDetails
            {
                FirstName = "Pooja",
                LastName = "Gupta",
                Age = 21,
                Address = "Dombivali",
                Salary = 19916
            });

            hrc.EmployeeList.Add(new EmployeeDetails
            {
                FirstName = "Shivaji",
                LastName = "Balerao",
                Age = 24,
                Address = "Pune",
                Salary = 19916
            });

            hrc.EmployeeList.Add(new EmployeeDetails
            {
                FirstName = "Shailesh",
                LastName = "NA",
                Age = 24,
                Address = "Khargahr",
                Salary = 19916
            });

            hrc.EmployeeList.Add(new EmployeeDetails
            {
                FirstName = "Yogesh",
                LastName = "NA",
                Age = 24,
                Address = "Thane",
                Salary = 19916
            });

            hrc.EmployeeList.Add(new EmployeeDetails
            {
                FirstName = "Neelam",
                LastName = "Jain",
                Age = 23,
                Address = "Thane",
                Salary = 19916
            });

            hrc.EmployeeList.Add(new EmployeeDetails
            {
                FirstName = "Abdul",
                LastName = "Raheman",
                Age = 24,
                Address = "NA",
                Salary = 19916
            });

            hrc.EmployeeList.Add(new EmployeeDetails
            {
                FirstName = "Chetan",
                LastName = "NA",
                Age = 23,
                Address = "Thane",
                Salary = 19916
            });

            hrc.EmployeeList.Add(new EmployeeDetails
            {
                FirstName = "Davis",
                LastName = "NA",
                Age = 24,
                Address = "Thane",
                Salary = 19916
            });

            hrc.EmployeeList.Add(new EmployeeDetails
            {
                FirstName = "Mahesh",
                LastName = "NA",
                Age = 22,
                Address = "NA",
                Salary = 19916
            });

            hrc.EmployeeList.Add(new EmployeeDetails
            {
                FirstName = "Umair",
                LastName = "Shaikh",
                Age = 25,
                Address = "Western me kider to",
                Salary = 19916
            });



        }
    }   


    //Inheritance & abstraction
   public  class SuccessfullDataSetUp : DataSetUp
    {
      public void SuccessfullSetUpData(HR hrc)
        {
            SuccessfullDataSetUp successfullDataSetUpc = new SuccessfullDataSetUp();
            successfullDataSetUpc.TLData(hrc);
            successfullDataSetUpc.EnployeeData(hrc);
            
        }

    }

}
    

