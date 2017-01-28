using System;
using System.Linq;

namespace _04.Sieve_of_Eratosthenes
{
    public class Program
    {
        public static void Main(string[] args)
        {
            int numbers = int.Parse(Console.ReadLine());

            bool[] primes = new bool[numbers + 1];

            for (int i = 0; i <= numbers; i++)
            {
                primes[i] = true;
            }
            primes[0] = primes[1] = false;

            for (int i = 0; i < primes.Length; i++)
            {
                if (primes[i] == true)
                {
                    for (int j = 2; (j * i) <= numbers; j++)
                    {
                        primes[j * i] = false;
                    }
                }
            }
            for (int i = 2; i <= numbers; i++)
            {
                if (primes[i] == true)
                {
                    Console.Write(i+" ");
                }

            }
            Console.WriteLine();
        }
    }
}
