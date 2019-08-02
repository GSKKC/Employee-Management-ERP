using System;
using System.Threading;

namespace EmployeeManagementProjectDemo
{
    class Program : IIntroduction
    {
        private static HR hrc = new HR();
        private static TL tlc = new TL();
       static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");

            //Implementing Interface
            Program programc = new Program();
            programc.Introduction();

            //Implementing Inheritance
            SuccessfullSetUpData();
            PrintEmployeeList();
            //HR updates data
            HRUpdateTrainingStatus();
            //Print Updated EmployeList
            PrintUpdatedEmployeeList();
            //now HR allocate Employees to TLs
            HRAllocateEmployees();
            // Generate report
            ReportGeneration();
        }

        public void Introduction()
        {
            Console.Write(@"





     ========== WELCOME TO EMPLOYEE MANAGEMENT PROGRAM DEMO SOLN ============
                                                    




                               ");
            Thread.Sleep(3000);

            for (int i = 0; i <= 100; i++)
            {


                Console.Clear();
               

                Console.Write(@"




 ========== WELCOME TO EMPLOYEE MANAGEMENT PROGRAM DEMO SOLN ============
                                                    




                               Loading: {0}%", i); Thread.Sleep(50);
                Console.WriteLine();
                if(i==100)
                {
                    Thread.Sleep(200);
                }
            }
            Console.Clear();
        }


        private static bool SetUpData()
        {
            Console.Write("\n\tLoading Data"); Thread.Sleep(2000);
            Console.Write(". ");Thread.Sleep(2000);
            Console.Write(". "); Thread.Sleep(2000);
            Console.Write(". \n"); Thread.Sleep(2000);

            //Interface class call
            SuccessfullDataSetUp successfullDataSetUpc = new SuccessfullDataSetUp();
            successfullDataSetUpc.SuccessfullSetUpData(hrc);
            
          
            return true;

            //Here i wanted to Implement Try Catch but its not part of our training so avoided
            /*try{
             *  SetupTLData();
            SetUpEmployeeData();
            }
            catch(Exception ex)
            {
            Console.WriteLine(ex);
            return false;
            }
            finallyy{}
            return true;

             
            */
        }

      
        private static void SuccessfullSetUpData()
        {
           
            bool status = SetUpData();
            if (status)
            {
                Console.WriteLine("\nSuccessfully Loaded Data");
            }
            //only if try-catch was implemented
            /* else{Console.Write("Error Occured can't load Data\n");
             * }*/
        }
        private static void PrintEmployeeList()
        {
            foreach (var item in hrc.EmployeeList)
            {
                if (item == null)
                {
                    continue;
                }
                Console.WriteLine($"\nFirst Name: {item.FirstName}\n" +
                    $"Last Name: {item.LastName}\n" +
                    $"Address: {item.Address}\n" +
                    $"Age: {item.Age}\n" +
                    $"Salary: {item.Salary}\n" +
                    $"Designation: {item.Designation}\n" +
                    $"Under Training: {item.UnderTrainingStatus}\n" +
                    $"========================================================");
            }
        }
        private static void HRUpdateTrainingStatus()
        {
            Console.WriteLine("\n\nTraining Completed Now Updating Every Employees Traning Status");Thread.Sleep(3000);
            foreach (var item in hrc.EmployeeList)
            {
                if (item == null)
                {
                    continue;
                }
                item.UnderTrainingStatus = false;
            }
        }
        private static void PrintUpdatedEmployeeList()
        {

            foreach (var item in hrc.EmployeeList)
            {
                if (item == null)
                {
                    continue;
                }
                Console.WriteLine($"\nFirst Name: {item.FirstName}\n" +
                    $"Last Name: {item.LastName}\n" +
                    $"Address: {item.Address}\n" +
                    $"Age: {item.Age}\n" +
                    $"Salary: {item.Salary}\n" +
                    $"Designation: {item.Designation}\n" +
                    $"Under Training: {item.UnderTrainingStatus}\n" +
                    $"========================================================");
            }
        }
        private static void HRAllocateEmployees()
        {

            while (true)
            {
                Console.WriteLine("\n=========Menu Driven Program===========\n");
                Console.WriteLine("Select Operation\n");
                Console.WriteLine("1. Randomly Assign Employee To TL's\n2. Hold on Let me Decide\n3. Donot Want to Assign they are not ready yet\n");
                int choice = Convert.ToInt32((Console.ReadLine()));

                switch (choice)
                {
                    case 1: RandomlyAssignEmployee(); return;
                    case 2: HRMandar(); return;
                    case 3: return;
                    default: Console.WriteLine("Invalid choice\nTry again..........\n"); break;

                }
            }


        }
        private static void HRMandar()
        {
            
            int assign;
            bool status;
            Console.WriteLine("List of Employees just Completed their Training\n");
            Console.WriteLine("To Assign Empoyee\n Press 1 to Ashwani or Press 2 to Harshwantu");
            foreach (var item in hrc.EmployeeList)
            {
                if (item == null)
                {
                    continue;
                }
                Console.WriteLine($"\n : {item.FirstName} {item.LastName}\n");
                status = true;
                do
                {
                    assign = Convert.ToInt32(Console.ReadLine());
                    if (assign == 1)
                    {
                        hrc.TLList[assign - 1].MyEmployeeList.Add(item);
                    }
                    else if (assign == 2)
                    {
                        hrc.TLList[assign - 1].MyEmployeeList.Add(item);
                    }
                    else
                    {
                        status = false;
                        Console.WriteLine("Invaid Entry\n");

                    }
                } while (!status);
            }
           
        }
        private static void RandomlyAssignEmployee()
        {
            Random randomc = new Random();
            int radomTL;
            Console.WriteLine("Done!!\n");


            foreach (var item in hrc.EmployeeList)
            {
                radomTL = randomc.Next(0, 2);

                if (hrc.TLList[radomTL] == null || item == null)
                {
                    continue;
                }

                if (hrc.TLList[radomTL].Name.Contains("Ashwani", StringComparison.OrdinalIgnoreCase))
                {
                    hrc.TLList[radomTL].MyEmployeeList.Add(item);
                }
                if (hrc.TLList[radomTL].Name.Contains("Harshwantu", StringComparison.OrdinalIgnoreCase))
                {
                    hrc.TLList[radomTL].MyEmployeeList.Add(item);
                }
                //Console.WriteLine("");
                //Console.WriteLine(hrc.TLList[radomTL].Name + " " + item.FirstName + " \n" + item.LastName + "\n============");

            }
        }
        private static void EmployeesUnderTLs()
        {

            for (int i = 0; i < hrc.TLList.Count; i++)
            {
                if (hrc.TLList[i] == null)
                {
                    continue;
                }

                Console.WriteLine("===============\n");
                Console.WriteLine($"TL Name: {hrc.TLList[i].Name} \n");

                for (int j = 0; j < hrc.TLList[i].MyEmployeeList.Count; j++)
                {
                    if (hrc.TLList[i].MyEmployeeList[j] == null)
                    {
                        continue;
                    }
                    Console.WriteLine(hrc.TLList[i].MyEmployeeList[j].FirstName + " " + hrc.TLList[i].MyEmployeeList[j].LastName);


                }


                //foreach (var item in hrc.TLList)
                //{

                //    foreach (var items in hrc.TLList[item].MyEmployeeList)
                //    {

                //    }

                //    if ( item == null)
                //    {
                //        continue;
                //    }
                //    Console.WriteLine("===============\n");
                //    Console.WriteLine($"TL Name: {item.Name} \n");
                //    foreach (var items in tlc.MyEmployeeList)
                //    {
                //      Console.WriteLine(items.FirstName+" "+items.LastName);

                //    }
                ////   
                //   if (hrc.TLList[radomTL].Name.Contains("Ashwani", StringComparison.OrdinalIgnoreCase))
                //   {
                //       hrc.TLList[radomTL].MyEmployeeList.Add(item);
                //   }
                //   if (hrc.TLList[radomTL].Name.Contains("Harshwantu", StringComparison.OrdinalIgnoreCase))
                //   {
                //       hrc.TLList[radomTL].MyEmployeeList.Add(item);
                //   }
                //   //Console.WriteLine("");
                //   //Console.WriteLine(hrc.TLList[radomTL].Name + " " + item.FirstName + " \n" + item.LastName + "\n============"); 

            }
        }
        private static void ReportGeneration()
        {
            while (true)
            {
                Console.WriteLine("\n=========Menu Driven Program===========\n");
                Console.WriteLine("Select Report\n");
                Console.WriteLine("1. Employee List\n2. TL's with assigned Employees\n3. Reassign Employees \n4. Exit\n");
                int choice = Convert.ToInt32((Console.ReadLine()));
                switch (choice)
                {
                    case 1: PrintUpdatedEmployeeList(); break;
                    case 2: EmployeesUnderTLs(); break;
                    case 3:
                        foreach (var item in hrc.TLList)
                        {
                            item.MyEmployeeList.Clear();

                        }
                            
                        
                        HRAllocateEmployees();break;
                    case 4: return;
                    default: Console.WriteLine("Invalid choice\nTry again..........\n"); break;

                }
            }
        }


    }
}
