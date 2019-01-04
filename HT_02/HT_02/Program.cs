#define T07
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

            #region T04
#if (T04)

            const string numberText = "Enter number: ";
            int number;
            bool isInRangeFromFiveToTen;

            Console.Write(numberText);
            number = Convert.ToInt32(Console.ReadLine());
            isInRangeFromFiveToTen = number > 4 && number <= 10;
            Console.WriteLine($"The number {number} {(isInRangeFromFiveToTen ? "" : "not ")}meets the conditions");

#endif
            #endregion

            #region T05
#if (T05)

            const string numberText = "Enter number: ";
            int number;
            int thousants;

            Console.Write(numberText);
            number = Convert.ToInt32(Console.ReadLine());
            thousants = number / 1000 % 10;
            Console.WriteLine($"The number has {thousants} thousands");

#endif
            #endregion

            #region T06
#if (T06)

            const string numberText = "Enter number: ";
            const int base8 = 8;
            int number;
            string base8number;
            int secondPosition;

            Console.Write(numberText);
            number = Convert.ToInt32(Console.ReadLine());
            base8number = Convert.ToString(number, base8);
            secondPosition = Convert.ToInt32(base8number) / 10 % 10;
            Console.WriteLine($"The number has {secondPosition} in the second position");

#endif
            #endregion

            #region T07
#if (T07)

            const string numberText = "Enter number: ";
            const int base2 = 2;
            int number;
            string base2number;
            int thirdPosition;

            Console.Write(numberText);
            number = Convert.ToInt32(Console.ReadLine());
            thirdPosition = number >> 2;
            base2number = Convert.ToString(thirdPosition, base2);
            Console.WriteLine($"The number third byte is {base2number.Substring(base2number.Length - 1)}"); // TODO come up with another solution

#endif
            #endregion
        }
    }
}