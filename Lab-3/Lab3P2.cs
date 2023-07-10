using System;

public class Staff
{
    public string Name;
    public string Designation;

    public Staff(String Name, String Designation)
    {
        this.Name = Name;
        this.Designation = Designation;
    }

    public void displayData()
    {
        if (Designation == "HOD")
        {
            Console.WriteLine("Name : {0} \nDesignation : {1}", this.Name, this.Designation);
        }
    }
}
public class StaffData
{
    public static void Main(string[] args)
    {
        Staff s1 = new Staff("ABC", "professor");
        Staff s2 = new Staff("CDE", "Admin");
        Staff s3 = new Staff("EFG", "Coordinator");
        Staff s4 = new Staff("GHI", "Dean");
        Staff s5 = new Staff("IJK", "HOD");
        s1.displayData();
        s2.displayData();
        s3.displayData();
        s4.displayData();
        s5.displayData();

    }
}