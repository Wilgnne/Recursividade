using System;

namespace Soma_de_Fatoriais
{
    class Program
    {
        static UInt64 fatorial (UInt64 n)
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
            while(true)
            {
                string entrada = Console.ReadLine();
                if (String.IsNullOrEmpty(entrada))
                    break;
                string[] NM = entrada.Split(new char[] {' '});
                Console.WriteLine((fatorial(UInt64.Parse(NM[0])) + fatorial(UInt64.Parse(NM[1]))));
            }
        }
    }
}
