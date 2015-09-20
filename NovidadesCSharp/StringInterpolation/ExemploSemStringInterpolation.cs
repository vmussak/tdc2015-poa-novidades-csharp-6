using System;

namespace NovidadesCSharp.StringInterpolation
{
    public static class ExemploSemStringInterpolation
    {
        public static void Concatenar()
        {
            long cpf = 18312864326;
            string nome = "Zézinho da Silva";
            byte idade = 15;

            var x = nome + ", " + idade + " anos";
            var y = string.Format("CPF: {0:000\\.000\\.000\\-00}", cpf);

            Console.WriteLine(x);
            Console.WriteLine(y);
        }
    }
}