using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace arshiashoppinglist
{
    class Program
    {
        static void Main(string[] args)
        {
           //p.1
            Console.BackgroundColor = ConsoleColor.Cyan;
            Console.ForegroundColor = ConsoleColor.White;
            Console.Clear();


            bool isRunning = true;
            Console.WriteLine("\t\t\t HOW MANY ITEMS DO YOU WANT ON YOUR LIST?");
            
            int listno = int.Parse (Console.ReadLine());
            string[] todo = new string[listno];

            for (int i = 0; i < todo.Length; i++)
            {
                Console.WriteLine("\t\t\t WHAT IS YOUR NEXT ITEM?");
                todo[i] = Console.ReadLine();
            }
            Console.WriteLine("\n");
            for (int i = 0; i < todo.Length; i++)
            {
                Console.WriteLine(todo[i]);
            }

                Console.ReadKey();
                Console.Clear();
                while (isRunning)
                {

                    Console.WriteLine(" 1 = Veiw The List \n 2 = Add To List \n 3 = Remove From List \n 4. = Exit");



                    int Read = int.Parse(Console.ReadLine());


                    if (Read == 1)
                    {
                        for (int i = 0; i < todo.Length; i++)
                        {
                            Console.WriteLine(todo[i]);
                        }
                    }
                    
                    if (Read == 4)
                    {
                        isRunning = false;
                    }

                    if (Read == 2)
                    {
                        string[] temp;
                        temp = new string[todo.Length + 1];
                        for (int i = 0; i < todo.Length; i++)
                        {
                            temp[i] = todo[i];
                        }
                        Console.WriteLine("What Do You Want To Add To Your List");
                        temp[todo.Length] = (Console.ReadLine());
                        todo = temp;
                        //ask the user what they want to add
                      
                        

                       
                        //then set old array equal to new array
                    }


                    if (Read == 3)
                    {
                        

                        Console.WriteLine("What Do You Want To Delete?");
                        string remove = (Console.ReadLine());
                        if (todo.Contains(remove) == false)
                        {
                            Console.WriteLine("There Is No Such Thing");
                            Console.ReadKey();
                        }
                        else
                        {
                            string[] temp;
                            temp = new string[todo.Length - 1];
                            for (int i = 0, j = 0; i < todo.Length; i++, j++)
                            {
                                if (remove == todo[i])
                                {
                                    j--;
                                }
                                else
                                {
                                    temp[j] = todo[i];
                                }

                               
                                //have an if statement to check if the item isnt the remove string
                                // take all your stuff and put it in temp from todo
                            }
                            todo = temp;
                        }
                        //make a new array that is 1 less in size than the old one
                        //ask for the item number that you want to remove
                        //forloop thru the array and check, if the item, is found
                        //when it is, skip over it, but transfer the rest
                        //then set the old array = new array
                    }


                    
                }
            Console.ReadKey();

            //1. View the list
            //2. Add to the list
            //3. Remove from the list
            //4. Exit
            //store the items, that they type in

        }
    }
}
