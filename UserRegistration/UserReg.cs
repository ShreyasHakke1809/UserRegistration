using System.Text.RegularExpressions;

namespace UserRegistration
{
    public class UserReg
    {
        public static string ValidFirstName(string firstName)
        {
            Console.WriteLine("\nPlease Enter your First Name:");
            string firstName_pattern = "^[A-Z][a-zA-Z]{2,}$";

            if (Regex.IsMatch(firstName, firstName_pattern))
            {
                Console.WriteLine("First Name is Valid");
                return firstName;
            }
            else
            {
                return "First Name is not Valid";
            }
        }
        public static string ValidLastName(string lastName)
        {
            Console.WriteLine("\nPlease Enter your Last Name:");
            string pattern = "^[A-Z][a-zA-Z]{2,}$";

            if (Regex.IsMatch(lastName, pattern))
            {
                Console.WriteLine("Last Name is Valid");
                return lastName;
            }
            else
            {
                return "Last Name is not Valid";
            }
        }
        public static string ValidEmail(string email)
        {
            Console.WriteLine("\nPlease Enter your Email-ID:");
            string email_pattern = @"^[a-zA-Z0-9]{3,10}([._+-][a-zA-Z0-9]{1,10})?@[a-zA-Z0-9]{1,10}[.][a-zA-Z]{2,3}([.][a-zA-Z]{2,3})?$";

            if (Regex.IsMatch(email, email_pattern))
            {
                Console.WriteLine("Email is Valid");
                return email;
            }
            else
            {
                return "Email is not Valid";
            }
        }
        public static string ValidMobileNumber(string mobNum)
        {
            //Console.WriteLine("\nPlease Enter your Mobie Number:");
            string mobNum_pattern = "^[+]?91[ -][1-9][0-9]{9}$";

            if (Regex.IsMatch(mobNum, mobNum_pattern))
            {
                Console.WriteLine("Mobile Number is Valid");
                return mobNum;
            }
            else
            {
                return "Mobile Number is not Valid";
            }
        }
        public static string ValidPassword(string password)
        {
            Console.WriteLine("\nPlease Enter your Password:");
            Console.WriteLine("Password must contain min 8 characters");
            string password_pattern = "^(?=.*[a-z])(?=.*[A-Z])(?=.*[0-9])(?=.*[&%$#@?^*!~]).{8,}$";

            if (Regex.IsMatch(password, password_pattern))
            {
                Console.WriteLine("Password is Valid");
                return password;
            }
            else
            {
                return "Password is not Valid";
                //ValidPassword();
            }
        }
    }
}
