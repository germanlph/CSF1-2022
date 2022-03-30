using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _4Thursday
{
    class InputLab
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Input Lab!");

            /*
             * Ask the user for the following info:
             *     - Favorite season
             *     - Favorite car
             *     - Favorite TV show
             *     - How much they spent on cable last year
             *      
             * Give them a response using all of their info
             * in one statement at the end using string formatting or 
             * interpolation. Use currency formatting when you display 
             * the cable bill.
             */

            Console.WriteLine("What is your favorite season?");
            string favSeason = Console.ReadLine();
            Console.WriteLine("What is your favorite car?");
            string favCar = Console.ReadLine();
            Console.WriteLine("What is your favorite TV show?");
            string favShow = Console.ReadLine();
            Console.WriteLine("How much money did you spend on cable last year?");
            string cableExpenseString = Console.ReadLine();
            decimal cableExpense = decimal.Parse(cableExpenseString);

            Console.WriteLine($"Your favorite season is {favSeason}.\nYour favorite car is {favCar}." +
                $"\nYour favorite TV show is {favShow}.\n" +
                $"You spent {cableExpense:c} on cable last year? Phew!");

        }
    }
}
