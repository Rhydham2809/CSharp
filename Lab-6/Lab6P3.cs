using System;

class StackDemo
{
    public static void Main()
    {
        Stack<int> a1 = new Stack<int>();
        Console.WriteLine("Please select the option for following operations : ");
        int a=0;
        while (a != 7)
        {
            Console.WriteLine(" 1.Push \n 2.Pop \n 3.Peep \n 4.Contains \n 5.Clear \n 6.View \n 7.exit");
            a = int.Parse(Console.ReadLine());
            if (a == 1)
            {
                Console.WriteLine("Please enter integer : ");
                a1.Push(int.Parse(Console.ReadLine()));
            }
            else if (a == 2)
            {
                try
                {
                    a1.Pop();
                }
                catch(Exception ex) 
                { 
                    Console.WriteLine(ex.Message);
                }

                Console.WriteLine("Successfully deleted");
            }
            else if (a == 3)
            {
                try
                {
                    Console.WriteLine("Top most element is : {0}", a1.Peek());

                }
                catch ( Exception ex)
                {
                    Console.WriteLine(ex.Message);
                }
            }
            else if (a == 4)
            {
                Console.WriteLine("Please enter elements to search : ");
                int search = int.Parse(Console.ReadLine());
                if (a1.Contains(search))
                {
                    Console.WriteLine("{0} elemets found!", search);
                }
                else
                {
                    Console.WriteLine("{0} elemets not found!", search);
                }
            }
            else if (a == 5)
            {
                a1.Clear();
            }
            else if(a == 6)
            {
                Console.WriteLine("Stack contains following data : ");
                foreach(int i in a1)
                {
                    Console.WriteLine(i);
                }

            }
        }
        if (a == 7)
        {
            Console.WriteLine("Successfully exited");
            Console.ReadLine();
        }
    }
}
