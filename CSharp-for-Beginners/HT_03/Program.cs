#define T03
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
        }
    }
}
