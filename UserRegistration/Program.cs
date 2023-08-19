namespace UserRegistration
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome to User Registrtion program");
            Console.WriteLine("Please choose an option");
            Console.WriteLine("\n1.First Name\n2.Last Name\n3.Valid Email\n4.Valid MobileNumber\n5.Password");
            /*int option = Convert.ToInt32(Console.ReadLine());
            switch (option)
            {
                case 1:
                    UserReg.ValidFirstName();
                    break;
                case 2:
                    UserReg.ValidLastName();
                    break;
                case 3:
                    UserReg.ValidEmail();
                    break;
                case 4:
                    UserReg.ValidMobileNumber();
                    break;
                case 5:
                    UserReg.ValidPassword();
                    break;
                default:
                    Console.WriteLine("Please choose a valid option");
                    break;
            }*/
            UserReg.ValidMobileNumber("919673215173");
            // Console.WriteLine("HaPPY");
            // string us = UserReg.ValidMobileNumber("+91-9673215173");
            //  string u = UserReg.ValidMobileNumber("+919673215173");

            // Console.WriteLine("First" + use);
            // Console.WriteLine(us);
            // Console.WriteLine("Third" + u);
        }
    }
}