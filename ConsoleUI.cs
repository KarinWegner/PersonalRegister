using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PersonalRegister
{
    public class ConsoleUI
    {
        public void Print(string message)
        {
            Console.WriteLine($"Message: {message}");
        }

        public string GetInput()
        {
            return Console.ReadLine();
        }
    }
}
