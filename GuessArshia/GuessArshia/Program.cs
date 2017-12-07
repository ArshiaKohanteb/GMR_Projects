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
            bool isPlaying = true;
            Console.BackgroundColor = ConsoleColor.Cyan;
            Console.ForegroundColor = ConsoleColor.DarkGreen;
            Console.Clear();
            Random generator = new Random();
            int randomnumber = generator.Next(0, 101);

            int numeral = 0;

            while (true)
            {
                while (isPlaying)
                {

                    Console.WriteLine("Guess A number");
                    int dude = int.Parse(Console.ReadLine());
                    if (dude < randomnumber)
                    {
                        Console.WriteLine("Too low");
                    }

                    if (dude > randomnumber)
                    {
                        Console.WriteLine("Too high");
                    }

                    if (randomnumber == dude)
                    {
                        Console.WriteLine("Your Guess Is Exactly Correct");
                        isPlaying = false;
                    }
                    numeral++;
                }

                Console.WriteLine("It Took You {0} Times To Do This Game", numeral);
                Console.WriteLine("Would you like to do the game again???? \n If So Press 1 \n\n Would you like to exit???? \n If So Press 2");
                int Read = int.Parse(Console.ReadLine());
                if (Read == 2)
                {
                    break;
                }
            }








            //ask the user for a guess
            //check if their guess is more, less, or correct than random number
        }
    }
}