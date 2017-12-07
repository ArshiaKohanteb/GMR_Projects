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
                Console.WriteLine("\t\t\t input 3 triangle side lengths");

                int length = int.Parse(Console.ReadLine());
                int length2 = int.Parse(Console.ReadLine());
                int length3 = int.Parse(Console.ReadLine());
                //side 1 + side 2 > side 3
                if (length + length2 < length3 || length2 + length3 < length || length3 + length < length2)
                {
                    Console.WriteLine("\t\t\t NOT A POSSIBLE TRIANGLE");
                }
                else
                {
                    if (length == length2 && length2 == length3)
                    {
                        Console.WriteLine("\t\t\t You have an EQUILATIRAL triangle");
                    }

                    if (length != length2 && length2 != length3 && length != length3)

                    { Console.WriteLine("\t\t\t You have a SCALENE triangle"); }

                    else
                    {
                        Console.WriteLine("\t\t\t You have a ISOSOLESE triangle");
                    }
                }
                Console.WriteLine("\t\t\t WOULD YOU LIKE TO DO IT AGAIN? \n\t\t\t\t 1 FOR YES \n\t\t\t\t 2 FOR NO");
                int answer = int.Parse(Console.ReadLine());
                if (answer == 2)
                {
                    break;
                }
            }
        }
    }
}

//TODO: CHECK IF ITS ACTUALLY A TRIANGLE