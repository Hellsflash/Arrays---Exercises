using System;
using System.Linq;

namespace _7.Max_Sequence_of_Increasing_Elements
{
    public class Program
    {
        public static void Main(string[] args)
        {
            int[] sequance = Console.ReadLine().Split(new char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries).Select(int.Parse).ToArray();

            int startSequance = 0;
            int lehgthOFSequance = 1;
            int currStart = 0;
            int currLength = 1;

            for (int i = 1; i < sequance.Length; i++)
            {
                if (sequance[i] > sequance[i - 1])
                {
                    currLength++;

                    if (currLength > lehgthOFSequance)
                    {
                        lehgthOFSequance = currLength;
                        startSequance = currStart;

                    }

                }
                else
                {
                    
                    currStart = i;
                    currLength = 1;

                }
            }

            for (int i = startSequance; i < startSequance+lehgthOFSequance ; i++)
            {
                Console.Write("{0} ", sequance[i]);
            }
            Console.WriteLine();
        }
    }
}
