// Description: C# Expression Evaluator | Evaluate, Compile and Execute C# code and expression at runtime.
// Website: http://eval-expression.net/
// Documentation: https://github.com/zzzprojects/Eval-Expression.NET/wiki
// Forum & Issues: https://github.com/zzzprojects/Eval-Expression.NET/issues
// License: https://github.com/zzzprojects/Eval-Expression.NET/blob/master/LICENSE
// More projects: http://www.zzzprojects.com/
// Copyright © ZZZ Projects Inc. 2014 - 2016. All rights reserved.

using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;

namespace Z.Expressions
{
    public static partial class Extensions
    {
        public static IOrderedEnumerable<TSource> ThenByDynamic<TSource>(this IOrderedQueryable<TSource> source, Expression<Func<TSource, string>> keySelector)
        {
            return source.ThenByDynamic(keySelector, null);
        }

        public static IOrderedEnumerable<TSource> ThenByDynamic<TSource>(this IOrderedQueryable<TSource> source, Expression<Func<TSource, string>> keySelector, object parameter)
        {
            return (IOrderedEnumerable<TSource>) EvalLinq.Execute("{1}.ThenBy({expression});", keySelector, parameter, source);
        }

        public static IOrderedEnumerable<TSource> ThenByDynamic<TSource, TKey>(this IOrderedQueryable<TSource> source, Expression<Func<TSource, string>> keySelector, IComparer<TKey> comparer)
        {
            return source.ThenByDynamic(keySelector, comparer, null);
        }

        public static IOrderedEnumerable<TSource> ThenByDynamic<TSource, TKey>(this IOrderedQueryable<TSource> source, Expression<Func<TSource, string>> keySelector, IComparer<TKey> comparer, object parameter)
        {
            return (IOrderedEnumerable<TSource>) EvalLinq.Execute("{1}.ThenBy({expression}, {2});", keySelector, parameter, source, comparer);
        }
    }
}