using System.ComponentModel;

namespace PersonalRegister
{
    internal class Program
    {
        private static Payroll payroll = new Payroll();
        static void Main(string[] args)
        {

            bool isAlive = true;

            SeedData();

            do
            {
                Console.WriteLine("1. Add Employee" +
                    "\n2: Show Employees" +
                    "\nQ: Quit");

                string input = Console.ReadLine().ToUpper();

                switch (input){
                    case "1":
                        AddEmployee();
                        break;
                    case "2":
                        PrintEmployees();
                        break;
                    case "Q":
                        isAlive = false;
                        break;
                    default:
                        break;
                }
            }while(isAlive);
        }

        private static void AddEmployee()
        {
            bool success = false;
            string name;
            int salary = 0;

            do
            {

                Console.WriteLine("Name: ");
                name = Console.ReadLine();

                if (string.IsNullOrWhiteSpace(name))
                {
                    Console.WriteLine("You must enter a valid name");
                }
                else
                {
                    success = true;
                    Console.WriteLine("Salary: ");
                    int.TryParse(Console.ReadLine(), out salary);
                }
            } while (!success);

            payroll.AddEmployee(name, salary);
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
