// Description: C# Expression Evaluator | Evaluate, Compile and Execute C# code and expression at runtime.
// Website & Documentation: https://github.com/zzzprojects/Eval-Expression.NET
// Forum: https://zzzprojects.uservoice.com/forums/327759-eval-expression-net
// License: http://www.zzzprojects.com/license-agreement/
// More projects: http://www.zzzprojects.com/
// Copyright (c) 2015 ZZZ Projects. All rights reserved.

using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq.Expressions;
using System.Reflection;
using Z.Expressions.CodeCompiler.CSharp;

namespace Z.Expressions
{
    internal static partial class EvalCompiler
    {
        /// <summary>Resolve enumerable parameters used for the code or expression.</summary>
        /// <param name="scope">The expression scope for the code or expression to compile.</param>
        /// <param name="parameterTypes">The dictionary of parameter (name / type) used in the code or expression to compile.</param>
        /// <returns>A ParameterExpression list used in code or expression to compile.</returns>
        private static List<ParameterExpression> ResolveParameterEnumerable(ExpressionScope scope, IDictionary<string, Type> parameterTypes)
        {
            var parameters = new List<ParameterExpression>();

            var parameterEnumerable = scope.CreateParameter(typeof (IEnumerable));
            parameters.Add(parameterEnumerable);

            var dictParameter = scope.CreateVariable(typeof (Dictionary<string, object>));
            var methodConvert = typeof (EvalCompiler).GetMethod("ResolveToParameterDictionary", BindingFlags.NonPublic | BindingFlags.Static);
            var expressionConvert = Expression.Call(methodConvert, new Expression[] {parameterEnumerable});
            var expressionAssign = Expression.Assign(dictParameter, expressionConvert);
            scope.Expressions.Add(expressionAssign);

            foreach (var parameter in parameterTypes)
            {
                scope.CreateLazyVariable(parameter.Key, new Lazy<Expression>(() =>
                {
                    var innerParameter = scope.CreateVariable(parameter.Value, parameter.Key);

                    Expression innerExpression = Expression.Property(dictParameter, DictionaryItemPropertyInfo, Expression.Constant(parameter.Key));

                    innerExpression = innerExpression.Type != parameter.Value ?
                        Expression.Assign(innerParameter, Expression.Convert(innerExpression, parameter.Value)) :
                        Expression.Assign(innerParameter, innerExpression);

                    scope.Expressions.Add(Expression.Assign(innerParameter, innerExpression));

                    return innerParameter;
                }));
            }

            return parameters;
        }
    }
}