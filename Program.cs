using System.ComponentModel;
using PersonalRegister.Helpers;

namespace PersonalRegister
{
    internal class Program
    {
        private static Payroll payroll = new Payroll();
        static void Main(string[] args)
        {
            Main main = new Main();

            try
            {

                main.Run();
            }
            catch (ArgumentNullException ex)
            {
                Console.WriteLine(ex.Message);
            }
            catch (ArgumentException ex)
            {
                Console.WriteLine(ex.Message);
            }
            finally { main.Run(); }
        }
    }
}
