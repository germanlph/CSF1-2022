using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2Tuesday
{
    class CastingLab
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Casting Lab!");

            //some variables to use:
            byte puddle = 100;
            short pond = 29456;
            int lake = 100000; //one hundred thousand
            long ocean = 5;

            //1. cast the value of lake into ocean and display it
            //2. cast the value of pond into puddle and display it
            //3. cast the value of pond into ocean and display it
            //4. cast the value of ocean into lake and display it

            //for each casting, include a comment categorizing it as:
            //implicit casting
            //explicit casting
            //explicit casting with truncation

            //REMEMBER.... right to left thinking....

            ocean = lake; // Don't need an explicit cast
            Console.WriteLine("Implicitly cast smaller lake into larger ocean: " + ocean);

            puddle = (byte)pond;
            Console.WriteLine("Explicit cast with truncation - puddle is now: " + puddle);

            ocean = pond;
            Console.WriteLine("Implicitly cast smaller into larger - ocean is now: " + ocean);

            lake = (int)ocean;
            Console.WriteLine("Explicit cast larger into smaller - lake is now: " + lake);
        }
    }
}
