using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CustomDatabase;
namespace DatabaseRepo
{
    public interface IEmployeeRepo
    {
        int GetEmployeeData(int id);
        List<EmployeeModel> GetAllEmployeeData();
        void SaveEmployeeData();

    }
}
