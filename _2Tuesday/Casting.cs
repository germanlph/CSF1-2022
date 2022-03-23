using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2Tuesday
{
    class Casting
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Casting!!!");

            #region Casting Notes
            /*
             * Casting is copying the value from a variable of one
             * type to a variable of a different, but similar type.
             * 
             * IMPLICIT Casting: copies the contents from a smaller
             * container to a larger container (aka data type).
             * This always fits.
             */
            #endregion

            byte toothpasteBox = 1;
            short shoeBox = 200;
            int movingBox = 3200;
            long fridgeBox;

            fridgeBox = toothpasteBox; // Implicit casting (byte to a long) (Right to left)
            // Always works because the value can fit in the larger container
            Console.WriteLine("Fridge box has a value of: " + fridgeBox);

            long ovenBox = fridgeBox; // This is not casting. It is just assignment of one long to another.
            Console.WriteLine("The second big box has a value of: " + ovenBox);

            //toothpasteBox = fridgeBox;
            /*
             * EXPLICIT Casting - going from a larget to a smaller
             * container. This requires extra work.
             * 
             * You have to explicitly state the data type you're 
             * casting to. This can create issues if the value won't fit.
             * 
             * Explicit  -> Explain
             */

            toothpasteBox = (byte)shoeBox;
            // Casting the value of shoeBox into toothpasteBox explicitly
            Console.WriteLine("Toothpate box has a value of: " + toothpasteBox);

            Console.WriteLine("And now the value of ShoeBox is: " + shoeBox);

            /*
             * If you explicitly case a LARGER value to a SMALLER container... 
             * you get a mess (truncation)
             * 
             * Above we set movingBox to be 3200. What happens if we
             * copy that value as a byte.
             */

            toothpasteBox = (byte)movingBox;
            // the toothpaste box will be the byte value of the moving box
            Console.WriteLine("toothpaste box is now: " + toothpasteBox);
            Console.WriteLine("Moving box is still: " + movingBox);

            //MINI LAB
            // Cast the long into the int and display it on the screen (fridgeBox into movingBox)
            movingBox = (int)fridgeBox; // right to left thinking

            decimal dec1 = 4.3m;

            decimal dec2 = (decimal)4.3;

            // Both of these lines above are the same.
            // m or M is a shortcut for explicitly casting a double
            // into a decimal

            decimal deathStars = 1.75m;

            // An example of where truncation might actually be useful

            int completedDeathStars = (int)deathStars;

            // This is a great place to introduce "cw -> tab -> tab"
            Console.WriteLine("Out of " + deathStars + " Death Stars, only " + completedDeathStars + " have been completed");
        }
    }
}
