using System;

class Candidate
{
    int id;
    string name;
    int age;
    double weight;
    double height;


    public static void Main()
    {
        Candidate c = new Candidate();
        c.GetCandidateDetails();
        c.DiplayCandidateDetails();
        Console.ReadLine();
    }


    void GetCandidateDetails()
    {
        Console.Write("Please enter id : ");
        this.id = int.Parse(Console.ReadLine());

        Console.Write("Please enter Name : ");
        this.name = Console.ReadLine();

        Console.Write("Please enter Age : ");
        this.age = int.Parse(Console.ReadLine());

        Console.Write("Please enter Weight : ");
        this.weight = double.Parse(Console.ReadLine());

        Console.Write("Please enter Height : ");
        this.height = double.Parse(Console.ReadLine());

    }

    void DiplayCandidateDetails()
    {
        Console.WriteLine("ID : " + this.id);
        Console.WriteLine("Name : " + this.name);
        Console.WriteLine("Age : " + this.age);
        Console.WriteLine("Weight : " + this.weight);
        Console.WriteLine("Height : " + this.height);
    }
}




