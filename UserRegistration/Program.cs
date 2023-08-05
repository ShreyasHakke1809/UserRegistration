namespace UserRegistration
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome to User Registrtion program");
            Console.WriteLine("Please choose an option");
            Console.WriteLine("\n1. First Name \n2. Last Name");
            int option = Convert.ToInt32(Console.ReadLine());
            switch (option)
            {
                case 1:
                    UserReg.ValidFirstName();
                    break;
                case 2:
                    UserReg.ValidLastName();
                    break;
                default:
                    Console.WriteLine("Please choose a valid option");
                    break;
            }
        }
    }
}