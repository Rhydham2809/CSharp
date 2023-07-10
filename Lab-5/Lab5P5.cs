using System;

public class Hospital
{
    public virtual void HospitalDetails()
    {
        Console.WriteLine("Hospital Names");
    }
}

public class Apollo : Hospital
{
    public override void HospitalDetails()
    {
        Console.WriteLine("Apollo");
    }
}

public class Wockhardt : Hospital
{
    public override void HospitalDetails()
    {
        Console.WriteLine("Wockhardt");
    }
}

public class Gokul_Superspeciality : Hospital
{
    public override void HospitalDetails()
    {
        Console.WriteLine("Gokul_Superspeciality");
    }
}

public class Program
{
    public static void Main(string[] args)
    {
        Hospital r = new Hospital();
        r.HospitalDetails();

        Apollo h = new Apollo();
        h.HospitalDetails();

        Wockhardt s = new Wockhardt();
        s.HospitalDetails();

        Gokul_Superspeciality i = new Gokul_Superspeciality();
        i.HospitalDetails();
    }
}

