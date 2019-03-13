using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CustomDatabase;
using DatabaseRepo;
using AccessingFromDB;


namespace BusinessRepo
{
    public class EmployeeBLRepo
    {
        IEmployeeRepo employeeRepo;
        public EmployeeBLRepo(int choice)
        {
            
            if (choice == 1)
            {
                employeeRepo = new EmployeeRepo();
            }
            else if (choice == 2)
            {
                employeeRepo = new AccessDBTable();
            }
        }
       // EmployeeRepo obj = new EmployeeRepo();
        //AccessDBTable obj = new AccessDBTable();
        public int GetEmployeeData(int id)
        {
          
            return id;
        }

        public List<EmployeeModel> GetAllEmployeeData()
        {
            return employeeRepo.GetAllEmployeeData();
        }
        public void AddEmployeeData()
        {
            employeeRepo.SaveEmployeeData();
        }
        
    }
}
