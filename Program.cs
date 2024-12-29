using System.ComponentModel;
using PersonalRegister.Helpers;
using PersonalRegister.UI;

namespace PersonalRegister
{
    internal class Program
    {
        private static Payroll payroll = new Payroll();
        static void Main(string[] args)
        {
            Main main = new Main();
                var ui = new ConsoleUI();

            try
            {
                main.Run(ui);
            }
            catch (ArgumentNullException ex)
            {
                Console.WriteLine(ex.Message);
            }
            catch (ArgumentException ex)
            {
                Console.WriteLine(ex.Message);
            }
            finally { main.Run(ui); }
        }
    }
}
