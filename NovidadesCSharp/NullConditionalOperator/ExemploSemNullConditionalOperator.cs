using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NovidadesCSharp.NullConditionalOperator
{
    public static class ExemploSemNullConditionalOperator
    {
        public static void NovoBairro()
        {
            var bairro = new Bairro("Centro");
            var cidade = bairro.Cidade != null
                ? bairro.Cidade.Nome
                : string.Empty;

            var bairro2 = new Bairro("Centro", "Franca");
            var cidade2 = bairro2.Cidade != null
                ? bairro2.Cidade.Nome
                : string.Empty;

            Console.WriteLine("Bairro 01");
            Console.WriteLine("Nome: {0}", bairro.Nome);
            Console.WriteLine("Cidade: {0}", cidade);

            Console.WriteLine("Bairro 02");
            Console.WriteLine("Nome: {0}", bairro2.Nome);
            Console.WriteLine("Cidade: {0}", cidade2);
        }
    }
}
