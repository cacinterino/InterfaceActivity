using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InterfaceAct
{
    internal abstract class Person
    {
        public required string Fname { get; set; }
        public required string Lname { get; set; }
        public string Mname { get; set; }
        public DateTime Birthdate { get; set; }
        public string EmailAddress { get; set; }

        public string GetName()
        {
            return $"{Fname} {Mname} {Lname}";
        }

        public void SetName(string fname, string lname, string mname)
        {
            Fname = fname;
            Lname = lname;
            Mname = mname;
        }
    }
}
