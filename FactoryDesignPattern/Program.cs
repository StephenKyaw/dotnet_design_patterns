// See https://aka.ms/new-console-template for more information
using FactoryDesignPattern;

Console.WriteLine("Hello, World!");


string emplyee_type = "PartTime";

IEmployee? employee = null;


if (emplyee_type == "PartTime")
{
    employee = new PartTimeEmployee();
}
else if (emplyee_type == "Permanent")
{
    employee= new PermanentEmployee();
}

Console.WriteLine(employee.EmployeeType());
Console.WriteLine(employee.GetSalary());

