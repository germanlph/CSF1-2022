using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _4Thursday
{
    class BranchingSwitch
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Branching: Switch statements");

            /*
             * Switches are the other form of branching.
             * Not as flexible as IF (don't handle ranges well)
             * But GREAT at exact matching.
             * 
             * SYNTAX:
             * 
             * switch (valueToCheck)
             * {
             *      case TEST:
             *          //code
             *          break;
             *          
             *      default:
             *          //code
             *          break;
             * }
             */

            Console.WriteLine("Enter a number: ");
            short userNbr = short.Parse(Console.ReadLine());

            switch (userNbr)
            {
                case 1:
                    Console.WriteLine("You typed 1");
                    break;
                case 2:
                case 3:
                case 4:
                case 5:
                case 42:
                    Console.WriteLine("You typed 2-5 or 42");
                    //Treat multiple cases like an OR ||
                    break;
                default:
                    //Optional, has no test, is like an else
                    Console.WriteLine("You typed something else");
                    break;
            }//end switch

            // If you see the error "cannot fall out", you missed a break;

            // Note that although we did ranges above, this should illustrate that ranges
            // do NOT work well with switches

            // Switches are commonly used for menus!
            Console.WriteLine("\n\nPlease choose a program to run.\n 1) Numbers\n2) Drawing\n3) Water\n4) Change");
            string userOption = Console.ReadLine().ToUpper();

            switch (userOption)
            {
                case "1":
                case "1)":
                case "NUMBERS":
                case "N":
                    Console.WriteLine("1, 2, 3, 4, 5, 6, ahhhhhhhhhhhhhhh!");
                    break;
                case "2":
                case "2)":
                case "DRAWING":
                case "D":
                    // The code in the case statement could go on for many lines
                    // We could put an ascii drawing in here from chris.com
                    Console.WriteLine(@"Lookie! I made a sword!

                        0=={:::::::::::::::::::::>

                    ");
                    break;
                case "3":
                case "3)":
                case "WATER":
                case "W":
                    Console.WriteLine("Water Lab!");
                    // You can copy/paste the code from your water lab here.
                    break;
                case "4":
                case "4)":
                case "CHANGE":
                case "C":
                    Console.WriteLine("Change lab!!!");
                    // We can add the change lab code here
                    break;
                default:
                    Console.WriteLine("Input unrecognized. Please restart the program and try again");
                    break;
            }// end switch
        } // end of SVM
    }// end of class
}// end of namespace
