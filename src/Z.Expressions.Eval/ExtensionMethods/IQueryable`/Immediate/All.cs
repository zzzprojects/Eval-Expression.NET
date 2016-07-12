// Description: C# Expression Evaluator | Evaluate, Compile and Execute C# code and expression at runtime.
// Website: http://eval-expression.net/
// Documentation: https://github.com/zzzprojects/Eval-Expression.NET/wiki
// Forum & Issues: https://github.com/zzzprojects/Eval-Expression.NET/issues
// License: https://github.com/zzzprojects/Eval-Expression.NET/blob/master/LICENSE
// More projects: http://www.zzzprojects.com/
// Copyright © ZZZ Projects Inc. 2014 - 2016. All rights reserved.

using System;
using System.Linq;
using System.Linq.Expressions;

namespace Z.Expressions
{
    public static partial class Extensions
    {
        public static bool All<TSource>(this IQueryable<TSource> source, Expression<Func<TSource, string>> predicate)
        {
            return source.All(predicate, null);
        }

        public static bool All<TSource>(this IQueryable<TSource> source, Expression<Func<TSource, string>> predicate, object parameter)
        {
            return (bool) EvalLinq.Execute("{1}.All({expression});", predicate, parameter, source);
        }
    }
}