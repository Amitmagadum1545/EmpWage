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
            EmpWageProgram google = new EmpWageProgram("Google", 20, 2, 10);
            EmpWageProgram tataMotors = new EmpWageProgram("Tata Motors", 10, 4, 20);
            EmpWageProgram marutiSuzuki = new EmpWageProgram("Maruti Suzuki", 15, 3, 15);
            google.computeEmpWage();
            tataMotors.computeEmpWage();
            marutiSuzuki.computeEmpWage();
            Console.ReadLine();
        }
    }
}
