using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EmpWage
{
    internal class EmpWageProgram
    {
        public static void EmployeeDailyWage()
        {
            const int WAGEPERHOUR = 20;
            int empWorkHr;
            int DailyEmployeeWage = 0;
            Random random = new Random();
            int empCheck = random.Next(3);
            if(empCheck == 0)
            {
                Console.WriteLine("Employee is Absent");
                empWorkHr = 0;
            }
            else if (empCheck == 1)
            {
                Console.WriteLine("Employee is Present");
                empWorkHr = 8;
            }
            else
            {
                Console.WriteLine("Employee is Part Time Present");
                empWorkHr = 4;
                
            }
            DailyEmployeeWage = empWorkHr * WAGEPERHOUR;
            Console.WriteLine($"Daily Employee Wage is" + DailyEmployeeWage);
        }
    }
}
