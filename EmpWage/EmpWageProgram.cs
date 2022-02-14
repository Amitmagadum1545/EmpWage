using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EmpWage
{
    internal class EmpWageProgram
    {
        public static void EmployeeMonthlyWage()
        {
            const int WAGE_PER_HOUR = 20, WORKING_DAYS_PER_MONT = 20;
            int empWorkHr = 0, TotalWagePerMonth=0;
            int DailyEmployeeWage = 0;
            Random random = new Random();
            for (int day = 1; day <= WORKING_DAYS_PER_MONT; day++)
            {
                int empCheck = random.Next(3);
                switch (empCheck)
                {
                    case 0:
                        Console.WriteLine("Employee is Absent");
                        empWorkHr = 0;
                        break;
                    case 1:
                        Console.WriteLine("Employee is Present");
                        empWorkHr = 8;
                        break;
                    case 2:
                        Console.WriteLine("Employee is Part Time Present");
                        empWorkHr = 4;
                        break;
                }
                DailyEmployeeWage = empWorkHr * WAGE_PER_HOUR;
                Console.WriteLine($"Daily Employee Wage for Day {day} is: " + DailyEmployeeWage);
                TotalWagePerMonth = DailyEmployeeWage + TotalWagePerMonth;
                
            }
            Console.WriteLine($"Monthly Employee Wage is: " + TotalWagePerMonth);
        }
    }
}
