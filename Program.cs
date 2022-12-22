using System;

namespace project_1
{
    class Program
    {
        static void Main(string[] args)
        {
           
            Console.Write("Enter n1: ");
            Console.Write("Enter the beginning: ");
            double n1 = double.Parse(Console.ReadLine());
            Console.Write("Enter the end: ");
            double n2 = double.Parse(Console.ReadLine());
            if (n1 > n2 )
            {
                Console.WriteLine("please restart the program and enter the number correctly");
            }
            else
            {

                Console.WriteLine("Prime numbers between them");
                Console.WriteLine("");
                if (n1 < 2)
                    n1 = 2;
                for (double i = n1; i <= n2; i++)
                {
                    int a = 0;
                    for (double x = 2; x <= i / 2; x++)
                    {
                        if (i % x == 0)
                        {
                            a++;
                            break;
                        }
                    }
                    if (a == 0)
                        Console.WriteLine(i);
                }
            }
            

        }
    }
}
