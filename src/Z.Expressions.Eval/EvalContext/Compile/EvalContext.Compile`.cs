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

namespace Z.Expressions
{
    public partial class EvalContext
    {
        /// <summary>Compile the code or expression and return a TDelegate of type Func or Action to execute.</summary>
        /// <typeparam name="TDelegate">Type of the delegate (Func or Action) to use to compile the code or expression.</typeparam>
        /// <param name="code">The code or expression to compile.</param>
        /// <returns>A TDelegate of type Func or Action that represents the compiled code or expression.</returns>
        public TDelegate Compile<TDelegate>(string code)
        {
            return Compile<TDelegate>(code, null);
        }

        /// <summary>Compile the code or expression and return a TDelegate of type Func or Action to execute.</summary>
        /// <typeparam name="TDelegate">Type of the delegate (Func or Action) to use to compile the code or expression.</typeparam>
        /// <param name="code">The code or expression to compile.</param>
        /// <param name="parameterNames">Parameter names used to compile the code or expressions.</param>
        /// <returns>A TDelegate of type Func or Action that represents the compiled code or expression.</returns>
        public TDelegate Compile<TDelegate>(string code, IEnumerable<string> parameterNames)
        {
            return Compile<TDelegate>(code, parameterNames.ToArray());
        }

        /// <summary>Compile the code or expression and return a TDelegate of type Func or Action to execute.</summary>
        /// <typeparam name="TDelegate">Type of the delegate (Func or Action) to use to compile the code or expression.</typeparam>
        /// <param name="code">The code or expression to compile.</param>
        /// <param name="parameterNames">Parameter names used to compile the code or expressions.</param>
        /// <returns>A TDelegate of type Func or Action that represents the compiled code or expression.</returns>
        public TDelegate Compile<TDelegate>(string code, params string[] parameterNames)
        {
            var parameterTypes = new Dictionary<string, Type>();

            var tDelegate = typeof (TDelegate);
            var arguments = tDelegate.GetGenericArguments();
            var isAction = tDelegate.FullName.StartsWith("System.Action");

            var tReturn = isAction ? null : arguments.Last();
            var lastArgumentPosition = isAction ? arguments.Length : arguments.Length - 1;

            for (var i = 0; i < lastArgumentPosition; i++)
            {
                if (parameterNames != null && i <= parameterNames.Length)
                {
                    parameterTypes.Add(parameterNames[i], arguments[i]);
                }
                else
                {
                    parameterTypes.Add(string.Concat("{", i, "}"), arguments[i]);
                }
            }

            return EvalCompiler.Compile<TDelegate>(this, code, parameterTypes, tReturn, EvalCompilerParameterKind.Typed);
        }
    }
}