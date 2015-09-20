using System;

namespace NovidadesCSharp.UsingStatic
{
    public static class ExemploSemUsingStatic
    {
        public static void Produto(int a, int b)
        {
            var produto = Math.Pow(a, b);
            Console.WriteLine(produto);
        }
    }
}