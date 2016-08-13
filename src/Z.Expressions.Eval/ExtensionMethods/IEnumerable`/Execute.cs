// Description: C# Expression Evaluator | Evaluate, Compile and Execute C# code and expression at runtime.
// Website: http://eval-expression.net/
// Documentation: https://github.com/zzzprojects/Eval-Expression.NET/wiki
// Forum & Issues: https://github.com/zzzprojects/Eval-Expression.NET/issues
// License: https://github.com/zzzprojects/Eval-Expression.NET/blob/master/LICENSE
// More projects: http://www.zzzprojects.com/
// Copyright © ZZZ Projects Inc. 2014 - 2016. All rights reserved.

using System.Collections;

namespace Z.Expressions
{
    public static partial class Extensions
    {
        public static object Execute(this IEnumerable source, string expression)
        {
            return source.Execute<object>(expression, null);
        }

        public static object Execute(this IEnumerable source, string expression, object parameter)
        {
            return source.Execute<object>(expression, parameter);
        }

        public static TValue Execute<TValue>(this IEnumerable source, string expression)
        {
            return source.Execute<TValue>(expression, null);
        }

        public static TValue Execute<TValue>(this IEnumerable source, string expression, object parameter)
        {
            return (TValue) EvalLinq.Execute("{1}." + expression, null, parameter, source);
        }
    }
}