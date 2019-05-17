using System;
using System.Collections.Generic;

namespace Quantas_Chamadas_Recursivas
{
    class Program
    {
        public static int MudarBase(int num, int novaBase)
        {
            int total = 0;
            int cont = 1;
            
            do
            {
                int digit = num % novaBase;
                num = num / novaBase;

                total += digit * cont;
                cont *= 10;
            }
            while (num != 0);
            return total;
        }

        public static UInt64 fib (UInt64 n, IDictionary<UInt64, UInt64> fibDic)
        {
            if (n == 0 || n == 1)
                return n;
            else 
            {
                if (fibDic.ContainsKey(n))
                    return fibDic[n];
                else
                {
                    UInt64 FibN = fib(n-1, fibDic) + fib(n-2, fibDic);
                    fibDic.Add(n, FibN);
                    return FibN;
                }
            }
        }

        static void Main(string[] args)
        {
            IDictionary<UInt64, UInt64> fibonacci = new Dictionary<UInt64, UInt64>();
            fibonacci.Add(0, 0);
            fibonacci.Add(1, 1);


            Console.WriteLine(MudarBase(10, 100));
        }
    }
}
