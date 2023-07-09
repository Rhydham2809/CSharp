using System;
using System.Collections;

class Menu{
    public static void Main()
    {
        Console.WriteLine("Please enter the number for the following functions : ");
        int a = 1 ;
        ArrayList a1 = new ArrayList();
            while(a!=6)
            {
                Console.WriteLine(" 1.Add student \n 2.Remove Student \n 3.Remove student from a range \n 4.Clear all the students \n 5.View \n 6.exit");
                a = int.Parse(Console.ReadLine());
                if (a==1)
                {
                    Console.WriteLine("Please enter student name : ");
                    a1.Add(Console.ReadLine());
                }
                else if(a==2) 
                {
                    Console.WriteLine("Please enter student's name to be removed : ");
                    string b = Console.ReadLine();
                    if(a1.Contains(b))
                    {
                        a1.Remove(b);
                        Console.WriteLine("Removed successfully");
                    }
                    else { Console.WriteLine("No such student exiets"); }
                }
                else if(a==3) 
                {
                    Console.WriteLine("Please enter starting and ending range from 0 to {0}",a1.Count-1);
                    int startingrange = int.Parse(Console.ReadLine());
                    int endingrange   = int.Parse(Console.ReadLine());
                    a1.RemoveRange(startingrange, endingrange);
                }
                else if (a==4) 
                {
                    a1.Clear();
                }
                else if(a==5)
                {
                    Console.WriteLine("The data is as follows : ");
                    for(int i=0;i<a1.Count; i++)
                    {
                        Console.WriteLine(a1[i]);
                    }
                }
            }
            if(a==6)
            {
                Console.WriteLine("Successfully exited");
                Console.ReadLine();
            }
        }
}