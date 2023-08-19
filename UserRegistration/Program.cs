namespace UserRegistration
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome to User Registrtion program");
            Console.WriteLine("Please choose an option");
            Console.WriteLine("\n1.First Name\n2.Last Name\n3.Valid Email\n4.Valid MobileNumber\n5.Password");
            int option = Convert.ToInt32(Console.ReadLine());
            switch (option)
            {
                case 1:
                    UserReg.ValidFirstName("Shreyas");
                    break;
                case 2:
                    UserReg.ValidLastName("Hakke");
                    break;
                case 3:
                    UserReg.ValidEmail("Shreyashakke1809@gmail.com");
                    break;
                case 4:
                    UserReg.ValidMobileNumber("9673215173");
                    break;
                case 5:
                    UserReg.ValidPassword("12345678");
                    break;
                default:
                    Console.WriteLine("Please choose a valid option");
                    break;
            }
        }
    }
}