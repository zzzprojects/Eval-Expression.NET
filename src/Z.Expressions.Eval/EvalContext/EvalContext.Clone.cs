// Description: C# Expression Evaluator | Evaluate, Compile and Execute C# code and expression at runtime.
// Website: http://eval-expression.net/
// Documentation: https://github.com/zzzprojects/Eval-Expression.NET/wiki
// Forum & Issues: https://github.com/zzzprojects/Eval-Expression.NET/issues
// License: https://github.com/zzzprojects/Eval-Expression.NET/blob/master/LICENSE
// More projects: http://www.zzzprojects.com/
// Copyright © ZZZ Projects Inc. 2014 - 2016. All rights reserved.

using System;
using System.Collections.Concurrent;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Reflection;

namespace Z.Expressions
{
    public partial class EvalContext
    {
        /// <summary>Makes a shallow copy of current EvalContext.</summary>
        /// <returns>A shallow copy of the current EvalContext.</returns>
        public EvalContext Clone()
        {
            return new EvalContext
            {
                AliasExtensionMethods = new ConcurrentDictionary<string, ConcurrentDictionary<MethodInfo, byte>>(AliasExtensionMethods.Select(pair => new KeyValuePair<string, ConcurrentDictionary<MethodInfo, byte>>(pair.Key, new ConcurrentDictionary<MethodInfo, byte>(pair.Value)))),
                AliasGlobalConstants = new ConcurrentDictionary<string, ConstantExpression>(AliasGlobalConstants),
                AliasGlobalVariables = new ConcurrentDictionary<string, object>(AliasGlobalVariables),
                AliasNames = new ConcurrentDictionary<string, string>(AliasNames),
                AliasStaticMembers = new ConcurrentDictionary<string, ConcurrentDictionary<MemberInfo, byte>>(AliasStaticMembers.Select(pair => new KeyValuePair<string, ConcurrentDictionary<MemberInfo, byte>>(pair.Key, new ConcurrentDictionary<MemberInfo, byte>(pair.Value)))),
                AliasTypes = new ConcurrentDictionary<string, Type>(AliasTypes),
                BindingFlags = BindingFlags,
                CacheKeyPrefix = CacheKeyPrefix,
                UseCache = UseCache,
                UseCaretForExponent = UseCaretForExponent
            };
        }
    }
}