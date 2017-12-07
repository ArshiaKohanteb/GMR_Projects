using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Arshialoginwarrays
{
    class Program
    {
        static void Main(string[] args)
        {

            bool login = false;
            string[] username;

            username = new string[3];

            username[0] = "a";
            username[1] = "b";
            username[2] = "c";

            string[] password;

            password = new string[3];
            
            password[0] = "a";
            password[1] = "b";
            password[2] = "c";

            while(!login)
            {
            Console.WriteLine("\t\t\t INPUT USERNAME");
            string cuser=(Console.ReadLine());

            Console.WriteLine("\t\t\t INPUT PASSWORD");
            string cpass = (Console.ReadLine());

            for (int count = 0; count < username.Length; count++ )
            {
                if (username[count] == cuser && password[count] == cpass)
                {
                    Console.WriteLine("\t\t\t !!!!!YOU SUCCSEFULLY LOGGED IN!!!!!");
                    login = true;
                    break;
                }
            }
            if (login == false)
            {
                Console.WriteLine("\t\t\t !!!!!YOU SUCCSEFULLY LOGGED IN!!!!!  \n\t\t\t !!!!!!!!!!!!!!!!NOT!!!!!!!!!!!!!!!!");
            }
            }
            /*
            int x = 0;
            while (x < 10)
            {
                Console.WriteLine(string.Format("{0}", x));
                x++;
            }

            for (int i = 0; i < 10; i++)
            {
                Console.WriteLine(string.Format("{0}", i));
            }

            */


            /*
            int[] my2array = {5, 2, 1};

            int[] myarray;

            myarray = new int[3];

            myarray[0] = 5;
            myarray[1] = 2;
            myarray[2] = 1;

            Console.WriteLine(string.Format("array 1: {0}, array 2: {1}, array 3: {2}", myarray[0], myarray[1], myarray[2]));
            Console.WriteLine(string.Format("array 1: {0}, array 2: {1}, array 3: {2}", my2array[0], my2array[1], my2array[2]));
            * */
            Console.ReadKey();
        }
    }
}
