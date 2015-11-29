// Description: C# Expression Evaluator | Evaluate, Compile and Execute C# code and expression at runtime.
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
        /// <summary>Resolve lazy member from the member type</summary>
        /// <param name="scope">The expression scope for the code or expression to compile.</param>
        /// <param name="parameterTypes">The dictionary of parameter (name / type) used in the code or expression to compile.</param>
        /// <param name="parameterName">The main parameter name.</param>
        /// <param name="memberType">The member type.</param>
        private static void ResolzeLazyMember(ExpressionScope scope, IDictionary<string, Type> parameterTypes, string parameterName, Type memberType)
        {
            if (Type.GetTypeCode(memberType) == TypeCode.Object)
            {
                var parameterProperties = memberType.GetProperties();
                var parameterFields = memberType.GetFields();

                foreach (var propertyInfo in parameterProperties)
                {
                    parameterTypes.Add(propertyInfo.Name, propertyInfo.PropertyType);

                    scope.CreateLazyVariable(propertyInfo.Name, new Lazy<Expression>(() =>
                    {
                        var innerParameter = scope.CreateVariable(propertyInfo.PropertyType, propertyInfo.Name);
                        var innerExpression = Expression.Assign(innerParameter, Expression.Property(scope.GetValueExpressionOrNull(parameterName), propertyInfo));
                        scope.Expressions.Add(innerExpression);

                        return innerParameter;
                    }));
                }

                foreach (var fieldInfo in parameterFields)
                {
                    parameterTypes.Add(fieldInfo.Name, fieldInfo.FieldType);

                    scope.CreateLazyVariable(fieldInfo.Name, new Lazy<Expression>(() =>
                    {
                        var innerParameter = scope.CreateVariable(fieldInfo.FieldType, fieldInfo.Name);
                        var innerExpression = Expression.Assign(innerParameter, Expression.Field(scope.GetValueExpressionOrNull(parameterName), fieldInfo));
                        scope.Expressions.Add(innerExpression);

                        return innerParameter;
                    }));
                }
            }
        }
    }
}