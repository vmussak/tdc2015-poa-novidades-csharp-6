namespace NovidadesCSharp.NullConditionalOperator
{
    public class Bairro
    {
        public Bairro(string nome)
        {
            Nome = nome;
        }

        public Bairro(string nome, string nomeCidade) : this(nome)
        {
            Cidade = new Cidade(nomeCidade);
        }

        public string Nome { get; set; }
        public Cidade Cidade { get; set; }
    }
}