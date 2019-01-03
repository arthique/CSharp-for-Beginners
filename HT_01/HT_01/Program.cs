#define T06
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

            #region T02
#if (T02)

            string name;
            int age;

            Console.Write("Enter your name: ");
            name = Console.ReadLine();
            Console.Write("Enter your age: ");
            age = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine($"{name} is {age} years old");

#endif
            #endregion

            #region T03
#if (T03)

            string currentDayName;
            string currentMonthName;
            int currentDayDate;

            Console.Write("Enter current day name: ");
            currentDayName = Console.ReadLine();
            Console.Write("Enter current moth name: ");
            currentMonthName = Console.ReadLine();
            Console.Write("Enter current day number: ");
            currentDayDate = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine($"Today is {currentDayName} {currentDayDate} {currentMonthName}");

#endif
            #endregion

            #region T04
#if (T04)

            string monthName;
            int numberDayMonth;

            Console.Write("Enter month name: ");
            monthName = Console.ReadLine();
            Console.Write("Enter number days in month: ");
            numberDayMonth = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine($"{monthName} has {numberDayMonth} days");

#endif
            #endregion

            #region T05
#if (T05)

            string birthYearText = "Enter your birth year: ";
            int currentYear = 2019;
            int birthYear;

            Console.Write(birthYearText);
            birthYear = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine($"Your age is {currentYear - birthYear}");

#endif
            #endregion

            #region T06

            string nameText = "Enter your name: ";
            string birthYearText = "Enter your birth year: ";
            int currentYear = 2019;
            string name;
            int birthYear;

            Console.Write(nameText);
            name = Console.ReadLine();
            Console.Write(birthYearText);
            birthYear = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine($"{name} is {currentYear - birthYear} years old.");

            #endregion

        }
    }
}
