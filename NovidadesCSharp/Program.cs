using NovidadesCSharp.AutoPropertyInitializer;
using NovidadesCSharp.ChamadasAssincronas;
using NovidadesCSharp.ExceptionFilter;
using NovidadesCSharp.ExpressionBodiedMembers;
using NovidadesCSharp.ExpressoesLambda;
using NovidadesCSharp.NameOf;
using NovidadesCSharp.NullConditionalOperator;
using NovidadesCSharp.StringInterpolation;
using NovidadesCSharp.UsingStatic;
using System;

namespace NovidadesCSharp
{
    class Program
    {
        static void Main(string[] args)
        {
            //DebugExpressoesLambda.VerPedidosPendentes();

            //ExemploUsingStatic.Produto(10, 20);
            //ExemploSemUsingStatic.Produto(10, 20);

            //ExemploAutoPropertyInitializer.NovoEvento();
            //ExemploSemAutoPropertyInitializer.NovoEvento();

            //ExemploExpressionBodiedMembers.NovaPessoa();
            //ExemploSemExpressionBodiedMembers.NovaPessoa();

            //ExemploNullConditionalOperator.NovoBairro();
            //ExemploSemNullConditionalOperator.NovoBairro();

            //ExemploStringInterpolation.Concatenar();
            //ExemploSemStringInterpolation.Concatenar();

            //ExemploExceptionFilter.GerarException();
            //ExemploSemExceptionFilter.GerarException();

            //ExemploNameOf.VerNomes();
            //ExemploSemNameOf.VerNomes();
            
            ExemploChamadasAssincronas.Testar();

            Console.ReadKey();
        }
    }
}