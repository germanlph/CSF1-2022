using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSF1
{
    class DataTypes
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Let's do more variables!");
            // This will fail unless I set DataTypes as the startup object in the Project Properties

            Console.WriteLine("Data Types: Bob Sure Is Loving - BSIL");
            // Byte 8-bit
            // Short 16-bit
            // Int 32-bit
            // Long 64-bit
            // Google: C# numeric types
            // https://docs.microsoft.com/en-us/dotnet/csharp/language-reference/builtin-types/integral-numeric-types

            // declare
            byte byteNbr;

            // Initialize
            byteNbr = 0;

            // Reassign
            byteNbr = 255;

            // byteNbr = 256;
            // Too big!

            // declare and initialize
            short shortNbr = -1234;
            int intNbr = 12392823;
            long longNbr = 123456789123456789;

            // The name of a variable doesn't really matter,
            // it can be anything you want, but....
            // good variable names are typically descriptive of what you are storing
            // or how the vriable will be used.
            // Shoe store: shoe, shoeBox

            // Lesser-used C# integer variant
            sbyte sbyteNbr = -7;

            // MINI LAB!!!!! Declare and initialize a ushort, uint and a ulong
            short labShort = -10;
            ushort labUShort = 32768;
            int labInt = -20;
            uint labUInt = 2147483648;
            long labLong = -30;
            ulong labULong = 9223372036854775808;

            //int someInt = 22.7;
            // without casting, I can't put this value into an int
            // with casting, it would truncate to a whole number
            // (chop off the decimal)

            // Floating point Data Types:
            // These support decimal values
            float smallFraction = 12; // 32-bit, 45 digits, 7-digit precision
            double smallFraction2 = 12.9; // 64-bit, 324 digits, 14-digit precision
            // double is the default floating point value
            decimal smallFraction3 = 23; // decimal supports
            // the greatest accuracy... 128-bit, 29 digit precision

            //float floatNbr = 29.345;
            float anotherFloat = 234234.2342343f;
            // I can use the f or the F, doesn't matter

            decimal decimalNbr = 23432.234234234m;
            // only works with m or M (Money!!!)

            double doubleNbr = 234232.23423423;
            // no suffic needed because .net sees a floating point
            // value as already being a double

            Console.WriteLine("Calculation result: " + (anotherFloat / 1.5f));

            // Bool accepts only values of true or false
            // no quotes.. quotes would make it a string

            bool isTheDoctor = false;

            Console.WriteLine("Are you the Doctor? " + isTheDoctor);

            isTheDoctor = true;
            // reassign

            Console.WriteLine("Are you the doctor? " + isTheDoctor);

            // The char datatype accepts a single character value in single quotes
            char myLetter = 'A';
            //char anotherLetter = "A";
            //char someOtherLetter = 'abc';
            char symbol = '%';

            Console.WriteLine("Symbol is: " + symbol +
                " and letter is " + myLetter);

            // string accepts any number of characters in double quotes
            string firstName = "James";
            Console.WriteLine(firstName);

            string lastName = "Bond";
            Console.WriteLine(lastName);

            // With some creative concatenation we can do a little formatting 
            // of our string outputs
            Console.WriteLine(firstName + " " + lastName);
            Console.WriteLine(firstName + ' ' + lastName);

            // MINI-LAB! Use concatenation to write out James Bond's signature introduction

            Console.WriteLine("Name's " + lastName + ", " + firstName + " " + lastName + ".");

        }// static void Main()
    }// class
}// namespace
