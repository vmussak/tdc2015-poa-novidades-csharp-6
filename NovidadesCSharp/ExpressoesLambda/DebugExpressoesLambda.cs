using System;
using System.Linq;

namespace NovidadesCSharp.ExpressoesLambda
{
    public static class DebugExpressoesLambda
    {
        public static void VerPedidosPendentes()
        {
            var pedidos = new PedidoRepository().ListarTodosOsPedidos();

            var pedidosPendentesErrado = pedidos.Where(x => x.Confirmado || !x.Confirmado);

            Console.WriteLine("{0} Pedidos pendentes", pedidosPendentesErrado.Count());
            Console.WriteLine("Primeiro pedido:");
            Console.WriteLine(pedidosPendentesErrado.First().ToString());

            Console.ReadKey();
        }
    }
}