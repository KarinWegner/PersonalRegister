using PersonalRegister.Helpers;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using PersonalRegister.UI;

namespace PersonalRegister
{
    internal class Main
    {
        private Payroll payroll = new Payroll();
        private IUI ui;
        public void Run(IUI ui)
        {
            this.ui = ui;
            bool isAlive = true;
            SeedData();

            do
            {
                MenuHelpers.ShowMainMenu();

                string input = ui.GetInput().ToUpper();

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

        private void AddEmployee()
        {

            string name = Util.AskForString("Name", ui);
            uint salary = Util.AskForUInt("Salary", ui);

            payroll.AddEmployee(name, salary);
        }
        private void PrintEmployees()
        {
            IEnumerable<Employee> employees = payroll.GetEmployees();
            foreach (Employee employee in employees)
            {
                ui.Print(employee.ToString());
            }
        }

        private void SeedData()
        {
            payroll.AddEmployee("Kalle", 25000);
            payroll.AddEmployee("Anna", 28000);
            payroll.AddEmployee("Stefan", 35000);
        }

    }
}