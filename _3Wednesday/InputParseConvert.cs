using System;

namespace _3Wednesday
{
    class InputParseConvert
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Capturing input, parsing and converting");

            #region Input/Output Notes
            /*
             * There are 2 main options for output in console:
             * Write() and WriteLine()
             * 
             * WriteLine() adds a line break after your output.
             * Write() does not.
             * 
             * There are 3 options for Input in console:
             * 
             * Read() - Only takes 1 keystroke of input and stores the
             * ascii value of the key.
             * ReadKey() - Similar idea, but captures the key's
             *              character value (the book uses this to
             *              halt their programs)
             * ReadLine() - Most common. It allows the user to input
             * something and reads the input as a string after they
             * hit enter.
             *  
             * The important part is capturing or using the information
             * they gave you.
             * */
            #endregion

            //string firstName = "Doctor", lastName = "Who";

            //Console.Write(firstName);
            //Console.Write(" " + lastName);
            // No line break after a Console.Write()
            //Console.WriteLine(" - and now a line break...");
            // WriteLine() adds a break AFTER the output

            //Console.WriteLine();
            //Console.ReadKey();// Comment this out after testing

            // Bonus content to show Console.Read();
            //Console.Read();
            //Console.WriteLine("Input some text and lets' see what happens: ");
            //int input = Console.Read();
            //Console.WriteLine(input);

            // ReadLine() lets a user type input, however, you must
            // capture that input or it is lost

            //Console.ReadLine();
            /*
             * You cannot put any code inside the parens of the 
             * ReadLine(). Using ReadLine() by itself without storing
             * the input or using it immediately results in the input 
             * being lost.
             * Using ReadLine()
             * 
             * Step 1 - Explain to the user what to type!
             *          They cannot read your mind.....
             *          
             * Step 2 - Allow them to type by using
             *          Console.ReadLine()
             *          
             * Step 3 - Capture their input into a variable and store it 
             *          or use it immediately
             */

            // Step 1
            //Console.Write("What is your name?");
            //Console.WriteLine();

            // Steps 2 & 3
            //string userName = Console.ReadLine();

            // Now we can do something with the input
            //Console.WriteLine("Hello, " + userName + "!");

            //An example of using the input immediately.
            // We can NOT reuse the input from teh below ReadLine()

            // Step 1
            //Console.WriteLine("What is your quest?");
            //Console.WriteLine();

            // Step 2 let them type and this time I will use that info immediately
            //Console.WriteLine(Console.ReadLine() + " is a silly quest...");

            // MINI LAB - Ask the user for their favourite colour.
            // Tell them their colour back and what you think of it.
            // Use the name they gave you above in the your response
            //Console.WriteLine();
            // Step 1
            //Console.WriteLine("What is your favourite colour");

            // Step 2 & 3
            //string userColour = Console.ReadLine();
            //Console.WriteLine();

            // Use it
            //Console.WriteLine(userName + ", did you really chose " + userColour + "? That's weak!\n");

            // Another example
            //Console.WriteLine("What planet are you from?");
            //string userPlanet = Console.ReadLine();

            // String formatting uses 0-based counting for indexes
            // and puts the variables into those spots.
            // Think of it like placeholders
            //Console.WriteLine("{0} is great, {1}\n", userPlanet, userName);
            // If the placeholders and the number of arguments doesn't match, stuff goes wrong

            // Since ReadLine() always returns a string we will need
            // to do extra work to use that information as another 
            // datatype. One option for this is called Parsing.
            // Syntax: datatype.Parse(stringValue)
            //Console.WriteLine("What is your age?");
            //string userAge = Console.ReadLine();
            //int age = int.Parse(userAge);
            //int yearsTo100 = 100 - age;

            //Console.WriteLine("Only {0} more years until you're 100!", yearsTo100);

            //Step 1 - give instructions
            Console.WriteLine("How much do you want to make per year? " +
                "Decimal values are OK, no $ symbols allowed");

            // Steps 2 & 3 - capture input
            string salaryString = Console.ReadLine();

            //Now we parse!
            decimal salary = decimal.Parse(salaryString);
            //Console.WriteLine("Salary: $" + salary);

            //String Interpolation
            //Like string formatting, string interpolation uses placeholders.
            //Unlike formatting, however, you pass the information you want
            //plugged in directly into the placeholder:

            Console.WriteLine($"Well, {salary * .35m} will go to taxes");

            //True names:
            /*
             * All of the data types we have used up to this point are
             * "intrinsic" or "simple" datatypes that have their own
             * C# reserved keyword associated with them. In reality
             * the keyword is just an alias for class that exists
             * by default in the FCL (Framework Class Library). You 
             * can use either the alias or the true name:
             * 
             * byte = Byte
             * short = Int16
             * int = Int32
             * long = Int64
             * decimal = Decimal
             * double = Double
             * float = Single
             * string = String
             * bool = Boolean
             * char = Char
             */

            //Example
            int x = 1;
            Int32 y = 2;

            //Convert is another option for changing the datatype
            //of information. It works similar to Parse(), but the
            //syntax is different:
            //Convert.ToTRUENAME(valueToConvert)
            //Example: Convert.ToInt32(userAge)

            // Ask the user how many times they have been smuggled.
            // They get a free light saber after 10 trips!

            // Step 1 - Instructions
            Console.WriteLine("How many times have you been smuggled through Imperial lines by Solo " +
                "and Chewie shipping?");

            // Steps 2 & 3: capture input
            string timesSmuggledString = Console.ReadLine();

            // Parsing
            //short timesSmuggled = short.Parse(timesSmuggledString);

            // Now let's use Convert, which is essentially the same
            short timesSmuggled = Convert.ToInt16(timesSmuggledString);

            Console.WriteLine("You have {0} more trips to get your" +
                " free lightsaber!", 10 - timesSmuggled);



        }
    }
}
