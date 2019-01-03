using System;

namespace HT_01
{
    class Program
    {
        static void Main(string[] args)
        {
            #region

            string firstName;
            string lastName;

            Console.Write("Enter your first name: ");
            firstName = Console.ReadLine();
            Console.Write("Enter your last name: ");
            lastName = Console.ReadLine();
            Console.WriteLine($"Welcome {firstName} {lastName}");

            #endregion
        }
    }
}
