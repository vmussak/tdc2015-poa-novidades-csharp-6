using System;
using static System.Math;

namespace NovidadesCSharp.UsingStatic
{
    public static class ExemploUsingStatic
    {
        public static void Produto(int a, int b)
        {
            var produto = Pow(a, b);
            Console.WriteLine(produto);
        }
    }
}