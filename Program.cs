using System;
using NUnit;

namespace FizzBuzzConsoleApp
{
    class Program
    {
        public static string[] FizzBuzz(int limit)
        {
            string[] FizzBuzzResult = new string[limit];
            for (int i = 1; i <= limit; i++)
            {
                Console.WriteLine("hello");
                string result = "";
                if (i%3 != 0 && i%5 != 0)
                {
                    result = i.ToString();
                }
                else
                {
                    if (i % 3 == 0) { result += "Fizz"; }
                    if (i % 5 == 0) { result += "Buzz"; }
                }
                FizzBuzzResult[i-1] = result;
            }
            return FizzBuzzResult;
        }

        public void WriteFizzBuzz(int limit)
        {
            foreach(string result in FizzBuzz(limit))
            {
                Console.WriteLine(result);
            }
        }
    }
}


