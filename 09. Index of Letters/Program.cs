using System;



namespace _09.Index_of_Letters
{
    public class Program
    {
        public static void Main(string[] args)
        {
            string word = Console.ReadLine();

            string[] alphabet = new string[] { "a", "b", "c", "d", "e", "f", "g", "h", "i", "j", "k", "l", "m", "n", "o", "p", "q", "r", "s", "t", "u", "v", "w", "x", "y", "z" };

            for (int i = 0; i < word.Length; i++)
            {
                for (int j = 0; j < alphabet.Length; j++)
                {
                    if (word[i].ToString().Contains(alphabet[j]))
                    {
                        Console.WriteLine("{0} -> {1}", word[i], j);

                    }
                }

            }
        }
    }
}
