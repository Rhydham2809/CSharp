/*Write a program to Define a class Distance have data members dist1, dist2,
dist3. Initialize the two data members using constructor and store their 
addition in third data member using function and display addition*/

using System;
using System.Collections.Generic;

public class Distance_Demo
{
    public static void Main()
    {
        Console.WriteLine("Please enter distance 1 : ");
        double dist1 = double.Parse(Console.ReadLine());
        Console.WriteLine("Please enter distance 2 : ");
        double dist2 = double.Parse(Console.ReadLine());
        Distance d = new Distance(dist1, dist2);
        d.sum();
        d.display();
    }
}

public class Distance
{
    double dist1;
    double dist2;
    double dist3;

    public Distance(double dist1, double dist2)
    {
        this.dist1 = dist1;
        this.dist2 = dist2;
    }

    public void sum()
    {
        this.dist3 = this.dist1+this.dist2;
    }

    public void display()
    {
        Console.WriteLine("Answer : {0}",this.dist3);
    }


}
