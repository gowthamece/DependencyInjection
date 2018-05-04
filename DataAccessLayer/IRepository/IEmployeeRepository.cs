using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccessLayer.IRepository
{
   public interface IEmployeeRepository
    {
        List<Employee> GetEmployees();
        List<Employee> GetEmployeeEntities();
    }
}
