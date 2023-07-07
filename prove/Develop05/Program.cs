using System;

namespace employee_demo
{
  
class Program
{
    static void Main(string[] args)
    {
        HourlyEmployee hEmployee = new HourlyEmployee();
        hEmployee.SetName( "Abdias");
        hEmployee.SetIdNumber("123abc");
        hEmployee.SetPayRate(15);
        hEmployee.SetHoursWorked(35);

        SAlaryEmployee sEmployee = new SAlaryEmployee();
        sEmployee.SetName("Taina");
        sEmployee.SetIdNumber("456EJF");
        sEmployee.SetSalary(60000);

    

    }
    Public static void DisplayEmplyeeInformation(Employee employee)
    {
        _employee = employee;
    }
}  
}