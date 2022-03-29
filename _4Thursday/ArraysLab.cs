using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _4Thursday
{
    class ArraysLab
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Arrays Lab!");

            /*
             * REQUIREMENTS:
             * 1) Ask the user for 5 scores (1 at a time)
             * 2) Display the high, low and average score
             *  
             * The scores should be ones from a test, like 0-100
             */

            Console.WriteLine("Enter 5 scores to get the min, max and average.");

            Console.WriteLine("Enter the first score");
            string firstString = Console.ReadLine();
            Console.WriteLine("Enter the second score");
            string secondString = Console.ReadLine();
            Console.WriteLine("Enter the third score");
            string thirdString = Console.ReadLine();
            Console.WriteLine("Enter the fourth score");
            string fourthString = Console.ReadLine();
            Console.WriteLine("Enter the fifth and last score");
            string fifthString = Console.ReadLine();

            int[] scores = new int[5];
            scores[0] = int.Parse(firstString);
            scores[1] = int.Parse(secondString);
            scores[2] = int.Parse(thirdString);
            scores[3] = int.Parse(fourthString);
            scores[4] = int.Parse(fifthString);

            Array.Sort(scores);
            int highest = scores[4];
            int lowest = scores[0];
            double average = scores.Average();

            Console.WriteLine("The highest score you entered was {0}. The lowest was {1}. The average score was {2:n2}", highest, lowest, average);

        }
    }
}
