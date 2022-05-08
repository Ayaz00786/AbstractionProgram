using System;

namespace Abstraction
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Employee emp = new FullTimeEmployee();

            emp.FirstName = "Ayaz";
            emp.LastName = "Ahmad";
            emp.email = "Ayaj@gmail.com";
            emp.id = 123;

            emp.GetFullName();
        }
    }
}
