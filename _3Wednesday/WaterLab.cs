using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _3Wednesday
{
    class WaterLab
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Lab 3A Water");

            /*
             * Write a program that will:
             * 
             *      - Assume that a gallon of water weighs 8.33 pounds
             *      - Prompt the user to enter a number of gallons
             *      - Display the total weight of the water in pounds
             *      
             * Test with something simple like 2 to start.
             */

            const decimal GALLON_WEIGHT = 8.33m;

            Console.WriteLine("Please enter an amount of water in gallons: ");
            string userInput = Console.ReadLine();
            decimal userInputGallons = decimal.Parse(userInput);
            Console.WriteLine("\nThat many gallons of water weighs: {0:0.00} pounds", GALLON_WEIGHT * userInputGallons);

        }
    }
}
