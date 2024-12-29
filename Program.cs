namespace PersonalRegister
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Payroll payroll = new Payroll();

            payroll.AddEmployee("Kalle", 20000);
            payroll.AddEmployee("Anna", 30000);

            IEnumerable<Employee> employees = payroll.GetEmployees();


            foreach (Employee employee in employees)
            {
                Console.WriteLine($"Name: {employee.Name} Salary: {employee.Salary}");
            }
        }
    }
}
