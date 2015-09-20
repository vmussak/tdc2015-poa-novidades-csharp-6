using System.Collections.Generic;

namespace NovidadesCSharp.ExpressoesLambda
{
    public class PedidoRepository
    {
        public IEnumerable<Pedido> ListarTodosOsPedidos()
        {
            var lstPedidos = new List<Pedido>();

            for (int i = 0; i < 30; i++)
                lstPedidos.Add(new Pedido($"Pedido {i:000}", i % 2 != 0));

            return lstPedidos;
        }
    }
}