#define T01
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
        }
    }
}
