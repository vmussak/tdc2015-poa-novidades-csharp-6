using System;
using System.Threading;
using System.Threading.Tasks;

namespace NovidadesCSharp.ChamadasAssincronas
{
    public static class ExemploChamadasAssincronas
    {
		private static int count = 0;
		
		public static void Testar()
		{
			Console.WriteLine($"{++count} - Antes do método | Thread {Thread.CurrentThread.ManagedThreadId}");
            MetodoQualquer();
            Console.WriteLine($"{++count} - Depois do método | Thread {Thread.CurrentThread.ManagedThreadId}");
		}
		
        public static async void MetodoQualquer()
        {
            try
            {
                throw new Exception();
            }
            catch (Exception)
            {
                Console.WriteLine($"{++count} - Antes do catch await | Thread {Thread.CurrentThread.ManagedThreadId}");
                await TestAsync("catch");
                Console.WriteLine($"{++count} - Depois do catch await | Thread {Thread.CurrentThread.ManagedThreadId}");
            }
            finally
            {
                Console.WriteLine($"{++count} - Antes do finally await | Thread {Thread.CurrentThread.ManagedThreadId}");
                await TestAsync("finally");
                Console.WriteLine($"{++count} - Depois do finally await | Thread {Thread.CurrentThread.ManagedThreadId}");
            }
        }

        public static Task TestAsync(string quemChamou)
        {
            return Task.Factory.StartNew(() =>
            {
                Console.WriteLine($"{++count} - Método assíncrono antes da Thread - {quemChamou} | Thread {Thread.CurrentThread.ManagedThreadId}");
                Thread.Sleep(1000);
                Console.WriteLine($"{++count} - Método assíncrono depois da Thread - {quemChamou} | Thread {Thread.CurrentThread.ManagedThreadId}");
            });
        }
    }
}