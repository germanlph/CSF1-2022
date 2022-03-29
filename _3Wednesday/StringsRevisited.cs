using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _3Wednesday
{
    class StringsRevisited
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Strings Revisited!!");

            //You can use the ToString() to get the string
            //version of any value from a variable of any 
            //datatype.
            //You call this method from the variable name.
            //This can be used to turn a value in any variable of any datatype
            //into a string
            int myFavNumber = 42;
            string text = myFavNumber.ToString();
            Console.WriteLine("Number is: " + text);
            Console.WriteLine(myFavNumber.GetType());
            Console.WriteLine(text.GetType());

            // Another example:
            decimal someDecimal = 123456.1213m;
            string decimalString = someDecimal.ToString();
            Console.WriteLine(someDecimal);
            Console.WriteLine(decimalString);

            //In the console, it is useful for the ability to pass format specifiers to the ToString()
            // to "format" numbers or dates
            Console.WriteLine(someDecimal.ToString("n") + " with n for number");

            Console.WriteLine(someDecimal.ToString("n6") + " with n6 for number");

            Console.WriteLine(someDecimal.ToString("c") + " with c for currency");

            Console.WriteLine(someDecimal.ToString("e") + " with e for exponential");

            // Let's show these with string formatting
            Console.WriteLine("{0:n3} is n3 formatting and {0:c} is currency formatting", someDecimal);

            // In String Interpolation
            Console.WriteLine($"{someDecimal:n3} is n3 formatting (interpolation), {someDecimal:c} is currency");

            // Escape sequences
            // Special characters used inside of a string that ignore
            // certain characters. In C# they begin with a \

            // \n creates a new line insde of a string
            Console.WriteLine("I love escapes!\nThey are easy!");

            // \" escapes " and allows it to be used as a character
            Console.WriteLine("\"I like turtles\", Zombie Kid said.");

            // \\ escapes \ (you have to escape... the escape)
            Console.WriteLine("C:\\VS2017\\Projects\\CSF1");

            //Beep!
            //Console.WriteLine("Danger!\a");

            // \u#### gives you a unicode character
            Console.WriteLine("It feels like it is 110\u00B0 in here");
            // www.utf8-chartable.de

            /*
             * Make text easier to read on-screen with concatenation:
             * To create a longer string that is easy to read use concatenation
             */
            string nonsense = "sdhflkwogihlkwnvmnokwghoiwdvokmklscnoihowekmslkhflk" +
               "sviuonwefjlkbhowkjnsdfnokhgihowief" +
               "sfabhoweknvghokwdjfn098234yh5tnlwkdfh";

            // Verbatim character @
            // Similar to escape but it captures ALL characters LITERALLY

            // This includes spacing, but to show double quotes inside a
            // verbatim string, you have to use double double quotes.
            // To start a verbatim string add @ before the double quotes
            string greeting = @"Julio says

""hello"" and that

            file is at
                                    C:\julio\dox";
            Console.WriteLine(greeting);

            string myArt = @"
      __            /^\
    .'  \          / :.\   
   /     \         | :: \ 
  /   /.  \       / ::: | 
 |    |::. \     / :::'/  
 |   / \::. |   / :::'/
 `--`   \'  `~~~ ':'/`
         /         (    
        /   0 _ 0   \   
      \/     \_/     \/  
    -== '.'   |   '.' ==-   
      /\    '-^-'    /\    
        \   _   _   /             
       .-`-((\o/))-`-.   
  _   /     //^\\     \   _    
.""o"".(    , .:::. ,    ).""o"".  
| o  o\\    \:::::/    //o  o| 
 \    \\    |:::::|   //    /   
  \    \\__ /:::::\__//    /   
   \ .:.\   `':::'`  /.:. /
    \':: |_        _|::' /
 jgs `---` `""""""""""` `---`";

            //! Above image courtesy https://asciiart.website/ 
            //! Formerly Chris.com
            Console.WriteLine(myArt);

            // verbatim is often used for file locations
            string fileLocation = @"C:\student\documents\ubergeek.doc";

            Console.WriteLine("This is the file location: " + fileLocation);// String concatenation again

            // We can format strings without Console.WriteLine()
            string formattedString = string.Format("This is the file location {0}:", fileLocation);
            // This method is extremely useful, because it gives us a reusable string variable
            Console.WriteLine(formattedString);
        }
    }
}
