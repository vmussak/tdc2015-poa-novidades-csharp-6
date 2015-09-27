using System;
using System.Linq;

namespace NovidadesCSharp.ExpressoesLambda
{
    public static class DebugExpressoesLambda
    {
        public static void VerPedidosPendentes()
        {
            var pedidos = new PedidoRepository().ListarTodosOsPedidos();

            var pedidosPendentes = pedidos.Where(x => !x.Confirmado);

            Console.WriteLine("{0} Pedidos pendentes", pedidosPendentes.Count());
            Console.WriteLine("Primeiro pedido:");
            Console.WriteLine(pedidosPendentes.First().ToString());
        }
    }
}