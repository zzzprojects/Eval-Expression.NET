// Description: C# Expression Evaluator | Evaluate, Compile and Execute C# code and expression at runtime.
// Website: http://eval-expression.net/
// Documentation: https://github.com/zzzprojects/Eval-Expression.NET/wiki
// Forum & Issues: https://github.com/zzzprojects/Eval-Expression.NET/issues
// License: https://github.com/zzzprojects/Eval-Expression.NET/blob/master/LICENSE
// More projects: http://www.zzzprojects.com/
// Copyright © ZZZ Projects Inc. 2014 - 2016. All rights reserved.

using System;
using System.Collections.Concurrent;
using System.Linq;
using System.Reflection;
using System.Runtime.CompilerServices;

namespace Z.Expressions
{
    public partial class EvalContext
    {
        /// <summary>Unregisters all extension methods from the specified types.</summary>
        /// <param name="types">A variable-length parameters list containing types to unregister extension methods from.</param>
        /// <returns>An Fluent EvalContext.</returns>
        public EvalContext UnregisterExtensionMethod(params Type[] types)
        {
            foreach (var type in types)
            {
                var extensionMethods = type.GetMethods(BindingFlags.Static | BindingFlags.Public | BindingFlags.NonPublic)
                    .Where(x => x.IsDefined(typeof (ExtensionAttribute), false)).ToArray();

                UnregisterExtensionMethod(extensionMethods);
            }


            return this;
        }

        /// <summary>Unregisters all specified extension methods.</summary>
        /// <param name="extensionMethods">A variable-length parameters list containing extension methods to unregister.</param>
        /// <returns>An Fluent EvalContext.</returns>
        public EvalContext UnregisterExtensionMethod(params MethodInfo[] extensionMethods)
        {
            foreach (var method in extensionMethods)
            {
                UnregisterMember(method);

                ConcurrentDictionary<MethodInfo, byte> values;
                if (AliasExtensionMethods.TryGetValue(method.Name, out values))
                {
                    byte outByte;
                    values.TryRemove(method, out outByte);
                }
            }

            return this;
        }
    }
}