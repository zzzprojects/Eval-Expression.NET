// Description: Evaluate, Compile and Execute C# code and expression at runtime
// Website & Documentation: https://github.com/zzzprojects/Eval-Expression.NET
// Forum: https://zzzprojects.uservoice.com/forums/327759-eval-expression-net
// License: http://www.zzzprojects.com/license-agreement/
// More projects: http://www.zzzprojects.com/
// Copyright (c) 2015 ZZZ Projects. All rights reserved.

using System;
using System.Collections;
using System.Collections.Generic;

namespace Z.Expressions
{
    public partial class EvalContext
    {
        /// <summary>Compile and evaluate the code or expression and return the result of type TResult.</summary>
        /// <typeparam name="TResult">Type of the result of the evaluted code or expression.</typeparam>
        /// <param name="code">The code or expression to evaluate.</param>
        /// <returns>The evaluated result of type TResult or null that represents the evaluted code or expression.</returns>
        public TResult Execute<TResult>(string code)
        {
            return EvalCompiler.Compile<Func<TResult>>(this, code, null, typeof (TResult), EvalCompilerParameterKind.None)();
        }

        /// <summary>Compile and evaluate the code or expression and return the result of type TResult.</summary>
        /// <typeparam name="TResult">Type of the result of the evaluted code or expression.</typeparam>
        /// <param name="code">The code or expression to evaluate.</param>
        /// <param name="parameters">The parameter values used to evaluates the code or expression.</param>
        /// <returns>The evaluated result of type TResult or null that represents the evaluted code or expression.</returns>
        public TResult Execute<TResult>(string code, object parameters)
        {
            EvalCompilerParameterKind parameterKind;

            var parameterTypes = new Dictionary<string, Type> {{"{0}", parameters.GetType()}};

            if (parameters is IDictionary)
            {
                parameterKind = EvalCompilerParameterKind.SingleDictionary;

                foreach (DictionaryEntry entry in (IDictionary) parameters)
                {
                    parameterTypes.Add(entry.Key.ToString(), entry.Value.GetType());
                }

                return EvalCompiler.Compile<Func<IDictionary, TResult>>(this, code, parameterTypes, typeof (TResult), parameterKind)((IDictionary) parameters);
            }

            parameterKind = EvalCompilerParameterKind.SingleObject;

            var type = parameters.GetType();
            var parameterProperties = type.GetProperties();
            var parameterFields = type.GetFields();

            foreach (var propertyInfo in parameterProperties)
            {
                parameterTypes.Add(propertyInfo.Name, propertyInfo.PropertyType);
            }

            foreach (var fieldInfo in parameterFields)
            {
                parameterTypes.Add(fieldInfo.Name, fieldInfo.FieldType);
            }

            return EvalCompiler.Compile<Func<object, TResult>>(this, code, parameterTypes, typeof (TResult), parameterKind)(parameters);
        }

        /// <summary>Compile and evaluate the code or expression and return the result of type TResult.</summary>
        /// <typeparam name="TResult">Type of the result of the evaluted code or expression.</typeparam>
        /// <param name="code">The code or expression to evaluate.</param>
        /// <param name="parameters">The parameter values used to evaluates the code or expression.</param>
        /// <returns>The evaluated result of type TResult or null that represents the evaluted code or expression.</returns>
        public TResult Execute<TResult>(string code, params object[] parameters)
        {
            var dictValues = new Dictionary<string, object>();
            var dictTypes = new Dictionary<string, Type>();

            for (var i = 0; i < parameters.Length; i++)
            {
                var key = string.Concat("{", i, "}");
                dictValues.Add(key, parameters[i]);
                dictTypes.Add(key, parameters[i].GetType());
            }

            return EvalCompiler.Compile<Func<IDictionary, TResult>>(this, code, dictTypes, typeof (TResult), EvalCompilerParameterKind.Dictionary)(dictValues);
        }
    }
}