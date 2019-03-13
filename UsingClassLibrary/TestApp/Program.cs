using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BusinessRepo;
using CustomDatabase;
using AccessingFromDB;
namespace TestApp
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Press 1 For Static Data");
            Console.WriteLine("Press 2 for DB Data");
            int ch;
            ch = Convert.ToInt32(Console.ReadLine());
           
            EmployeeBLRepo employeeBLRepo = new EmployeeBLRepo(ch);
            var list = employeeBLRepo.GetAllEmployeeData();
            foreach(var item in list)
            {
                Console.WriteLine(item.EmpId);
                Console.WriteLine(item.EmplName);
                Console.WriteLine(item.EmplAddress);
            }

            //AccessDBTable accessingFromDB = new AccessDBTable();
            //Console.WriteLine("All Employee detail:1");
            //Console.WriteLine("Employee detail:2");
            //Console.WriteLine("Employee From DB:4");
            //Console.WriteLine("Save Employee detail:3");
            //int choice;
            //choice = Convert.ToInt32(Console.ReadLine());
            //switch(choice)
            //{
            //    case 1:
            //        List<EmployeeModel> empList = employeeBLRepo.GetAllEmployeeData();
            //        foreach(var item in empList)
            //        {
            //            Console.WriteLine(item.EmpId);
            //            Console.WriteLine(item.EmplName);
            //            Console.WriteLine(item.EmplAddress);
            //        }

            //        break;
            //    case 2:
            //        employeeBLRepo.GetEmployeeData(1);
            //        break;
            //    case 3:
            //        employeeBLRepo.AddEmployeeData();
            //        break;
            //    case 4:

            //        //without interface implementation
            //        //List<Employee11Mar> list=accessingFromDB.GetAllEmployeeData();
            //        //foreach(var lst in list)
            //        //{
            //        //    Console.WriteLine(lst.Id);
            //        //    Console.WriteLine(lst.Name);
            //        //    Console.WriteLine(lst.Address);
            //        //}
            //            break;
            //}


            Console.ReadKey();
           

        }
    }
}
