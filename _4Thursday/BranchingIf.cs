using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _4Thursday
{
    class BranchingIf
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Branching with If");

            /*
             * If allows you to test for a condition. If that
             * condition is true it runs the code inside of the scope.
             * Otherwise, the scope is skipped.
             * 
             * Optionally, you can add one or more else ifs that will
             * run if the previous conditions were not met and their
             * condition is true.
             * 
             * Optionally, you can also include 1 final ELSE with NO
             * condition, it will always run if nothing else above
             * did, and it MUST always be the last statement of
             * an IF tree.
             */

            //Console.WriteLine("What day is it? Monday, Tuesday, etc");
            //string userDay = Console.ReadLine().ToLower();

            //if (userDay == "thursday")
            //{//begin if scope
                // The code here in this scope will run ONLY if the
                // above condition is true
                //Console.WriteLine("Only one more day until the weekend");
            //}//end if scope

            Console.WriteLine("\nMoving along....\n");

            // Now a FULL IF TREE
            // Only 1 scope of an IF tree will run
            int monsterStrength = 100;
            int heroStrength;
            Console.WriteLine("You enter a cave. You see bones and a white rabbit.");
            Console.WriteLine("Enter your attack strength: ");
            heroStrength = Convert.ToInt32(Console.ReadLine());

            if (heroStrength > monsterStrength)
            {
                Console.WriteLine("You use the Holy Hand Grenade of Antioch and blow the rabbit to tiny bits");
            }// end if
            else if (heroStrength == monsterStrength)
            {
                Console.WriteLine("Alright, then. We'll call it a draw.");
            }// end else if
            else if (heroStrength >= monsterStrength * .75)
            {
                // If the user entered a number greater than 75%
                // of the rabbit's strength, this will run.
                // If the rabbit's strength is 100, this checks for 75-99
                Console.WriteLine("You die a valiant death, but put up a great fight.");
            }// end second else if
            else if (heroStrength > 0)
            {
                // Covers 1-74
                Console.WriteLine("You join the pile of bones!");
            }// end else if
            else if (heroStrength > 20)
            {
                // This will NEVER run. In order for this condition to be
                // true, one of the conditions above was already true and the if
                // tree was exited
                // This is a Logical error
                Console.WriteLine("This will NEVER run");
            }// end else if
            else
            {
                // There is no condition for an else
                // It MUST be the last statement in an IF tree
                // This will run if the user enters 0 or below
                Console.WriteLine("Dude, you're already dead");
            }// end else

            // What matters in an IF tree is that a condition resolves to true or false

            // Because a bool stores a true or false value, we can use a bool
            // to determine whether or not an IF should run

            bool runMe = true;
            if (runMe)
            {
                Console.WriteLine("\nProgram running...\n");
            }

            // Capture user input to determine if the user
            // should have access to some functionality
            bool isAdmin = false;

            Console.WriteLine("Enter your username: ");
            string username = Console.ReadLine().ToUpper();

            if (username == "CHRIS" || username == "ADMIN")
            {
                isAdmin = true;
            }

            if (isAdmin)
            {
                Console.WriteLine("You're an admin!");
            }

            // NESTED IF, you can nest if trees inside of branches of other trees

            Console.WriteLine("Shall we play a game?");
            string userProgram = Console.ReadLine().ToUpper();

            if (userProgram == "Y" || userProgram == "YES")
            {
                // Come back to the user and give them options for games
                Console.WriteLine("Choose chess, frogger or war");
                string userGame = Console.ReadLine().ToLower();
                if (userGame == "chess")
                {
                    Console.WriteLine("I calculate that you would lose. Checkmate!");
                }
                else if (userGame == "frogger")
                {
                    Console.WriteLine("You're too slow..... SPLAT!");
                }
                else if (userGame == "war")
                {
                    Console.WriteLine("Global thermonuclear war executed!");
                }
                else
                {
                    Console.WriteLine("Response not understood");
                }
            }// end if that checks for yes
            else if (userProgram == "N" || userProgram == "NO")
            {
                Console.WriteLine("We didn't want you to play our game anyway...");
            }//end check for no
            else
            {
                Console.WriteLine("Response not understood, please restart");
            }// end else

            // IF statements are GREAT with numeric ranges
            Console.WriteLine("Enter the score on your physics exam: ");
            byte testScore = byte.Parse(Console.ReadLine());

            // if -> tab -> tab

            if (testScore >= 90)
            {
                Console.WriteLine("Great job! You got an A!!");
            }// end if A
            else if (testScore >= 80)
            {
                Console.WriteLine("Fair job... B");
            }// end if B
            // MINI-LAB
            // 70 and over
            // 60 and over is a D
            // everything else if an F
            else if (testScore >= 70)
            {
                Console.WriteLine("You might be in some trouble... C");
            }// end if C
            else if (testScore >= 60)
            {
                Console.WriteLine("Dude, were you even trying?... D");
            }// end if D
            else
            {
                Console.WriteLine("I have nothing to say to you");
            }// end if F

            // The ternary operator is a quick inline if/else statement.
            // Syntax:
            // BooleanCondition ? codeIfTrue : codeIfFalse;
            Console.WriteLine("How many Daleks are there?");
            int dalekCount = int.Parse(Console.ReadLine());
            Console.WriteLine("Oh, no! {0} Dalek{1}!", dalekCount, dalekCount == 1 ? "" : "s");
        }
    }
}
