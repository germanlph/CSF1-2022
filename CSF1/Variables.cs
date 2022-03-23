using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSF1
{
    class Variables
    {
        static void Main(string[] args)
        {
            // Comment
            // // at the start of a line allows you to write a comment,
            // which will be ignored by the compiler.
            // These are single-line comments

            // The Main method is where a C# console app starts to execute

            // In Visual Studio the solution is the collection/portfolio of projects.
            // The projects are like a roadmap detailing how things relate to each other.

            // .NET supports 3 kinds of applications:
            // 1. Windows - Console apps are what we will be using in CSF
            // 2. Web Applications - This is where most of the track will focus.
            // 3. Web Services - these are distributed applications (APIs) (Application Programming Interface)

            // 3 steps to running a program
            // 1. Save (CTRL + S)
            // !Note how VS indicates unsaved code in the tab and to the right of the line numbers.
            // 2. Build (CTRL + SHIFT + B)
            // !Note how VS indicates Build Started and Build Succeeded
            // 3. Run (CTRL + F5)
            // Lucky for us, CTRL + F5 does all 3 in ONE!

            Console.WriteLine("Hello World");

            //Ignores whitespace EXCEPT for inside of a string which means
            //you CANNOT intuitively break a string into 2 lines.

            //! Sing-line Comment closing scopes now.

            /*
             * This is a multi-line comment.
             * 
             * A variable is just a container to hold information. Just like
             * any other container its contents can be changed. Since C# is
             * a type-safe language all variables must have an assigned datatype.
             * The datatype cannot be changed programmatically (in the code).
             * 
             * Declaration, Initialization, & Assignment
             * 
             * Declaration means creating the variable. This requires
             * a datatype and a name.
             * 
             * Initialization means giving it a value for the first time.
             * 
             * Assignment means giving it a value at any time.
             */

            int firstExample; // Declaration

            // string firstExample; I already used that name

            firstExample = 1; // Initialization

            firstExample = 2; // Assignment

            // Often we declare and initialize in the same line

            string name = "Legal Name";

            Console.WriteLine(name);

            name = "Anakin Skywalker";

            Console.WriteLine(name);

            int bigNbr; // Delaration

            bigNbr = 55321; // Initialization
            // Don't use commas for larger numbers

            Console.WriteLine(bigNbr);
            Console.WriteLine(55321);
            Console.WriteLine("55321");
            // All three display the same thing but they are different

            // The functional difference between a string and an int:
            Console.WriteLine("Add 2 ints");
            Console.WriteLine(17 + 25); // 2 literal numbers being added with +

            Console.WriteLine("Add 2 string");
            Console.WriteLine("17" + "25"); // 2 literal strings being added with +

            // Adding two strings together is called "contatenation"

            Console.WriteLine(" something weird is        happening here   ".Trim()); // This is a rabbit trail about string methods

            int kuBasketballPts = 1068;
            int muBasketballPts = 1003;

            Console.WriteLine("KU scored " + kuBasketballPts + " points in 15 games.");
            Console.WriteLine("Total KU & MU points: " + (kuBasketballPts + muBasketballPts));

            /*
             * The () around the numeric calculation trumps the order of operations
             * and makes sure the concatenation happens AFTER the calculation.
             */


            #region Variable Name Requirements

            /*
             * Variable names can only begin with alphabetic characters 
             * or underscores_
             * 
             * After the first character you can use alpha, numeric or underscore
             * with the following limitations:
             * 
             * - They cannot contain spaces
             * - They must contain at least 1 alpha or numeric character
             * - They cannot be a C# reserved keyword (blue font)
             * - They must be unique within their scope {}
             */
            #endregion

            //int kuBasketballPts = 1100;

            // The line above is no good
            // Either:
            // A. You were trying to create a new variable witht the same name.
            // B. You were trying to reassign kuBasketballPts with a new value.
            // If B...

            kuBasketballPts = 1100;

            const int MEANING_OF_LIFE = 42;
            //MEANING_OF_LIFE = 43;
            // You must assign a value to a const when you declare it.
            // You cannot change it later
            // Otherwise it is just like any other variable

            Console.WriteLine("The answer to life is " + MEANING_OF_LIFE);

            // If you are creating multiple variables, some syntax works better than others

            //Declare several variables and initialize them individually
            int steves, endermen, pigs, creepers, zombies;
            //Datatype then name of the variables of that type that you
            //wish to create, separated by commas.

            //You must initialize a variable before you can use it.
            //Now we need to initialize all of the above variables.
            //The initialization order only matters in that you must
            //initialize a variable BEFORE you use it.

            steves = 3;
            pigs = 5;
            zombies = 2;
            endermen = 7;
            creepers = 1;

            // Declare several variables and initialize just one
            int pizzas, burritos, tacos = 10;
            //Console.WriteLine(pizzas); can't use an uninitialized variable

            Console.WriteLine(tacos);

            // pizzas and burritos cannot be used until they are initialized

            int coaches = 2, players = 43, cheerleaders = 10;

            // When declaring multiple variables you CANNOT mix datatypes
            //int mlsTeams = 42, string favTeam = "sporting kc";
            int mlsTeams = 42; string favTeam = "Sporting KC";

            // MINI LAB: Write a sentence using both variables from above with contatenation

            Console.WriteLine("There are " + mlsTeams + " teams in MLS. " + favTeam + " is my favorite one.");

        }
    }
}
