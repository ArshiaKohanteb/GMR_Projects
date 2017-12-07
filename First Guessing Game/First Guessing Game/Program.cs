using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ConsoleApplication1
{
    class Program
    {
        static void Main(string[] args)
        {
            while (true)
            {
                Console.BackgroundColor = ConsoleColor.Cyan;
                Console.ForegroundColor = ConsoleColor.DarkGreen;
                Console.Clear();
                Console.WriteLine("\t\t Welcome To The Best & Better Best Guessing Game");
                Console.WriteLine("Please Enter A Minimum Number...");
                int min = int.Parse(Console.ReadLine());
                Console.WriteLine("...Please Enter A Maximum Number");
                int max = int.Parse(Console.ReadLine());
                if (min > max)
                {
                    Console.WriteLine("IIMMPPOOSSIIBBLLEE");
                    Console.ReadKey();
                    break;
                }
                    Console.WriteLine("Think Of A Number Between {0} - {1}", min, max);
                while (true)
                {
                    int minmax = (min + max) / 2;
                    Console.WriteLine("\n Is This Your Number - {0}", minmax);

                    Console.WriteLine("\n Press 1 For Too Low,\n Press 2 for Too High \n Perfect");
                    int playre = int.Parse(Console.ReadLine());

                    if (playre == 1)
                    {
                        min = minmax;
                    }

                    if (playre == 2)
                    {
                        max = minmax;
                    }

                    if (playre == 3)
                    {
                        Console.WriteLine("YYYYYAAAAAAAAAYYYYYYY");
                        Console.ReadKey();
                        break;
                    }
                }
            }
        }
    }
}
