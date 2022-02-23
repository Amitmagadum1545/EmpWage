using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EmpWage
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome To Employee Wage Program");
            EmpWageProgram.EmployeeMonthlyWage("Google", 20, 2, 10);
            EmpWageProgram.EmployeeMonthlyWage("Tata Motors", 10, 4, 20);
            EmpWageProgram.EmployeeMonthlyWage("Maruti Suzuki", 15, 3, 15);
            Console.ReadLine();
        }
    }
}
