using System;
using System.Linq;


namespace _08.Most_Frequent_Number
{
    public class Program
    {
        public static void Main(string[] args)
        {
            int[] sequance = Console.ReadLine().Split(new char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries).Select(int.Parse).ToArray();

            int maxCounter = 0;
            int mostFreqNumber = 0;

            for (int i = 0; i < sequance.Length; i++)
            {
                int counter = 0;
                for (int j = i; j < sequance.Length; j++)
                {
                    if (sequance[i]==sequance[j])
                    {
                        counter++;
                        if (counter>maxCounter)
                        {
                            maxCounter = counter;
                            mostFreqNumber = sequance[i];
                        }
                    }
                }
            }
            Console.WriteLine(mostFreqNumber);

        }
    }
}
