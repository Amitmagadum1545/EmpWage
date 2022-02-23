using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EmpWage
{
    internal class EmpWageProgram
    {
        private string company;
        private int emp_Wage_Per_Hr;
        private int working_Days_Per_Month;
        private int max_Hrs_Per_Month;
        private int totalWagePerMonth;
       
        public EmpWageProgram(string company, int emp_Wage_Per_Hr, int working_Days_Per_Month, int max_Hrs_Per_Month)
        {
            this.company = company;
            this.emp_Wage_Per_Hr = emp_Wage_Per_Hr;
            this.working_Days_Per_Month = working_Days_Per_Month;
            this.max_Hrs_Per_Month = max_Hrs_Per_Month;
        }
        public void computeEmpWage()
        {
            int empWorkHr = 0, DailyEmployeeWage = 0, totalempWorkHr = 0, day = 1;
            Random random = new Random();
            while (totalempWorkHr <= max_Hrs_Per_Month && day <= working_Days_Per_Month)
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
                DailyEmployeeWage = empWorkHr * emp_Wage_Per_Hr;
                Console.WriteLine($"Daily Employee Wage for Day {day} is: " + DailyEmployeeWage);
                totalWagePerMonth = DailyEmployeeWage + totalWagePerMonth;
                totalempWorkHr = empWorkHr + totalempWorkHr;
                day++;
            }
            Console.WriteLine("Monthly Employee Wage for " + this.company + " is " + totalWagePerMonth +" ,Total Employee Working Hours are "+ totalempWorkHr);
        }
    }
}
