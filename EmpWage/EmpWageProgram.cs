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
            const int WAGE_PER_HOUR = 20, WORKING_DAYS_PER_MONT = 20, MAX_WORK_HOUR = 100;
            int empWorkHr = 0, totalWagePerMonth = 0, totalempWorkHr = 0, day=1;
            int DailyEmployeeWage = 0;
            Random random = new Random();
            while (totalempWorkHr <= MAX_WORK_HOUR && day <= WORKING_DAYS_PER_MONT)
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
                totalWagePerMonth = DailyEmployeeWage + totalWagePerMonth;
                totalempWorkHr = empWorkHr + totalempWorkHr;
                day++;
            }
            Console.WriteLine($"Monthly Employee Wage is: " + totalWagePerMonth +" ,Total Employee Working Hours are "+ totalempWorkHr);
        }
    }
}
