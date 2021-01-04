using System;

namespace Recursive_Fibonacci
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            int[] digits = new int[n];
            digits[0] = 1;
            digits[1] = 1;

            for (int i = 2; i < n; i++)
            {
                digits[i] = digits[i - 1] + digits[i-2];
            }
            Console.WriteLine(digits[n-1]);
        }
    }
}
