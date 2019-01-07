#define T03
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
        }
    }
}
