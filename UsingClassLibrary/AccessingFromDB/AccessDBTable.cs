using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using CustomDatabase;
using DatabaseRepo;

namespace AccessingFromDB
{
   public class AccessDBTable: IEmployeeRepo
    {
        //BusinessRepo.EmployeeBLRepo employeeBLRepo = new EmployeeBLRepo();
        public int GetEmployeeData(int id)
        {

            return id;
        }

        //Without implementing interface
        //public List<Employee11Mar> GetAllEmployeeData()
        //{
        //    EmployeeEntities employeeEntities = new EmployeeEntities();
            
        //    List<Employee11Mar> employeeObject = employeeEntities.Employee11Mar.ToList();
        //    return employeeObject;
        //}

        public List<EmployeeModel> GetAllEmployeeData()
        {
            EmployeeEntities employeeEntities = new EmployeeEntities();
            var emp = employeeEntities.Employee11Mar.ToList();
            List<EmployeeModel> custommodel = new List<EmployeeModel>();
            foreach(var item in emp)
            {
                EmployeeModel model = new EmployeeModel();
                model.EmpId = item.Id;
                model.EmplName = item.Name;
                model.EmplAddress = item.Address;
                custommodel.Add(model);
            }
            return custommodel;

        }

        public void SaveEmployeeData()
        {
            throw new NotImplementedException();
        }
    }
}
