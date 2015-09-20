using System;

namespace NovidadesCSharp.AutoPropertyInitializer
{
    public static class ExemploSemAutoPropertyInitializer
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
            public Evento()
            {
                Nome = "The Developers Conference";
                Cidade = "Porto Alegre";
                Ano = 2015;
            }

            public string Nome { get; set; }
            public string Cidade { get; set; }
            public int Ano { get; set; }
        }
    }
}