using System;
using System.Linq;

namespace Encrypt_Sort_and_Print_Array
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            int[] names = new int [n];
            int sum = 0;
            int current = 0;

            for (int i = 0; i < n; i++)
            {
                string name = Console.ReadLine();
                for (int k = 0; k < name.Length; k++)
                {
                    switch (name[k])
                    {
                        case 'u':
                            current = name[k] * name.Length;
                            sum += current;
                            break;
                        case 'U':
                            current = name[k] * name.Length;
                            sum += current;
                            break;
                        case 'a':
                            current = name[k] * name.Length;
                            sum += current;
                            break;
                        case 'A':
                            current = name[k] * name.Length;
                            sum += current;
                            break;
                        case 'i':
                            current = name[k] * name.Length;
                            sum += current;
                            break;
                        case 'I':
                            current = name[k] * name.Length;
                            sum += current;
                            break;
                        case 'o':
                            current = name[k] * name.Length;
                            sum += current;
                            break;
                        case 'O':
                            current = name[k] * name.Length;
                            sum += current;
                            break;
                        case 'e':
                            current = name[k] * name.Length;
                            sum += current;
                            break;
                        case 'E':
                            current = name[k] * name.Length;
                            sum += current;
                            break;

                        default:
                            current = name[k] / name.Length;
                            sum += current;
                            break;
                    }
                }
                names[i] = sum;
                sum = 0;
            }
            int temp;

            for (int i = 0; i < names.Length - 1; i++)
            {
                for (int j = i + 1; j < names.Length; j++)
                {
                    if (names[i] > names[j])
                    {

                        temp = names[i];
                        names[i] = names[j];
                        names[j] = temp;

                    }

                }

            }
            foreach (var item in names)
            {
                Console.WriteLine(item);
            }

        }
    }
}
