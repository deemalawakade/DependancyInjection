using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CustomDatabase;
namespace DatabaseRepo
{


   public class EmployeeRepo : IEmployeeRepo
    {
        public List<EmployeeModel> GetAllEmployeeData()
        {
            List<EmployeeModel> empList = new List<EmployeeModel>{
            new EmployeeModel() { EmpId = 1, EmplName = "John", EmplAddress = "kolh" },
            new EmployeeModel() { EmpId = 2, EmplName = "shobha", EmplAddress = "kolh" }
            };
            return empList;
        }
        
        public int GetEmployeeData(int id)
        {
          
            return id;
        }

        public void SaveEmployeeData()
        {
            
        }
    }
}
