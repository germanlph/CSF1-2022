using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _4Thursday
{
    class Arrays
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Arrays");

            /*
             * An array stores a fixed-size sequential collection of 
             * objects of the same type. 
             * 
             * An array is used to store a collection of 
             * data, but it is often more useful to think of an array as 
             * a collection of variables of the same type.
             * 
             * Standard Arrays: 
             * 
             * - Have a fixed size (can't change it programmatically)
             * - The size is called the Length (1-based counting)
             * - Uses 0-based counting for the positions of the indexes.
             * - Type safe
             * - Use the "new" keyword to call the "constructor" that builds the object
             */

            //One way to declare an array: declare with a set Length (1-based counting)
            string[] dresser = new string[4];
            // Created a string array named dresser and assigned it the length of 4

            // Now we can assign the values individually
            // You must first initialize them before you can use them.
            // You can initialize them in any order
            dresser[0] = "shirts"; // in the drawer with an idex of 0, put "shirts"
            dresser[1] = "pants";
            dresser[3] = "socks";
            dresser[2] = "shorts";

            // Each of the indexes called by dresser[indexNumber]
            // is a variable that you can use in your program.

            Console.WriteLine("{0} are in the drawer with an index of 2", dresser[2]);

            //MINI LAB - Write the last index to the screen using string interpolation
            Console.WriteLine($"{dresser[3]} is in the last drawer.");

            // You can reassign the drawers (index) of the array just like normal variables
            dresser[3] = "t-shirts";

            Console.WriteLine("{0} is in the 4th drawer with an index of 3", dresser[3]);

            Console.WriteLine("{0} is in the index 1 and {1} is in the index 2", dresser[1], dresser[2]);

            // To explore an object in intellisense use a period.
            Console.WriteLine(dresser.Length + " is the Length of the array");

            // The first index is always 0
            Console.WriteLine("The first item is " + dresser[0]);

            // The last index is always 1 less than the Length
            Console.WriteLine("The last item is " + dresser[dresser.Length -1]);// equivalent dresser[3]

            // Another array, created the long way.
            // The long was is best if you don't know what all you want to put
            // in the boxes. You MUST still know how many boxes you need.
            decimal[] prices = new decimal[5];
            //Generally collections have a plural name

            prices[0] = 24.99m;
            prices[1] = 100;
            prices[2] = 50;
            prices[3] = 9.75m;

            //prices[6] = 25; //you will get a runtime error
            // The exception would be for  outside the bounds if you try to access or use 
            // and index that cannot exist
            prices[4] = 199;

            // Just like teh string array, you can write a single index's
            // value to the screen
            Console.WriteLine(prices[1]);

            //... but you cannot write the entire collection
            Console.WriteLine(prices);
            // The compiler does not know how to format complex datatypes
            // by default, so attempting to print a complex datatype to the screen
            // will usually result in an output of the namespace.className where the 
            // class is defined.

            // You can do math with the contents of the array
            //decimal totalSale = prices[0] + prices[1] + prices[2] + prices[3] + prices[4]; // This is lengthy

            decimal totalSale = prices.Sum();

            Console.WriteLine($"Total sale: {totalSale:c}");

            Console.WriteLine("\nPrices has {0} indexes. \n1st Index holds {1:c} and the last index holds {2:c}",
                prices.Length, prices[0], prices[prices.Length -1]);

            // Sort() is called from the Array class. It sorts
            // the indexes of the specified array from lowest to
            // highest value by number or from a-z for alphas. 
            // It is referred to as an "ascenting sort", as it ascends
            // from the lowest to the highest value.
            // Syntax Array.Sort(someArray);

            Array.Sort(prices);

            Console.WriteLine("\nPrices has {0} indexes. \n1st Index holds {1:c} and the last index holds {2:c}",
                prices.Length, prices[0], prices[prices.Length - 1]);

            Console.WriteLine();

            // To get a descending sort (highest to lowest)
            // there is not a direct method.
            // You have to .Sort() the array first
            // and then run .Reverse() which just flips the contents
            // of the indexes

            // Since we've already sorted...
            Array.Reverse(prices);

            Console.WriteLine("\nPrices has {0} indexes. \n1st Index holds {1:c} and the last index holds {2:c}",
                prices.Length, prices[0], prices[prices.Length - 1]);


            // For fun:
            //Random chance = new Random();
            //int randomIndex = chance.Next(5);
            //Console.WriteLine("Random is {0:c} at the index of {1}", prices[randomIndex], randomIndex);



        }
    }
}
