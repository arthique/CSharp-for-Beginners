#define T10B
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

            #region T05A
#if (T05A)

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

            #region T05B
#if (T05B)

            string dayName;
            string output;

            Console.Write("Enter a day name: ");
            dayName = Console.ReadLine();
            if (dayName == "sunday")
            {
                output = "Entered first day of week";
            }
            else if (dayName == "monday")
            {
                output = "Entered second day of week";
            }
            else if (dayName == "tuesday")
            {
                output = "Entered third day of week";
            }
            else if (dayName == "wednesday")
            {
                output = "Entered fourth day of week";
            }
            else if (dayName == "thursday")
            {
                output = "Entered fifth day of week";
            }
            else if (dayName == "friday")
            {
                output = "Entered sixth day of week";
            }
            else if (dayName == "saturday")
            {
                output = "Entered seventh day of week";
            }
            else
            {
                output = "Entered incorrect day name";
            }
            Console.WriteLine(output);

#endif
            #endregion

            #region T06A
#if (T06A)

            const string numberText = "Enter a number: ";
            int number;
            int oddSum = 0;
            string oddNumbers = String.Empty;

            try
            {
                Console.Write(numberText);
                number = Int32.Parse(Console.ReadLine());

                if (number > 0)
                {
                    while (number > 0)
                    {
                        if (number % 2 != 0)
                        {
                            oddNumbers += number > 1 ? $"{number} + " : $"{number}";
                            oddSum += number;
                        }
                        number -= 1;
                    }
                    Console.WriteLine($"{oddNumbers} = {oddSum}");
                }
                else
                {
                    Console.WriteLine("Entered number less 1");
                }
            }
            catch
            {
                Console.WriteLine("Entered incorrect number");
            }

#endif
            #endregion

            #region T06B
#if (T06B)

            const string numberText = "Enter a number: ";
            int number;
            int oddSum = 0;
            string oddNumbers = String.Empty;

            try
            {
                Console.Write(numberText);
                number = Int32.Parse(Console.ReadLine());

                if (number > 0)
                {
                    for (; number > 0; number--)
                    {
                        if (number % 2 != 0)
                        {
                            oddNumbers += number > 1 ? $"{number} + " : $"{number}";
                            oddSum += number;
                        }
                    }
                    Console.WriteLine($"{oddNumbers} = {oddSum}");
                }
                else
                {
                    Console.WriteLine("Entered number less 1");
                }
            }
            catch
            {
                Console.WriteLine("Entered incorrect number");
            }

#endif
            #endregion

            #region T07A
#if (T07A)

            const string numberText = "Enter a number: ";
            int number;
            int sumOfNumberSquares = 0;
            string numberSquares = String.Empty;

            try
            {
                Console.Write(numberText);
                number = Int32.Parse(Console.ReadLine());

                if (number >= 0)
                {
                    while (number >= 0)
                    {
                        numberSquares += number > 0 ? $"{number}^2 + " : $"{number}^2";
                        sumOfNumberSquares += number * number;
                        number -= 1;
                    }
                    Console.WriteLine($"{numberSquares} = {sumOfNumberSquares}");
                }
                else
                {
                    Console.WriteLine("Entered number less 0");
                }
            }
            catch
            {
                Console.WriteLine("Entered incorrect number");
            }

#endif
            #endregion

            #region T07B
#if (T07B)

            const string numberText = "Enter a number: ";
            int number;
            int sumOfNumberSquares = 0;
            string numberSquares = String.Empty;

            try
            {
                Console.Write(numberText);
                number = Int32.Parse(Console.ReadLine());

                if (number >= 0)
                {
                    for (; number >= 0; number--)
                    {
                        numberSquares += number > 0 ? $"{number}^2 + " : $"{number}^2";
                        sumOfNumberSquares += number * number;
                    }
                    Console.WriteLine($"{numberSquares} = {sumOfNumberSquares}");
                }
                else
                {
                    Console.WriteLine("Entered number less 0");
                }
            }
            catch
            {
                Console.WriteLine("Entered incorrect number");
            }

#endif
            #endregion

            #region T08A
#if (T08A)

            const string numberText = "Enter a number: ";
            int number;
            int i;
            int sum = 0;
            int prev;
            string fibNumbers = String.Empty;

            try
            {
                Console.Write(numberText);
                number = Int32.Parse(Console.ReadLine());
                if (number > 0)
                {
                    i = prev = 1;
                    while (i <= number)
                    {
                        if (i == 1)
                        {
                            fibNumbers = $"{i}";
                            sum = i;
                        }
                        else
                        {
                            fibNumbers = $"{fibNumbers} + {sum}";
                            sum += prev;
                            prev = sum - prev;
                        }
                        i += 1;
                    }
                    Console.WriteLine($"{fibNumbers}");
                }
                else
                {
                    Console.WriteLine("Entered number less 0");
                }
            }
            catch
            {
                Console.WriteLine("Entered incorrect number");
            }
#endif
            #endregion

            #region T08B
#if (T08B)

            const string numberText = "Enter a number: ";
            int number;
            int sum = 0;
            int prev;
            string fibNumbers = String.Empty;

            try
            {
                Console.Write(numberText);
                number = Int32.Parse(Console.ReadLine());
                if (number > 0)
                {
                    for (int i = prev = 1; i <= number; i++)
                    {
                        if (i == 1)
                        {
                            fibNumbers = $"{i}";
                            sum = i;
                        }
                        else
                        {
                            fibNumbers += $" + {sum}";
                            sum += prev;
                            prev = sum - prev;
                        }
                    }
                    Console.WriteLine($"{fibNumbers}");
                }
                else
                {
                    Console.WriteLine("Entered number less 0");
                }
            }
            catch
            {
                Console.WriteLine("Entered incorrect number");
            }
#endif
            #endregion

            #region T09A
#if (T09A)
            const string numberText = "Enter a number: ";
            int firstNumber;
            int secondNumber;
            string output = String.Empty;

            try
            {
                Console.Write(numberText);
                firstNumber = Int32.Parse(Console.ReadLine());
                Console.Write(numberText);
                secondNumber = Int32.Parse(Console.ReadLine());

                if (firstNumber == secondNumber)
                {
                    output = $"{firstNumber}";
                }
                else if (firstNumber > secondNumber)
                {
                    while (secondNumber <= firstNumber)
                    {
                        output += $"{secondNumber} ";
                        secondNumber += 1;
                    }
                }
                else
                {
                    while (firstNumber <= secondNumber)
                    {
                        output += $"{firstNumber} ";
                        firstNumber += 1;
                    }
                }
                Console.WriteLine(output);

            }
            catch
            {
                Console.WriteLine("Entered value is not a number");
            }
#endif
            #endregion

            #region T09B
#if (T09B)
            const string numberText = "Enter a number: ";
            int firstNumber;
            int secondNumber;
            string output = String.Empty;

            try
            {
                Console.Write(numberText);
                firstNumber = Int32.Parse(Console.ReadLine());
                Console.Write(numberText);
                secondNumber = Int32.Parse(Console.ReadLine());

                if (firstNumber == secondNumber)
                {
                    output = $"{firstNumber}";
                }
                else
                {
                    int min = firstNumber > secondNumber ? secondNumber : firstNumber;
                    int max = firstNumber > secondNumber ? firstNumber : secondNumber;
                    for (; min <= max; min++)
                    {
                        output += $"{min} ";
                    }
                }
                Console.WriteLine(output);

            }
            catch
            {
                Console.WriteLine("Entered value is not a number");
            }
#endif
            #endregion

            #region T10A
#if (T10A)
            const string numberText = "Enter a number: ";
            int number;
            int sum = 0;
            string numbers = String.Empty;

            try
            {
                Console.Write(numberText);
                number = Int32.Parse(Console.ReadLine());

                if (number > 0)
                {
                    int i = 0;
                    while (number > 0)
                    {
                        if ((i / 5 > 0 && i % 5 == 2) || (i / 3 > 0 && i % 3 == 1))
                        {
                            numbers += sum > 0 ? $" + {i}" : $"{i}";
                            sum += i;
                            number--;
                        }
                        i++;
                    }
                    Console.WriteLine($"{numbers} = {sum}");

                }
                else
                {
                    Console.WriteLine("Entered number less 1");
                }
            }
            catch
            {
                Console.WriteLine("Entered value is not a number!");
            }
#endif
            #endregion

            #region T10B
#if (T10B)
            const string numberText = "Enter a number: ";
            int number;
            int sum = 0;
            string numbers = String.Empty;

            try
            {
                Console.Write(numberText);
                number = Int32.Parse(Console.ReadLine());

                if (number > 0)
                {
                    for (int i = 0; number > 0; i++)
                    {
                        if ((i / 5 > 0 && i % 5 == 2) || (i / 3 > 0 && i % 3 == 1))
                        {
                            numbers += sum > 0 ? $" + {i}" : $"{i}";
                            sum += i;
                            number--;
                        }
                    }
                    Console.WriteLine($"{numbers} = {sum}");

                }
                else
                {
                    Console.WriteLine("Entered number less 1");
                }
            }
            catch
            {
                Console.WriteLine("Entered value is not a number!");
            }
#endif
            #endregion
        }
    }
}
