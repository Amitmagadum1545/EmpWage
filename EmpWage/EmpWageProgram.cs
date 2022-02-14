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
            int DailyEmployeeWage = 0;
            Random random = new Random();
            int empCheck = random.Next(2);
            if(empCheck == 0)
            {
                Console.WriteLine("Employee is Absent");
                int empWorkHr = 0;
                DailyEmployeeWage = empWorkHr * WAGEPERHOUR;
            }
            else
            {
                Console.WriteLine("Employee is Present");
                int empWorkHr = 8;
                DailyEmployeeWage = empWorkHr * WAGEPERHOUR;
            }
            Console.WriteLine($"Daily Employee Wage is" + DailyEmployeeWage);
        }
    }
}
