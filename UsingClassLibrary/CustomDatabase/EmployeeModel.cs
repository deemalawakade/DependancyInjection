using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CustomDatabase
{
    public class EmployeeModel

    {
        //public EmployeeModel(int id, string empname, string address)
        //{
        //    EmpId = id;
        //    EmplName = empname;
        //    EmplAddress = address;
        //}
        public int EmpId{get;set;}
        public string EmplName { get; set; }
        public string EmplAddress { get; set; }
    }
}
