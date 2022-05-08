using System;
using System.Collections.Generic;
using System.Text;

namespace Abstraction
{
    abstract class Employee
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public int id { get; set; }
        public string email { get; set; }

        public abstract void GetFullName();
    }
     class FullTimeEmployee: Employee
    {
        public override void GetFullName()
        {
            Console.WriteLine(id+" -- "+FirstName+" "+LastName+" -- "+email);
        }
    }
}
