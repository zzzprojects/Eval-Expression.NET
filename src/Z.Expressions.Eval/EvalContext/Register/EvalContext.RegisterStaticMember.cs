// Description: C# Expression Evaluator | Evaluate, Compile and Execute C# code and expression at runtime.
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
        /// <summary>Registers static member from specified types.</summary>
        /// <param name="types">A variable-length parameters list containing types to register static members from.</param>
        /// <returns>An Fluent EvalContext.</returns>
        public EvalContext RegisterStaticMember(params Type[] types)
        {
            foreach (var type in types)
            {
                var fields = type.GetFields(BindingFlags.Public | BindingFlags.Static);
                var properties = type.GetProperties(BindingFlags.Public | BindingFlags.Static);
                var methods = type.GetMethods(BindingFlags.Public | BindingFlags.Static);

                RegisterStaticMember(fields);
                RegisterStaticMember(properties);
                RegisterStaticMember(methods);
            }

            return this;
        }

        /// <summary>Registers specified static members.</summary>
        /// <param name="members">A variable-length parameters list containing members to register.</param>
        /// <returns>An Fluent EvalContext.</returns>
        public EvalContext RegisterStaticMember(params MemberInfo[] members)
        {
            foreach (var member in members)
            {
                AliasStaticMembers.AddOrUpdate(member.Name, s =>
                {
                    var dict = new ConcurrentDictionary<MemberInfo, byte>();
                    dict.TryAdd(member, 1);
                    return dict;
                }, (s, list) =>
                {
                    list.TryAdd(member, 1);
                    return list;
                });
            }

            return this;
        }
    }
}