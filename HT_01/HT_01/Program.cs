#define T01
using System;

namespace HT_01
{
    class Program
    {
        static void Main(string[] args)
        {
            #region T01
            #if (T01)

            string firstName;
            string lastName;

            Console.Write("Enter your first name: ");
            firstName = Console.ReadLine();
            Console.Write("Enter your last name: ");
            lastName = Console.ReadLine();
            Console.WriteLine($"Welcome {firstName} {lastName}");

            #endif
            #endregion
        }
    }
}
