using System;
using System.Diagnostics;

namespace NovidadesCSharp.ExceptionFilter
{
    public static class ExemploSemExceptionFilter
    {
        public static void GerarException()
        {
            try
            {
                throw new Exception("Ocorreu um erro qualquer");
            }
            catch (Exception ex)
            {
                if (Debugger.IsAttached)
                    Console.WriteLine(ex.Message);
                else
                    Console.WriteLine("Que pena, ocorreu um erro :( ");
            }
        }
    }
}