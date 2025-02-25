using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InterfaceAct
{
    internal class Admin : Person
    {
        public void Create()
        {
            Console.WriteLine("Admin: Creating a user...");
        }

        public void Update()
        {
            Console.WriteLine("Admin: Updating a user...");
        }

        public void Delete()
        {
            Console.WriteLine("Admin: Deleting a user...");
        }
    }
}
