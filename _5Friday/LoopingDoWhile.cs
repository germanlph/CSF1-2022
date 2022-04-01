using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _5Friday
{
    class LoopingDoWhile
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Looping with DoWhile");
            Console.Title = "---------------> Do While <------------------";

            /* Do While Loop - best for when you want to run code
             * an indeterminable number of times BUT
             * at least once!!!
             * (1 to ???)
             * 
             * COUNTER
             * 
             * do
             * {
             *      //code to run
             *      UPDATE
             *      
             * } while (CONDITION);
             */

            int cookie = 1;//Counter/Initializer

            do
            {
                Console.WriteLine("Yum! You have had " + cookie + " cookie" + (cookie == 1 ? "" : "s"));
                cookie++;
            } while (cookie <= 5);

            // The below do while is not great. It doesn't do much other than show an example of a do while
            // A do while will ALWAYS run at least once
            Console.WriteLine("\n\nDo you want to run this program?");
            string runProgram = Console.ReadLine().ToUpper();

            do
            {
                Console.WriteLine("Success! The program is running!");
                // Could be many lines of code here
                Console.WriteLine("Do you want to keep going?");
                runProgram = Console.ReadLine().ToUpper();// UPDATE
            } while (runProgram == "Y" || runProgram == "YES"); // CONDITION
            // Don't forget the ;
            // The above example should have been a while loop because it may not need
            // to run at all if the user says anything but YES from the start

            // Real-world example
            bool repeat = true; //Assume they want to run the program
            // Generally you write a while or do while to run forever
            // and just deal with it when they want to stop.
            // The above bool, repeat, is our counter

            do
            {
                // do while ALWAYS runs once, at least! Best for menus!!!
                Console.WriteLine("-= Wekk Ant Eeru Phone Company =-");
                Console.WriteLine("B) Bill\nP) Payment\nS) Service\nX) Exit");
                string userChoice = Console.ReadLine().ToUpper();

                // Clear the console after input
                Console.Clear();

                switch (userChoice)
                {
                    case "B":
                    case "BILL":
                        Console.WriteLine("Your balance is $500.00\n\n");
                        break;

                    case "P":
                    case "PAYMENT":
                        Console.WriteLine("Your payment is pending...\n\n");
                        break;

                    case "S":
                    case "SERVICE":
                        Console.WriteLine("We will be there in 1-30 days. Someone must be present when we arrive.\n\n");
                        break;

                    case "X":
                    case "EXIT":
                        Console.WriteLine("Thank you for calling.");
                        repeat = false;// UPDATE
                        break;
                    default:
                        Console.WriteLine("That was not a valid option.\nA $5 invalid option fee has been applied to your bill.");
                        break;
                }// end switch

            } while (repeat);// Condition
        }// end main()
    }// end class
}// end namespace
