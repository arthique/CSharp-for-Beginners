#define T01
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
        }
    }
}
