using System;
using System.Collections.Generic;
using System.Text;

namespace Employee_Management_System
{
    internal class Part_Time_Employee : Employee
    {
        public int HoursWorked { get; set; }
        public decimal HourlyRate { get; set; }
        public Part_Time_Employee(string Name, int Id, int hoursWorked,decimal hourlyRate) : base(Name, Id)
        {
            this.HourlyRate = hourlyRate;
            this.HoursWorked = hoursWorked;
        }
        public override decimal CalculateSalary()
        {
            Salary = HourlyRate * HoursWorked;
            return Salary;
        }

        public override string DisplayInfo()
        {
            return $"{base.DisplayInfo()} , Type Working : Part Time Employee";
        }


        public override void Work()
        {
            Console.WriteLine($"{Name} is Working part-time");
        }
    }
}
