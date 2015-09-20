using System;

namespace NovidadesCSharp.ExpressionBodiedMembers
{
    public static class ExemploSemExpressionBodiedMembers
    {
        public static void NovaPessoa()
        {
            var pessoa = new Pessoa("Vinicius", "Mussak");
            Console.WriteLine(pessoa.NomeCompleto);
        }

        private class Pessoa
        {
            public Pessoa(string nome, string sobrenome)
            {
                Nome = nome;
                Sobrenome = sobrenome;
            }

            public string Nome { get; set; }
            public string Sobrenome { get; set; }

            public string NomeCompleto
            {
                get { return Nome + " " + Sobrenome; }
            }
        }
    }
}
