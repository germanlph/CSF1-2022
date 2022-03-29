using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _3Wednesday
{
    class LogicComparison
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Logical and Comparison Operators");

            //Comparison Operators
            //"Relational" and "Equality" operators compare
            //2 different values and result in a bool answer of
            //true or false

            /*
             *  > is greater than
             *  < is less than
             *  >= is greater than or equal to
             *  <= is less than or equal to
             */

            int ceoPayGrade = 20;
            int mgrPayGrade = 12;
            int mailroomPayGrade = 2;

            bool isCeoPayHigher = ceoPayGrade > mgrPayGrade;
            // "true" is not the same as true
            // "false" is not the same as false
            Console.WriteLine("Is CEO greater than MGR? " + isCeoPayHigher);
            //bool isThisTrue = true;

            Console.WriteLine("Is MGR great than CEO? " + (mgrPayGrade > ceoPayGrade));

            Console.WriteLine("Is mailroom less than or equal to CEO? " + (mailroomPayGrade <= ceoPayGrade));

            Console.WriteLine("Is 5 less than 6? " + (5 <= 6));

            Console.WriteLine("Is mailroom less than or equal to 1? " + (mailroomPayGrade <= 1));

            // a single = sign is used for assignment
            // To test equality we use == two of them
            Console.WriteLine("Is MGR equal to CEO? " + (mgrPayGrade == ceoPayGrade));

            // For "not" equal we have to use !=
            // An exclamation point in C# generally means "NOT"
            Console.WriteLine("Is MGR different than CEO? " + (mgrPayGrade != ceoPayGrade));

            // Compare strings
            string b = "batman";
            string b2 = "BATMAN";

            Console.WriteLine("Is b equal to b2? " + (b == b2));

            Console.WriteLine("Is case sensitivity a thing? With INSENSITE case, is b equal to b2? " + (b.ToUpper() == b2));
            // When we manage casing ourselves (in code) we can compare strings without casing being a problem
            // All methods (purple boxes in intellisense) MUST have parenthesis (parens)

            //Basic overview of C# Methods - A method
            //is a group of statements that together perform
            //a task. 
            //Every C# program has at least one class with
            //a method named Main.
            //() = Method
            //!Will go over these in great detail next week.

            //Logical operators combine two comparison operators
            //or bool values and returns a bool.
            // && is used for AND
            // || is used for OR
            //They still compare two values, but they must both
            //resolve to Boolean values.

            bool payComparison = ceoPayGrade > mailroomPayGrade && ceoPayGrade < mgrPayGrade;

            Console.WriteLine("Is CEO less than MGR AND greater than mailroom? " + payComparison);

            Console.WriteLine("Is MGR greater than Mailroom AND CEO greater than MGR? " + (mgrPayGrade > mailroomPayGrade && ceoPayGrade > mgrPayGrade));

            Console.WriteLine("Is 15 less than 5 or equal to 15? " + (15 < 5 || 15 == 15));

            // You can use literal values or variables or any mixture of the two in a logical operator
            Console.WriteLine("Is 15 less than 5 OR $ equal to a? " + (15 < 5 || '$' == 'a'));



        }// end Main
    }// end Class
}// end namespace
