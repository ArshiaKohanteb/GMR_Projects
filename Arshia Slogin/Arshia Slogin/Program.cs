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


            string correctUsername = "awesome";
            string correctPassword = "awesome";
            Console.WriteLine("\t\t\t What is your username?");
            string username = Console.ReadLine();

            Console.WriteLine("\t\t\t What is your password?");
            string password  = Console.ReadLine();


            if (username == correctUsername && password == correctPassword)
            {
                Console.WriteLine("\t\t\t !!!!!YOU SUCCSEFULLY LOGGED IN!!!!!");
            }

            else
            {
                Console.WriteLine("\t\t\t !!!!!YOU SUCCSEFULLY LOGGED IN!!!!!  \n\t\t\t !!!!!!!!!!!!!NOT!!!!!!!!!!!!!!!!!!!");
            }

      
            if (password != correctPassword && username != correctUsername)
            {
                Console.WriteLine(" \t\t\t BOTH USERNAME & PASSWORD INNCORECT");
            }
            else if (username != correctUsername)
            {
                Console.WriteLine("\t\t\t\t USERNAME INNCORECT");
            }
            else if (password != correctPassword)
            { Console.WriteLine("\t\t\t\t PASSWORD INNCORECT"); }

            

           
            Console.ReadKey();
        }
    }
}
