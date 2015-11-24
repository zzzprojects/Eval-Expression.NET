// Description: Evaluate, Compile and Execute C# code and expression at runtime
// Website & Documentation: https://github.com/zzzprojects/Eval-Expression.NET
// Forum: https://zzzprojects.uservoice.com/forums/327759-eval-expression-net
// License: http://www.zzzprojects.com/license-agreement/
// More projects: http://www.zzzprojects.com/
// Copyright (c) 2015 ZZZ Projects. All rights reserved.

using System;
using System.Collections.Generic;
using System.Linq.Expressions;
using Z.Expressions.CodeCompiler.CSharp;

namespace Z.Expressions
{
    internal static partial class EvalCompiler
    {
        /// <summary>Resolve untyped parameters used for the code or expression.</summary>
        /// <param name="scope">The expression scope for the code or expression to compile.</param>
        /// <param name="parameterTypes">The dictionary of parameter (name / type) used in the code or expression to compile.</param>
        /// <returns>A ParameterExpression list used in code or expression to compile.</returns>
        private static List<ParameterExpression> ResolveParameterUntyped(ExpressionScope scope, IDictionary<string, Type> parameterTypes)
        {
            var parameters = new List<ParameterExpression>();

            foreach (var parameter in parameterTypes)
            {
                var parameterExpression = scope.CreateOuterParameter(typeof (object), scope.GenerateUniqueParameterName());
                parameters.Add(parameterExpression);

                scope.CreateLazyBlockParameter(parameter.Key, new Lazy<Expression>(() =>
                {
                    var innerParameter = scope.CreateBlockParameter(parameter.Value, parameter.Key);

                    var innerExpression = parameterExpression.Type != parameter.Value ?
                        Expression.Assign(innerParameter, Expression.Convert(parameterExpression, parameter.Value)) :
                        Expression.Assign(innerParameter, parameterExpression);

                    scope.Expressions.Insert(0, innerExpression);

                    return innerParameter;
                }));
            }

            return parameters;
        }
    }
}