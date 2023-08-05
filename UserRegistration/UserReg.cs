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
        public static void ValidEmail()
        {
            Console.WriteLine("\nPlease Enter your Email-ID:");
            string email = Console.ReadLine();
            string email_pattern = @"^[a-zA-Z0-9]{3,10}([._+-][a-zA-Z0-9]{1,10})?@[a-zA-Z0-9]{1,10}[.][a-zA-Z]{2,3}([.][a-zA-Z]{2,3})?$";

            if (Regex.IsMatch(email, email_pattern))
            {
                Console.WriteLine("Email is Valid");
            }
            else
            {
                Console.WriteLine("Email is not Valid");
                ValidEmail();
            }
        }
        public static void ValidMobileNumber()
        {
            Console.WriteLine("\nPlease Enter your Mobie Number:");
            string mobNum = Console.ReadLine();
            string mobNum_pattern = "^[+]?91[ -][1-9][0-9]{9}$";

            if (Regex.IsMatch(mobNum, mobNum_pattern))
            {
                Console.WriteLine("Mobie Number is Valid");
            }
            else
            {
                Console.WriteLine("Mobie Number is not Valid");
                ValidMobileNumber();
            }
        }
        public static void ValidPassword()
        {
            Console.WriteLine("\nPlease Enter your Password:");
            Console.WriteLine("Password must contain min 8 characters");
            string password = Console.ReadLine();
            string password_pattern = "^(?=.*[a-z])(?=.*[A-Z]).{8,}$";
            if (Regex.IsMatch(password, password_pattern))
            {
                Console.WriteLine("Password is Valid");
            }
            else
            {
                Console.WriteLine("Password is not Valid");
                ValidPassword();
            }
        }
    }
}
