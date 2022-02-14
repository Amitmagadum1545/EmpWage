using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EmpWage
{
    internal class EmpWageProgram
    {
        public static void CheckEmpPresentOrAbsent()
        {
            Random random = new Random();
            int empCheck = random.Next(2);
            if(empCheck == 0)
            {
                Console.WriteLine("Employee is Absent");

            }
            else
            {
                Console.WriteLine("Employee is Present");
            }
        }
    }
}
