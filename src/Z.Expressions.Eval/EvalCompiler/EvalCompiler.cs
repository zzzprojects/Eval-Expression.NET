// Description: Evaluate, Compile and Execute C# code and expression at runtime
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
using System.Runtime.Caching;
using System.Threading.Tasks;
using Z.Expressions.CodeAnalysis.CSharp;
using Z.Expressions.CodeCompiler.CSharp;

namespace Z.Expressions
{
    internal static partial class EvalCompiler
    {
        /// <summary>Property info for the IDictionary Item indexer used in ResolveParameter methods.</summary>
        private static readonly PropertyInfo DictionaryItemPropertyInfo = typeof (IDictionary).GetProperty("Item", new[] {typeof (string)});

        /// <summary>Compile the code or expression and return a TDelegate of type Func or Action to execute.</summary>
        /// <typeparam name="TDelegate">Type of the delegate (Func or Action) to use to compile the code or expression.</typeparam>
        /// <param name="context">The eval context used to compile the code or expression.</param>
        /// <param name="code">The code or expression to compile.</param>
        /// <param name="parameterTypes">The dictionary of parameter (name / type) used in the code or expression to compile.</param>
        /// <param name="resultType">Type of the compiled code or expression result.</param>
        /// <param name="parameterKind">The parameter kind for the code or expression to compile.</param>
        /// <returns>A TDelegate of type Func or Action that represents the compiled code or expression.</returns>
        internal static TDelegate Compile<TDelegate>(EvalContext context, string code, IDictionary<string, Type> parameterTypes, Type resultType, EvalCompilerParameterKind parameterKind)
        {
            var cacheKey = context.UseCache ? ResolveCacheKey(context, typeof (TDelegate), code, parameterTypes) : "";

            if (context.UseCache)
            {
                var item = EvalManager.Cache.Get(cacheKey);

                if (item != null)
                {
                    return (TDelegate) item;
                }
            }

            // Options
            var scope = new ExpressionScope
            {
                AliasExtensionMethods = context.AliasExtensionMethods,
                AliasGlobalConstants = context.AliasGlobalConstants,
                AliasGlobalVariables = context.AliasGlobalVariables,
                AliasNames = context.AliasNames,
                AliasStaticMembers = context.AliasStaticMembers,
                AliasTypes = context.AliasTypes,
                BindingFlags = context.BindingFlags,
                UseCaretForExponent = context.UseCaretForExponent
            };

            // Resolve Parameter
            var parameterExpressions = ResolveParameter(scope, parameterKind, parameterTypes);

            // CodeAnalysis
            var syntaxRoot = SyntaxParser.ParseText(code);

            // CodeCompiler
            var expression = ExpressionParser.ParseSyntax(scope, syntaxRoot, resultType);

            // Compile the expression
            var compiled = Expression.Lambda<TDelegate>(expression, parameterExpressions).Compile();

            if (context.UseCache)
            {
                EvalManager.Cache.AddOrGetExisting(new CacheItem(cacheKey, compiled), new CacheItemPolicy());
            }

            return compiled;
        }

#if !NET40
        /// <summary>Compile the code or expression and return a TDelegate of type Func or Action to execute.</summary>
        /// <typeparam name="TDelegate">Type of the delegate (Func or Action) to use to compile the code or expression.</typeparam>
        /// <param name="context">The eval context used to compile the code or expression.</param>
        /// <param name="code">The code or expression to compile.</param>
        /// <param name="parameterTypes">The dictionary of parameter (name / type) used in the code or expression to compile.</param>
        /// <param name="resultType">Type of the compiled code or expression result.</param>
        /// <param name="parameterKind">The parameter kind for the code or expression to compile.</param>
        /// <returns>A TDelegate of type Func or Action that represents the compiled code or expression.</returns>
        internal static Task<TDelegate> CompileAsync<TDelegate>(EvalContext context, string code, IDictionary<string, Type> parameterTypes, Type resultType, EvalCompilerParameterKind parameterKind)
        {
            return Task.Run(() => Compile<TDelegate>(context, code, parameterTypes, resultType, parameterKind));
        }
#endif
    }
}