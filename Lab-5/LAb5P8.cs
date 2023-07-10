using System;

public delegate T Calculate<T>(T x, T y);
public class Calculator

{
    public static void Main(string[] args)
    {
        Calculate<double> cl = Addition;
        double doubleResult = cl(2.2, 4.5);
        Console.WriteLine("Add : {0}",doubleResult);

        Calculate<double> cl1 = Subtraction;
        double doubleResult1 = cl(2.2, 4.57);
        Console.WriteLine("Sub : {0}", doubleResult1);

        Calculate<double> cl2 = Multiplication;
        double doubleResult2 = cl(2.240, 4.5);
        Console.WriteLine("Mul : {0}", doubleResult2);

        Calculate<double> cl3 = Division;
        double doubleResult3 = cl(2.299999, 4.5);
        Console.WriteLine("Div : {0}", doubleResult3);

    }
    public static double Addition(double a,double b)
    {
        return a + b;
    }

    public static double Subtraction(double a, double b)
    {
         return a - b;
    }

    public static double Multiplication(double a, double b)
    {
        return  a * b;
    }

    public static double Division(double a, double b)
    {
        try
        {
            return   a / b;
        }
        catch(Exception e) 
        {
            return 000;
        }

    }
}
