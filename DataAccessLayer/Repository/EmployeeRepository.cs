using DataAccessLayer.DataModel;
using DataAccessLayer.IRepository;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccessLayer.Repository
{
   public class EmployeeRepository : IEmployeeRepository
    {
        public List<Employee> GetEmployees()
        {
            return new List<Employee>(){
                new Employee { EmployeeID = 1, FirstName = "Gowtham", LastName = "K" , Email="gowthamk91@outlook.com", Age=25},
                new Employee { EmployeeID = 1, FirstName = "Pradeep", LastName = "Raj" , Email="pradeep@outlook.com", Age=24 },
             
            };
        }

        public List<Employee> GetEmployeeEntities()
        {
            List<Employee> employees = new List<Employee>();
            using (EmployeeEntities context = new EmployeeEntities())
            {
               var empList= context.Employees.ToList();
                foreach(var item in empList)
                {
                    employees.Add(new Employee { EmployeeID = item.EmployeeID, FirstName = item.FirstName, LastName = item.LastName, Age = item.Age });
                }
            }
            return employees;
        }
    }
}
