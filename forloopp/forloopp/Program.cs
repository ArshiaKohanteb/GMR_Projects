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
            Console.WriteLine("\t\t\t How many *s do you want in  a row? \n\t\t\t\t       (4 rows)");

            int cool = int.Parse(Console.ReadLine());
            
            for (int J = 1; J < 5; J++)
            {
               
                for (int i = 0; i < cool; i++)
                {
                    Console.Write("*");
                }
                Console.WriteLine(" ");
            }
              
            Console.ReadKey();
        }
    }
}
