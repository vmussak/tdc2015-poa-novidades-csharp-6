using System;

namespace NovidadesCSharp.ExpressoesLambda
{
    public class Pedido
    {
        public Pedido(string descricao, bool confirmado)
        {
            Id = Guid.NewGuid();
            Descricao = descricao;
            Confirmado = confirmado;
        }

        public Guid Id { get; set; }
        public string Descricao { get; set; }
        public bool Confirmado { get; set; }

        public override string ToString()
        {
            return $"Id: {Id}\n Descricao: {Descricao}\n Confirmado: {(Confirmado ? "Sim": "Não")}";
        }
    }
}