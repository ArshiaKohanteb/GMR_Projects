using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace HCalculater
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.BackgroundColor = ConsoleColor.Cyan;
            Console.ForegroundColor = ConsoleColor.DarkGreen;
            Console.Clear();
            int[] Days31 = new int[7];
            Days31[0] = 1;
            Days31[1] = 3;
            Days31[2] = 5;
            Days31[3] = 7;
            Days31[4] = 8;
            Days31[5] = 10;
            Days31[6] = 12;
            int[] Days30 = new int[4];

            while (true)
            {
                Console.WriteLine("\t\t\tBirth Year PLEASE");
                int birthyear = int.Parse(Console.ReadLine());
                int year = 2014 - birthyear;
                Console.WriteLine("\t\t\tBirth Month");
                int bmonth = int.Parse(Console.ReadLine());
           
                Console.WriteLine("\t\t\tBirth Date");
                bool possible = true;
                int bday = int.Parse(Console.ReadLine());
                if (bday == 31)
                {
                    for (int i = 0; i < Days31.Length; i++)
                    {
                        if (bmonth == Days31[i])
                        {
                            break;
                        }
                        else if (i == Days31.Length - 1)
                        {
                            possible = false;
                        }
                    }
                }
                if (bmonth == 2 && bday > 28)
                {
                }
                if ((bday > DateTime.Today.Day && bmonth == DateTime.Today.Month) || bmonth > DateTime.Today.Month)
                {
                    year -= 1;
                }
                if (birthyear < -1 || birthyear > 2016 || bmonth > 12 || bmonth < 1 || ! possible || bday < 1 || bday > 31)
                {
                    Console.WriteLine("\t\t\t IMPOSSIBLE IMPOSSIBLE IMPOSSIBLE");
                    Console.ReadKey();
                    break;
                }
                Console.WriteLine("\n\n\n\t\t\tYou Are {0} Years Old", year);
                Console.ReadKey();
               }
            }
        }
    }