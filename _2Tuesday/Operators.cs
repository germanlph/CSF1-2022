using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2Tuesday
{
    class Operators
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Operators: doing math in code ;)");

            // Concatenation review
            Console.WriteLine(3 + 5); // add two number (math)
            Console.WriteLine(3 + "5"); // append two strings (concatenation)

            Console.WriteLine();

            Console.WriteLine(12 - 8); // subtraction
            Console.WriteLine(10 / 5); // division
            Console.WriteLine(2 * 11); // multiplication

            int legos = 15 + 27;
            Console.WriteLine(legos);

            // We can make a lego car from 9 pieces
            // How many cars can we make?
            int legoCars = legos / 9;
            Console.WriteLine("I can make " + legoCars + " lego cars");

            // What if we want to see what's left?
            // We need modulus
            int leftoverPieces = legos % 9;

            Console.WriteLine("I have " + leftoverPieces + " pieces left");

            Console.WriteLine();

            // We have 75 nails. It takes 30 nails to make a dresser.
            // How many dressers can we make, and how many nails would be left over?
            int nails = 75;
            int dressersMade = nails / 30;
            int nailsLeftOver = nails % 30;
            // for both variables we asked the same question
            // but requested a different piece of the answer
            Console.WriteLine("We made " + dressersMade + " dressers.");
            Console.WriteLine("We ended up with " + nailsLeftOver + " left over nails.");

            Console.WriteLine();

            // MINI LAB
            //  There are 100 cookies and 47 students.
            // How many cookies does each student get and how many
            // cookies are left over?
            int cookies = 100, students = 47;
            int cookiesForEach = cookies / students;
            int cookiesLeft = cookies % students;
            Console.WriteLine("Each student would get " + cookiesForEach + " cookies and " +
                " we would have " + cookiesLeft + " cookies left");

            Console.WriteLine();

            // Unary operators are used to quickly increment/decrement a variable's value
            int hobbits = 2;
            Console.WriteLine("We have here " + hobbits + " hobbits");

            // To add the long way we would say:
            hobbits = hobbits + 1;
            Console.WriteLine("Hobbits is now " + hobbits);
            // The short way, with the unary operator is:
            hobbits++;
            Console.WriteLine("Hobbits is now " + hobbits);

            // to decrease the value by one the long way:
            hobbits = hobbits - 1;
            Console.WriteLine("Hobbits is now " + hobbits);
            //Unary operator
            hobbits--;
            Console.WriteLine("Hobbits is now " + hobbits);

            Console.WriteLine();

            // Above we put the unary operator after the variable name,
            // however, it can also come before the variable, which affects
            // how the incrementation occurs.
            // variable++ is a POST-FIX (happens last)
            // ++variable is a PRE-FIX (happens first)

            int goblins = 12, orcs = 1;
            int badGuys = goblins + orcs++;

            Console.WriteLine("badGuys was assigned first, BEFORE orcs were incremented, so badGuys is " + badGuys);
            Console.WriteLine("After all is said and one, we still incremented orcs " + orcs);

            Console.WriteLine();

            // Page 51 of the wrox book has a short example of operator precedence
            int xBoxGames = 12, psGames = 1;
            int games = xBoxGames + ++psGames;
            Console.WriteLine("Games was assigned AFTER psGames were changed. Games is now " + games);
            Console.WriteLine("psGames became two BEFORE games was assigned. psGames is now " + psGames);
            // could have written this as:
            // psGames = psGames + 1;
            // int games = xBoxGames + psGames;
            Console.WriteLine();

            //Assignment operators:
            //= assigns the value on the right to the variable on the left.
            //It can also be used with mathematical operators to create a 
            //shortcut to do math on a variable and reassign the value back
            //to that variable.
            //examples of assignment operators:
            // +=, -=, *=, /=, %=

            int players = 2;
            Console.WriteLine(players);

            players = players + 4; // long way
            Console.WriteLine(players); // 6

            players += 4; // short way
            Console.WriteLine(players); // 10

            // Multiply the long way
            players = players * 2; // long way
            Console.WriteLine(players); // 20

            players *= 2;// short way
            Console.WriteLine(players); // 40

            // MINI LAB
            // Using the players variable divide by 2 both the short and long way
            // Print your answers to the console

            // Long way
            players = players / 2;
            Console.WriteLine(players); // 20

            // short way
            players /= 2;
            Console.WriteLine(players); // 10

            // Now subtract by 3 both the long and short way
            players = players - 3;
            Console.WriteLine(players); // 7
            players -= 3;
            Console.WriteLine(players); // 4

            // finally, modulus by 2 using the shortcut ONLY
            // ... and print
            players %= 2;
            Console.WriteLine(players); // 0
            // Modulus by 2 will tell you if a number is even or odd.
            // Any odd number would have a remainder of 1.

            Console.WriteLine(67 % 2); // = 1 so odd number
            Console.WriteLine(888 % 2); // = 0 so even number

            Console.WriteLine();

            // Standard mathematical order of opearations sequence (PEMDAS)
            // applies with all operators in a mathematical expression
            int newCalc = 5 + 3 * 6 / 2 + 12; //26
            Console.WriteLine(newCalc);

            int newCalc2 = (5 + 3) * 6 / 2 + 12; //36
            Console.WriteLine(newCalc2 + " WITH parens");
        } // end Main()
    } // end class
} // end namespace
