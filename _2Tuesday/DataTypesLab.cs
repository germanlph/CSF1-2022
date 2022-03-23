using System;

namespace _2Tuesday
{
    class DataTypesLab
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Data Types Lab");

            /* 
             * Declare and initialize variables 
             * of 10 different data types.
             * Use at least:
             * 
             *      1 string
             *      1 whole number type
             *      1 floating point type
             *      1 bool
             *      1 char
             *      
             * Display each of them with a Console.WriteLine();
             * 
             * Additionally, create two variables - one that uses 
             * the min and one that uses the max value for at
             * least one whole number type and display them.
             */

            string location = "Kansas";
            string weather = "lame";
            int days = 2;
            int temp = 72;
            decimal symptom = 101.5m;
            bool feelingsOnTheMatter = true;
            bool wantItToChange = true;
            char badGrade = 'F';
            char passingGrade = 'C';
            char topGrade = 'A';

            Console.WriteLine("I live in " + location + " and the weather here right now is " + weather);
            Console.WriteLine("In fact, it's been " + weather + " for " + days + " days");
            Console.WriteLine("I wish it were currently " + temp + " degrees, because this " + weather + " weather makes me " +
                " as sick as a " + symptom + " fever");
            Console.WriteLine("Do I like the ideas of seasons? " + feelingsOnTheMatter);
            Console.WriteLine("Do I still wish spring would hurry up? " + wantItToChange);
            Console.WriteLine("So I will give this current weather a grade of " + badGrade);
            Console.WriteLine("I'd be happy with weather that was about on the level of a " + passingGrade);
            Console.WriteLine("But what I really want is grade " + topGrade + " weather");


            Console.WriteLine("The maximum of an int is: " + Int32.MaxValue); // What happens after I add a period?*******
            Console.WriteLine("The minimum value of a byte is: " + byte.MinValue); // Framework Class Library


            Console.WriteLine("Something on this \n line.");
        }
    }
}
