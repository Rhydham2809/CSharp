/*Write a program to Define a class Salary which will contain member 
variable Basic, TA, DA, HRA. Write a program using Constructor with default
values for DA and HRA and calculate the salary of employee*/

using System;

public class Salary_Demo
{
    public static void Main()
    {
        Salary salary = new Salary();
        Salary salary2 = new Salary();
    }
}

class Salary
{
    double basic;
    double ta;
    double da;
    double hra;
    double gs;
    public Salary()
    {
        Console.WriteLine("Please enter basic salary : ");
        this.basic = double.Parse(Console.ReadLine());
        Console.WriteLine("Please enter TA  : ");
        this.ta = double.Parse(Console.ReadLine());
        hra = basic * (20 / 100.00);
        da = basic * (40 / 100.00);
        gs = basic + ta + basic * hra + da * basic;
        Console.WriteLine("Gross Salary : {0} Rs", Math.Round(gs, 4));
    }
}
