using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FormationCS
{
    static class Outils
    {
        public static int AskPositiveNumberNonZero(string question)
        {
            return AskNumberBetweenRange(question, 1, int.MaxValue, "ERROR: Value should be positive and non null");
        }

        public static int AskNumberBetweenRange(string question, int min, int max, string customMessage = null)
        {
            int number = AskNumber(question);

            if (number >= min && number <= max)
            {
                return number;
            }

            if (customMessage != null)
            {
                Console.WriteLine(customMessage);
            }
            else
            {
                Console.WriteLine($"ERROR: Input should be between {min} and {max}!");
            }

            Console.WriteLine("------");
            Console.WriteLine();

            return AskNumberBetweenRange(question, min, max, customMessage);
        }

        public static int AskNumber(string question)
        {
            while (true)
            {
                Console.Write($"{question} --> ");
                string? response = Console.ReadLine();

                Console.WriteLine();
                Console.WriteLine("------");

                try
                {
                    int length = int.Parse(response);

                    return length;
                }
                catch
                {
                    Console.WriteLine("ERROR: Only accepting numbers.");
                }

                Console.WriteLine("------");
                Console.WriteLine();
            }
        }
    }
}
