using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NovidadesCSharp.ExpressionBodiedMembers
{
    public static class ExemploExpressionBodiedMembers
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

            public string NomeCompleto => Nome + " " + Sobrenome;
        }
    }
}
