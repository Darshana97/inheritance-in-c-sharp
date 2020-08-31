using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace inheritance
{

    class Employee
    {
         public string FirstName;
        public string LastName;
        string Email;

        public void PrintFullName()
        {

        }

    }

    class FullTimeEmployee : Employee
    {
        public float AnnualSalary;
    }

    class PartTimeEmployee : Employee
    {
        float HourlySalary;
    }

    class Program
    {
        static void Main(string[] args)
        {

            FullTimeEmployee FTE = new FullTimeEmployee();
            FTE.FirstName = "Darshana";
            FTE.LastName = "Senevirathna";
            FTE.AnnualSalary = 120000;
            FTE.PrintFullName();
        }
    }
}
