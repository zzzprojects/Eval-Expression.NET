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
        public static IQueryable<object> SelectDynamic<TSource>(this IQueryable<TSource> source, Expression<Func<TSource, string>> selector)
        {
            return source.SelectDynamic(selector, null);
        }

        public static IQueryable<object> SelectDynamic<TSource>(this IQueryable<TSource> source, Expression<Func<TSource, string>> selector, object parameter)
        {
            return (IQueryable<object>) EvalLinq.Execute("{1}.Select({expression});", selector, parameter, source);
        }

        public static IQueryable<object> SelectDynamic<TSource>(this IQueryable<TSource> source, Expression<Func<TSource, int, string>> selector)
        {
            return source.SelectDynamic(selector, null);
        }

        public static IQueryable<object> SelectDynamic<TSource>(this IQueryable<TSource> source, Expression<Func<TSource, int, string>> selector, object parameter)
        {
            return (IQueryable<object>) EvalLinq.Execute("{1}.Select({expression});", selector, parameter, source);
        }
    }
}