﻿using PersonalRegister.Helpers;
using PersonalRegister;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PersonalRegister
{
    internal class Main
    {
        private static Payroll payroll = new Payroll();

        public void Run()
        {
            bool isAlive = true;

            SeedData();

            do
            {
                MenuHelpers.ShowMainMenu();

                string input = Console.ReadLine().ToUpper();

                switch (input)
                {
                    case MenuHelpers.Add:
                        AddEmployee();
                        break;
                    case MenuHelpers.Print:
                        PrintEmployees();
                        break;
                    case MenuHelpers.Quit:
                        isAlive = false;
                        break;
                    default:
                        break;
                }
            } while (isAlive);
        }

        private static void AddEmployee()
        {

            string name = Util.AskForString("Name");
            uint salary = Util.AskForUInt("Salary");

            payroll.AddEmployee(new Employee(name, salary));
        }
        private static void PrintEmployees()
        {
            IEnumerable<Employee> employees = payroll.GetEmployees();
            foreach (Employee employee in employees)
            {
                Console.WriteLine(employee);
            }
        }

        private static void SeedData()
        {
            payroll.AddEmployee("Kalle", 25000);
            payroll.AddEmployee("Anna", 28000);
            payroll.AddEmployee("Stefan", 35000);
        }

    }
}