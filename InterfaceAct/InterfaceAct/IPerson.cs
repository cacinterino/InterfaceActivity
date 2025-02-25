using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InterfaceAct
{
    interface IPerson
    {
        string Fname { get; set; }
        string Lname { get; set; }
        string Mname { get; set; }
        DateTime Birthdate { get; set; }
        string EmailAddress { get; set; }

        string GetName();
        void SetName(string fname, string lname, string mname);
    }
}
