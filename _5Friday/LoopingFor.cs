using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _5Friday
{
    class LoopingFor
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Looping with FOR");
            Console.Title = "-======== LOOPING WITH FOR ========-";

            /*
             * FOR LOOP SYNTAX
             * 
             * for (COUNTER/INITIALIZER; CONDITION; UPDATE)
             * {
             *      //code to run
             * }
             */

            /*
            * Some books refer to COUNTER as INITIALIZER
            * //! Mnemonic device: ICU 
            * 
            * Counter - the starting point where you initailize a 
            * variable that is used to check the condition. The 
            * counter gets updated after each pass through the loop.
            *
            * Condition - A Boolean statement that tells the loop
            * when to stop. It is checked before each pass.
            * 
            * Update - the change to the counter after each 
            *          pass of the loop (increment, decrement, etc.)
            * 
            * Remember: a for loop is best used when you know exactly 
            *           how many times you want to run the code
            *           
            * For loops are common and useful in many algorithms 
            * and methods in the C# language
            */

            // NOTE below that the COUNTER is declared and initialized
            // within the for loop and that it is only accessible within the for loop
            for (int candyBar = 1; candyBar <= 7; candyBar++)
            {
                Console.WriteLine("You have " + candyBar + " candy bars");
            }// end of FOR

            // MINI LAB
            // Start with 3 grapes and eat until you have had 15.
            // Eat 3 at a time.
            for (int grapes = 3; grapes <= 15; grapes = grapes + 3)
            {
                Console.WriteLine("You have eaten " + grapes + " grapes.");
            }// end of FOR

            Console.WriteLine();
            // Count to 20, but skip 13
            for (int count = 1; count <= 20; count++)
            {// 1 cw ++, 2 cw ++, 3 cw ++, 4 cw ++, 5 cw ++, 6 cw ++, 7 cw ++, 8 cw ++, 9 cw ++, 10 cw ++, 11 cw ++, 12 cw ++, 13 NO cw ++, 14 cw ++......
                if (count != 13)// at 13 this is false
                {
                    Console.WriteLine(count);
                }
            }// end of FOR

            Console.WriteLine();
            for (int count = 1; count <= 20; count++)
            {
                if (count == 13)
                {
                    // do nothing
                }
                else
                {
                    Console.WriteLine(count);
                }
            }// end of FOR

            Console.WriteLine();
            // The continue keyword stops teh current iteration of the loop
            // and moves on to the next iteration. Let's do the same example
            // above, but with continue:
            for (int count = 1; count <= 20; count++)
            {
                if (count == 13)
                {
                    continue;
                }
                Console.WriteLine(count);
            }// end of FOR




            // From user input
            Console.WriteLine("\n\nHow many cookies do you want?");
            int userCookies = int.Parse(Console.ReadLine());

            for (int cookie = 1; cookie <= userCookies; cookie++)
            {
                Console.WriteLine("You ate a cookie! " + cookie);
            }

            // Running-total Variable
            // Create a variable in an outer scope; allows you
            // to use it and make changes to it from an inner scope

            // Start by creating your running total variable.
            // This can be numeric or a string that you just track into onto
            string listOfNames = "";// typically an empty string (in the case of strings);

            Console.WriteLine("\n\nREGISTRATION\n");
            Console.WriteLine("How many people would you like to register to Comic Con?");
            int totalRegistrations = Convert.ToInt32(Console.ReadLine());

            for (int reg = 0; reg < totalRegistrations; reg++)
            {
                Console.WriteLine("Please enter a name to register: ");
                listOfNames += Console.ReadLine() + "\n";
            }

            Console.WriteLine($"\nYou have registered: \n{listOfNames}");

            // We can loop through an array with a for loop
            decimal[] prices = { 15.95m, 9.99m, 20, 10, 9.75m }; //new decimal[5]

            for (int i = 0; i < prices.Length; i++)
            {
                Console.WriteLine("At the index of {0} is {1:c}", i, prices[i]); //prices[1]
            }// end for

            Console.WriteLine("The total is: {0:c}", prices.Sum());


        }// end static void Main()
    }// end of LoopingFor.cs class
}// end of namespace
