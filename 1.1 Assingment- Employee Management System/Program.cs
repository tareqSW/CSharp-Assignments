using Employee_Management_System;

Employee employee;

Console.WriteLine("=== Employee Management System ===");
Console.WriteLine("1. Full-Time Employee");
Console.WriteLine("2. Part-Time Employee");
Console.Write("Choose employee type: ");

int choice = Convert.ToInt32(Console.ReadLine());
if(choice != 1 && choice != 2)
{
    throw new Exception("Please Enter correct 1 or 2");
}
Console.Write("Enter employee ID: ");
int id = Convert.ToInt32(Console.ReadLine());

Console.Write("Enter employee name: ");
string name = Console.ReadLine();

switch (choice)
{
    case 1:
        Console.Write("Enter monthly salary (JOD): ");
        decimal monthlySalary = Convert.ToDecimal(Console.ReadLine());

        employee = new Full_Time_Employee(name, id, monthlySalary);
        break;

    case 2:
        Console.Write("Enter hours worked: ");
        int hoursWorked = Convert.ToInt32(Console.ReadLine());

        Console.Write("Enter hourly rate (JOD): ");
        decimal hourlyRate = Convert.ToDecimal(Console.ReadLine());

        employee = new Part_Time_Employee(name, id, hoursWorked, hourlyRate);
        break;

    default:
        Console.WriteLine("Invalid employee type!");
        return;
}

Console.WriteLine("\n=== Employee Information ===");
Console.WriteLine(employee.DisplayInfo());

Console.WriteLine("-----------------------------");
employee.Work();
