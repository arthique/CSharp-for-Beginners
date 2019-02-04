#define T01A
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
        }
    }
}
