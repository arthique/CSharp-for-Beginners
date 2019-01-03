#define T01
using System;

namespace HT_02
{
    class Program
    {
        static void Main(string[] args)
        {
            #region T01
#if (T01)

            const string numberText = "Enter number: ";
            int number;
            bool isDividedByThree;

            Console.Write(numberText);
            number = Convert.ToInt32(Console.ReadLine());
            isDividedByThree = number % 3 == 0;
            Console.WriteLine($"A number {number} is {(isDividedByThree ? "" : "not ")}divided by 3");

#endif
            #endregion
        }
    }
}