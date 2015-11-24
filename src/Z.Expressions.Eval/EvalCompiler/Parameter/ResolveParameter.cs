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
        /// <summary>Resolve parameters used for the code or expression.</summary>
        /// <param name="scope">The expression scope for the code or expression to compile.</param>
        /// <param name="parameterKind">The parameter kind for the code or expression to compile.</param>
        /// <param name="parameterTypes">The dictionary of parameter (name / type) used in the code or expression to compile.</param>
        /// <returns>A ParameterExpression list used in code or expression to compile.</returns>
        private static List<ParameterExpression> ResolveParameter(ExpressionScope scope, EvalCompilerParameterKind parameterKind, IDictionary<string, Type> parameterTypes)
        {
            if (parameterTypes == null) return null;

            List<ParameterExpression> parameterExpressions;

            switch (parameterKind)
            {
                case EvalCompilerParameterKind.Dictionary:
                    parameterExpressions = ResolveParameterDictionary(scope, parameterTypes);
                    break;
                case EvalCompilerParameterKind.Enumerable:
                    parameterExpressions = ResolveParameterEnumerable(scope, parameterTypes);
                    break;
                case EvalCompilerParameterKind.SingleDictionary:
                    parameterExpressions = ResolveParameterSingleDictionary(scope, parameterTypes);
                    break;
                case EvalCompilerParameterKind.SingleObject:
                    parameterExpressions = ResolveParameterSingleObject(scope, parameterTypes);
                    break;
                case EvalCompilerParameterKind.Typed:
                    parameterExpressions = ResolveParameterTyped(scope, parameterTypes);
                    break;
                case EvalCompilerParameterKind.Untyped:
                    parameterExpressions = ResolveParameterUntyped(scope, parameterTypes);
                    break;
                default:
                    parameterExpressions = new List<ParameterExpression>();
                    break;
            }

            return parameterExpressions;
        }
    }
}