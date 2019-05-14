#define T06
using System;

namespace HT_05
{
    class Program
    {
        #region T01
#if (T01)
        static int CalculateDoubleFactorial(int n)
        {
            int s = 1;

            for (int k = (n % 2 == 0) ? 2 : 1; k <= n; k += 2)
            {
                s *= k;
            }
            return s;
        }
#endif
        #endregion
        #region T01A
#if (T01A)
        static int CalculateDoubleFactorialRecursively(int n)
        {
            if (n == 1)
            {
                return 1;
            }
            if (n == 2)
            {
                return 2;
            }
            else
            {
                return n * CalculateDoubleFactorialRecursively(n - 2);
            }

        }
#endif
        #endregion
        #region T02
#if (T02)
        static int CalculateSquareSumOfNaturalNumbers(int n)
        {
            int s = 0;
            for (int i = 0; i <= n; i += 1)
            {
                s += i * i;
            }
            return s;
        }
#endif
        #endregion
        #region T02A
#if (T02A)
        static int CalculateRecursiveSquareSumOfNaturalNumbers(int n)
        {
            if (n == 0)
            {
                return 0;
            }
            else if (n == 1)
            {
                return 1;
            }
            else
            {
                return n * n + CalculateRecursiveSquareSumOfNaturalNumbers(n - 1);
            }
        }
#endif
        #endregion
        #region T03
#if (T03)

        static int[] ClipArray(int[] items, int n)
        {
            int size = n;

            if (n > items.Length)
            {
                size = items.Length;
            }
            int[] tmpArray = new int[size];
            for (int i = 0; i < size; i += 1)
            {
                tmpArray[i] = items[i];
            }
            return tmpArray;
        }
#endif
        #endregion
        #region T04
#if (T04)
        static int[] ClipCharArray(char[] symbols, int n)
        {
            int size = n;
            if (n > symbols.Length)
            {
                size = symbols.Length;
            }
            int[] tmpArray = new int[size];
            for (int i = 0; i < size; i += 1)
            {
                tmpArray[i] = (int)symbols[i];
            }
            return tmpArray;
        }
#endif
        #endregion
        #region T05
#if (T05)
        static int CalculateAverage(int[] numbers)
        {
            int sum = 0;
            for (int i = 0; i < numbers.Length; i += 1)
            {
                sum += numbers[i];
            }
            return sum / numbers.Length;
        }
#endif
        #endregion
        #region T06
#if (T06)
        static int FindMaxValue(int[,] numbers, out int row, out int column)
        {
            row = 0;
            column = 0;
            int max = numbers[row, column];

            for (int i = 0, rowSize = numbers.GetLength(0); i < rowSize; i++)
            {
                for (int j = 0, colSize = numbers.GetLength(1); j < colSize; j++)
                {
                    if (numbers[i, j] > max)
                    {
                        max = numbers[i, j];
                        row = i;
                        column = j;
                    }
                }
            }
            return max;
        }
#endif
        #endregion
        static void Main(string[] args)
        {
            #region T01
#if (T01)

            const string numberText = "Enter a number: ";
            int number = 0;

            Console.Write(numberText);
            try
            {
                number = Convert.ToInt32(Console.ReadLine());
            }
            catch
            {
                Console.WriteLine("Entered value is not a number");
            }
            int doubleFactorial = CalculateDoubleFactorial(number);
            Console.Write($" double factorial {number}!! = {doubleFactorial}");

#endif
            #endregion
            #region T01A
#if (T01A)

            const string numberText = "Enter a number: ";
            int number = 0;

            Console.Write(numberText);
            try
            {
                number = Convert.ToInt32(Console.ReadLine());
            }
            catch
            {
                Console.WriteLine("Entered value is not a number");
            }
            int doubleFactorial = CalculateDoubleFactorialRecursively(number);
            Console.Write($" double factorial {number}!! = {doubleFactorial}");

#endif
            #endregion
            #region T02
#if (T02)
            const string numberText = "Enter a number: ";
            int number = 0;

            Console.Write(numberText);
            try
            {
                number = Convert.ToInt32(Console.ReadLine());
            }
            catch
            {
                Console.WriteLine("Entered value is not a number");
            }
            int squareOfSum = CalculateSquareSumOfNaturalNumbers(number);
            Console.Write($" Square of sum of number {number} = {squareOfSum}");
#endif
            #endregion
            #region T02A
#if (T02A)
            const string numberText = "Enter a number: ";
            int number = 0;

            Console.Write(numberText);
            try
            {
                number = Convert.ToInt32(Console.ReadLine());
            }
            catch
            {
                Console.WriteLine("Entered value is not a number");
            }
            int squareOfSum = CalculateRecursiveSquareSumOfNaturalNumbers(number);
            Console.Write($" Square of sum of number {number} = {squareOfSum}");
#endif
            #endregion
            #region T03
#if T03
            const string numberText = "Enter a number: ";
            int number = 0;
            int arraySize = 20;
            int[] numbers = new int[arraySize];
            Random rnd = new Random();
            for (int i = 0; i < arraySize; i++)
            {
                numbers[i] = rnd.Next(1, 10);
                Console.Write($"{numbers[i]} ");
            }

            Console.Write($"\n{numberText}");
            try
            {
                number = Convert.ToInt32(Console.ReadLine());
            }
            catch
            {
                Console.WriteLine("Entered value is not a number");
            }
            int[] result = ClipArray(numbers, number);
            Console.ForegroundColor = ConsoleColor.Yellow;
            for (int i = 0; i < result.Length; i++)
            {
                Console.Write($"{result[i]} ");
            }
            Console.ForegroundColor = ConsoleColor.White;

#endif
            #endregion
            #region T04
#if (T04)
            const string numberText = "Enter a number: ";
            int number = 0;
            int arraySize = 20;
            char[] symbols = new char[arraySize];
            Random rnd = new Random();
            for (int i = 0; i < arraySize; i++)
            {
                symbols[i] = (char)rnd.Next(56, 127);
                Console.Write($"{symbols[i]} ");
            }
            Console.Write(numberText);
            try
            {
                number = Convert.ToInt32(Console.ReadLine());
            }
            catch
            {
                Console.WriteLine("Entered value is not a number");
            }
            int[] result = ClipCharArray(symbols, number);
            Console.ForegroundColor = ConsoleColor.Yellow;
            for (int i = 0; i < result.Length; i++)
            {
                Console.Write($"{result[i]} ");
            }
            Console.ForegroundColor = ConsoleColor.White;

#endif
            #endregion
            #region T05
#if (T05)
            const string numberText = "Enter a number: ";
            int number = 0;

            Console.Write($"\n{numberText}");
            try
            {
                number = Convert.ToInt32(Console.ReadLine());
            }
            catch
            {
                Console.WriteLine("Entered value is not a number");
            }
            int[] numbers = new int[number];
            Random rnd = new Random();
            Console.ForegroundColor = ConsoleColor.Yellow;
            for (int i = 0; i < number; i++)
            {
                numbers[i] = rnd.Next(1, 100);
                Console.Write($"{numbers[i]} ");
            }
            Console.ForegroundColor = ConsoleColor.White;

            int result = CalculateAverage(numbers);
            Console.Write($"Average of numbers = {result} ");
#endif
            #endregion
            #region T06
#if (T06)
            int[,] numbers = new int[5, 5];
            Random rnd = new Random();

            Console.ForegroundColor = ConsoleColor.Yellow;
            Console.WriteLine("Numbers: ");
            for (int i = 0, rowSize = numbers.GetLength(0); i < rowSize; i++)
            {
                for (int j = 0, colSize = numbers.GetLength(1); j < colSize; j++)
                {

                    numbers[i, j] = rnd.Next(0, 100);
                    Console.Write($"{numbers[i, j]}\t");
                }
                Console.WriteLine();
            }
            Console.ForegroundColor = ConsoleColor.White;
            int row, column;
            int result = FindMaxValue(numbers, out row, out column);
            Console.Write($"Max of numbers = {result}, row {row}, column {column}");

#endif
            #endregion
        }
    }
}
