using System;

namespace AddressBookSystem
{
    class Program
    {
        static void Main(string[] args)
        {
            AddressBookMain();
            Contact();
        }
        public static void AddressBookMain()
        {
            Console.WriteLine("Welcome To Adress Book");
        }
        public static void Contact()
        {
            string First_Name, Last_Name, Address, Email, State;
            double Zip_Code, Phone_Number;
            Console.WriteLine("Enter the first name and the last name");
            First_Name = Console.ReadLine();
            Last_Name = Console.ReadLine();
            Console.WriteLine("Enter the Address");
            Address = Console.ReadLine();
            Console.WriteLine("Enter the Email ID");
            Email = Console.ReadLine();
            Console.WriteLine("Enter the State");
            State = Console.ReadLine();
            Console.WriteLine("Enter Zip Code");
            Zip_Code = Console.Read();
            Console.WriteLine("Enter Phone Number");
            Phone_Number = Console.Read();
            Console.ReadKey();
        }
    }
}
