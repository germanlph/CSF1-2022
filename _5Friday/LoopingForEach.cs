using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _5Friday
{
    class LoopingForEach
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Looping with For Each");
            Console.Title = @"\\\\\****** For Each ******/////";

            /* FOREACH is a specialized loop made for collections.
             * It provides READONLY access
             * You can see the values in the collection, but you
             * can NOT change them in a foreach.
             * 
             * foreach (DATATYPE MADEUPNAME in COLLECTION)
             * {
             *      //code to run with MADEUPNAME
             * }
             * 
             * This is the easiest, least error-prone loop. 
             * It is preferred in many program contexts,
             * but we lose some flexibility with it.
             * 
             * The foreach-loop is versatile.
             * We will end up using them in strings,
             * string arrays, and even DataTables.
             */

            string[] colors = { "red", "blue", "green", "purple", "black", "pink" }; // inline declare and initialize array

            foreach (string color in colors)
            {
                Console.WriteLine(color);
                //colors[2] = "peachpuff";// allowed but a VERY BAD IDEA
                //Don't try to change a collection while you're looping inside of it.
            }//end foreach

            Console.WriteLine();

            int[] gradeScores = { 100, 80, 42, 75, 2 };

            foreach (int bob in gradeScores)// the name inside the loop can we whatever I want
            {
                Console.WriteLine(bob);
            }// end foreach

            // MINI LAB
            // Print out each of the prices in the
            // below array to the screen with currency formatting:

            Console.WriteLine();

            decimal[] cartPrices = { 12.99m, 2, 9.99m, 10, 20 };

            foreach (decimal p in cartPrices)
            {
                Console.WriteLine($"{p:c}");
            }

            // Let's total up all of the prices in the cart.
            // Create a running total variable so we can 
            // print out the total AFTER the foreach

            decimal totalSale = 0;// always give a running-total variable an initial value

            Console.WriteLine("\nThank you for purchasing from WeRProgrammers.Inc\n");

            foreach (decimal price in cartPrices)
            {
                totalSale += price;
                //totalSale = totalSale + price;//another option
                Console.WriteLine("After adding {0:c}, the total is now: {1:c}", price, totalSale);
            }// end foreach

            Console.WriteLine("\nYour total purchase is: {0:c}", totalSale);

            // Remember, a string is a collection of characters
            string letters = "abcdefghijklmnopqrstuvwxyz";

            foreach (char c in letters)
            {
                Console.WriteLine(c);
            }

            Console.WriteLine(letters.Length + " total letters");

            //string backwards = letters.Reverse().ToString();

        }
    }
}
