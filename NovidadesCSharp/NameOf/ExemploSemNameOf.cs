using System;
using System.Linq.Expressions;

namespace NovidadesCSharp.NameOf
{
    public static class ExemploSemNameOf
    {
        public static void VerNomes()
        {
            var nomeDaPropriedade = "Qualquer coisa";
            Console.WriteLine(GetName(() => nomeDaPropriedade));
        }

        static string GetName<T>(Expression<Func<T>> expr)
        {
            return ((MemberExpression)expr.Body).Member.Name;
        }
    }
}