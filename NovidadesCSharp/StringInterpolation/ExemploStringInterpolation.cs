using System;

namespace NovidadesCSharp.StringInterpolation
{
    public static class ExemploStringInterpolation
    {
        public static void Concatenar()
        {
            long cpf = 18312864326;
            string nome = "Zézinho da Silva";
            byte idade = 15;

            var x = $"{nome}, {idade} anos";
            var y = $"CPF: {cpf:000\\.000\\.000\\-00}";

            Console.WriteLine(x);
            Console.WriteLine(y);
        }
    }
}