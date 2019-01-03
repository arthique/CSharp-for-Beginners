#define T03
using System;

namespace HT_02
{
    class Program
    {
        static void Main(string[] args)
        {
            #region T01
#if (T01)

            const string numberText = "Enter number: ";
            int number;
            bool isDividedByThree;

            Console.Write(numberText);
            number = Convert.ToInt32(Console.ReadLine());
            isDividedByThree = number % 3 == 0;
            Console.WriteLine($"A number {number} is {(isDividedByThree ? "" : "not ")}divided by 3");

#endif
            #endregion

            #region T02
#if (T02)

            const string numberText = "Enter number: ";
            int number;
            bool isDividedByFiveWithReminderTwo;
            bool isDividedBySevenWithReminderOne;

            Console.Write(numberText);
            number = Convert.ToInt32(Console.ReadLine());
            isDividedByFiveWithReminderTwo = number % 5 == 2;
            isDividedBySevenWithReminderOne = number % 7 == 1;
            Console.WriteLine($"A number {number} {(isDividedByFiveWithReminderTwo && isDividedBySevenWithReminderOne ? "" : "not ")}meets the conditions");

#endif
            #endregion

            #region T03
#if (T03)

            const string numberText = "Enter number: ";
            int number;
            bool isDividedByFour;
            bool isLessTen;

            Console.Write(numberText);
            number = Convert.ToInt32(Console.ReadLine());
            isDividedByFour = number % 4 == 0;
            isLessTen = number < 10;
            Console.WriteLine($"The number {number} {(isDividedByFour && isLessTen ? "" : "not ")}meets the conditions");

#endif
            #endregion
        }
    }
}