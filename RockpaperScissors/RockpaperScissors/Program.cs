using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace RockpaperScissors
{
    public enum item
    {
        none = 0,
        Rock = 1,
        Paper = 2,
        Scissor = 3
    }
    class Program
    {
        static void Main(string[] args)
        {
            Console.BackgroundColor = ConsoleColor.Cyan;
            Console.ForegroundColor = ConsoleColor.DarkGreen;
            Console.Clear();
            Console.WriteLine("\t\t\tWelcome To ROCK , PAPER , SCISSORS , OF DOOOOOOOOOOOOM");
            Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine("\t\t\t\t    Rock = 1 \n\t\t\t\t   Paper = 2 \n\t\t\t\t Scissors = 3 \n\t\t\t Shoot = 4(Shoot Beats Everything!)");
            while (true)
            {
                Console.ForegroundColor = ConsoleColor.DarkMagenta;
                int player = int.Parse(Console.ReadLine());
                Random random = new Random();
                int computernum = random.Next(1, 4);
                if (player == computernum)
                {
                    Console.ForegroundColor = ConsoleColor.Yellow;
                    Console.WriteLine("ITS A VERRRRRRYYYYYY BBBBBOOOOOORRRRRRIIIIIINNNNNNGGGGG TTTTIIIIIEEEEE");
                    Console.WriteLine("'Cause The Computer Did {0} And You Did {1}", ((item)computernum).ToString(), ((item)player).ToString());
                }
                //rock - scissors , shoot - everything , scissors - rock , paper - rock , Scissors - paper
                else if (player == 1 && computernum == 3 || player == 2 && computernum == 1 || player == 3 && computernum == 2)
                {
                    Console.ForegroundColor = ConsoleColor.DarkYellow;
                    Console.WriteLine("FINALLY , WE WON!!");
                    Console.WriteLine("Cause The Computer Did {0} And You Did {1}", ((item)computernum).ToString(), ((item)player).ToString());
                }
                else if (player == 4 && computernum == 1 || player == 4 && computernum == 2 || player == 4 && computernum == 3)
                {
                    Console.ForegroundColor = ConsoleColor.Red;
                    Console.WriteLine("Of Course We Won");
                    Console.WriteLine("'Cause You Did Shoot\n But FYI The Computer Did {0}",computernum);
                }

                else if (computernum == 1 && player == 3 || computernum == 2 && player == 1 || computernum == 3 && player == 2)
                {
                    Console.ForegroundColor = ConsoleColor.Magenta;
                    Console.WriteLine("SADLY , THE COMPUTER WON  ):");
                    Console.WriteLine("'Cause The Computer Did {0} And You Did {1}",((item)computernum).ToString(), ((item)player).ToString());
                }
                else
                {
                    Console.WriteLine("You Need To Enter Somthing Valid");
                }
                Console.ForegroundColor = ConsoleColor.White;
                Console.WriteLine("To Play Again Type \n1 For Rock\n2 For Paper\n3 For Scissors & 4 For Shoot");
            }
       Console.ReadKey();
     }    
   }       
 }

