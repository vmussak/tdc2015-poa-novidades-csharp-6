using System;

namespace NovidadesCSharp.NameOf
{
    public static class ExemploNameOf
    {
        public static void VerNomes()
        {
            var nomeDaPropriedade = "Qualquer coisa";
            Console.WriteLine(nameof(nomeDaPropriedade));
        }
    }
}