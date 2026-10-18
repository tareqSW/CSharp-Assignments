using System;
using System.Collections.Generic;
using System.Text;

namespace Employee_Management_System
{
    internal class Full_Time_Employee : Employee
    {
        public Full_Time_Employee(string Name, int Id,decimal monthlySalary) : base(Name, Id)
        {
            Salary= monthlySalary;
        }

        public override decimal CalculateSalary()
        {
            return Salary;
        }

        public override string DisplayInfo()
        {
            return $"{base.DisplayInfo()}, Type Working : Full Time Employee";
        }

        public override void Work()
        {
            Console.WriteLine($"{Name} is Working full-time");
        }
    }
}
