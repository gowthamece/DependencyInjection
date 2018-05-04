using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DataAccessLayer;
using DataAccessLayer.IRepository;

namespace DataService
{
   public class EmployeeService : IEmployeeService
    {
        private IEmployeeRepository _iEmployeeRepository;

        public EmployeeService(IEmployeeRepository iEmployeeRepository)
        {
            _iEmployeeRepository = iEmployeeRepository;

        }

        public List<Employee> GetEmployees()
        {
            return _iEmployeeRepository.GetEmployees();
        }

        public List<Employee> GetEmployeeEntities()
        {
            return _iEmployeeRepository.GetEmployeeEntities();
        }
    }
}
