// Description: Evaluate, Compile and Execute C# code and expression at runtime
// Website & Documentation: https://github.com/zzzprojects/Eval-Expression.NET
// Forum: https://zzzprojects.uservoice.com/forums/327759-eval-expression-net
// License: http://www.zzzprojects.com/license-agreement/
// More projects: http://www.zzzprojects.com/
// Copyright (c) 2015 ZZZ Projects. All rights reserved.

using System;
using System.Collections.Concurrent;
using System.Linq;
using System.Reflection;
using System.Runtime.CompilerServices;

namespace Z.Expressions
{
    public partial class EvalContext
    {
        /// <summary>Registers all extension methods from specified types.</summary>
        /// <param name="types">A variable-length parameters list containing types to register extension methods from.</param>
        /// <returns>An Fluent EvalContext.</returns>
        public EvalContext RegisterExtensionMethod(params Type[] types)
        {
            foreach (var type in types)
            {
                var extensionMethods = type.GetMethods(BindingFlags.Static | BindingFlags.Public | BindingFlags.NonPublic)
                    .Where(x => x.IsDefined(typeof (ExtensionAttribute), false)).ToArray();

                RegisterExtensionMethod(extensionMethods);
            }

            return this;
        }

        /// <summary>Registers all specified extension methods.</summary>
        /// <param name="extensionMethods">A variable-length parameters list containing extension methods to register.</param>
        /// <returns>An Fluent EvalContext.</returns>
        public EvalContext RegisterExtensionMethod(params MethodInfo[] extensionMethods)
        {
            foreach (var method in extensionMethods)
            {
                AliasExtensionMethods.AddOrUpdate(method.Name, s =>
                {
                    var dict = new ConcurrentDictionary<MethodInfo, byte>();
                    dict.TryAdd(method, 1);
                    return dict;
                }, (s, list) =>
                {
                    list.TryAdd(method, 1);
                    return list;
                });
            }

            return this;
        }
    }
}