using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSF1
{
    class NamingConventions
    {
        //NOTE this class has NO main method.
        //It could NEVER be a start-up object for a console
        //application. It would just be a helper file.

        //If this file was in a special project called a Dynamic Link
        //Library (aka Class Library) it would build as a .dll instead of a .exe

        /*
         * Naming conventions are guidelines on how to name things.
         * Breaking them won't generally cause build errors,
         * but they can be helpful to stick to.
         * 
         * lowercase
         * Examples: thisislowercase, namespace
         * - RULE: Required with keywords
         * - This convention could be elsewhere, but generally is not
         * 
         * UPPERCASE
         * Example: ONE_RING
         * - Used rarely, most typically with constants to make them
         * stand out.
         * - Use an _ for a space.
         * 
         * camelCase
         *  Examples: thisIsCamelCase, employeeName
         * - Uses lowercase letters for the first word and a 
         * capitalied first letter for each following word
         * - Typically this is used for variables and parameters
         * 
         * PascalCase
         * Examples:
         * ThisIsPascalCase, NamingConventions
         * - Uses an uppercase first letter for every word.
         * - Typically PascalCase is used for "everything else":
         * namespace, class, method, properties, etc.
         * 
         * Hungarian or Lezinski convention:
         * Example: intCustomersInQueue, btnClick, lblDisplay, rdrAuthors
         * 
         * - This looks like camelCase but the first word is descriptive
         *   of what the object is.
         */
    }
}
