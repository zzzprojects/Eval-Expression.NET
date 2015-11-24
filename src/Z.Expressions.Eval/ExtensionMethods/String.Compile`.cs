// Description: Evaluate, Compile and Execute C# code and expression at runtime
// Website & Documentation: https://github.com/zzzprojects/Eval-Expression.NET
// Forum: https://zzzprojects.uservoice.com/forums/327759-eval-expression-net
// License: http://www.zzzprojects.com/license-agreement/
// More projects: http://www.zzzprojects.com/
// Copyright (c) 2015 ZZZ Projects. All rights reserved.

using System.Collections.Generic;

namespace Z.Expressions
{
    public static partial class Extensions
    {
        /// <summary>Compile the code or expression and return a TDelegate of type Func or Action to execute.</summary>
        /// <typeparam name="TDelegate">Type of the delegate (Func or Action) to use to compile the code or expression.</typeparam>
        /// <param name="code">The code or expression to compile.</param>
        /// <returns>A TDelegate of type Func or Action that represents the compiled code or expression.</returns>
        public static TDelegate Compile<TDelegate>(this string code)
        {
            return EvalManager.DefaultContext.Compile<TDelegate>(code);
        }

        /// <summary>Compile the code or expression and return a TDelegate of type Func or action to execute.</summary>
        /// <typeparam name="TDelegate">Type of the delegate (Func or Action) to use to compile the code or expression.</typeparam>
        /// <param name="code">The code or expression to compile.</param>
        /// <param name="parameterNames">Parameter names used to compile the code or expressions.</param>
        /// <returns>A TDelegate of type Func or Action that represents the compiled code or expression.</returns>
        public static TDelegate Compile<TDelegate>(this string code, IEnumerable<string> parameterNames)
        {
            return EvalManager.DefaultContext.Compile<TDelegate>(code, parameterNames);
        }

        /// <summary>Compile the code or expression and return a TDelegate of type Func or Action to execute.</summary>
        /// <typeparam name="TDelegate">Type of the delegate (Func or Action) to use to compile the code or expression.</typeparam>
        /// <param name="code">The code or expression to compile.</param>
        /// <param name="parameterNames">Parameter names used to compile the code or expressions.</param>
        /// <returns>A TDelegate of type Func or Action that represents the compiled code or expression.</returns>
        public static TDelegate Compile<TDelegate>(this string code, params string[] parameterNames)
        {
            return EvalManager.DefaultContext.Compile<TDelegate>(code, parameterNames);
        }
    }
}