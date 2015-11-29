// Description: C# Expression Evaluator | Evaluate, Compile and Execute C# code and expression at runtime.
// Website & Documentation: https://github.com/zzzprojects/Eval-Expression.NET
// Forum: https://zzzprojects.uservoice.com/forums/327759-eval-expression-net
// License: http://www.zzzprojects.com/license-agreement/
// More projects: http://www.zzzprojects.com/
// Copyright (c) 2015 ZZZ Projects. All rights reserved.

using System;
using System.Collections.Generic;
using System.Linq;

namespace Z.Expressions
{
    internal static partial class EvalCompiler
    {
        /// <summary>Resolve and return the cache key used in the EvalManager cache.</summary>
        /// <param name="context">The eval context used to compile the code or expression.</param>
        /// <param name="tdelegate">Type of the delegate (Func or Action) to use to compile the code or expression.</param>
        /// <param name="code">The code or expression to compile.</param>
        /// <param name="parameterTypes">List of parameter types used to compile the code or expression.</param>
        /// <returns>A string representing a unique key for the combinaison delegate/code/parameter types.</returns>
        private static string ResolveCacheKey(EvalContext context, Type tdelegate, string code, IDictionary<string, Type> parameterTypes)
        {
            // Concatenate:
            // - CacheKey Prefix
            // - Code or expression
            // - Delegate
            // - Parameter Types
            return string.Concat(context.CacheKeyPrefix,
                ";",
                code,
                ";",
                tdelegate.FullName,
                ";",
                parameterTypes == null ? "" : string.Join(";", parameterTypes.Values.Select(x => x.FullName)));
        }
    }
}