﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PersonalRegister
{
    internal class Payroll
    {
        private List<Employee> employees {  get; set; }
        public Payroll() 
        {
            employees = new List<Employee>();
        }

        internal void AddEmployee(string name, uint salary)
        {
            if(name is null) throw new ArgumentNullException(name);
            employees.Add(new Employee(name, salary));
        }
        internal void AddEmployee(Employee employee)
        {
            employees.Add(employee);
        }
        internal IEnumerable<Employee> GetEmployees() 
        {
            return employees.ToArray();
        }
    }
}
