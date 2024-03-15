using System;

namespace BetterDecorator
{
    class Program
    {
        private static string Decor(string s, char dec, int n)
        {
            return $"{"dec"*n} {s} {"dec"*n}";
        }
        private static void Main(string[] args)
        {
            Console.WriteLine(Decor("Good Morning!", '*', 4));
            Console.WriteLine(Decor("Good Morning!", '.', 2));
        }
    }
}