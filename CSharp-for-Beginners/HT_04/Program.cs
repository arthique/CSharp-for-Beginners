#define T07
using System;

namespace HT_04
{
    class Program
    {
        static void Main(string[] args)
        {
            #region T01
#if (T01)

            const string sizeText = "Enter array size: ";
            int arraySize;
            int[] numberArray;

            try
            {
                Console.Write(sizeText);
                arraySize = Int32.Parse(Console.ReadLine());
                numberArray = new int[arraySize];
                for (int i = 0, count = 0; count < arraySize; i++)
                {
                    if (i / 5 > 0 && i % 5 == 2)
                    {
                        numberArray[count] = i;
                        Console.Write($"{(count > 0 ? $"\t{numberArray[count]}" : $"{numberArray[count]}")}");
                        count++;
                    }
                }

            }
            catch
            {
                Console.WriteLine("Entered value is not a number!");
            }

#endif
            #endregion

            #region T02
#if (T02)

            const string sizeText = "Enter array size: ";
            int arraySize;
            double[] numberArray;
            int value = 2;

            try
            {
                Console.Write(sizeText);
                arraySize = Int32.Parse(Console.ReadLine());
                numberArray = new double[arraySize];

                for (int i = 0; i < arraySize; i++)
                {
                    numberArray[i] = Math.Pow(value, i);
                }
                for (int i = 0, size = numberArray.Length; i < size; i++)
                {
                    Console.WriteLine("{0}^{1} = {2:N0}", value, i, numberArray[i]);
                }
                Console.WriteLine();
                for (int i = numberArray.Length - 1; i >= 0; i--)
                {
                    Console.WriteLine("{0}^{1} = {2:N0}", value, i, numberArray[i]);
                }
            }
            catch
            {
                Console.WriteLine("Entered value is not a number!");
            }

#endif
            #endregion

            #region T03
#if (T03)

            const string sizeText = "Enter array size: ";
            int arraySize;
            char[] symbs;
            char firstElement = 'a';

            try
            {
                Console.Write(sizeText);
                arraySize = Int32.Parse(Console.ReadLine());
                symbs = new char[arraySize];
                for (int i = 0; i < arraySize; i++)
                {
                    symbs[i] = (char)(firstElement + (i * 2));
                }
                for (int i = 0, size = symbs.Length; i < size; i++)
                {
                    Console.Write($"{symbs[i]} ");
                }
                Console.WriteLine();
                for (int i = symbs.Length - 1; i >= 0; i--)
                {
                    Console.Write($"{symbs[i]} ");
                }
            }
            catch
            {
                Console.WriteLine("Entered value is not a number!");
            }

#endif
            #endregion

            #region T04
#if (T04)

            int arraySize = 10;
            char[] symbs = new char[arraySize];
            char symb = 'A';

            for (int i = 0; i < arraySize; i++)
            {
                symb = (char)(symb + 1);
            MYSYMB:
                if (symb == 'A' || symb == 'E' || symb == 'I')
                {
                    symb = (char)(symb + 1);
                    goto MYSYMB;
                }
                symbs[i] = symb;
            }
            foreach (char s in symbs)
            {
                Console.Write($"{s} ");
            }

#endif
            #endregion

            #region T05
#if (T05)

            int arraySize = 20;
            int[] numbers = new int[arraySize];
            int minNumber;
            string indexes = String.Empty;
            Random rnd = new Random();

            for (int i = 0; i < arraySize; i++)
            {
                numbers[i] = rnd.Next(1, 10);
                Console.Write($"{numbers[i]} ");
            }

            minNumber = numbers[0];
            foreach (int num in numbers)
            {
                if (minNumber > num)
                {
                    minNumber = num;
                }
            }
            Console.Write($"\nMin number = {minNumber} in the indexes ");
            for (int i = 0; i < arraySize; i++)
            {
                if (numbers[i] == minNumber)
                {
                    indexes += indexes == String.Empty ? $"{i}" : $", {i}";
                }
            }
            Console.Write($"{indexes}");

#endif
            #endregion

            #region T06
#if (T06)

            int arraySize = 20;
            int[] numbers = new int[arraySize];
            Random rnd = new Random();

            Console.WriteLine("Created array");
            for (int i = 0; i < arraySize; i++)
            {
                numbers[i] = rnd.Next(1, 100);
                Console.Write($"{numbers[i]} ");
            }
            for (int i = 1, s; i < arraySize; i++)
            {
                for (int j = 0; j < arraySize - 1; j++)
                {
                    if (numbers[j] < numbers[j + 1])
                    {
                        s = numbers[j + 1];
                        numbers[j + 1] = numbers[j];
                        numbers[j] = s;

                    }
                }
            }
            Console.ForegroundColor = ConsoleColor.Yellow;
            Console.WriteLine("\n\nSorted array");
            for (int i = 0; i < arraySize; i++)
            {
                Console.Write($"{numbers[i]} ");
            }
            Console.ForegroundColor = ConsoleColor.White;

#endif
            #endregion

            #region T07
#if (T07)

            char[] symbols = new char[11];
            char tmp;
            Random rnd = new Random();

            for (int i = 0, size = symbols.Length; i < size; i++)
            {
                symbols[i] = (char)('A' + rnd.Next(0, 25));
            }
            Console.WriteLine("Original array:");
            foreach (char symbol in symbols)
            {
                Console.Write($"{symbol} ");
            }
            for (int i = 0, size = symbols.Length; i < size / 2; i++)
            {
                tmp = symbols[size - (1 + i)];
                symbols[size - (1 + i)] = symbols[i];
                symbols[i] = tmp;
            }
            Console.ForegroundColor = ConsoleColor.Yellow;
            Console.WriteLine("\n\nReverse array:");
            foreach (char symbol in symbols)
            {
                Console.Write($"{symbol} ");
            }
            Console.ForegroundColor = ConsoleColor.White;

#endif
            #endregion
        }
    }
}
