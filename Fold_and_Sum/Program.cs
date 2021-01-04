using System;
using System.Linq;

namespace Fold_and_Sum
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] numbers = Console.ReadLine()
                 .Split()
                 .Select(int.Parse)
                 .ToArray();
            int[] results = new int[numbers.Length / 2];

            for (int i = 0; i < numbers.Length / 4; i++)
            {
                results[i] = numbers[(numbers.Length / 4) + i] + numbers[(numbers.Length / 4) - 1 - i];
            }

            for (int i = (numbers.Length / 2) - 1; i >= numbers.Length / 4; i--)
            {
                results[i] = numbers[(numbers.Length / 4) + i] + numbers[(numbers.Length + numbers.Length / 4) - 1 - i];
            }

            Console.WriteLine(string.Join(" ", results));
        }
    }
}
