using System;
using System.Linq;


namespace _02.Rotate_and_Sum
{
    public class Program
    {
        public static void Main(string[] args)
        {
            var array = Console.ReadLine().Split(' ').Select(int.Parse).ToArray();
            int numberOfRotations = int.Parse(Console.ReadLine());

            int[] sumRotated = new int[array.Length];

            for (int i = 0; i < numberOfRotations; i++)
            {
                int[] rotatedNumbers = new int[array.Length];
                rotatedNumbers[0] = array[array.Length - 1];

                for (int j = 1; j < array.Length; j++)
                {
                    rotatedNumbers[j] = array[j - 1];
                }
                for (int j = 0; j < array.Length; j++)
                {
                    sumRotated[j] += rotatedNumbers[j];
                    array = rotatedNumbers;
                }
            }
            Console.WriteLine(string.Join(" ", sumRotated));
        }
    }
}
