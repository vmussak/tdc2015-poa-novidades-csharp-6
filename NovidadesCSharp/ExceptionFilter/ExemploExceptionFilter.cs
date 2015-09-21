using System;
using System.Diagnostics;

namespace NovidadesCSharp.ExceptionFilter
{
    public static class ExemploExceptionFilter
    {
        public static void GerarException()
        {
            try
            {
                throw new Exception("Ocorreu um erro qualquer");
            }
            catch (Exception ex) when (Debugger.IsAttached)
            {
                Console.WriteLine(ex.Message);
            }
            catch (Exception)
            {
                Console.WriteLine("Que pena, ocorreu um erro :( ");
            }
        }
    }
}