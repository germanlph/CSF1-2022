using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _5Friday
{
    class LoopingWhile
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Looping While!");
            Console.Title = "***** While Loops *****";

            /*While loop - best for when you want to run code
             * an indeterminable number of times
             * (0 to ???)
             * 
             * COUNTER
             * 
             * while (CONDITION)
             * {
             *      //code to run
             *      UPDATE
             * }
             */

            int cookie = 1;//counter
            while (cookie <= 5)// CONDITION - no semicolon
            {
                // Code to run
                Console.WriteLine("Yum! You have eaten " + cookie + " cookie" + (cookie == 1 ? "" : "s"));
                cookie++;//update
            }// end while

            // Because you can set the update conditionally
            // it is easy to forget it... or to accidentally create
            // an infinite loop by using a bad condition

            //long number = 1;//counter
            //while (number > 0) // condition
            //{
            //    Console.WriteLine(number);
            //    number++;//update
            //}// end while

            // Virtually every time you have an infinite loop, you wrote the condition wrong.

            // MINI LAB
            // Write a while loop that start with 10 bags of groceries
            // and counts down as they are unloaded until there are none remaining.
            int groceryBags = 10;

            while (groceryBags > 0)
            {
                Console.WriteLine("You have {0} bags of groceries left to unload", groceryBags);
                groceryBags--;
            }// end while

            // It is most common to use a while loop with a bool
            // for a counter as this allows us to conditionally
            // change the bool for when we want to exit the loop

            bool moreBags = true;//counter

            while (moreBags)//condition just needs to true
            {
                Console.WriteLine("\n\nYou have unloaded some groceries");
                //ask the user if they have more bags!
                // If not, we are done!
                Console.WriteLine("Do you have more bags? Y/N: ");
                //ConsoleKey
                ConsoleKey userAnswer = Console.ReadKey(true).Key;
                if (userAnswer == ConsoleKey.N)
                {
                    moreBags = false;
                }// end if
            }//end while

            // PROGRAMMER REAL WORLD EXAMPLE
            // for loops are great for a specific number of times to loop.
            // They are ideal when you know the COUNT

            // while loops are great for an indeterminate number of times.
            // They are ideal when you the CONDITION

            Console.Write("Would you like to play a game? Y/N: ");
            ConsoleKey runProgram = Console.ReadKey(true).Key; //Counter

            while (runProgram == ConsoleKey.Y)
            {
                Console.WriteLine("\nYou win!");

                Console.Write("Play again? Y/N: ");
                runProgram = Console.ReadKey(true).Key;
            }//end while



        }// end Main()
    }// end class
}//end namespace
