﻿#define T05
using System;

namespace HT_03
{
    class Program
    {
        static void Main(string[] args)
        {
            #region T01
#if (T01)

            const string numberText = "Enter a number: ";
            int number;

            Console.Write(numberText);
            try
            {
                number = Int32.Parse(Console.ReadLine());
                if (number % 3 == 0 && number % 7 == 0)
                {
                    Console.WriteLine($"The number {number} is diveded by 3 and 7");
                }
                else
                {
                    Console.WriteLine($"The number {number} is not divided by 3 and 7");
                }
            }
            catch
            {
                Console.WriteLine("Entered value is not a number");
            }


#endif
            #endregion

            #region T02
#if (T02)

            int firstNumber;
            int secondNumber;

            try
            {
                Console.Write("Enter first number: ");
                firstNumber = Int32.Parse(Console.ReadLine());
                Console.Write("Enter second number: ");
                secondNumber = Int32.Parse(Console.ReadLine());
                if (firstNumber == secondNumber)
                {
                    Console.WriteLine("The numbers is equals");
                }
                else if (firstNumber > secondNumber)
                {
                    Console.WriteLine("First number greater second number");
                }
                else
                {
                    Console.WriteLine("First number less second number");
                }
            }
            catch
            {
                Console.WriteLine("Entered value is not a number");
            }
#endif
            #endregion

            #region T03
#if (T03)

            int number;
            int sum = 0;
            do
            {
                try
                {
                    Console.Write("Enter a number: ");
                    number = Int32.Parse(Console.ReadLine());
                    sum += number;
                }
                catch
                {
                    Console.WriteLine("Entered value is not a number");
                    break;
                }
            }
            while (number > 0);
            Console.WriteLine($"Sum = {sum}");

#endif
            #endregion

            #region T04
#if (T04)

            int number;

            Console.Write("Enter a number: ");
            try
            {
                number = Int32.Parse(Console.ReadLine());
                switch (number)
                {
                    case 1:
                        Console.WriteLine("Sunday");
                        break;
                    case 2:
                        Console.WriteLine("Monday");
                        break;
                    case 3:
                        Console.WriteLine("Tuesday");
                        break;
                    case 4:
                        Console.WriteLine("Wednesday");
                        break;
                    case 5:
                        Console.WriteLine("Thursday");
                        break;
                    case 6:
                        Console.WriteLine("Friday");
                        break;
                    case 7:
                        Console.WriteLine("Saturday");
                        break;
                    default:
                        Console.WriteLine("Entered number must be in range from 1 to 7");
                        break;
                }
            }
            catch
            {
                Console.WriteLine("Entered value is not a number!");
            }

#endif
            #endregion

            #region T05
#if (T05)

            string dayName;
            int dayNumber = 0;

            Console.Write("Enter a day name: ");
            dayName = Console.ReadLine();
            switch (dayName.ToLower())
            {
                case "sunday":
                    dayNumber = 1;
                    break;
                case "monday":
                    dayNumber = 2;
                    break;
                case "tuesday":
                    dayNumber = 3;
                    break;
                case "wednesday":
                    dayNumber = 4;
                    break;
                case "thursday":
                    dayNumber = 5;
                    break;
                case "friday":
                    dayNumber = 6;
                    break;
                case "sarutday":
                    dayNumber = 7;
                    break;
            }
            if (dayNumber > 0 && dayNumber <= 7)
            {
                Console.WriteLine($"Entered {dayNumber} day in the week");
            }
            else
            {
                Console.WriteLine("Entered incorrect day name");
            }

#endif
            #endregion
        }
    }
}
