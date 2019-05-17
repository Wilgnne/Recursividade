using System;

namespace Fatorial_Simples
{
    class Program
    {
        static int fatorial (int n)
        {
            if (n == 1 || n == 0)
                return 1;
            else
            {
                return n * fatorial(n -1);
            }
        }

        static void Main(string[] args)
        {
            Console.WriteLine(fatorial(int.Parse(Console.ReadLine())));
        }
    }
}
