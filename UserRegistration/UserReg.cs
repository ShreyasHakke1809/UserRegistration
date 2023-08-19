using System.Text.RegularExpressions;

namespace UserRegistration
{
    public class UserReg
    {
        public static string ValidFirstName(string firstName)
        {
            try
            {
                Console.WriteLine("\nPlease Enter your First Name:");
                string firstName_pattern = "^[A-Z][a-zA-Z]{2,}$";

                if (firstName.Equals(string.Empty))
                {
                    throw new UserRegException(UserRegException.ExceptionType.EMPTY_MESSAGE, "First name should not be empty");
                }
                if (Regex.IsMatch(firstName, firstName_pattern))
                {
                    Console.WriteLine("First Name is valid");
                    return firstName;
                }
                else
                {
                    throw new UserRegException(UserRegException.ExceptionType.INVALID_MESSAGE, "First Name is not Valid");
                }
            }
            catch (Exception ex)
            {
                return ex.Message;
            }

        }
        public static string ValidLastName(string lastName)
        {
            try
            {
                Console.WriteLine("\nPlease Enter your Last Name:");
                string pattern = "^[A-Z][a-zA-Z]{2,}$";

                if (lastName.Equals(string.Empty))
                {
                    throw new UserRegException(UserRegException.ExceptionType.EMPTY_MESSAGE, "Last Name should not be empty");
                }
                if (Regex.IsMatch(lastName, pattern))
                {
                    Console.WriteLine("Last Name is Valid");
                    return lastName;
                }
                else
                {
                    throw new UserRegException(UserRegException.ExceptionType.INVALID_MESSAGE, "Last Name is not Valid");
                }
            }
            catch (Exception ex)
            {
                return ex.Message;
            }
        }
        public static string ValidEmail(string email)
        {
            try
            {
                Console.WriteLine("\nPlease Enter your Email-ID:");
                string email_pattern = @"^[a-zA-Z0-9]{3,10}([._+-][a-zA-Z0-9]{1,10})?@[a-zA-Z0-9]{1,10}[.][a-zA-Z]{2,3}([.][a-zA-Z]{2,3})?$";

                if (email.Equals(string.Empty))
                {
                    throw new UserRegException(UserRegException.ExceptionType.EMPTY_MESSAGE, "Email should not be empty");
                }
                if (Regex.IsMatch(email, email_pattern))
                {
                    Console.WriteLine("Email is Valid");
                    return email;
                }
                else
                {
                    throw new UserRegException(UserRegException.ExceptionType.INVALID_MESSAGE, "Email is not Valid");
                }
            }
            catch (Exception ex)
            {
                return ex.Message;
            }

        }
        public static string ValidMobileNumber(string mobNum)
        {
            try
            {
                Console.WriteLine("\nPlease Enter your Mobie Number:");
                string mobNum_pattern = "^[+]?91[ -][1-9][0-9]{9}$";

                if (mobNum.Equals(string.Empty))
                {
                    throw new UserRegException(UserRegException.ExceptionType.EMPTY_MESSAGE, "Mobile number should not be empty");
                }
                if (Regex.IsMatch(mobNum, mobNum_pattern))
                {
                    Console.WriteLine("Mobile Number is Valid");
                    return mobNum;
                }
                else
                {
                    throw new UserRegException(UserRegException.ExceptionType.INVALID_MESSAGE, "Mobile Number is not Valid");
                }
            }
            catch (Exception ex)
            {
                return ex.Message;
            }

        }
        public static string ValidPassword(string password)
        {
            try
            {
                Console.WriteLine("\nPlease Enter your Password:");
                Console.WriteLine("Password must contain min 8 characters");
                string password_pattern = "^(?=.*[a-z])(?=.*[A-Z])(?=.*[0-9])(?=.*[&%$#@?^*!~]).{8,}$";

                if (password.Equals(string.Empty))
                {
                    throw new UserRegException(UserRegException.ExceptionType.EMPTY_MESSAGE, "Password should not be empty");
                }
                if (Regex.IsMatch(password, password_pattern))
                {
                    Console.WriteLine("Password is Valid");
                    return password;
                }
                else
                {
                    throw new UserRegException(UserRegException.ExceptionType.INVALID_MESSAGE, "Password is not Valid");
                }
            }
            catch (Exception ex)
            {
                return ex.Message;
            }
        }
    }
}
