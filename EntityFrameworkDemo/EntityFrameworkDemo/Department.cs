using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace EntityFrameworkDemo
{
    public class Department
    {
        public int Id { set; get; }
        public string Name { set; get; }
        public string Location { set; get; }
        public List<Employee> Employees { set; get; }
    }
}