// Description: Evaluate, Compile and Execute C# code and expression at runtime
// Website & Documentation: https://github.com/zzzprojects/Eval-Expression.NET
// Forum: https://zzzprojects.uservoice.com/forums/327759-eval-expression-net
// License: http://www.zzzprojects.com/license-agreement/
// More projects: http://www.zzzprojects.com/
// Copyright (c) 2015 ZZZ Projects. All rights reserved.

using System;
using System.Collections.Concurrent;
using System.Reflection;

namespace Z.Expressions
{
    public partial class EvalContext
    {
        /// <summary>Unregisters static member from specified types.</summary>
        /// <param name="types">A variable-length parameters list containing types to unregister static members from.</param>
        /// <returns>An Fluent EvalContext.</returns>
        public EvalContext UnregisterStaticMember(params Type[] types)
        {
            foreach (var type in types)
            {
                var fields = type.GetFields(BindingFlags.Public | BindingFlags.Static);
                var properties = type.GetProperties(BindingFlags.Public | BindingFlags.Static);
                var methods = type.GetMethods(BindingFlags.Public | BindingFlags.Static);

                UnregisterStaticMember(fields);
                UnregisterStaticMember(properties);
                UnregisterStaticMember(methods);
            }

            return this;
        }

        /// <summary>Unregisters static member from specified types.</summary>
        /// <param name="members">A variable-length parameters list containing members.</param>
        /// <returns>An Fluent EvalContext.</returns>
        public EvalContext UnregisterStaticMember(params MemberInfo[] members)
        {
            foreach (var member in members)
            {
                ConcurrentDictionary<MemberInfo, byte> values;
                if (AliasStaticMembers.TryGetValue(member.Name, out values))
                {
                    byte outByte;
                    values.TryRemove(member, out outByte);
                }
            }

            return this;
        }
    }
}