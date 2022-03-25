using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _3Wednesday
{
    class Change
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Lab 3B Change");

            /* 
             * Write a program that will:
             * 
             * -Prompt the user to enter an amount of dollars and
             *       cents. For example: 1.18
             * -Display the number of quarters, dimes, nickels,
             *       and pennies to make that amount.
             *          
             * Ex: If they entered 1.18 it should say:
             *  4 quarters, 1 dimes, 1 nickels, 3 pennies
             *  
             * Ex: If they entered 2.02 it should say:
             *  8 quarters, 0 dimes, 0 nickels, 2 pennies
             *  
             * Complete the water lab FIRST!
             * 
             * HINT:  Break it into small problems 
             * (how do I figure out the quarters, then dimes, etc)
             */

            //Get user input
            Console.WriteLine();
            Console.Write("Please enter an amount of dollars and cents: $");
            string userInput = Console.ReadLine();

            //Convert/Parse user input to int * 100 
            decimal userDecimal = decimal.Parse(userInput) * 100;
            int user = (int)userDecimal;

            //Compute quarters
            int quarters;
            quarters = user / 25;
            user = user % 25;

            //compute dimes
            int dimes;
            dimes = user / 10;
            user = user % 10;

            //compute nickels
            int nickels;
            nickels = user / 5;
            user = user % 5;

            //compute pennies
            int pennies = user;


            //write out results to user
            Console.WriteLine("\nYou have:\n{0} Quarters\n{1} Dimes\n{2} Nickels" +
                "\n{3} Pennies", quarters, dimes, nickels, pennies);


            //Console.WriteLine("Please enter an amount of dollars and cents (include the decimal)");

            //string userEntry = Console.ReadLine();
            //decimal dollarAmount = Convert.ToDecimal(userEntry);
            ////dollarAmount = dollarAmount * 100;
            ////int convertedDollars = Convert.ToInt32(dollarAmount);

            //int quarters, dimes, nickels, pennies;

            //quarters = (int)(dollarAmount / .25m);
            //dollarAmount = dollarAmount % .25m;
            //dimes = (int)(dollarAmount / .10m);
            //dollarAmount = dollarAmount % .10m;
            //nickels = (int)(dollarAmount / .05m);
            //dollarAmount = dollarAmount % .05m;
            //pennies = (int)(dollarAmount / .01m);

            //OR:

            ////quarters = convertedDollars / 25;
            ////dimes = (convertedDollars - (quarters * 25)) / 10;
            ////nickels = (convertedDollars - (quarters * 25) - (dimes * 10)) / 5;
            ////pennies = (convertedDollars - (quarters * 25) - (dimes * 10) - (nickels * 5));

            //Console.WriteLine("You have {0} quarters, {1} dimes," +
            //"{2} nickels, and {3} pennies.", 
            //    quarters, 
            //    dimes, 
            //    nickels, 
            //    pennies);


            #region A Complicated Solution

            //    //Shinijami working
            //    #region Declare Local Vars
            //    const double QUARTER = 25, DIME = 10, NICKEL = 05, PENNY = 01;
            //    double[] coinValue = new double[] {QUARTER, DIME, NICKEL, PENNY };
            //    string[] coinName = new string[4] { "Quarter", "Dime", "Nickel", "Penny" };
            //    int[] change = new int[4];
            //    //int quarters, dimes, nickels, pennies;
            //    double totalChange;
            //    double currentChange;
            //    //user input
            //    string userInput = " ";
            //    bool running = true;
            //    int userOption;
            //    //misc
            //    string space = " ";
            //    #endregion

            //    while (running)
            //    {
            //        #region Gather User Number
            //        Console.WriteLine("Please enter a dollar amount in the format of X.YZ");
            //        userInput = Console.ReadLine();
            //        totalChange = double.Parse(userInput);
            //        currentChange = totalChange *100;
            //        #endregion

            //        bool isValid = false;
            //        do
            //        {                  
            //            Console.WriteLine("\nWould you like to...\n0: find max Quarters\n1: Find max Dimes\n"+
            //            "2: Find max Nickels\n3: Find max Pennies\n4: Find out what a cashier would give you");
            //            userInput = Console.ReadLine();
            //            //userOption = int.Parse(userInput);

            //            switch (userInput) { 
            //                case "0":
            //                case "1":
            //                case "2":
            //                case "3":
            //                    #region Call Method FINDCHANGE to get max of a coin

            //                    FindChange(currentChange, int.Parse(userInput), coinValue, change);
            //                    Console.WriteLine("The max number of {0} you will get is {1}",
            //                        coinName[int.Parse(userInput)], change[int.Parse(userInput)]);
            //                    break;

            //                    #endregion
            //                case "4":
            //                    #region Find what a cashier would give you

            //                    Console.WriteLine("We are going to find out what a cashier SHOULD give you");
            //                    for (int i = 0; i < change.Count(); i++) {
            //                        currentChange = FindChange(currentChange, i, coinValue, change);
            //                        //Console.WriteLine(i);
            //                    }
            //                    PrintAllChange(change, coinName);
            //                    break;

            //                    #endregion
            //                default:
            //                    #region ID107 Handling

            //                    Console.WriteLine("Im sorry but we didnt understand that, could you please print it again?");
            //                    isValid = true;
            //                    break;

            //                    #endregion
            //            }//end switch
            //        } while (isValid);
            //        #region Accept input to terminate menu
            //        Console.WriteLine();
            //        Console.WriteLine("press '0' with out the 's to terminate program\nAnything else to re-run");
            //        userInput = Console.ReadLine();
            //        if (userInput == "0")
            //            running = false;
            //        #endregion
            //    }//end While
            //}//end Main and the fun begins

            //#region Method FINDCHANGE accepts current money, what coin and calculates how many

            //static double FindChange(double currentChange, int coin, double[] coinValue, int[] change)
            //{
            //    change[coin] = (int)(currentChange / coinValue[coin]);
            //    currentChange %= coinValue[coin];
            //    return currentChange;
            //}//end method

            //#endregion

            //static void PrintAllChange(int[] change, string[] coinName) {
            //    for (int i = 0; i < change.Count(); i++) {
            //        //Console.WriteLine(i);
            //        Console.WriteLine(coinName[i] + ": " + change[i]);
            //    }//end forLoop

            #endregion

        }
    }
}
