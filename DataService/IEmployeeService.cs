using DataAccessLayer;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataService
{
    public interface IEmployeeService
    {
        List<Employee> GetEmployees();
        List<Employee> GetEmployeeEntities();

    }
}
