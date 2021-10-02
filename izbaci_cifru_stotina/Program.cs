using System;

namespace zbir_cifara
{
    class Program
    {
        static void Main(string[] args)
        {
            int n, a, b, c;

            n = int.Parse(Console.ReadLine());

            a = n / 1000;
            b = n % 100;
            c = 100 * a + b;

            Console.WriteLine(c);
        }
    }
}
