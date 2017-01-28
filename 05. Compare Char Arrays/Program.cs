using System;
using System.Linq;

namespace _05.Compare_Char_Arrays
{
    class Program
    {
        static void Main(string[] args)
        {
            var firstArray = Console.ReadLine().Split(' ').Select(char.Parse).ToArray();
            var secondArray = Console.ReadLine().Split(' ').Select(char.Parse).ToArray();

            if (firstArray.Length < secondArray.Length)
            {
                Console.WriteLine("{0}\n{1}", string.Join("", firstArray), string.Join("", secondArray));
            }
            else if (firstArray.Length > secondArray.Length)
            {
                Console.WriteLine("{0}\n{1}", string.Join("", secondArray), string.Join("", firstArray));
            }
            else if (firstArray.Length == secondArray.Length)
            {
                for (int i = 0; i < Math.Min(firstArray.Length, secondArray.Length); i++)
                {
                    if (firstArray[i] > secondArray[i])
                    {
                        Console.WriteLine("{0}\n{1}", string.Join("", secondArray), string.Join("", firstArray));
                        break;
                    }
                    else if (firstArray[i] < secondArray[i])
                    {
                        Console.WriteLine("{0}\n{1}", string.Join("", firstArray), string.Join("", secondArray));
                        break;
                    }
                    else if (firstArray[i] == secondArray[i])
                    {

                        Console.WriteLine("{0}\n{1}", string.Join("", firstArray), string.Join("", secondArray));
                        break;
                    }
                }
            }

        }
    }
}
