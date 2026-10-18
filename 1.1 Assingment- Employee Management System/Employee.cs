using System;
using System.Collections.Generic;
using System.Text;

namespace Employee_Management_System
{
    public abstract class Employee : IWorkable
    {
        private decimal _Salary {  get; set; }
        public decimal Salary { get
            {
                return _Salary;
            } 
            set { 
                _Salary= value;            
            
            } 
        }
        public  int Id {  get; set; }
        public string Name { get; set; }
        public Employee(string Name, int Id)
        {
            this.Name = Name;
            this.Id = Id;
        }

        public abstract decimal CalculateSalary();

        public abstract void Work();
        public virtual string DisplayInfo()
        {
            return $"ID : {Id}, " +
                $"Name : {Name}, " +
                $"Salary: {CalculateSalary()}, ";
        }

        
    }
}
