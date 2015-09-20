using System;

namespace NovidadesCSharp.NullConditionalOperator
{
    public static class ExemploNullConditionalOperator
    {
        public static void NovoBairro()
        {
            var bairro = new Bairro("Centro");
            var cidade = bairro.Cidade?.Nome;

            var bairro2 = new Bairro("Centro", "Franca");
            var cidade2 = bairro2.Cidade?.Nome;

            Console.WriteLine("Bairro 01");
            Console.WriteLine("Nome: {0}", bairro.Nome);
            Console.WriteLine("Cidade: {0}", cidade);

            Console.WriteLine("Bairro 02");
            Console.WriteLine("Nome: {0}", bairro2.Nome);
            Console.WriteLine("Cidade: {0}", cidade2);
        }
    }
}