using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InterfaceAct
{
    internal class Employee : Person
    {
        public void Teach()
        {
            Console.WriteLine("Employee: Teaching...");
        }

        public void AdminWork()
        {
            Console.WriteLine("Employee: Administering...");
        }
    }
}
