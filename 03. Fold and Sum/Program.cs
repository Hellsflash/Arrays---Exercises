using System;
using System.Linq;

namespace _03.Fold_and_Sum
{
    public class Program
    {
        public static void Main(string[] args)
        {
            var Array = Console.ReadLine().Split(' ').Select(int.Parse).ToArray();

            int k = Array.Length / 4;

            var leftRow = Array.Take(k).Reverse();
            var rightRow = Array.Reverse().Take(k);

            var firstRow = leftRow.Concat(rightRow).ToArray();
            var secondRow = Array.Skip(k).Take(2 * k).ToArray();
            var sumRows = firstRow.Select((x, index) => x + secondRow[index]);
            Console.WriteLine(string.Join(" ",sumRows));
         }
    }
}
