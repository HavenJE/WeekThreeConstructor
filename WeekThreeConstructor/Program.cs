// 3.7 Understanding constructors

using System;
class Employee
{
    private int employeeNumber;
    private string employeeName;
    public int EmployeeAge { get; set; }
    public void DisplayInformation()
    {
        Console.WriteLine("Employee number: {0}", employeeNumber);
        Console.WriteLine("Employee name: {0}", employeeName);
        Console.WriteLine("Employee age: {0}", EmployeeAge);
    }
    public Employee(int id, string name, int age)
    {
        employeeNumber = id;
        employeeName = name;
        EmployeeAge = age;
    }
    public static void Main()
    {
        Employee myAssistant = new Employee(123, "Haven", 42);
        myAssistant.DisplayInformation();
    }
}