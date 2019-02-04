#define T01
using System;

namespace HT_05
{
    class Program
    {
        static int CalculateDoubleFactorial(int n)
        {
            int s = 1;

            for (int k = (n % 2 == 0) ? 2 : 1; k <= n; k += 2)
            {
                s *= k;
            }
            return s;
        }

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
        }
    }
}
