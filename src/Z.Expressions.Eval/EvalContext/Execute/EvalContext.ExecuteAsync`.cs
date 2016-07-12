// Description: C# Expression Evaluator | Evaluate, Compile and Execute C# code and expression at runtime.
// Website: http://eval-expression.net/
// Documentation: https://github.com/zzzprojects/Eval-Expression.NET/wiki
// Forum & Issues: https://github.com/zzzprojects/Eval-Expression.NET/issues
// License: https://github.com/zzzprojects/Eval-Expression.NET/blob/master/LICENSE
// More projects: http://www.zzzprojects.com/
// Copyright © ZZZ Projects Inc. 2014 - 2016. All rights reserved.


#if NET45
using System;
using System.Collections;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace Z.Expressions
{
    public partial class EvalContext
    {
        /// <summary>Compile and evaluate the code or expression and return the result of type TResult.</summary>
        /// <typeparam name="TResult">Type of the result of the evaluted code or expression.</typeparam>
        /// <param name="code">The code or expression to evaluate.</param>
        /// <returns>The evaluated result of type TResult or null that represents the evaluted code or expression.</returns>
        public async Task<TResult> ExecuteAsync<TResult>(string code)
        {
            return EvalCompiler.CompileAsync<Func<TResult>>(this, code, null, typeof (TResult), EvalCompilerParameterKind.None).Result();
        }

        /// <summary>Compile and evaluate the code or expression and return the result of type TResult.</summary>
        /// <typeparam name="TResult">Type of the result of the evaluted code or expression.</typeparam>
        /// <param name="code">The code or expression to evaluate.</param>
        /// <param name="parameters">The parameter values used to evaluates the code or expression.</param>
        /// <returns>The evaluated result of type TResult or null that represents the evaluted code or expression.</returns>
        public Task<TResult> ExecuteAsync<TResult>(string code, object parameters)
        {
            var parameterTypes = new Dictionary<string, Type> {{"{0}", parameters.GetType()}};

            if (parameters is IDictionary)
            {
                foreach (DictionaryEntry entry in (IDictionary) parameters)
                {
                    parameterTypes.Add(entry.Key.ToString(), entry.Value.GetType());
                }

                return Task.Run(() => EvalCompiler.Compile<Func<IDictionary, TResult>>(this, code, parameterTypes, typeof (TResult), EvalCompilerParameterKind.SingleDictionary)((IDictionary) parameters));
            }

            return Task.Run(() => EvalCompiler.Compile<Func<object, TResult>>(this, code, parameterTypes, typeof (TResult), EvalCompilerParameterKind.Untyped)(parameters));
        }

        /// <summary>Compile and evaluate the code or expression and return the result of type TResult.</summary>
        /// <typeparam name="TResult">Type of the result of the evaluted code or expression.</typeparam>
        /// <param name="code">The code or expression to evaluate.</param>
        /// <param name="parameters">The parameter values used to evaluates the code or expression.</param>
        /// <returns>The evaluated result of type TResult or null that represents the evaluted code or expression.</returns>
        public Task<TResult> ExecuteAsync<TResult>(string code, params object[] parameters)
        {
            var parameterTypes = new Dictionary<string, Type>();
            var parameterValues = new Dictionary<string, object>();

            for (var i = 0; i < parameters.Length; i++)
            {
                var key = string.Concat("{", i, "}");
                parameterValues.Add(key, parameters[i]);
                parameterTypes.Add(key, parameters[i].GetType());
            }

            return Task.Run(() => EvalCompiler.Compile<Func<IDictionary, TResult>>(this, code, parameterTypes, typeof (TResult), EvalCompilerParameterKind.Dictionary)(parameterValues));
        }
    }
}

#endif