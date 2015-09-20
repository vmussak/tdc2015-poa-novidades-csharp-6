using System;

namespace NovidadesCSharp.AutoPropertyInitializer
{
    public static class ExemploAutoPropertyInitializer
    {
        public static void NovoEvento()
        {
            var evento = new Evento();
            Console.WriteLine("Nome: {0}", evento.Nome);
            Console.WriteLine("Cidade: {0}", evento.Cidade);
            Console.WriteLine("Ano: {0}", evento.Ano);
        }

        private class Evento
        {
            public string Nome { get; set; } = "The Developers Conference";
            public string Cidade { get; set; } = "Porto Alegre";
            public int Ano { get; set; } = 2015;
        }
    }
}