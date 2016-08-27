using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace EntityFrameworkDemo
{
    public class EmployeeRepository
    {
        public List<Department> GetDepartments()
        {
            return new EmployeeDBContext().Departments.Include("Employees").ToList();
        }
    }
}