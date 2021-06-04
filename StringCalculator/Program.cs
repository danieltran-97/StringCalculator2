using System;

namespace StringCalculator
{
    public static class Program
    {
        public static void Main(string[] args)
        {
            var stringCalculator = new StringCalculator();
            var input = GetInputFromConsole();

            Console.WriteLine(stringCalculator.Add(input));

        }

        private static string GetInputFromConsole()
        {
            Console.Write("Please enter a number:   ");
            return Console.ReadLine();
        }
    }
}