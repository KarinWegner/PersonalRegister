using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PersonalRegister
{
    internal class Droid
    {
        private string firstname;

        private int salary;

        public int Salary
        {
            get { return salary; }
            set
            {
                if (value < 0)
                {
                    salary = 0;
                }
                else
                {
                    salary = value;
                }
            }
        }

        public int Salary2 { get; set; }

        public static int Count;

        public Droid(string name, int salary)
        {
            firstname = name;
            Salary = salary;
            Count++;
        }
        public Droid() { Count++; }

        public string GetFirstName()
        {
            return firstname;
        }
        public void SetFirstName(string name)
        {
            firstname = name;
        }
        public static void GetCount()
        {
            Console.WriteLine(Count);
        }
    }
}
