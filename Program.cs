using System;

namespace Aula25Fibonacci
{
    class Program
    {
        static void Main(string[] args)
        {
            Recursividade rec = new Recursividade();
            rec.GerarSequenciaFibonacci(0, 1, 10);

            System.Console.WriteLine("\n"+rec.GerarFatorial(5));

        }
    }
}
