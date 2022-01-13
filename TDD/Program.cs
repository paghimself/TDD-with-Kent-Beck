using System;
using TDD.Tools;

namespace TDD
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var a = Money.Dollar(1);
            Console.WriteLine(a);

            var b = Money.Franc(10);
            Console.WriteLine(b);
        }
    }
}
