using System;

namespace Fibonacci_Quantas_Chamadas
{
    class Program
    {
        public static int FibonacciChamadas (int n, ref int call)
        {
            call ++;
            if (n == 1 || n == 0)
            {
                return n;
            }
            else
            {
                return FibonacciChamadas(n-1, ref call) + FibonacciChamadas(n-2, ref call);
            }
        }

        static void Main(string[] args)
        {
            int testes = int.Parse(Console.ReadLine());

            for (int i = 0; i < testes; i++)
            {
                int num = int.Parse(Console.ReadLine());
                int e = -1;
                int fib = FibonacciChamadas(num, ref e);

                Console.WriteLine("fib({0}) = {1} calls = {2}", num, e, fib);
            }
        }
    }
}
