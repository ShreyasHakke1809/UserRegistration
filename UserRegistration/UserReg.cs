using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace UserRegistration
{
    internal class UserReg
    {
        public static void ValidFirstName()
        {
            Console.WriteLine("\nPlease Enter your First Name:");
            string firstName = Console.ReadLine();
            string firstName_pattern = "^[A-Z][a-zA-Z]{2,}$";

            if (Regex.IsMatch(firstName, firstName_pattern))
            {
                Console.WriteLine("First Name is Valid");
            }
            else
            {
                Console.WriteLine("First Name is not Valid");
            }
        }
        public static void ValidLastName()
        {
            Console.WriteLine("\nPlease Enter your Last Name:");
            string lastName = Console.ReadLine();
            string pattern = "^[A-Z][a-zA-Z]{2,}$";

            if (Regex.IsMatch(lastName, pattern))
            {
                Console.WriteLine("Last Name is Valid");
            }
            else
            {
                Console.WriteLine("Last Name is not Valid");
                ValidLastName();
            }
        }
    }
}
